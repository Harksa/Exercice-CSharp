using System;
using System.Collections.Generic;

namespace ExercicesBDD.Models
{
    public class Client
    {
        public int ID { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public DateTime DateNaissance { get; set; }

        public string Adresse { get; set; }

        public int CodePostal { get; set; }

        public string Ville { get; set; }

        public virtual ICollection<Loue> Loues { get; set; }
    }
}
