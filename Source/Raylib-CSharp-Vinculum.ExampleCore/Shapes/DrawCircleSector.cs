
//------------------------------------------------------------------------------
//
// Copyright 2022-2023 © Raylib-CSharp-Vinculum, Raylib-CsLo and Contributors. 
// This file is licensed to you under the MPL-2.0.
// See the LICENSE file in the project's root for more info.
//
// Raylib-CSharp-Vinculum, .Net/C# bindings for raylib 5.0.
// Find Raylib-CSharp-Vinculum here: https://github.com/ZeroElectric/Raylib-CSharp-Vinculum
// Find Raylib here: https://github.com/raysan5/raylib
//
//------------------------------------------------------------------------------

namespace ZeroElectric.Vinculum.ExampleCore.Shapes;

/*******************************************************************************************
*
*   raylib [shapes] example - draw circle sector (with gui options)
*
*   This example has been created using raylib 2.5 (www.raylib.com)
*   raylib is licensed under an unmodified zlib/libpng license (View raylib.h for details)
*
*   Example contributed by Vlad Adrian (@demizdor) and reviewed by Ramon Santamaria (@raysan5)
*
*   Copyright (c) 2018 Vlad Adrian (@demizdor) and Ramon Santamaria (@raysan5)
*
********************************************************************************************/

public unsafe static class DrawCircleSector
{
	public static int main()
	{
		// Initialization
		//--------------------------------------------------------------------------------------

		const int screenWidth = 800;
		const int screenHeight = 450;

		InitWindow(screenWidth, screenHeight, "raylib [shapes] example - draw circle sector");

		Vector2 center = new Vector2((GetScreenWidth() - 300) / 2.0f, GetScreenHeight() / 2.0f);

		float outerRadius = 180.0f;
		float startAngle = 0.0f;
		float endAngle = 180.0f;
		float segments = 0;
		int minSegments = 4;

		GuiLoadStyleDefault(); //init raygui

		SetTargetFPS(60);               // Set our game to run at 60 frames-per-second

		// Main game loop, 'WindowShouldClose' Detects window close button or ESC key
		//----------------------------------------------------------------------------------
		while (!WindowShouldClose())
		{
			// Update
			//----------------------------------------------------------------------------------

			// NOTE: All variables update happens inside GUI control functions

			// Draw
			//----------------------------------------------------------------------------------

			BeginDrawing();

			ClearBackground(RAYWHITE);

			DrawLine(500, 0, 500, GetScreenHeight(), Fade(LIGHTGRAY, 0.6f));
			DrawRectangle(500, 0, GetScreenWidth() - 500, GetScreenHeight(), Fade(LIGHTGRAY, 0.3f));

			DrawCircleSector(center, outerRadius, startAngle, endAngle, (int)segments, Fade(MAROON, 0.3f));
			DrawCircleSectorLines(center, outerRadius, startAngle, endAngle, (int)segments, Fade(MAROON, 0.6f));

			// Draw GUI controls
			//------------------------------------------------------------------------------

			GuiSliderBar(new Rectangle(600, 40, 120, 20), "StartAngle", null, ref startAngle, 0, 720);
			GuiSliderBar(new Rectangle(600, 70, 120, 20), "EndAngle", null, ref endAngle, 0, 720);

			GuiSliderBar(new Rectangle(600, 140, 120, 20), "Radius", null, ref outerRadius, 0, 200);
			GuiSliderBar(new Rectangle(600, 170, 120, 20), "Segments", null, ref segments, 0, 100);

			minSegments = (int)MathF.Ceiling((endAngle - startAngle) / 90);
			DrawText(TextFormat("MODE: %s", (segments >= minSegments) ? "MANUAL" : "AUTO"), 600, 200, 10, (segments >= minSegments) ? MAROON : DARKGRAY);

			DrawFPS(10, 10);

			EndDrawing();
		}

		// De-Initialization
		//--------------------------------------------------------------------------------------

		CloseWindow();        // Close window and OpenGL context

		return 0;
	}
}
