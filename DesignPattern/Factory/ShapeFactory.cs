using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Factory.Shapes;

namespace DesignPattern.Factory
{
    class ShapeFactory : AbstractFactory
    {
        public override IShape GetShape(string shapeType) {
            if (shapeType.Equals("RECTANGLE")) {
                return new Rectangle();
            } else if (shapeType.Equals("SQUARE")) {
                return new Square();
            }

            return null;
        }
    }
}
