using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicesBDD.Models
{
    public class Vehicule
    {
        public int ID { get; set; }

        public string Immatriculation { get; set; }

        public string Couleur { get; set; }

        public DateTime DateMiseEnService { get; set; }

        public ICollection<Loue> Loues { get; set; }

        public virtual Categorie Categorie { get; set; }

        public virtual Marque Marque { get; set; }
    }
}
