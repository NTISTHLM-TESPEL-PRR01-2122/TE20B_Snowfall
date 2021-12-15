using System.Collections.Generic;
using Raylib_cs;

Raylib.InitWindow(800, 600, "SnowFall");
Raylib.SetTargetFPS(60);
Color skyBlue = new Color(135, 206, 235, 255);

List<Rectangle> snowflakes = new List<Rectangle>();

int s = 0;
while (s < 7)
{
  snowflakes.Add(new Rectangle(10 + s * 20, 10, 5, 5));
  s++;
}
while (!Raylib.WindowShouldClose())
{
  Raylib.BeginDrawing();
  Raylib.ClearBackground(skyBlue);
  int i = 0;
  while (i < 7)
  {
    Raylib.DrawRectangleRec(snowflakes[i], Color.WHITE);
    i++;
  }

  Raylib.EndDrawing();
}