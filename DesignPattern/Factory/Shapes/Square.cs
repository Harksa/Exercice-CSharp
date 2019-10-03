using System;

namespace DesignPattern.Factory.Shapes
{
    class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("┌─┐\n│ │\n└─┘");
        }
    }
}
