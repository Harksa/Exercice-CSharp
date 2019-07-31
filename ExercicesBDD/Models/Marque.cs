using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicesBDD.Models
{
    class Marque
    {
        public int ID { get; set; }

        public string Nom { get; set; }

        public virtual ICollection<Vehicule> Vehicules { get; set; }
    }
}
