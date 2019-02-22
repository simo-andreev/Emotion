# Emotion
<img src="EmotionLogo.png" width="128px" />

[![Build status](https://ci.appveyor.com/api/projects/status/qur90gc2wdhmd5ff/branch/master?svg=true)](https://ci.appveyor.com/project/Cryru/emotion/branch/master)

Development: [![debug artifact](https://img.shields.io/badge/Download-%20Debug%20Build-brightgreen.svg)](https://ci.appveyor.com/api/projects/Cryru/Emotion/artifacts/EmotionCore%2Fbin%2FEmotion%20Built%20Debug.zip?branch=master&job=Configuration%3A%20Debug-GLES) [![nuget debug](https://img.shields.io/nuget/v/Emotion.svg)](https://www.nuget.org/packages/Emotion/)

Deployment: [![release artifact](https://img.shields.io/badge/Download-%20Release%20Build-brightgreen.svg)](https://ci.appveyor.com/api/projects/Cryru/Emotion/artifacts/EmotionCore%2Fbin%2FEmotion%20Built.zip?branch=master&job=Configuration%3A%20Release-GLES)

## What is it?

Emotion is a cross-platform game engine written in C#, with the intent of removing overhead and providing abstraction without sacrificing control. The idea is, to make game development about game development and not about engine or low-level backend development, but allowing those who want to do that with the option to do so. The goal is to save time, and provide indie developers (and mostly myself) with a foundation.

## Requirements:

- At least .Net Framework 4.6.2 or the equivalent Mono runtime.
- OpenGL Support
  - At least 3.0 on Windows and Linux, but it has shown to work on older versions.
  - 3.3 Core on MacOS
- GLSL Support Options
  - 300 es support on Windows or Linux
  - 330 support on MacOS
- Visual C++ Redist 2010
  - [x64](https://www.microsoft.com/es-es/download/details.aspx?id=14632)
  - [x86](https://www.microsoft.com/en-us/download/details.aspx?id=5555)

## Features So Far

- Window creation.
- SIMD vector and matrix math, through System.Numerics.
- Mouse and keyboard input.
  - Captured only while the window has focus preventing rogue clicks.
  - Detect key down, key up, and key held independently.
- Asset loading and management.
  - Textures: All FreeImage supported formats. ex. BMP/PNG/JPEG/GIF
  - Fonts: All FreeType supported formats. ex. TTF/OTF
  - Sounds: RIFF WAV
  - Text Files
  - Binaries
- Camera system.
  - Default cameras include one which follows the mouse and one which follows a target transform. 
  - Easy to create your own.
- Rendering
  - Drawing of things like lines, rectangles, triangles, and circles.
    - These are all drawn as triangles, no GL_LINES here, monsieur!
  - Super fast rendering of many objects at once (less draw calls) through the magic of MapBuffers, batching, and streaming.
  - Model matrix stack.
  - Textures with alpha testing and blending.
   - Draw order independent.
  - Spritesheet based animation.
  - Text.
    - Includes advanced font drawing with control over each individual glyph.
    - Extensible Richtext class featuring auto wrapping, alignment, markup, and more.
  - Draw arbitrary vertices, the wrapper gives you control over your own model matrix and buffers.
  - Easy shader creation with fallbacks and helper uniforms.
- Sound engine with fading effects.
  - Play on multiple layers with individual control over them.
  - Queue sounds one after another.
  - Seemless looping through streaming buffers.
- UI system.
  - Customize base controls through inheritance or use them straight away.
  - Layouting and anchoring.
  - Parenting system.
  - Comes with basic controls such as labels, buttons, scrollbar, and more.
- Easy tilemap drawing.
  - Integration with the Tiled application.
  - Includes layer opacity, multiple tilesets, animated tiles, and more.
- An implementation of A*.
  - With the ability to add a custom heuristics function, and perform other customizations.
- A Javascript scripting engine.
- Logging.
  - Runs on another thread as not to interrupt your game.
  - Remote logging to PaperTrail and other services which support the protocol.
- Graphical debugging and a command console.
  - Debug the camera, or UI through the engine.
  - Execute scripting commands at real time.
- Scenes.
- Framerate independent timing, semi-fixed step and free-step based on configuration.
  - Managed delta time and total time access in the shader for cool effects.
  - The update loop will always be up to date when a target fps is selected.
- Lots of configuration through settings and flags.
- Steam integration.

## Documentation

The documentation is still a work in progress.

* [Getting Started](./Documents/Start)
* Modules
  * [AssetLoader](./Documents/AssetLoader)
    * [Shaders](./Documents/Shaders)
  * [SoundManager](./Documents/SoundManager)
* [Configuration](./Documents/Configuration)
* [Special Thanks](./Documents/Thanks)

For more information you can refer to the automated tests here - [Emotion.Tests](Emotion.Tests) or check the playground of examples here - [EmotionSandbox](https://github.com/Cryru/EmotionSandbox).

If interested you can use the visual debugger found here - [Rationale](https://github.com/Cryru/Rationale). Take note that it might not be up to date/work.

## Platforms

### Platforms Tested On:

The latest build is always tested on the configurations listed as `Primary`.

- Windows 10 x64/x86
  - Intel HD Graphics 620 `(Primary)`
  - Nvidia 940MX `(Primary)`
  - AMD R9 200
  - 970M
- Ubuntu Xenial-Xerus x64 `(Last Test On: Build 271) Feb 5th`
  - OpenGL MESA Driver
- Linux Mint 19.1 `(Last Test On: Build 271) Feb 5th`
  - Nvidia 1060
- MacOS X High-Sierra x64 `(Last Test On: Build 272) Feb 6th`
- MacOS X 18.5 Mountain Lion x64 `(Last Test On: Build 272) Feb 6th`

### Theoretical Platforms:

It should run on these platforms as well, but they are only technically supported due to lack of testing.

- Windows Vista/7/8/8.1 x64/x86
- Debian 9+ x64
- MacOS 18.5 Mountain Lion+ x64

### Planned Platforms:

- Android 5.0+

## Building:

Just clone and build. Everything is included.

For information on how to build for other platforms check out: https://github.com/Cryru/The-Struggles-Of-Running-And-Statically-Linking-Mono

To use Steamworks on Linux and Mac you need to move the `Steamworks.Net-Mono.dll` file from the `Libraries/Steamworks` folder to the root and overwrite the default Steamworks.Net there BEFORE PACKAGING.

## Testing and QA

The engine has unit and integration tests, but they aren't automatically run as the CI doesn't support OpenGL 3.3+ Despite this I ensure that all tests pass before merging into master. Take note however that the tests are only ran on Windows 10 and do not test other platforms. There I rely on user and my own game development testing. Other issues like difference in driver behavior are also hard to catch using these tests and rely on user feedback.

## Projects Used

[OpenTK](https://github.com/opentk/opentk) [OpenGL/OpenAL] : Context and host creation, input capturing, GL API and AL api.
- OpenAL32.dll included. x64/x86
- openal.so included. x64
    - libsndio.so.6.1 included.
- libopenal.1.dylib x64

[FreeImage-DotNet-Core](https://github.com/matgr1/FreeImage-dotnet-core) [FreeImage] : Loading and converting images.
- FreeImage.dll included. x64/x86
- FreeImage.so included. x64
    - libpng14.14.dylib included.
- FreeImage.dylib included. x64

[SharpFont](https://github.com/Robmaister/SharpFont) [FreeType] : Loading fonts and glyphs, and rendering them.
- freetype6.dll included. x64/x86
- freetype.so included. x64
- libfreetype.6.dylib included. x64

[TiledSharp](https://github.com/marshallward/TiledSharp) [Modified] : Loading .tmx Tiled files.

[Jint](https://github.com/sebastienros/jint) : Javascript script engine.

System.Numerics : Vector and matrix math.

[Steamworks.Net](https://github.com/rlabrecque/Steamworks.NET) : Steam integration support.
- Steamworks.Net.dll incldued. x86
- Steamworks.Net-Mono.cll included. Mac/Linux x86
    - libsteam_api.dylib x64
    - libsteam_api.so x64
    - steam_api.dll x86
    - steam_api64.dll x64
	
[SeriLog](https://serilog.net/) : Logging

## Inspired By

- Processing
- MonoGame
- LOVE Framework
- Sparky
