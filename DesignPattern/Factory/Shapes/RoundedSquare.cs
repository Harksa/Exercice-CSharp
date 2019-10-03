using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory.Shapes
{
    class RoundedSquare : IShape
    {
        public void Draw() {
            Console.WriteLine("*─*\n│ │\n*─*");
        }
    }
}
