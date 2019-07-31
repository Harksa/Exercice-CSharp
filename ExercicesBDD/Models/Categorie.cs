using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicesBDD.Models
{
    class Categorie
    {
        public int ID { get; set; }

        public string Libelle { get; set; }

        public float PrixKM { get; set; }

        public virtual ICollection<Vehicule> Vehicules { get; set; }
    }
}
