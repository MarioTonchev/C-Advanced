namespace SimpleSnake
{
    using System;
    using SimpleSnake.Core;
    using SimpleSnake.GameObjects;
    using Utilities;

    public class StartUp
    {
        public static void Main()
        {
            ConsoleWindow.CustomizeConsole();

            Wall wall = new(50, 20);
            Snake snake = new(wall);

            Engine engine = new(wall);
            engine.Run();
        }
    }
}
