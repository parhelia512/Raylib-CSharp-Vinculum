// [!!] [!!] [!!] [!!] [!!] [!!] [!!] [!!] [!!] [!!] [!!] [!!] [!!] [!!] [!!] 
// [!!] Copyright ©️ Raylib-CsLo and Contributors. 
// [!!] This file is licensed to you under the MPL-2.0.
// [!!] See the LICENSE file in the project root for more info. 
// [!!] ------------------------------------------------- 
// [!!] The code and 100+ examples are here! https://github.com/NotNotTech/Raylib-CsLo 
// [!!] [!!] [!!] [!!] [!!] [!!] [!!] [!!] [!!] [!!] [!!]  [!!] [!!] [!!] [!!]

namespace ZeroElectric.Vinculum.Examples.Audio;

/*******************************************************************************************
*
*   raylib [audio] example - Multichannel sound playing
*
*   This example has been created using raylib 2.6 (www.raylib.com)
*   raylib is licensed under an unmodified zlib/libpng license (View raylib.h for details)
*
*   Example contributed by Chris Camacho (@chriscamacho) and reviewed by Ramon Santamaria (@raysan5)
*
*   Copyright (c) 2019 Chris Camacho (@chriscamacho) and Ramon Santamaria (@raysan5)
*
********************************************************************************************/

public unsafe static class MultichannelSoundPlaying
{

	public static int main()
	{
		// Initialization
		//--------------------------------------------------------------------------------------
		const int screenWidth = 800;
		const int screenHeight = 450;

		InitWindow(screenWidth, screenHeight, "raylib [audio] example - Multichannel sound playing");

		InitAudioDevice();      // Initialize audio device

		Sound fxWav = LoadSound("resources/sound.wav");         // Load WAV audio file
		Sound fxOgg = LoadSound("resources/target.ogg");        // Load OGG audio file

		SetSoundVolume(fxWav, 0.2f);

		SetTargetFPS(60);       // Set our game to run at 60 frames-per-second
								//--------------------------------------------------------------------------------------

		// Main game loop
		while (!WindowShouldClose())    // Detect window close button or ESC key
		{
			// Update
			//----------------------------------------------------------------------------------
			if (IsKeyPressed(KEY_ENTER)) PlaySoundMulti(fxWav);     // Play a new wav sound instance
			if (IsKeyPressed(KEY_SPACE)) PlaySoundMulti(fxOgg);     // Play a new ogg sound instance
																	//----------------------------------------------------------------------------------

			// Draw
			//----------------------------------------------------------------------------------
			BeginDrawing();

			ClearBackground(RAYWHITE);

			DrawText("MULTICHANNEL SOUND PLAYING", 20, 20, 20, GRAY);
			DrawText("Press SPACE to play new ogg instance!", 200, 120, 20, LIGHTGRAY);
			DrawText("Press ENTER to play new wav instance!", 200, 180, 20, LIGHTGRAY);

			DrawText(TextFormat("CONCURRENT SOUNDS PLAYING: %02i", GetSoundsPlaying()), 220, 280, 20, RED);

			EndDrawing();
			//----------------------------------------------------------------------------------
		}

		// De-Initialization
		//--------------------------------------------------------------------------------------
		StopSoundMulti();       // We must stop the buffer pool before unloading

		UnloadSound(fxWav);     // Unload sound data
		UnloadSound(fxOgg);     // Unload sound data

		CloseAudioDevice();     // Close audio device

		CloseWindow();          // Close window and OpenGL context
								//--------------------------------------------------------------------------------------

		return 0;
	}
}






