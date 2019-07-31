using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicesBase
{
    public static class Utilities
    {
        public static string GetUserStringInput(string text = "Rentrez un texte : ") {
            Console.Write(text);
            return Console.ReadLine();
        }

        public static int GetUserIntInput(string text = "Rentrez un nombre : ") {
            if (int.TryParse(GetUserStringInput(text), out int temp)) {
                return temp;
            }

            return 0;
        }

        public static char GetUserCharInput() {
            return Console.ReadKey().KeyChar;
        }
    }
}
