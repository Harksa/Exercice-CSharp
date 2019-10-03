using System;
using DesignPattern.Factory;
using ExercicesBase;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args) {

            Exercices exercices = new Exercices();

            int userInput = -1;

            while (userInput != 0) {
                userInput = Utilities.GetUserIntInput("Selectionnez un exercice : ");

                if (userInput > 0 && userInput < exercices.GetExerciceListSize()) {
                    exercices.DisplayExercice(userInput);
                }
            }
        }
    }
}
