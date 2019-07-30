using System;

namespace ExercicesBase.Models {

    public class Eleve {
        
        public string Nom { get; set; }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 18 && value <= 26)
                    age = value;
                else {
                    throw new InvalidAgeException();
                }
            }
        }

        private float moyenne;

        public float Moyenne
        {
            get { return moyenne; }
            set
            {
                if (value >= 0 && value <= 20)
                    moyenne = value;
                else {
                    throw new InvalidNoteException();
                }
            }
        }

        public Eleve(string nom, int age, float moyenne) {
            Nom = nom;
            Age = age;
            Moyenne = moyenne;
        }

        public override string ToString() {
            return $"{Nom} : {Age} -- {Moyenne}";
        }
    }

}