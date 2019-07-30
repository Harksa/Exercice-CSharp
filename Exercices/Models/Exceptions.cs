using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicesBase.Models
{
    public class InvalidAgeException : Exception {
        public InvalidAgeException() : base("L’âge doit être entre 18 et 26") {
            
        }
    }

    public class InvalidNoteException : Exception {
        public InvalidNoteException() : base("La note doit être entre 0 et 20") {
            
        }
    }
}
