using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicesBase.Models
{
    class Exercice {
        private delegate void VoidDelegate();

        private delegate void DoubleDelegate(double d1, double d2);

        public void Execute() {
            VoidDelegate voidDelegate = new VoidDelegate(Welcome);
            DoubleDelegate doubleDelegate = new DoubleDelegate(Add);

            voidDelegate();
            doubleDelegate(5, 10);
        }

        public static void DoSomething(string s, Action<string> action) {
            action(s);
        }

        [Obsolete("Use Execute method instead")]
        public void OldExecute() {
            Console.WriteLine("Old execute");
        }

        private static void Welcome() {
            Console.WriteLine("Welcome");
        }

        private static void Add(double d1, double d2) {
            Console.WriteLine($"Somme : {d1 + d2}");
        }
    }
}
