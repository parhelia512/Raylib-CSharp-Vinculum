
//------------------------------------------------------------------------------
//
// Copyright 2022 Â© Raylib-CSharp-Vinculum, Raylib-CsLo and Contributors. 
// This file is licensed to you under the MPL-2.0.
// See the LICENSE file in the project's root for more info.
//
// Raylib-CSharp-Vinculum, bindings for Raylib 4.2.
// Find Raylib-CSharp-Vinculum here: https://github.com/ZeroElectric/Raylib-CSharp-Vinculum
// Find Raylib here: https://github.com/raysan5/raylib
//
//------------------------------------------------------------------------------

//------------------------------------------------------------------------------
//
//     This file and it's containing folder are generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//------------------------------------------------------------------------------

namespace ZeroElectric.Vinculum
{
    public unsafe partial struct rresFileHeader
    {
        [NativeTypeName("unsigned char[4]")]
        public fixed byte id[4];

        [NativeTypeName("unsigned short")]
        public ushort version;

        [NativeTypeName("unsigned short")]
        public ushort chunkCount;

        [NativeTypeName("unsigned int")]
        public uint cdOffset;

        [NativeTypeName("unsigned int")]
        public uint reserved;
    }
}
