using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExercicesBase.Extensions;
using ExercicesBase.Interfaces;

namespace ExercicesBase.Models
{
    class ExercicesBasiques
    {
        private readonly List<Action> _exercices = new List<Action>();

        public ExercicesBasiques() {
            Init();
        }

        ~ExercicesBasiques() {
            Clear();
        }

        private void Init() 
        {
            _exercices.Add(Exercice1);
            _exercices.Add(Exercice2);
            _exercices.Add(Exercice3);
            _exercices.Add(Exercice4);
            _exercices.Add(Exercice5);
            _exercices.Add(Exercice6);
            _exercices.Add(Exercice7);
            _exercices.Add(Exercice8);
            _exercices.Add(Exercice9);
            _exercices.Add(Exercice10);
            _exercices.Add(Exercice11);
            _exercices.Add(Exercice12);
            _exercices.Add(Exercice13);
            _exercices.Add(Exercice14);
            _exercices.Add(Exercice15);
            _exercices.Add(Exercice16);
            _exercices.Add(Exercice17);
            _exercices.Add(Exercice18);
            _exercices.Add(Exercice19);
            _exercices.Add(Exercice20);
            _exercices.Add(Exercice21);
            _exercices.Add(Exercice22);
            _exercices.Add(Exercice23);
            _exercices.Add(Exercice24);
            _exercices.Add(Exercice25);
            _exercices.Add(Exercice26);
            _exercices.Add(Exercice27);
            _exercices.Add(Exercice28);
            _exercices.Add(Exercice29);
            _exercices.Add(Exercice30);
            _exercices.Add(Exercice31A35);
            _exercices.Add(Exercice36); //Numéro 32
            _exercices.Add(ExerciceTableau1);
            _exercices.Add(ExerciceTableau2);
            _exercices.Add(ExerciceTableau4);
            _exercices.Add(ExerciceTableau5);
            _exercices.Add(ExerciceTableau6);
            _exercices.Add(ExerciceTableau7);
            _exercices.Add(ExerciceLinq1); // 39
            _exercices.Add(ExerciceLinq2);
            _exercices.Add(ExerciceLinq3);
            _exercices.Add(ExerciceLinq4);
            _exercices.Add(ExerciceLinq5); //43
            _exercices.Add(ExerciceLinq6);
            _exercices.Add(ExerciceLinq7);
            _exercices.Add(ExerciceLinq8);
            _exercices.Add(ExerciceLinq9);
            _exercices.Add(ExerciceLinq10);
            _exercices.Add(ExerciceLinq11);
            _exercices.Add(ExerciceLinq12);
            _exercices.Add(ExerciceLinq13);
            _exercices.Add(ExerciceException1); // 52
            _exercices.Add(ExerciceException2); // 52
        }

        public void Clear() {
            _exercices.Clear();
        }

        public int GetExerciceListSize() {
            return _exercices.Count + 1;
        }

        public void DisplayExercice(int i) {
            _exercices[i-1].Invoke();
        }

        #region EXERCICES

        /// <summary>
        /// Affichez « Hello » et « World » sur 2 lignes séparés
        /// </summary>
        private static void Exercice1() {
            Console.WriteLine("Hello\nWorld");
        }

        /// <summary>
        /// Créez 2 fonctions dans votre classe, une pour récupérer l’entrée utilisateur en chaine de
        /// caractère et l’autre pour récupérer un entier. Utilisez ces méthodes dans les prochains
        /// exercices
        /// </summary>
        public static void Exercice2() {
            Console.WriteLine(Utilities.GetUserStringInput("Entrez un texte : "));
            Console.WriteLine(Utilities.GetUserIntInput("Entrez un chiffre : "));
        }

        /// <summary>
        /// Faites rentrez 3 mots à l’utilisateur et afficher les dans l’ordre inverse de la saisie
        /// </summary>
        private static void Exercice3() {
            List<string> list = new List<string>();

            for (int i = 0; i < 3; ++i) 
            {
                list.Add(Utilities.GetUserStringInput());
            }

            for (int i = 2; i >= 0; --i) 
            {
                Console.WriteLine(list[i]);
            }
        }

        /// <summary>
        /// Affichez si les 2 nombres rentré par l’utilisateur sont égaux
        /// </summary>
        private static void Exercice4() {
            int number1 = Utilities.GetUserIntInput("Veuillez rentrer un premier chiffre : ");
            int number2 = Utilities.GetUserIntInput("Veuillez rentrer un second chiffre : ");

            Console.WriteLine(number1 == number2  ? "Les deux chiffres sont égaux"  : "Les deux chiffres sont différents");
        }

        /// <summary>
        /// Créez 2 nombre, les afficher, les intervertir et les réafficher
        /// </summary>
        private static void Exercice5() {
            int number1 = Utilities.GetUserIntInput("Veuillez rentrer un premier chiffre : ");
            int number2 = Utilities.GetUserIntInput("Veuillez rentrer un second chiffre : ");

            Console.WriteLine($"Affichage des deux nombres avant qu'ils soient intervertis : {number1} et {number2}");

            int tmp = number1;
            number1 = number2;
            number2 = tmp;

            Console.WriteLine($"Affichage des nombres après : {number1} et {number2}");
        }

        /// <summary>
        /// Affichez le résultat de l’ajout, la soustraction, la multiplication et la division de 2 nombres
        /// rentrés par l’utilisateur
        /// </summary>
        private static void Exercice6() {
            int number1 = Utilities.GetUserIntInput("Veuillez rentrer un premier chiffre : ");
            int number2 = Utilities.GetUserIntInput("Veuillez rentrer un second chiffre : ");

            Console.WriteLine($"Addition : {number1 + number2}");
            Console.WriteLine($"Soustraction : {number1 - number2}");
            Console.WriteLine($"Multiplication : {number1 * number2}");
            Console.WriteLine($"Division : {number1 / number2} avec reste {number1 % number2}");
        }

        /// <summary>
        /// Affichez la moyenne de 4 nombres rentrés par l’utilisateur
        /// </summary>
        private static void Exercice7() {
            float moyenne = 0;
            for (int i = 0; i < 4; ++i) {
                moyenne += Utilities.GetUserIntInput($"Rentrez le nombre n°{i +1} : ");
            }

            Console.WriteLine($"Résultat de la moyenne : {moyenne / 4}");
        }

        /// <summary>
        /// Affichez le nombre le plus grand de 4 nombres rentrés par l’utilisateur
        /// </summary>
        private static void Exercice8() {
            int plusGrandNombre = 0;

            for (int i = 0; i < 4; ++i) 
            {
                int tmp = Utilities.GetUserIntInput($"Rentrez le nombre n°{i +1} : ");
                if (plusGrandNombre < tmp) 
                {
                    plusGrandNombre = tmp;
                }
            }

            Console.WriteLine($"Nombre le plus grand : {plusGrandNombre}");
        }

        /// <summary>
        /// Savoir si le nombre rentré est négatif ou positif
        /// </summary>
        private static void Exercice9() {
            int tmp = Utilities.GetUserIntInput();

            if (tmp == 0) Console.WriteLine("Nombre égal à 0");
            else if (tmp < 0) Console.WriteLine("Nombre négatif");
            else Console.WriteLine("Nombre positif");
        }

        /// <summary>
        /// Savoir si le nombre rentré est négatif ou positif
        /// </summary>
        private static void Exercice10() {
            Console.WriteLine(Utilities.GetUserIntInput() % 2 == 0 ? "Nombre pair" : "Nombre impair");
        }

        /// <summary>
        /// Rentrez un nombre en Celsius et le convertir en Kelvin et Fahrenheit
        /// </summary>
        private static void Exercice11() {
            float degrees = Utilities.GetUserIntInput("Rentrez un nombre en degré Celsius : ");

            Console.WriteLine($"Degré en Kelvin : {degrees.ToKelvin()}");
            Console.WriteLine($"Degré en Fahreinheit : {degrees.ToFahrenheit()}");
        }

        /// <summary>
        /// Rentrez un chiffre et dire de quel jour il s’agit sous forme de texte
        /// </summary>
        private static void Exercice12() {
            int day = Utilities.GetUserIntInput("Rentrez un nombre entre 1 et 7 : ");

            List<string> daysList = new List<string> {"Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche"};

            if (day > 0 && day < daysList.Count) 
            {
                Console.WriteLine($"Le jour est {daysList[day-1]}");
            } else 
            {
                Console.WriteLine("Nombre invalide");
            }
        }

        /// <summary>
        /// Bloquez un utilisateur après avoir rentré 3 faux password
        /// </summary>
        private static void Exercice13() {
            int tentatives = 0;
            while (tentatives != 3) 
            {
                Utilities.GetUserStringInput("Rentrez le mot de passe : "); //Pas besoin de sauver l'input
                Console.WriteLine("Mauvais mdp");
                tentatives++;
            }

            Console.WriteLine("La police arrive");
        }

        /// <summary>
        /// Rentrez un nombre, puis un signe (+ - * /), puis un autre nombre, affichez ensuite le résultat
        /// </summary>
        private static void Exercice14() {
            int number1 = Utilities.GetUserIntInput("Rentrez un chiffre : ");
            Console.Write("Rentrez un caractère : ");
            char operation = Utilities.GetUserCharInput();
            Console.WriteLine();
            int number2 = Utilities.GetUserIntInput("Rentrez un second chiffre : ");

            switch (operation) 
            {
                case '+':
                    Console.WriteLine($"Addition : {number1 + number2}");
                    break;
                case '-':
                    Console.WriteLine($"Soustraction : {number1 - number2}");
                    break;
                case '*':
                    Console.WriteLine($"Multiplication : {number1 * number2}");
                    break;
                case '/':
                    Console.WriteLine($"Division : {number1 / number2} avec reste {number1 % number2}");
                    break;
                default:
                    Console.WriteLine("Mauvais opérateur rentré");
                    break;
            }
        }

        /// <summary>
        /// Afficher les 10 premiers chiffres à partir de 0 (avec une boucle for)
        /// </summary>
        private static void Exercice15() {
            for (int i = 0; i < 11 ; ++i) {
                Console.WriteLine($"{i} ");
            }
        }

        /// <summary>
        /// Donnez la table de multiplication des 10 premiers chiffres
        /// </summary>
        private static void Exercice16() {
            for (int i = 0; i < 11; ++i) 
            {
                for (int j = 0; j < 11; ++j) 
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Rentrez une lettre et une taille et l’afficher sous forme de triangle
        /// </summary>
        private static void Exercice17() {
            Console.Write("Rentrez une lettre : ");
            char l = Utilities.GetUserCharInput();
            Console.WriteLine();
            int taille = Utilities.GetUserIntInput();

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < taille; ++i) 
            {
                stringBuilder.Append(l, i);
                stringBuilder.Append("\n");
            }
            Console.WriteLine(stringBuilder);
        }

        /// <summary>
        /// Faire une pyramide d’une hauteur donnée
        /// </summary>
        private static void Exercice18() {
            Console.Write("Rentrez un nombre : ");
            int taille = Utilities.GetUserIntInput();

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < taille; ++i) 
            {
                stringBuilder.Append(' ', taille - i);
                stringBuilder.Append('o', i * 2 + 1);
                stringBuilder.Append(' ', taille - i);
                stringBuilder.Append("\n");
            }
            Console.WriteLine(stringBuilder);
        }

        /// <summary>
        /// Faire un diamant d’une hauteur donnée
        /// </summary>
        private static void Exercice19() {
            Console.Write("Rentrez un nombre : ");
            int taille = Utilities.GetUserIntInput();

            if (taille % 2 == 0) {
                taille++;
            }

            int moitié = (taille-1) / 2;
                
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i <= moitié; ++i) 
            {
                stringBuilder.Append(' ', moitié - i);
                stringBuilder.Append('o', i * 2  + 1);
                stringBuilder.Append(' ', moitié - i);
                stringBuilder.Append("\n");
            }
            
            int loop = 1;
            for(int i = taille - moitié + 1; i <= taille; ++i)
            {
                stringBuilder.Append(' ', loop);
                stringBuilder.Append('o', (taille - i) * 2  + 1);
                stringBuilder.Append(' ', loop);
                stringBuilder.Append("\n");
                loop++;
            }

            Console.WriteLine(stringBuilder);
        }

        /// <summary>
        ///  Créez la date d’aujourd’hui et affichez-la de façon complète puis de façon jour/mois/année)
        /// </summary>
        private static void Exercice20() {
            DateTime now = DateTime.Now;;
            Console.WriteLine(now);
            Console.WriteLine($"Jour : {now.Day}, Mois : {now.Month}, Année : {now.Year}");
        }

        /// <summary>
        /// . Créer une date avec l’utilisateur qui rentre l’année, mois, jour, heure, minute et seconde et
        /// afficher le jour (Lundi, mardi…) | en français ou en anglais
        /// </summary>
        private static void Exercice21() {
            int annee = Utilities.GetUserIntInput("Entrez une année : ");
            int mois  = Utilities.GetUserIntInput("Entrez un mois : ");
            int jour  = Utilities.GetUserIntInput("Entrez un jour : ");

            int heure    = Utilities.GetUserIntInput("Entrez une heure : ");
            int minute   = Utilities.GetUserIntInput("Entrez une minute : ");
            int secondes = Utilities.GetUserIntInput("Entrez une seconde : ");

            DateTime time = new DateTime(annee, mois, jour);

            Console.WriteLine($"Jour rentrée : {time.DayOfWeek}");
        }

        /// <summary>
        /// Affichez la différence de temps entre 2 dates
        /// </summary>
        private static void Exercice22() {
            DateTime now = DateTime.Now;
            DateTime naissance = new DateTime(1992, 08, 02);

            var time = now.Subtract(naissance);

            Console.WriteLine($"Temps depuis mon anniversaire : {time.Days / 365} ans, {12 - ((time.Days / 365) % 12)} mois et {31 - (time.Days / 365 % 31)} jours");
        }
        
        /// <summary>
        /// Convertir une chaine de caractère en date
        /// </summary>
        private static void Exercice23() {
            string date = Utilities.GetUserStringInput("Entrez une date valide : ");

            if (DateTime.TryParse(date, out DateTime time)) {
                Console.WriteLine($"Date valide : {date}");
            } else {
                Console.WriteLine("Date invalide");
            }
        }

        /// <summary>
        /// Jeu du plus ou moins (un nombre est définit par défaut, puis l’utilisateur rentre un chiffre et
        /// le programme lui dit si le bon nombre est + ou – que celui définit jusqu’à que l’utilisateur trouve)
        /// </summary>
        private static void Exercice24() {
            int nombreADeviner = new Random().Next(1,101);
            int nombreUtilisateur = 0;

            int tentative = 0;
            while (nombreADeviner != nombreUtilisateur) {
                nombreUtilisateur = Utilities.GetUserIntInput("Entrez un nombre à deviner : ");

                if (nombreUtilisateur > nombreADeviner) {
                    Console.WriteLine("Le nombre à deviner est plus petit");
                } else if (nombreUtilisateur < nombreADeviner) {
                    Console.WriteLine("Le nombre à deviner est plus grand");
                }

                tentative++;
            }

            Console.WriteLine($"Le nombre à deviner était bien {nombreADeviner}. Réussi en {tentative} tentatives.");
        }

        /// <summary>
        /// Affichez une chaine donnée en majuscule
        /// </summary>
        private static void Exercice25() {
            Console.WriteLine(Utilities.GetUserStringInput().ToUpperInvariant());
        }

        /// <summary>
        /// Affichez le nombre de caractère d’une chaine sans utiliser la propriété Lenght
        /// </summary>
        private static void Exercice26() {
            string s = Utilities.GetUserStringInput();

            int count = 0;
            foreach (char c in s) {
                count++;
            }

            Console.WriteLine($"Nombre de charactères : {count}");
        }

        /// <summary>
        /// Affichez un espace entre toute les lettres d’une chaine de caractère donnée en inversant les
        /// lettres
        /// </summary>
        private static void Exercice27() {
            string s = Utilities.GetUserStringInput();

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; --i) {
                stringBuilder.Append($"{s[i]} ");
            }

            Console.WriteLine(stringBuilder);
        }

        /// <summary>
        /// Dire si une chaine est égale à une autre sans prendre en compte la casse
        /// </summary>
        private static void Exercice28() {
            string s1 = Utilities.GetUserStringInput("Rentrez un premier texte : ").ToLowerInvariant();
            string s2 = Utilities.GetUserStringInput("Rentrez un second texte : ").ToLowerInvariant();

            Console.WriteLine(s1.Equals(s2) ? "Les chaines sont égales" : "Les chaines ne sont pas égales");
        }

        /// <summary>
        /// Savoir si la chaine donnée est un palindrome (mot qui se lit dans les deux sens : SOS)
        /// </summary>
        private static void Exercice29() {
            string s = Utilities.GetUserStringInput();

            for (int i = 0; i < s.Length / 2; ++i) {
                if (s[i] == s[s.Length - 1 - i]) continue;
                Console.WriteLine("Le mot n'est pas un palindrome");
                return;
            }

            Console.WriteLine("Le mot est un palindrome");

        }
        /// <summary>
        /// Lister les nombres de 1 à 100, en remplaçant le nombre par un mot selon certaines
        /// conditions
        /// a. Le mot Fizz s'il est multiple de 3
        /// b. Le mot Buzz s'il est multiple de 5
        /// c. Le mot FizzBuzz s'il est multiple de 3 et de 5
        /// d. Un retour à la ligne tous les 9 éléments
        /// </summary>
        private static void Exercice30() {
            bool display;
            for (int i = 1; i < 101; ++i) {
                display = true;
                if (i % 3 == 0) {
                    Console.Write("Fizz");
                    display = false;
                }

                if (i % 5 == 0) {
                    Console.Write("Buzz");
                    display = false;
                }

                if (display) {
                    Console.Write($"{i}");
                }

                if (i % 9 == 0) {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }
        /// <summary>
        /// 31. Créez une classe Personne qui comporte trois propriétés, nom, prénom et date de naissance
        /// 32. Ecrivez une méthode qui inverse le prénom d’une personne
        /// 33. Créez une personne avec des valeurs rentrées par l’utilisateur, appelez la méthode crée
        /// précédemment et afficher la personne
        /// 34. Créez 1 Personne, l’affecter à une autre variable Personne, les afficher, appeler la méthode
        /// inverser prénom sur la première personne et les réafficher
        /// 35. Créez une propriété statique Test avec une valeur par défaut et l’afficher
        /// </summary>
        private static void Exercice31A35() {
            Personne personne1 = new Personne("Nom", "Prenom", DateTime.Now);
            Personne personne2 = personne1;

            Console.WriteLine($"Personne 1 : {personne1}\nPersonne 2 : {personne2}");
            personne1.InversePrenom();

            Console.WriteLine($"Personne 1 : {personne1}\nPersonne 2 : {personne2}");

            Console.WriteLine($"Variable static : {Personne.Test}");
        }

        /// <summary>
        ///   Ecrire les classes Personne et Employé.
        /// • Créez un programme de test qui comporte tableau de 4 personnes avec 2 personnes et deux
        /// employés.
        /// • Affichez l'ensemble des éléments du tableau à l'aide de foreach et de la méthode afficher.
        /// • Faire le même test avec un tableau de 4 ITravailleur
        /// </summary>
        private static void Exercice36() {
            List<Personne> personnes = new List<Personne> {
                new Personne("Nom1", "Prenom1", DateTime.Now),
                new Personne("Nom2", "Prenom2", DateTime.Now),
                new Employe("Nom3", "Prenom3", DateTime.Now, 5_000),
                new Employe("Nom3", "Prenom3", DateTime.Now, 10_000)
            };

            foreach (var personne in personnes) {
                personne.Afficher();
            }

            List<ITravailleur> travailleurs = new List<ITravailleur> {
                new Personne("Nom1", "Prenom1", DateTime.Now),
                new Personne("Nom2", "Prenom2", DateTime.Now),
                new Employe("Nom3", "Prenom3", DateTime.Now, 5_000),
                new Employe("Nom3", "Prenom3", DateTime.Now, 10_000)
            };

            foreach (var travailleur in travailleurs) {
                travailleur.Afficher();
            }
        }

        /// <summary>
        /// Créez un tableau d’entier, trier le tableau et afficher tous les nombres dans l’ordre
        /// </summary>
        private static void ExerciceTableau1() {
            List<int> ints = new List<int>{5,12,8,88,13,14,7,9};
            ints.Sort();
            foreach (var i in ints) {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Affichez une liste de string par ordre alphabétique
        /// </summary>
        private static void ExerciceTableau2() {
            List<string> stringList = new List<string>{"Bonjour", "Test", "Youpi", "Super", "Banane"};
            stringList.Sort();
            foreach (var s in stringList) {
                Console.Write($"{s} ");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Afficher un dictionnaire de personne avec un entier Id en clé
        /// </summary>
        private static void ExerciceTableau4() {
            Dictionary<int, Personne> personnes = new Dictionary<int, Personne> {
                {0, new Personne("Nom", "Prenom", DateTime.Today)},
                {1, new Personne("Nom1", "Prenom1", DateTime.Today)},
                {2, new Personne("Nom2", "Prenom2", DateTime.Today)},
            };

            foreach (var personne in personnes) {
                Console.WriteLine($"index : {personne.Key}, Personne : {personne.Value}");
            }
        }

        /// <summary>
        /// Tester le Contains avec le Equals et IEquatable
        /// </summary>
        private static void ExerciceTableau5() {
            List<Personne> personnes = new List<Personne> {
                new Personne("Xavier", "H", DateTime.Today)
            };

            Personne p = new Personne("Xavier", "H", DateTime.Today);

            Console.WriteLine(personnes.Contains(p) ? "Contenue" : "Non contenue");
        }

        /// <summary>
        /// Trié la liste de personne avec IComparable puis IComparer sur le nom puis le prénom
        /// </summary>
        private static void ExerciceTableau6() {
            List<Personne> personnes = new List<Personne> {
                new Personne("C", "A", DateTime.Today),
                new Personne("B", "B", DateTime.Today),
                new Personne("A", "A", DateTime.Today),
                new Personne("A", "B", DateTime.Today),
                new Personne("D", "A", DateTime.Today),
            };

            personnes.Sort();

            foreach (var personne in personnes) {
                Console.WriteLine(personne);
            }

            personnes.Sort(new ComparaisonOrdreDescendant());

            Console.WriteLine("Sens inverse : ");
            foreach (var personne in personnes) {
                Console.WriteLine(personne);
            }
        }

        /// <summary>
        /// Bonus : tester les Stacks et Queue
        /// </summary>
        private static void ExerciceTableau7() {
            Stack<string> stack = new Stack<string>();
            stack.Push("Bonjour");
            stack.Push("Autre bonjour");
            stack.Push("Super bonjour");

            while (stack.Count != 0) {
                Console.WriteLine(stack.Pop());
            }

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Bonjour");
            queue.Enqueue("Autre bonjour");
            queue.Enqueue("Super Bonjour");

            while (queue.Count != 0) {
                Console.WriteLine(queue.Dequeue());
            }
        }

        private static readonly List<int> ints = new List<int> {1, 4, 10, 49, 18, 55, 999, 100, 2, -1, -70};

        /// <summary>
        /// Afficher la somme
        /// </summary>
        private static void ExerciceLinq1() {
            Console.WriteLine($"Somme des entiers : {ints.Sum()}");
        }

        /// <summary>
        /// Afficher la moyenne
        /// </summary>
        private static void ExerciceLinq2() {
            Console.WriteLine($"Moyenne des entiers : {ints.Average()}");
        }

        /// <summary>
        /// Sélectionner que les nombres qui sont > 6
        /// </summary>
        private static void ExerciceLinq3() {
            List<int> superierA6 = ints.Where(i => i > 6).ToList();

            Console.Write("Affichage des éléments supérieurs à 6 : ");
            foreach (var i in superierA6) {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Compter le nombre d’élément
        /// </summary>
        private static void ExerciceLinq4() {
            Console.WriteLine($"Nombre d'élements : {ints.Count}");
        }

        private static readonly List<Personne> listPersonnes = new List<Personne> {
            new Personne("David", "Jean"),
            new Personne("David", "Raoul"),
            new Personne("Opazer", "Didier"),
            new Personne("Aports", "Louis"),
            new Personne("Loapze", "Kévin"),
            new Personne("Porteraa", "Xavier"),
            new Personne("Porteraa", "Azazel"),
            new Personne("Atenea", "Fabien"),
            new Personne("Jusiat", "Fabien"),
            new Personne("Doaezr", "Paul"),
            new Personne("Dupont", "Paul"),
        };

        /// <summary>
        /// Les trier avec la méthode OrderBy par le nom puis le prénom
        /// </summary>
        private static void ExerciceLinq5() {
            foreach (var personne in listPersonnes.OrderBy(p => p.Nom).ThenBy(p => p.Prenom).ToList()) {
                Console.WriteLine(personne);
            }
        }

        /// <summary>
        /// Afficher que les personnes qui ont leurs noms qui commence par D
        /// </summary>
        private static void ExerciceLinq6() {
            foreach (var personne in listPersonnes.Where(p => p.Nom.StartsWith("D"))) {
                Console.WriteLine(personne);
            }
        }

        /// <summary>
        /// Afficher que les noms des personnes
        /// </summary>
        private static void ExerciceLinq7() {
            foreach (string nom in listPersonnes.Select(p => p.Nom)) {
                Console.WriteLine(nom);
            }
        }

        /// <summary>
        /// Afficher le nom en majuscule et le prénom des personnes trié par ordre descendant sur le
        /// prénom dont leurs noms commence par D
        /// </summary>
        private static void ExerciceLinq8() {
            foreach (var personne in listPersonnes.Where(p => p.Nom.StartsWith("D")).OrderByDescending(p => p.Prenom).Select(p => new {Nom = p.Nom.ToUpper(), p.Prenom})) {
                Console.WriteLine($"{personne.Nom}, {personne.Prenom}");
            }
        }

        /// <summary>
        /// Sélectionner que les 2 première personne
        /// </summary>
        private static void ExerciceLinq9() {
            foreach (var personne in listPersonnes.Take(2)) {
                Console.WriteLine(personne);
            }
        }

        /// <summary>
        /// Sélection les personnes rentrés en 7ème 8ème et 9ème position
        /// </summary>
        private static void ExerciceLinq10() {
            foreach (var personne in listPersonnes.Skip(6).Take(3)) {
                Console.WriteLine(personne);
            }
        }

        /// <summary>
        /// Récupérer la personne qui a le nom Dupont
        /// </summary>
        private static void ExerciceLinq11() {
            Console.WriteLine(listPersonnes.FirstOrDefault(p => p.Nom.Equals("Dupont")));
        }

        /// <summary>
        /// Savoir si notre liste contient une personne dont le nom commence par D
        /// </summary>
        private static void ExerciceLinq12() {
            bool exist = listPersonnes.Exists(p => p.Nom.StartsWith("D"));

            Console.WriteLine(exist
                                  ? "Il existe une personne dont le nom commence par D"
                                  : "Il n'existe pas de personne dont le nom commence par D");
        }

        /// <summary>
        /// Regrouper les personnes par leurs prénoms
        /// </summary>
        private static void ExerciceLinq13() {
            foreach (var personne in listPersonnes.OrderBy(p => p.Prenom).GroupBy(p => p.Prenom)) {
                foreach (var p in personne) {
                    Console.WriteLine(p);
                }
            }
        }

        /// <summary>
        /// Gérer la division par 0 par un try catch
        /// </summary>
        private static void ExerciceException1() {
            int zero = 0;
            try {
                int result = 10 / zero;
                Console.WriteLine(result);
            } catch (Exception e) {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// Créer une classe Élèves caractérisée par nom, âge et moyenne.
        /// a. L’âge doit être entre 18 et 26 sinon l’exception InvalidAgeException (elle affiche le
        /// message "L’âge doit être entre 18 et 26") est générée.
        /// b. La note doit être entre 0 et 20 sinon l’exception InvalidNoteException est générée
        /// (elle affiche le message "La note doit être entre 0 et 20").
        /// </summary>
        private static void ExerciceException2() {
            try {
                Eleve eleve = new Eleve("Bonjour", 2, 21);
            } catch (Exception e) {
                Console.WriteLine("Une exception est survenue : " + e);
            }
            
            try {
                Eleve eleve = new Eleve("Robert", 12, 20);
            } catch (InvalidAgeException e) {
                Console.WriteLine("Age invalide : " + e);
            }

            try {
                Eleve eleve = new Eleve("Jean", 20, 100);
            } catch (InvalidNoteException e) {
                Console.WriteLine("Erreur note : " + e);
            }

        }
        #endregion
    }
}
