using System;
using System.Collections;
using System.Collections.Generic;
using ExercicesBase.Interfaces;

namespace ExercicesBase
{
    public class Personne : ITravailleur, IEquatable<Personne>, IComparable<Personne> {

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }

        public static int Test = 1;

        public Personne() {}

        public Personne(string nom, string prenom, DateTime dateTime) {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateTime;
        }

        public Personne(string nom, string prenom) : this(nom, prenom, DateTime.Now) {

        }
        
        public void InversePrenom() {
            char[] tmp = Prenom.ToCharArray();
            Array.Reverse(tmp);
            Prenom = new string(tmp);
            Console.WriteLine($"Nouveau prénom : {Prenom}");
        }

        public override string ToString() {
            return $"{Nom} {Prenom}, né le {DateNaissance}";
        }

        public virtual void Afficher() {
            Console.WriteLine(this);
        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (!(obj is Personne)) return false;

            Personne p = (Personne) obj;
            return Nom.Equals(p.Nom) && Prenom.Equals(p.Prenom);
        }

        public bool Equals(Personne p) {
            return Nom.Equals(p.Nom) && Prenom.Equals(p.Prenom);
        }

        public int CompareTo(Personne other)
        {
            if (Nom.Equals(other.Nom)) {
                return String.Compare(Prenom, other.Prenom, StringComparison.OrdinalIgnoreCase);
            }

            return String.Compare(Nom, other.Nom, StringComparison.OrdinalIgnoreCase);

        }
    }

    class ComparaisonOrdreDescendant : IComparer<Personne> {
        public int Compare(Personne x, Personne y) {
            return -x.CompareTo(y);
        }
    }
}
