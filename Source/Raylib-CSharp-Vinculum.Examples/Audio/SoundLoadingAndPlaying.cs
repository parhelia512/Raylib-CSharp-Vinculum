
//------------------------------------------------------------------------------
//
// Copyright 2022-2023 © Raylib-CSharp-Vinculum, Raylib-CsLo and Contributors. 
// This file is licensed to you under the MPL-2.0.
// See the LICENSE file in the project's root for more info.
//
// Raylib-CSharp-Vinculum, bindings for Raylib 4.5.
// Find Raylib-CSharp-Vinculum here: https://github.com/ZeroElectric/Raylib-CSharp-Vinculum
// Find Raylib here: https://github.com/raysan5/raylib
//
//------------------------------------------------------------------------------

namespace ZeroElectric.Vinculum.Examples.Audio;
/*******************************************************************************************
*
*   raylib [audio] example - Sound loading and playing
*
*   This example has been created using raylib 1.0 (www.raylib.com)
*   raylib is licensed under an unmodified zlib/libpng license (View raylib.h for details)
*
*   Copyright (c) 2014 Ramon Santamaria (@raysan5)
*
********************************************************************************************/

public unsafe static class SoundLoadingAndPlaying
{

	public static int main()
	{
		// Initialization
		//--------------------------------------------------------------------------------------
		const int screenWidth = 800;
		const int screenHeight = 450;

		InitWindow(screenWidth, screenHeight, "raylib [audio] example - sound loading and playing");

		InitAudioDevice();      // Initialize audio device

		Sound fxWav = LoadSound("resources/sound.wav");         // Load WAV audio file
		Sound fxOgg = LoadSound("resources/target.ogg");        // Load OGG audio file

		SetTargetFPS(60);               // Set our game to run at 60 frames-per-second
										//--------------------------------------------------------------------------------------

		// Main game loop
		while (!WindowShouldClose())    // Detect window close button or ESC key
		{
			// Update
			//----------------------------------------------------------------------------------
			if (IsKeyPressed(KEY_SPACE)) PlaySound(fxWav);      // Play WAV sound
			if (IsKeyPressed(KEY_ENTER)) PlaySound(fxOgg);      // Play OGG sound
																//----------------------------------------------------------------------------------

			// Draw
			//----------------------------------------------------------------------------------
			BeginDrawing();

			ClearBackground(RAYWHITE);

			DrawText("Press SPACE to PLAY the WAV sound!", 200, 180, 20, LIGHTGRAY);
			DrawText("Press ENTER to PLAY the OGG sound!", 200, 220, 20, LIGHTGRAY);

			EndDrawing();
			//----------------------------------------------------------------------------------
		}

		// De-Initialization
		//--------------------------------------------------------------------------------------
		UnloadSound(fxWav);     // Unload sound data
		UnloadSound(fxOgg);     // Unload sound data

		CloseAudioDevice();     // Close audio device

		CloseWindow();          // Close window and OpenGL context
								//--------------------------------------------------------------------------------------

		return 0;
	}
}







