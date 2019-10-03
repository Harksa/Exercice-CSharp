using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Factory.Shapes;

namespace DesignPattern.Factory
{
    class RoundedShapeFactory : AbstractFactory
    {
        public override IShape GetShape(string shapeType) {
            if (shapeType.Equals("RECTANGLE")) {
                return new RoundedRectangle();
            } else if (shapeType.Equals("SQUARE")) {
                return new RoundedSquare();
            }

            return null;
        }
    }
}
