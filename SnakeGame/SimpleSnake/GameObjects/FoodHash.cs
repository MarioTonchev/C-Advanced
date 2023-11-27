using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSnake.GameObjects
{
    public class FoodHash : Food
    {
        public FoodHash(Wall wall) : base(wall, '#', 3)
        {
        }
    }
}
