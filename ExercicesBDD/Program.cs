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
                } else if (userInput == -1) {
                    string crud = Utilities.GetUserStringInput("CRUD Client, sélection : ");
                    switch(crud)
                    {
                        case "C":
                            break;
                        case "R":
                            break;
                        case "U":
                            break;
                        case "D":
                            break;
                        default:
                            break;
                    }
                }
            }

            Console.WriteLine("Fin du programme");
        }
    }
}
