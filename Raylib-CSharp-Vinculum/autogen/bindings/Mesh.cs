
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
    public unsafe partial struct Mesh
    {
        public int vertexCount;

        public int triangleCount;

        public float* vertices;

        public float* texcoords;

        public float* texcoords2;

        public float* normals;

        public float* tangents;

        [NativeTypeName("unsigned char *")]
        public byte* colors;

        [NativeTypeName("unsigned short *")]
        public ushort* indices;

        public float* animVertices;

        public float* animNormals;

        [NativeTypeName("unsigned char *")]
        public byte* boneIds;

        public float* boneWeights;

        [NativeTypeName("unsigned int")]
        public uint vaoId;

        [NativeTypeName("unsigned int *")]
        public uint* vboId;
    }
}
