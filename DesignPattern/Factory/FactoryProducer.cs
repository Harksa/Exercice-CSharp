using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory
{
    class FactoryProducer
    {
        public static AbstractFactory GetFactory(bool rounded) {
            if (rounded) {
                return new RoundedShapeFactory();;
            } else {
                return new ShapeFactory();
            }
        }
    }
}
