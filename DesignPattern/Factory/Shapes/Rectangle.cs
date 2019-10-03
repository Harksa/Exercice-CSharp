using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory.Shapes
{
    class Rectangle : IShape
    {
        public void Draw() {
            Console.WriteLine("┌───┐\n│   │\n└───┘");
        }
    }
}
