using Raylib_cs;
using static Raylib_cs.Raylib;

namespace Examples.Shapes;

public class BasicShapes
{
    public static void Main()
    {
        // Initialization
        //--------------------------------------------------------------------------------------
        const int screenWidth = 800;
        const int screenHeight = 450;

        InitWindow(screenWidth, screenHeight, "Basic shape and image drawing");

        //Load the image into the cpu
        Image image = LoadImage("resources/raylib-cs_logo.png");

        //Transform it as a texture
        Texture2D texture = LoadTextureFromImage(image);

        //Unload/release it
        UnloadImage(image);
        //--------------------------------------------------------------------------------------

        // Main game loop
        while (!WindowShouldClose())
        {
            // Update
            //----------------------------------------------------------------------------------
            // TODO: Update your variables here
            //----------------------------------------------------------------------------------

            // Draw
            //----------------------------------------------------------------------------------
            BeginDrawing();
            ClearBackground(Color.RayWhite);

            /* Raylib supports drawing simple 2d shapes with internal functions 
            so uncomment the following lines to see it in action */

            // DrawText("some basic shapes available on raylib", 20, 20, 20, Color.DarkGray);

            // DrawLine(18, 42, screenWidth - 18, 42, Color.Black);

            // DrawCircle(screenWidth / 4, 120, 35, Color.DarkBlue);
            // DrawRectangle(screenWidth / 4 * 2 - 60, 100, 120, 60, Color.Red);
            // DrawTriangle(
            //     new Vector2(screenWidth / 4 * 3, 80),
            //     new Vector2(screenWidth / 4 * 3 - 60, 150),
            //     new Vector2(screenWidth / 4 * 3 + 60, 150), Color.Violet
            // );

            int x = screenWidth / 2 - texture.Width / 2;
            int y = screenHeight / 2 - texture.Height / 2;

            //This is where we draw the texture
            DrawTexture(texture, x - 200, y + 60, Color.White);



            EndDrawing();
            //----------------------------------------------------------------------------------
        }

        // De-Initialization
        //--------------------------------------------------------------------------------------
        CloseWindow();
        //--------------------------------------------------------------------------------------

    }
}