﻿#if SILICONSTUDIO_XENKO_GRAPHICS_API_OPENGLCORE
//------------------------------------------------------------------------------
// <auto-generated>
//     Xenko Effect Compiler File Generated:
//     Effect [SignedDistanceFieldFontShader]
//
//     Command Line: C:\work\Stash\Xenko\sources\engine\SiliconStudio.Xenko.Graphics\Shaders093.Bytecodes\..\..\..\..\Bin\Windows-Direct3D11\SiliconStudio.Assets.CompilerApp.exe --profile=Windows-OpenGL --platform=Windows --output-path=C:\work\Stash\Xenko\sources\engine\SiliconStudio.Xenko.Graphics\Shaders093.Bytecodes\obj\app_data --build-path=C:\work\Stash\Xenko\sources\engine\SiliconStudio.Xenko.Graphics\Shaders093.Bytecodes\obj\build_app_data --package-file=Graphics.xkpkg
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiliconStudio.Xenko.Graphics 
{
    internal partial class SignedDistanceFieldFontShader
    {
        private static readonly byte[] signedDistanceFieldFontBytecode = new byte[] {
4, 192, 254, 239, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 18, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 48, 9, 0, 0, 0, 7, 0, 0, 0, 0, 13, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 1, 5, 0, 0, 0, 255, 255, 
255, 255, 1, 0, 0, 0, 1, 0, 17, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 83, 97, 109, 112, 108, 101, 114, 8, 0, 0, 0, 10, 0, 0, 0, 0, 12, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 1, 5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 5, 0, 0, 0, 29, 83, 105, 103, 110, 101, 100, 68, 105, 115, 116, 97, 110, 99, 101, 70, 105, 101, 108, 100, 70, 111, 110, 116, 83, 104, 97, 100, 101, 114, 1, 153, 196, 61, 15, 255, 41, 213, 62, 100, 240, 102, 29, 126, 78, 149, 
243, 10, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 1, 92, 49, 96, 204, 191, 147, 108, 94, 16, 43, 217, 49, 95, 15, 148, 106, 16, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 83, 116, 114, 101, 97, 109, 1, 246, 153, 8, 5, 148, 172, 99, 193, 243, 129, 64, 222, 87, 206, 26, 123, 23, 
83, 105, 103, 110, 101, 100, 68, 105, 115, 116, 97, 110, 99, 101, 70, 105, 101, 108, 100, 70, 111, 110, 116, 1, 172, 117, 154, 63, 105, 69, 152, 92, 131, 197, 39, 182, 2, 37, 34, 214, 9, 84, 101, 120, 116, 117, 114, 105, 110, 103, 1, 169, 217, 238, 31, 185, 166, 138, 247, 206, 107, 18, 41, 22, 
134, 250, 234, 0, 2, 0, 0, 0, 0, 1, 0, 0, 0, 1, 184, 217, 213, 205, 215, 170, 138, 244, 210, 72, 208, 96, 79, 109, 202, 148, 0, 10, 5, 0, 0, 35, 118, 101, 114, 115, 105, 111, 110, 32, 52, 49, 48, 13, 10, 13, 10, 115, 116, 114, 117, 99, 116, 32, 86, 83, 95, 83, 84, 82, 
69, 65, 77, 83, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 49, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 59, 13, 10, 32, 32, 32, 32, 
118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 95, 105, 100, 55, 50, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 86, 83, 95, 79, 
85, 84, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 
59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 95, 105, 100, 55, 50, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 86, 83, 95, 73, 78, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 80, 111, 115, 105, 116, 
105, 111, 110, 95, 105, 100, 55, 49, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 95, 105, 100, 55, 50, 59, 13, 10, 125, 59, 13, 10, 111, 117, 
116, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 111, 117, 116, 32, 118, 101, 99, 52, 32, 118, 95, 67, 79, 76, 79, 82, 48, 59, 13, 10, 105, 110, 32, 118, 101, 99, 52, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 13, 10, 105, 
110, 32, 118, 101, 99, 50, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 105, 110, 32, 118, 101, 99, 52, 32, 97, 95, 67, 79, 76, 79, 82, 48, 59, 13, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 40, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 86, 83, 95, 73, 
78, 80, 85, 84, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 67, 111, 108, 111, 114, 95, 105, 100, 55, 50, 32, 61, 32, 97, 95, 67, 79, 76, 79, 82, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 
117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 32, 61, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 49, 32, 61, 
32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 13, 10, 32, 32, 32, 32, 86, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 
49, 32, 61, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 49, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 32, 61, 32, 95, 48, 105, 110, 112, 117, 
116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 95, 105, 100, 55, 50, 32, 61, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 67, 111, 108, 111, 114, 95, 105, 100, 55, 
50, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 49, 59, 13, 10, 32, 32, 
32, 32, 86, 83, 95, 79, 85, 84, 80, 85, 84, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 32, 61, 32, 115, 116, 
114, 101, 97, 109, 115, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 32, 61, 32, 115, 116, 114, 101, 97, 
109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 59, 13, 10, 32, 32, 32, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 67, 111, 108, 111, 114, 95, 105, 100, 55, 50, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 95, 105, 100, 55, 
50, 59, 13, 10, 32, 32, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 32, 61, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 118, 95, 84, 69, 88, 
67, 79, 79, 82, 68, 48, 32, 61, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 59, 13, 10, 32, 32, 32, 32, 118, 95, 67, 79, 76, 79, 82, 48, 32, 61, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 67, 111, 
108, 111, 114, 95, 105, 100, 55, 50, 59, 13, 10, 32, 32, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 122, 32, 61, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 122, 32, 42, 32, 50, 46, 48, 32, 45, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 
46, 119, 59, 13, 10, 32, 32, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 32, 61, 32, 45, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 59, 13, 10, 125, 13, 10, 0, 5, 0, 0, 0, 1, 116, 142, 189, 7, 239, 79, 17, 135, 39, 75, 74, 162, 97, 
77, 202, 178, 0, 106, 9, 0, 0, 35, 118, 101, 114, 115, 105, 111, 110, 32, 52, 49, 48, 13, 10, 13, 10, 115, 116, 114, 117, 99, 116, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 
95, 105, 100, 54, 49, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 95, 105, 100, 55, 50, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 
117, 99, 116, 32, 80, 83, 95, 79, 85, 84, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 86, 83, 95, 79, 85, 84, 80, 
85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 59, 13, 10, 
32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 95, 105, 100, 55, 50, 59, 13, 10, 125, 59, 13, 10, 117, 110, 105, 102, 111, 114, 109, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 32, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 
114, 95, 105, 100, 52, 49, 59, 13, 10, 108, 97, 121, 111, 117, 116, 40, 108, 111, 99, 97, 116, 105, 111, 110, 32, 61, 32, 48, 41, 32, 32, 111, 117, 116, 32, 118, 101, 99, 52, 32, 111, 117, 116, 95, 103, 108, 95, 102, 114, 97, 103, 100, 97, 116, 97, 95, 67, 111, 108, 111, 114, 84, 97, 114, 
103, 101, 116, 95, 105, 100, 49, 59, 13, 10, 105, 110, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 105, 110, 32, 118, 101, 99, 52, 32, 118, 95, 67, 79, 76, 79, 82, 48, 59, 13, 10, 102, 108, 111, 97, 116, 32, 109, 101, 100, 105, 97, 110, 95, 
105, 100, 50, 40, 102, 108, 111, 97, 116, 32, 114, 44, 32, 102, 108, 111, 97, 116, 32, 103, 44, 32, 102, 108, 111, 97, 116, 32, 98, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 109, 97, 120, 40, 109, 105, 110, 40, 114, 44, 32, 103, 41, 44, 32, 109, 105, 110, 
40, 109, 97, 120, 40, 114, 44, 32, 103, 41, 44, 32, 98, 41, 41, 59, 13, 10, 125, 13, 10, 118, 101, 99, 52, 32, 70, 111, 110, 116, 67, 111, 108, 111, 114, 95, 105, 100, 51, 40, 118, 101, 99, 52, 32, 115, 97, 109, 112, 108, 101, 100, 67, 111, 108, 111, 114, 44, 32, 118, 101, 99, 52, 32, 
116, 101, 120, 116, 67, 111, 108, 111, 114, 44, 32, 118, 101, 99, 52, 32, 98, 111, 114, 100, 101, 114, 67, 111, 108, 111, 114, 44, 32, 102, 108, 111, 97, 116, 32, 98, 111, 114, 100, 101, 114, 84, 104, 105, 99, 107, 110, 101, 115, 115, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 98, 111, 114, 100, 
101, 114, 84, 104, 105, 99, 107, 110, 101, 115, 115, 32, 61, 32, 99, 108, 97, 109, 112, 40, 98, 111, 114, 100, 101, 114, 84, 104, 105, 99, 107, 110, 101, 115, 115, 44, 32, 102, 108, 111, 97, 116, 40, 48, 41, 44, 32, 48, 46, 50, 41, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 
115, 104, 97, 114, 112, 110, 101, 115, 115, 77, 97, 103, 110, 105, 116, 117, 100, 101, 32, 61, 32, 48, 46, 53, 102, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 97, 120, 105, 115, 68, 105, 115, 116, 97, 110, 99, 101, 32, 61, 32, 48, 46, 52, 32, 45, 32, 98, 111, 114, 100, 101, 
114, 84, 104, 105, 99, 107, 110, 101, 115, 115, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 109, 101, 100, 105, 97, 110, 68, 105, 115, 116, 97, 110, 99, 101, 32, 61, 32, 109, 101, 100, 105, 97, 110, 95, 105, 100, 50, 40, 115, 97, 109, 112, 108, 101, 100, 67, 111, 108, 111, 114, 46, 
114, 44, 32, 115, 97, 109, 112, 108, 101, 100, 67, 111, 108, 111, 114, 46, 103, 44, 32, 115, 97, 109, 112, 108, 101, 100, 67, 111, 108, 111, 114, 46, 98, 41, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 115, 105, 103, 68, 105, 115, 116, 32, 61, 32, 109, 101, 100, 105, 97, 110, 68, 
105, 115, 116, 97, 110, 99, 101, 32, 45, 32, 97, 120, 105, 115, 68, 105, 115, 116, 97, 110, 99, 101, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 116, 114, 97, 110, 115, 105, 116, 105, 111, 110, 32, 61, 32, 102, 119, 105, 100, 116, 104, 40, 115, 105, 103, 68, 105, 115, 116, 41, 32, 
42, 32, 48, 46, 56, 53, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 111, 112, 97, 99, 105, 116, 121, 32, 61, 32, 115, 109, 111, 111, 116, 104, 115, 116, 101, 112, 40, 45, 116, 114, 97, 110, 115, 105, 116, 105, 111, 110, 44, 32, 116, 114, 97, 110, 115, 105, 116, 105, 111, 110, 44, 
32, 115, 105, 103, 68, 105, 115, 116, 41, 59, 13, 10, 32, 32, 32, 32, 111, 112, 97, 99, 105, 116, 121, 32, 42, 61, 32, 111, 112, 97, 99, 105, 116, 121, 59, 13, 10, 32, 32, 32, 32, 105, 102, 32, 40, 98, 111, 114, 100, 101, 114, 84, 104, 105, 99, 107, 110, 101, 115, 115, 32, 62, 32, 102, 
108, 111, 97, 116, 40, 48, 41, 41, 13, 10, 32, 32, 32, 32, 123, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 102, 97, 114, 68, 105, 115, 116, 97, 110, 99, 101, 32, 61, 32, 97, 120, 105, 115, 68, 105, 115, 116, 97, 110, 99, 101, 32, 43, 32, 98, 111, 114, 100, 
101, 114, 84, 104, 105, 99, 107, 110, 101, 115, 115, 32, 42, 32, 102, 108, 111, 97, 116, 40, 50, 41, 59, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 115, 105, 103, 68, 105, 115, 116, 66, 111, 114, 100, 101, 114, 32, 61, 32, 109, 101, 100, 105, 97, 110, 68, 105, 115, 
116, 97, 110, 99, 101, 32, 45, 32, 102, 97, 114, 68, 105, 115, 116, 97, 110, 99, 101, 59, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 98, 111, 114, 100, 101, 114, 76, 105, 110, 101, 32, 61, 32, 115, 104, 97, 114, 112, 110, 101, 115, 115, 77, 97, 103, 110, 105, 116, 
117, 100, 101, 32, 42, 32, 115, 105, 103, 68, 105, 115, 116, 66, 111, 114, 100, 101, 114, 32, 47, 32, 102, 119, 105, 100, 116, 104, 40, 115, 105, 103, 68, 105, 115, 116, 66, 111, 114, 100, 101, 114, 41, 32, 43, 32, 102, 97, 114, 68, 105, 115, 116, 97, 110, 99, 101, 59, 13, 10, 32, 32, 32, 32, 
32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 98, 111, 114, 100, 101, 114, 79, 112, 97, 99, 105, 116, 121, 32, 61, 32, 115, 109, 111, 111, 116, 104, 115, 116, 101, 112, 40, 102, 108, 111, 97, 116, 40, 48, 41, 44, 32, 102, 108, 111, 97, 116, 40, 49, 41, 44, 32, 98, 111, 114, 100, 101, 114, 76, 
105, 110, 101, 41, 59, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 116, 101, 120, 116, 67, 111, 108, 111, 114, 32, 61, 32, 109, 105, 120, 40, 98, 111, 114, 100, 101, 114, 67, 111, 108, 111, 114, 44, 32, 116, 101, 120, 116, 67, 111, 108, 111, 114, 44, 32, 118, 101, 99, 52, 40, 98, 111, 114, 100, 
101, 114, 79, 112, 97, 99, 105, 116, 121, 41, 41, 59, 13, 10, 32, 32, 32, 32, 125, 13, 10, 32, 32, 32, 32, 115, 97, 109, 112, 108, 101, 100, 67, 111, 108, 111, 114, 32, 61, 32, 109, 105, 120, 40, 118, 101, 99, 52, 40, 48, 44, 32, 48, 44, 32, 48, 44, 32, 48, 41, 44, 32, 116, 101, 
120, 116, 67, 111, 108, 111, 114, 44, 32, 118, 101, 99, 52, 40, 111, 112, 97, 99, 105, 116, 121, 41, 41, 59, 13, 10, 32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 115, 97, 109, 112, 108, 101, 100, 67, 111, 108, 111, 114, 59, 13, 10, 125, 13, 10, 118, 101, 99, 52, 32, 83, 104, 97, 100, 
105, 110, 103, 95, 105, 100, 52, 40, 105, 110, 111, 117, 116, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 115, 105, 103, 110, 101, 100, 77, 117, 108, 116, 105, 68, 105, 115, 116, 97, 110, 
99, 101, 32, 61, 32, 116, 101, 120, 116, 117, 114, 101, 40, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 44, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 41, 59, 
13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 98, 111, 114, 100, 101, 114, 67, 111, 108, 111, 114, 32, 61, 32, 118, 101, 99, 52, 40, 48, 44, 32, 48, 44, 32, 48, 44, 32, 49, 41, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 98, 111, 114, 100, 101, 114, 84, 104, 105, 99, 
107, 110, 101, 115, 115, 32, 61, 32, 48, 46, 102, 59, 13, 10, 32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 70, 111, 110, 116, 67, 111, 108, 111, 114, 95, 105, 100, 51, 40, 115, 105, 103, 110, 101, 100, 77, 117, 108, 116, 105, 68, 105, 115, 116, 97, 110, 99, 101, 44, 32, 115, 116, 114, 101, 
97, 109, 115, 46, 67, 111, 108, 111, 114, 95, 105, 100, 55, 50, 44, 32, 98, 111, 114, 100, 101, 114, 67, 111, 108, 111, 114, 44, 32, 98, 111, 114, 100, 101, 114, 84, 104, 105, 99, 107, 110, 101, 115, 115, 41, 59, 13, 10, 125, 13, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 40, 41, 13, 10, 
123, 13, 10, 32, 32, 32, 32, 86, 83, 95, 79, 85, 84, 80, 85, 84, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 67, 111, 108, 111, 114, 95, 105, 100, 55, 50, 32, 61, 32, 118, 95, 67, 79, 76, 79, 82, 48, 
59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 32, 61, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 83, 104, 97, 
100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 32, 61, 32, 103, 108, 95, 70, 114, 97, 103, 67, 111, 111, 114, 100, 59, 13, 10, 32, 32, 32, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 59, 13, 10, 32, 32, 32, 32, 115, 
116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 32, 61, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 
111, 114, 95, 105, 100, 55, 50, 32, 61, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 67, 111, 108, 111, 114, 95, 105, 100, 55, 50, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 32, 61, 32, 83, 
104, 97, 100, 105, 110, 103, 95, 105, 100, 52, 40, 115, 116, 114, 101, 97, 109, 115, 41, 59, 13, 10, 32, 32, 32, 32, 80, 83, 95, 79, 85, 84, 80, 85, 84, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 
67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 59, 13, 10, 32, 32, 32, 32, 111, 117, 116, 95, 103, 108, 95, 102, 114, 97, 103, 100, 97, 116, 97, 95, 
67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 32, 61, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 59, 13, 10, 125, 13, 10, 
        };
    }
}
#endif
