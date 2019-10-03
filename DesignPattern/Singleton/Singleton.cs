using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton
{
    class Singleton {
        private static Singleton _singleton;

        private Singleton() {

        }

        public static Singleton GetSingleton() {
            if (_singleton == null) {
                _singleton = new Singleton();;
            }

            return _singleton;
        }

        public void ShowMessage() {
            Console.WriteLine("Bonjour singleton");
        }

        public static void EraseSingleton() {
            _singleton = null;
        }
    }
}
