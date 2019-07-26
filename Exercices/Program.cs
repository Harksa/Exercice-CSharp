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
            ExerciceManager exerciceManager = new ExerciceManager();

            int userInput = -1;

            while (userInput != 0) {
                userInput = Utilities.GetUserIntInput("Selectionnez un exercice : ");

                if (userInput > 0 && userInput < exerciceManager.GetExerciceListSize()) {
                    exerciceManager.DisplayExercice(userInput);
                } else if (userInput == -1) {
                    Morpion morpion = new Morpion();
                    morpion.Game();
                }
            }

            exerciceManager.Clear();

            Console.WriteLine("Fin du programme");
        }
    }
}
