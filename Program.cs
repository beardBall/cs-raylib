using Raylib_cs;
using System.Numerics;
namespace HelloWorld;

class Program
{
    public static void Main()

    {

	const int screenWidth = 800;
	const int screenHeight = 600;
	Vector2 pos = new(screenWidth/2, screenHeight/2);
	Vector2 direction = new(1,1);
	int radius = 10;
        Raylib.InitWindow(screenWidth, screenHeight, "Hello World");

        while (!Raylib.WindowShouldClose())
        {

		pos.X = pos.X + 1 * direction.X;
		pos.Y = pos.Y + 1 * direction.Y;
		
		if(pos.X>screenWidth){
			direction.X = -1;
			radius++;
		}
		
		if(pos.Y > screenHeight){
			direction.Y = -1;
			radius++;
		}

		if(pos.X < 0){
			direction.X = 1;
			radius++;
		}
		
		if(pos.Y < 0){
			direction.Y = 1;
			radius++;
		}




            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);

           
	Raylib.DrawText("Hello, world!", 12, 12, 20, Color.Black);
	Raylib.DrawText("Waqar", 20,20, 36, Color.Red);
	
	Raylib.DrawCircleV(pos, radius, Color.Maroon);

	Raylib.DrawCircleV(pos, 20, Color.White);
	Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}
