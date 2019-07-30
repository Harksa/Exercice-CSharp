using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ExercicesBase.Models
{
    class ExercicesAvances
    {
        private readonly List<Action> _exercices = new List<Action>();

        public ExercicesAvances() {
            Init();
        }

        ~ExercicesAvances() {
            Clear();
        }

        private void Init() {
            _exercices.Add(Exercice1);
            _exercices.Add(Exercice2);
            _exercices.Add(Exercice3);
            _exercices.Add(Exercice4);
            _exercices.Add(Exercice5);
            _exercices.Add(Exercice6);
        }

        private void Clear() {
            _exercices.Clear();
        }

        public int GetExerciceListSize() {
            return _exercices.Count + 1;
        }

        public void DisplayExercice(int i) {
            _exercices[i -1].Invoke();
        }

        /// <summary>
        /// énéricité
        /// a. Créer une nouvelle classe « MyPair » qui a deux types génériques T et U.
        /// b. Cette classe a deux propriétés génériques First et Second et un constructeur
        /// générique.
        /// c. Ecrire la méthode ToString pour avoir le résultat suivant : « Value 1 : First – Value 2 :
        /// Second »
        /// d. Créer une instance de MyPair &lt;String, int&gt; et l’afficher
        /// </summary>
        private void Exercice1() {
            MyPair<string, int> pair = new MyPair<string, int>("Bonjour", 50);
            Console.WriteLine(pair);
        }

        /// <summary>
        /// a. Créer une nouvelle classe « Exercice ».
        /// b. Créer deux delegates, un retournant void et un autre avec deux paramètres de type
        /// double.
        /// c. Créer une méthode statique « Welcome » qui affiche un texte sur la console et une
        /// autre « Add » qui prend deux doubles paramètres et affiche leur somme.
        /// d. Utilisez les delegates pour exécuter les 2 méthodes
        /// </summary>
        private void Exercice2() {
            Exercice exercice = new Exercice();
            exercice.Execute();
        }

        /// <summary>
        /// Créez une méthode DoSomething qui a un paramètre callback (Action) qui est une
        /// fonction avec 1 paramètre de type string. Appelez la méthode DoSomething avec
        /// l’implémentation du callback avec un writeLine à l’intérieur
        /// </summary>
        private void Exercice3() {
            Exercice.DoSomething("Bonjour", s => { Console.WriteLine(s); });
        }

        /// <summary>
        /// Tester l’attribut :
        /// [System.Obsolete("use NewMethod", true)]
        /// </summary>
        private void Exercice4() {
            Exercice exercice = new Exercice();
            exercice.OldExecute();
        }

        /// <summary>
        /// Tester les exemples du cours
        /// </summary>
        private void Exercice5() {
            Tasks tasks = new Tasks();
            tasks.SimpleTasks();
        }

        /// <summary>
        /// Sérialiser et désérialiser une liste de personnes dans un fichier
        /// </summary>
        private void Exercice6() {
            List<Personne> personnes = new List<Personne> {
                new Personne("N1", "P1"),
                new Personne("N2", "P2"),
            };

            using (var stream = new FileStream("log.xml", FileMode.OpenOrCreate, FileAccess.Write)) {
                var xmlSerializer = new XmlSerializer(typeof(List<Personne>));
                xmlSerializer.Serialize(stream, personnes);
            }

            using (var stream = new FileStream("log.xml", FileMode.Open, FileAccess.Read)) {
                var xmlSerializer = new XmlSerializer(typeof(List<Personne>));

                if (xmlSerializer.Deserialize(stream) is List<Personne> readPersonnes) {
                    foreach (var personne in readPersonnes) {
                        Console.WriteLine(personne);
                    }
                }
            }
        }

    }
}
