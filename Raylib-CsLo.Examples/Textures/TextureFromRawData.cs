// Copyright ©️ Raylib-CsLo and Contributors.
// This file is licensed to you under the MPL-2.0.
// See the LICENSE file in the project root for more info.
// The code and 100+ examples are here! https://github.com/NotNotTech/Raylib-CsLo

namespace Raylib_CsLo.Examples.Textures;
using System.Runtime.CompilerServices;
using Microsoft.Toolkit.HighPerformance;

/*******************************************************************************************
*
*   raylib [textures] example - Load textures from raw data
*
*   NOTE: Images are loaded in CPU memory (RAM); textures are loaded in GPU memory (VRAM)
*
*   This example has been created using raylib 1.3 (www.raylib.com)
*   raylib is licensed under an unmodified zlib/libpng license (View raylib.h for details)
*
*   Copyright (c) 2015 Ramon Santamaria (@raysan5)
*
********************************************************************************************/

public static unsafe class TextureFromRawData
{

    // #include <stdlib.h>         // Required for: malloc() and free()

    public static int Example()
    {
        // Initialization

        const int screenWidth = 800;
        const int screenHeight = 450;

        InitWindow(screenWidth, screenHeight, "raylib [textures] example - texture from raw data");

        // NOTE: Textures MUST be loaded after Window initialization (OpenGL context is required)

        // Load RAW image data (512x512, 32bit RGBA, no file header)
        Image fudesumiRaw = LoadImageRaw("resources/fudesumi.raw", 384, 512, PIXELFORMAT_UNCOMPRESSED_R8G8B8A8, 0);
        Texture2D fudesumi = LoadTextureFromImage(fudesumiRaw);  // Upload CPU (RAM) image to GPU (VRAM)
        UnloadImage(fudesumiRaw);                                // Unload CPU (RAM) image data

        // Generate a checkedImage texture by code
        int width = 960;
        int height = 480;

        // Dynamic memory allocation to store pixels data (Color type)
        //Color* pixels = (Color*)malloc(width * height * sizeof(Color));
        //var pixels = stackalloc Color[width * height];
        Color[]? pixels = new Color[width * height];
        System.Runtime.InteropServices.GCHandle h_pixels = pixels.GcPin();

        //Span<Color> span = new Span<Color>(pixels);
        //Color* pColors = &span[0];

        //GCHandle pPixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
        //pPixels.
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (((x / 32) + (y / 32)) / 1 % 2 == 0)
                {
                    pixels[(y * width) + x] = ORANGE;
                }
                else
                {
                    pixels[(y * width) + x] = GOLD;
                }
            }
        }

        // Load pixels data into an image structure and create texture
        Image checkedIm = new()
        {
            data = Unsafe.AsPointer(ref pixels.DangerousGetReference()),             // We can assign pixels directly to data
            width = width,
            height = height,
            format = (int)PIXELFORMAT_UNCOMPRESSED_R8G8B8A8,
            mipmaps = 1
        };

        Texture2D checkedImage = LoadTextureFromImage(checkedIm);
        //RAYLIB-CSLO: our pixels are created in managed memory.  will be cleaned up by the GC
        //UnloadImage(checkedIm);         // Unload CPU (RAM) image data (pixels)


        // Main game loop
        while (!WindowShouldClose())    // Detect window close button or ESC key
        {
            // Update

            // TODO: Update your variables here


            // Draw

            BeginDrawing();

            ClearBackground(RAYWHITE);

            DrawTexture(checkedImage, (screenWidth / 2) - (checkedImage.width / 2), (screenHeight / 2) - (checkedImage.height / 2), Fade(WHITE, 0.5f));
            DrawTexture(fudesumi, 430, -30, WHITE);

            DrawText("CHECKED TEXTURE ", 84, 85, 30, BROWN);
            DrawText("GENERATED by CODE", 72, 148, 30, BROWN);
            DrawText("and RAW IMAGE LOADING", 46, 210, 30, BROWN);

            DrawText("(c) Fudesumi sprite by Eiden Marsal", 310, screenHeight - 20, 10, BROWN);

            EndDrawing();

        }

        // De-Initialization

        UnloadTexture(fudesumi);    // Texture unloading
        UnloadTexture(checkedImage);     // Texture unloading
        h_pixels.Free();
        CloseWindow();              // Close window and OpenGL context


        return 0;
    }

}
