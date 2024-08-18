﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SourceGenerator
{
    [Generator]
    public class ReflectorDataGenerator : ISourceGenerator
    {
        private static HashSet<string> _excludedNamespacesSubSpaces = new HashSet<string>()
        {
            "Silk",
            "SixLabors",
            "Microsoft.CSharp",
            "System.Messaging",
            "System.Workflow",
            "Roslyn",
            "WinApi",
            "FxResources",
            "vc",
            "Microsoft",
            "Microsoft.Cci",
            "Microsoft.Win32",
            "Microsoft.Internal",
            "Accessibility",
            "System",
            "System.Web",
            "System.Drawing",
            "System.Data",
            "OpenGL",
            "std",
            "<CppImplementationDetails>",
            "<CrtImplementationDetails>",
            "LinqToSqlShared",
        };
        private static HashSet<string> _excludedNamespacesTypes = new HashSet<string>()
        {
            "<global namespace>" // Global namespace
        };
        private StringBuilder _reflectorTypeGetCodeGen = new StringBuilder();
        private string _mainNamespace;
        private HashSet<string> _typeShortNameRegister = new HashSet<string>();

        public void GenerateReflectorForNamespace(ref GeneratorExecutionContext context, INamespaceSymbol space)
        {
            System.Collections.Immutable.ImmutableArray<INamedTypeSymbol> types = space.GetTypeMembers();
            string fullSpaceName = space.ToDisplayString();

            bool includeTypesFromNamespace = !_excludedNamespacesTypes.Contains(fullSpaceName);
            bool includeSubSpaces = !_excludedNamespacesSubSpaces.Contains(fullSpaceName);
            if (!includeSubSpaces) includeTypesFromNamespace = false;

            if (includeTypesFromNamespace)
            {
                Console.WriteLine($"Generating Reflector for types in namespace - {fullSpaceName}");
                foreach (var type in types)
                {
                    GenerateReflectorForType(ref context, type);
                }
            }

            if (includeSubSpaces)
            {
                IEnumerable<INamespaceSymbol> subSpaces = space.GetNamespaceMembers();
                foreach (var subspace in subSpaces)
                {
                    GenerateReflectorForNamespace(ref context, subspace);
                }
            }
        }

        public void GenerateReflectorForType(ref GeneratorExecutionContext context, INamedTypeSymbol typ)
        {
            if (!HasParameterlessConstructor(typ)) return;
            if (HasDontSerialize(typ)) return;
            if (typ.IsAbstract) return;
            if (typ.DeclaredAccessibility != Accessibility.Public) return;
            if (typ.IsGenericType) return;

            string typShortName = typ.Name;
            string fullTypName = typ.ToDisplayString();

            Console.WriteLine($"    Generating Reflector for type - {fullTypName}");
            string reflectorFileName = $"ReflectorTypeDataFor{fullTypName}";
            string reflectorClassName = $"{fullTypName.Replace(".", "_")}Class";

            _reflectorTypeGetCodeGen.AppendLine($"           {{ \"{fullTypName}\", new {reflectorClassName}() }},");

            if (!_typeShortNameRegister.Contains(typShortName))
            {
                _reflectorTypeGetCodeGen.AppendLine($"           {{ \"{typShortName}\", new {reflectorClassName}() }},");
                _typeShortNameRegister.Add(typShortName);
            }

            StringBuilder reflectorFile = new StringBuilder();
            reflectorFile.AppendLine("// <auto-generated/>");
            reflectorFile.AppendLine("// Generated by Emotion.SourceGeneration");
            reflectorFile.AppendLine("");
            reflectorFile.AppendLine("using System;");
            reflectorFile.AppendLine("using System.Collections.Generic;");
            reflectorFile.AppendLine("using System.Runtime.CompilerServices;");
            reflectorFile.AppendLine("using Emotion.Standard.Reflector;");
            reflectorFile.AppendLine("");
            reflectorFile.AppendLine($"namespace {_mainNamespace}");
            reflectorFile.AppendLine("{");
            reflectorFile.AppendLine($"   public class {reflectorClassName} : IReflectorTypeData");
            reflectorFile.AppendLine("   {");
            reflectorFile.AppendLine("");
            reflectorFile.AppendLine("");
            reflectorFile.AppendLine("       public ReflectorTypeMember[] GetMembers()");
            reflectorFile.AppendLine("       {");
            reflectorFile.AppendLine("          return new ReflectorTypeMember[] {");

            System.Collections.Immutable.ImmutableArray<ISymbol> members = typ.GetMembers();
            foreach (ISymbol member in members)
            {
                if (member.Kind != SymbolKind.Field && member.Kind != SymbolKind.Property) continue;
                if (member.DeclaredAccessibility != Accessibility.Public) continue;
                if (member.IsStatic) continue;

                ITypeSymbol memberType = null;
                if (member.Kind == SymbolKind.Property && member is IPropertySymbol propSymb)
                {
                    if (propSymb.GetMethod == null || propSymb.SetMethod == null) continue;
                    memberType = propSymb.Type;
                }
                else if(member is IFieldSymbol fieldSymb)
                {
                    if (fieldSymb.IsReadOnly) continue;
                    memberType = fieldSymb.Type;
                }

                string memberTypeName = memberType?.ToDisplayString();
                // Can't use nullable reference types in a typeof
                if (memberType != null && memberType.IsReferenceType && memberTypeName[memberTypeName.Length - 1] == '?')
                    memberTypeName = memberTypeName.Substring(0, memberTypeName.Length - 1);

                reflectorFile.AppendLine($"                    new ReflectorTypeMember(typeof({memberTypeName}), \"{member.Name}\") {{");
                reflectorFile.AppendLine($"                         WriteValue = (a, b) => {{ a.{member.Name} = b; }},");
                reflectorFile.AppendLine($"                         ReadValue = (a) => {{ return a.{member.Name}; }},");

                var attributes = member.GetAttributes();
                if (attributes.Length > 0)
                {
                    reflectorFile.AppendLine($"                         Attributes = new Attribute[] {{");

                    foreach (var attribute in attributes)
                    {
                        reflectorFile.AppendLine($"                             {GenerateAttributeDeclaration(attribute)},");
                    }
                    reflectorFile.AppendLine($"                         }},");
                }

                reflectorFile.AppendLine($"                    }},");
            }

            reflectorFile.AppendLine("           };");
            reflectorFile.AppendLine("       }");
            reflectorFile.AppendLine("   }");
            reflectorFile.AppendLine("}");

            context.AddSource($"{reflectorFileName}.generated.cs", reflectorFile.ToString());
        }

        public bool HasDontSerialize(INamedTypeSymbol typ)
        {
            INamedTypeSymbol typeToCheck = typ;
            while (typeToCheck != null && !SymbolEqualityComparer.Default.Equals(typeToCheck, typ.BaseType))
            {
                var attributes = typ.GetAttributes();
                foreach (var attribute in attributes)
                {
                    if (attribute.AttributeClass.Name == "DontSerializeAttribute")
                    {
                        return true;
                    }
                }

                typeToCheck = typ.BaseType;
            }

            return false;
        }

        public bool HasParameterlessConstructor(INamedTypeSymbol typ)
        {
            var constructors = typ.InstanceConstructors;
            if (constructors.Length == 0) return false;

            foreach (var constructor in constructors)
            {
                if (constructor.Parameters.IsEmpty)
                {
                    return true;
                }
            }
            return false;
        }

        private string GenerateAttributeDeclaration(AttributeData attribute)
        {
            var constructorArgs = string.Join(", ", attribute.ConstructorArguments.Select(arg => GetArgumentString(arg)).Where(x => x != null));
            var namedArgs = string.Join(", ", attribute.NamedArguments.Select(kvp => $"{kvp.Key} = {GetArgumentString(kvp.Value)}"));

            var args = constructorArgs;
            if (!string.IsNullOrEmpty(namedArgs))
            {
                if (!string.IsNullOrEmpty(constructorArgs))
                {
                    args += ", ";
                }
                args += namedArgs;
            }

            string fullAttributeName = attribute.AttributeClass?.ToDisplayString();
            return $"new {fullAttributeName}({args})";
        }

        private string GetArgumentString(TypedConstant argument)
        {
            if (argument.Kind == TypedConstantKind.Array)
            {
                var elements = argument.Values.Select(GetArgumentString);
                return $"new {argument.Type.ToDisplayString()} {{ {string.Join(", ", elements)} }}";
            }
            else if (argument.Kind == TypedConstantKind.Enum)
            {
                return $"{argument.Type.ToDisplayString()}.{argument.Value}";
            }
            else if (argument.Kind == TypedConstantKind.Type)
            {
                if (argument.Value == null) return null;
                return $"typeof({argument.Value})";
            }
            else if (argument.Value is string str)
            {
                return $"\"{str}\"";
            }
            else if (argument.Value is char c)
            {
                return $"'{c}'";
            }
            else if (argument.Value is null)
            {
                return "null";
            }
            else if(argument.Value is bool)
            {
                return argument.Value.ToString().ToLowerInvariant();
            }
            else
            {
                return argument.Value?.ToString() ?? string.Empty;
            }
        }

        public void Execute(GeneratorExecutionContext context)
        {
            var mainMethod = context.Compilation.GetEntryPoint(context.CancellationToken);
            _mainNamespace = mainMethod.ContainingNamespace.ToDisplayString();

            _reflectorTypeGetCodeGen.AppendLine("// <auto-generated/>");
            _reflectorTypeGetCodeGen.AppendLine("// Generated by Emotion.SourceGeneration");
            _reflectorTypeGetCodeGen.AppendLine("");
            _reflectorTypeGetCodeGen.AppendLine("using System;");
            _reflectorTypeGetCodeGen.AppendLine("using System.Collections.Generic;");
            _reflectorTypeGetCodeGen.AppendLine("using System.Runtime.CompilerServices;");
            _reflectorTypeGetCodeGen.AppendLine("using Emotion.Standard.Reflector;");
            _reflectorTypeGetCodeGen.AppendLine("");
            _reflectorTypeGetCodeGen.AppendLine($"namespace {_mainNamespace}");
            _reflectorTypeGetCodeGen.AppendLine("{");
            _reflectorTypeGetCodeGen.AppendLine("   public class MyReflectorData : IEmotionReflectorDataSource");
            _reflectorTypeGetCodeGen.AppendLine("   {");
            _reflectorTypeGetCodeGen.AppendLine("");
            _reflectorTypeGetCodeGen.AppendLine("       public static Dictionary<string, IReflectorTypeData> _data = new()");
            _reflectorTypeGetCodeGen.AppendLine("       {");

            INamespaceSymbol globalNamespace = context.Compilation.GlobalNamespace;
            GenerateReflectorForNamespace(ref context, globalNamespace);

            _reflectorTypeGetCodeGen.AppendLine("       };");
            _reflectorTypeGetCodeGen.AppendLine("");
            _reflectorTypeGetCodeGen.AppendLine("       [ModuleInitializer]");
            _reflectorTypeGetCodeGen.AppendLine("       public static void Initialize()");
            _reflectorTypeGetCodeGen.AppendLine("       {");
            _reflectorTypeGetCodeGen.AppendLine("           ReflectorEngine.RegisterDataSource(new MyReflectorData());");
            _reflectorTypeGetCodeGen.AppendLine("       }");
            _reflectorTypeGetCodeGen.AppendLine("");
            _reflectorTypeGetCodeGen.AppendLine("       public IReflectorTypeData? GetTypeData(string typeName)");
            _reflectorTypeGetCodeGen.AppendLine("       {");
            _reflectorTypeGetCodeGen.AppendLine("           if(!_data.TryGetValue(typeName, out IReflectorTypeData? data)) return null;");
            _reflectorTypeGetCodeGen.AppendLine("           return data;");
            _reflectorTypeGetCodeGen.AppendLine("       }");
            _reflectorTypeGetCodeGen.AppendLine("   }");
            _reflectorTypeGetCodeGen.AppendLine("}");

            string reflectorFileContent = _reflectorTypeGetCodeGen.ToString();
            context.AddSource($"EmotionReflectorData.generated.cs", reflectorFileContent);
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            // nop
        }
    }
}