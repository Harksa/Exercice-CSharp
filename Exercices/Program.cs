using System;
using System.Collections.Generic;
using ExercicesBase.Interfaces;
using ExercicesBase.Models;

namespace ExercicesBase
{
    class Program
    {
        static void Main(string[] args)
        {
            ExercicesBasiques exercicesBasiques = new ExercicesBasiques();
            ExercicesAvances exercicesAvances = new ExercicesAvances();

            int userInput = -1;

            while (userInput != 0) {
                userInput = Utilities.GetUserIntInput("Selectionnez un exercice : ");

                if (userInput > 0 && userInput < exercicesBasiques.GetExerciceListSize()) {
                    exercicesBasiques.DisplayExercice(userInput);
                } else if (userInput == -1) {
                    Morpion morpion = new Morpion();
                    morpion.Game();
                } else if (userInput == -2) {
                    userInput = Utilities.GetUserIntInput("Selectionnez un exercice avancé : ");
                    if (userInput > 0 && userInput < exercicesAvances.GetExerciceListSize()) {
                        exercicesAvances.DisplayExercice(userInput);
                    }
                }
            }

            Console.WriteLine("Fin du programme");
        }
    }
}
