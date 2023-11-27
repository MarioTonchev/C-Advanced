using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSnake.GameObjects
{
    public abstract class Food : Point
    {
        private char foodSymbol;
        private Random random;
        private Wall wall;
        protected Food(Wall wall, char foodSymbol, int foodPoints) : base(0, 0)
        {
            this.wall = wall;
            this.foodSymbol = foodSymbol;
            FoodPoints = foodPoints;
            random = new Random();
        }

        public int FoodPoints { get; private set; }

        public bool IsFoodPoint(Point snakeHead)
        {
            return LeftX == snakeHead.LeftX && TopY == snakeHead.TopY;
        }

        public void SetRandomPosition(Queue<Point> snake)
        {
            LeftX = random.Next(2, wall.LeftX - 2);
            TopY = random.Next(2, wall.TopY - 2);

            bool isPartOfSnake = snake.Any(x => x.TopY == this.TopY && x.LeftX == this.LeftX);

            while (isPartOfSnake)
            {
                LeftX = random.Next(2, wall.LeftX - 2);
                TopY = random.Next(2, wall.TopY - 2);

                isPartOfSnake = snake.Any(x => x.TopY == this.TopY && x.LeftX == this.LeftX);
            }

            Console.BackgroundColor = ConsoleColor.Red;
            this.Draw(foodSymbol);
            Console.BackgroundColor = ConsoleColor.White;
        }
    }
}
