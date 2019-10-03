using System;
using System.Collections.Generic;
using DesignPattern.Factory;
using DesignPattern.Factory.Shapes;
using DesignPattern.Singleton;

namespace DesignPattern {
    public class Exercices {

        private readonly List<Action> _exercices = new List<Action>();

        public Exercices() {
            Init();
        }

        private void Init() {
            _exercices.Add(Factory);
            _exercices.Add(SingletonExercice);
        }

        public int GetExerciceListSize() {
            return _exercices.Count + 1;
        }

        public void DisplayExercice(int i) {
            _exercices[i -1].Invoke();
        }

        private void Factory() {
            AbstractFactory factory = FactoryProducer.GetFactory(false);

            IShape shape1 = factory.GetShape("RECTANGLE");
            shape1.Draw();

            IShape shape2 = factory.GetShape("SQUARE");
            shape2.Draw();
            
            AbstractFactory roundedFactory = FactoryProducer.GetFactory(true);

            IShape shape3 = roundedFactory.GetShape("RECTANGLE");
            shape3.Draw();

            IShape shape4 = roundedFactory.GetShape("SQUARE");
            shape4.Draw();
        }

        private void SingletonExercice() {
            Singleton.Singleton.GetSingleton().ShowMessage();
            Singleton.Singleton.EraseSingleton();
        }
    }
}