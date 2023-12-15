#region Using

using System;
using System.Runtime.CompilerServices;

#endregion

namespace ImGuiNET
{
    public unsafe struct StbUndoState
    {
        public StbUndoRecord undo_rec_0;
        public StbUndoRecord undo_rec_1;
        public StbUndoRecord undo_rec_2;
        public StbUndoRecord undo_rec_3;
        public StbUndoRecord undo_rec_4;
        public StbUndoRecord undo_rec_5;
        public StbUndoRecord undo_rec_6;
        public StbUndoRecord undo_rec_7;
        public StbUndoRecord undo_rec_8;
        public StbUndoRecord undo_rec_9;
        public StbUndoRecord undo_rec_10;
        public StbUndoRecord undo_rec_11;
        public StbUndoRecord undo_rec_12;
        public StbUndoRecord undo_rec_13;
        public StbUndoRecord undo_rec_14;
        public StbUndoRecord undo_rec_15;
        public StbUndoRecord undo_rec_16;
        public StbUndoRecord undo_rec_17;
        public StbUndoRecord undo_rec_18;
        public StbUndoRecord undo_rec_19;
        public StbUndoRecord undo_rec_20;
        public StbUndoRecord undo_rec_21;
        public StbUndoRecord undo_rec_22;
        public StbUndoRecord undo_rec_23;
        public StbUndoRecord undo_rec_24;
        public StbUndoRecord undo_rec_25;
        public StbUndoRecord undo_rec_26;
        public StbUndoRecord undo_rec_27;
        public StbUndoRecord undo_rec_28;
        public StbUndoRecord undo_rec_29;
        public StbUndoRecord undo_rec_30;
        public StbUndoRecord undo_rec_31;
        public StbUndoRecord undo_rec_32;
        public StbUndoRecord undo_rec_33;
        public StbUndoRecord undo_rec_34;
        public StbUndoRecord undo_rec_35;
        public StbUndoRecord undo_rec_36;
        public StbUndoRecord undo_rec_37;
        public StbUndoRecord undo_rec_38;
        public StbUndoRecord undo_rec_39;
        public StbUndoRecord undo_rec_40;
        public StbUndoRecord undo_rec_41;
        public StbUndoRecord undo_rec_42;
        public StbUndoRecord undo_rec_43;
        public StbUndoRecord undo_rec_44;
        public StbUndoRecord undo_rec_45;
        public StbUndoRecord undo_rec_46;
        public StbUndoRecord undo_rec_47;
        public StbUndoRecord undo_rec_48;
        public StbUndoRecord undo_rec_49;
        public StbUndoRecord undo_rec_50;
        public StbUndoRecord undo_rec_51;
        public StbUndoRecord undo_rec_52;
        public StbUndoRecord undo_rec_53;
        public StbUndoRecord undo_rec_54;
        public StbUndoRecord undo_rec_55;
        public StbUndoRecord undo_rec_56;
        public StbUndoRecord undo_rec_57;
        public StbUndoRecord undo_rec_58;
        public StbUndoRecord undo_rec_59;
        public StbUndoRecord undo_rec_60;
        public StbUndoRecord undo_rec_61;
        public StbUndoRecord undo_rec_62;
        public StbUndoRecord undo_rec_63;
        public StbUndoRecord undo_rec_64;
        public StbUndoRecord undo_rec_65;
        public StbUndoRecord undo_rec_66;
        public StbUndoRecord undo_rec_67;
        public StbUndoRecord undo_rec_68;
        public StbUndoRecord undo_rec_69;
        public StbUndoRecord undo_rec_70;
        public StbUndoRecord undo_rec_71;
        public StbUndoRecord undo_rec_72;
        public StbUndoRecord undo_rec_73;
        public StbUndoRecord undo_rec_74;
        public StbUndoRecord undo_rec_75;
        public StbUndoRecord undo_rec_76;
        public StbUndoRecord undo_rec_77;
        public StbUndoRecord undo_rec_78;
        public StbUndoRecord undo_rec_79;
        public StbUndoRecord undo_rec_80;
        public StbUndoRecord undo_rec_81;
        public StbUndoRecord undo_rec_82;
        public StbUndoRecord undo_rec_83;
        public StbUndoRecord undo_rec_84;
        public StbUndoRecord undo_rec_85;
        public StbUndoRecord undo_rec_86;
        public StbUndoRecord undo_rec_87;
        public StbUndoRecord undo_rec_88;
        public StbUndoRecord undo_rec_89;
        public StbUndoRecord undo_rec_90;
        public StbUndoRecord undo_rec_91;
        public StbUndoRecord undo_rec_92;
        public StbUndoRecord undo_rec_93;
        public StbUndoRecord undo_rec_94;
        public StbUndoRecord undo_rec_95;
        public StbUndoRecord undo_rec_96;
        public StbUndoRecord undo_rec_97;
        public StbUndoRecord undo_rec_98;
        public fixed ushort undo_char[999];
        public short undo_point;
        public short redo_point;
        public int undo_char_point;
        public int redo_char_point;
    }

    public unsafe struct StbUndoStatePtr
    {
        public StbUndoState* NativePtr { get; }

        public StbUndoStatePtr(StbUndoState* nativePtr)
        {
            NativePtr = nativePtr;
        }

        public StbUndoStatePtr(IntPtr nativePtr)
        {
            NativePtr = (StbUndoState*) nativePtr;
        }

        public static implicit operator StbUndoStatePtr(StbUndoState* nativePtr)
        {
            return new StbUndoStatePtr(nativePtr);
        }

        public static implicit operator StbUndoState*(StbUndoStatePtr wrappedPtr)
        {
            return wrappedPtr.NativePtr;
        }

        public static implicit operator StbUndoStatePtr(IntPtr nativePtr)
        {
            return new StbUndoStatePtr(nativePtr);
        }

        public RangeAccessor<StbUndoRecord> undo_rec
        {
            get => new RangeAccessor<StbUndoRecord>(&NativePtr->undo_rec_0, 99);
        }

        public RangeAccessor<ushort> undo_char
        {
            get => new RangeAccessor<ushort>(NativePtr->undo_char, 999);
        }

        public ref short undo_point
        {
            get => ref Unsafe.AsRef<short>(&NativePtr->undo_point);
        }

        public ref short redo_point
        {
            get => ref Unsafe.AsRef<short>(&NativePtr->redo_point);
        }

        public ref int undo_char_point
        {
            get => ref Unsafe.AsRef<int>(&NativePtr->undo_char_point);
        }

        public ref int redo_char_point
        {
            get => ref Unsafe.AsRef<int>(&NativePtr->redo_char_point);
        }
    }
}