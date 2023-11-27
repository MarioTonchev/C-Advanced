using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSnake.GameObjects;

public class Point
{
    public Point(int leftx, int topy)
    {
        LeftX = leftx;
        TopY = topy;
    }

    public int LeftX { get; set; }
    public int TopY { get; set; }

    public void Draw(char symbol)
    {
        Console.SetCursorPosition(LeftX, TopY);
        Console.WriteLine(symbol);
    }

    public void Draw(int leftx, int topy, char symbol)
    {
        Console.SetCursorPosition(leftx, topy);
        Console.WriteLine(symbol);
    }
}
