using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicesBDD.Models
{
    public class Loue
    {
        public int ID { get; set; }

        public int NombreKm { get; set; }

        public DateTime DateDebut { get; set; }

        public DateTime DateFin { get; set; }

        public virtual Client Client { get; set; }

        public virtual Vehicule Vehicule { get; set; }
    }
}
