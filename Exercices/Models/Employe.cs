using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicesBase.Models
{
    class Employe : Personne
    {
        public int Salaire { get; set; }

        public Employe(string nom, string prenom, DateTime dateTime, int salaire) : base(nom, prenom, dateTime) {
            Salaire = salaire;
        }

        public override string ToString() {
            return $"{base.ToString()}, Salaire : {Salaire}";
        }

        public override void Afficher() {
            Console.WriteLine(this);
        }

    }



}
