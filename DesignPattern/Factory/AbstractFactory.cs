using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Factory.Shapes;

namespace DesignPattern.Factory
{
    abstract class AbstractFactory {
        public abstract IShape GetShape(string shapeType);
    }
}
