using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExercicesBase;

namespace ExercicesBDD
{
    class Exercices
    {
        private readonly List<Action> _exercices = new List<Action>();

        public Exercices() {
            Init();
        }

        ~Exercices() {
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
        /// Afficher tous les clients
        /// </summary>
        private static void Exercice1() {
            LocationsContext context = new LocationsContext();
            foreach (var client in context.Clients) {
                Console.WriteLine($"{client.Nom} {client.Prenom} - {client.DateNaissance}");
            }
        }

        /// <summary>
        /// Le nom et l’âge de tous les clients
        /// </summary>
        private static void Exercice2() {
            LocationsContext context = new LocationsContext();
            var clients = context.Clients.Select(c => new {c.Nom, Age =  DateTime.Now.Year - c.DateNaissance.Year});

            foreach (var client in clients) {
                Console.WriteLine($"{client.Nom} : {client.Age} ans");
            }
        }

        /// <summary>
        /// Le nombre de client par ville
        /// </summary>
        private static void Exercice3() {
            LocationsContext context = new LocationsContext();
            var clients = context.Clients.GroupBy(c => c.Ville).Select(group => new {Ville = group.Key, Total = group.Count()}).OrderBy(group => group.Ville);

            foreach (var client in clients) {
                Console.WriteLine($"{client.Ville} : {client.Total}");
            }
        }

        /// <summary>
        /// Les 10 premiers clients dont le nom commence par 'A'
        /// </summary>
        private static void Exercice4() {
            LocationsContext context = new LocationsContext();
            var clients = context.Clients.Where(c => c.Ville.StartsWith("A")).Take(10);

            foreach (var client in clients) {
                Console.WriteLine($"{client.Nom} {client.Prenom}");
            }
        }

        /// <summary>
        /// La liste des villes (distincte)
        /// </summary>
        private static void Exercice5() {
            LocationsContext context = new LocationsContext();
            var villes = context.Clients.Select(c => c.Ville).Distinct();

            foreach (var ville in villes) {
                Console.WriteLine(ville);
            }
        }
    }
}
