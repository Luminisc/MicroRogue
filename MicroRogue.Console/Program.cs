using System;
using MicroRogue.Core;

namespace MicroRogue.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.CursorVisible = false;
            System.Console.BufferWidth = System.Console.WindowWidth = 200;
            System.Console.BufferHeight = System.Console.WindowHeight = Math.Min(System.Console.LargestWindowHeight, 100);

            StartGame();
        }

        static void StartGame()
        {
            var game = new Game();
            game.LoadDemo();

            while (true)
            {
                DrawGame(game);
                var key = System.Console.ReadKey(true).Key;
                if (key == ConsoleKey.Escape)
                    return;

                game.ProcessKey(InputMapper.ToVirtualKey(key));
            }
        }

        private static void DrawGame(Game game)
        {
            // System.Console.Clear();
            ClearRectangle(1, 1, game.CurrentScene.Width, game.CurrentScene.Height);
            DrawScene(game.CurrentScene);
            DrawUnits(game);
        }

        private static void DrawScene(Scene scene)
        {
            DrawSceneBorders(scene);
        }

        private static void DrawSceneBorders(Scene scene)
        {
            System.Console.SetCursorPosition(0, 0);
            System.Console.Write(new string('*', scene.Width + 2));
            System.Console.SetCursorPosition(0, scene.Height + 1);
            System.Console.Write(new string('*', scene.Width + 2));

            for (int i = 0; i < scene.Height; i++)
            {
                System.Console.SetCursorPosition(0, i + 1);
                System.Console.Write("*");
                System.Console.SetCursorPosition(scene.Width + 1, i + 1);
                System.Console.Write("*");
            }
        }

        private static void DrawUnits(Game game)
        {
            foreach (var unit in game.Units)
            {
                DrawUnit(unit);
            }
            DrawUnit(game.PlayerUnit);
        }

        private static void DrawUnit(Unit unit)
        {
            System.Console.SetCursorPosition(unit.X + 1, unit.Y + 1);
            System.Console.Write(unit.Icon);
        }

        private static void ClearRectangle(int x, int y, int width, int height)
        {
            for (var i = 0; i < height; i++)
            {
                System.Console.SetCursorPosition(x, y + i);
                System.Console.Write(new string(' ', width));
            }
        }
    }
}