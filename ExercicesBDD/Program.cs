using System;
using System.Linq;
using ExercicesBase;
using ExercicesBDD.Models;

namespace ExercicesBDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercices exercices = new Exercices();

            int userInput = -1;

            while (userInput != 0) {
                userInput = Utilities.GetUserIntInput("Selectionnez un exercice : ");

                if (userInput > 0 && userInput < exercices.GetExerciceListSize()) {
                    exercices.DisplayExercice(userInput);
                }
            }

            Console.WriteLine("Fin du programme");
        }
    }
}
