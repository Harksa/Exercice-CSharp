using ExercicesBDD.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicesBDD.Controllers
{
    public static class LocationsController
    {
        #region CRUD CLIENT

        public static void CreateClient(string nom, string prenom, string adresse, int codePostal, string ville)
        {
            LocationsContext context = new LocationsContext();
            context.Clients.Add(new Client
            {
                Nom = nom,
                Prenom = prenom,
                DateNaissance = DateTime.Now,
                Adresse = adresse,
                CodePostal = codePostal,
                Ville = ville
            });
            context.SaveChanges();
        }

        public static Client ReadClient(int id)
        {
            LocationsContext context = new LocationsContext();
            return context.Clients.Find(id);
        }

        public static void UpdateClient(int id, string nom = null, string prenom = null, string adresse = null, int codePostal = 0, string ville = null)
        {
            LocationsContext context = new LocationsContext();
            Client toChange = context.Clients.Find(id);
            if(toChange == null) return;
            if(nom != null) toChange.Nom = nom;
            if(prenom != null) toChange.Prenom = prenom;
            if(adresse != null) toChange.Adresse = adresse;
            if(codePostal != 0) toChange.CodePostal = codePostal;
            if(ville != null) toChange.Ville = ville;
            context.SaveChanges();
        }

        public static void DeleteClient(int id)
        {
            LocationsContext context = new LocationsContext();
            Client toDelete = context.Clients.Find(id);
            if(toDelete == null) return;
            context.Clients.Remove(toDelete);
            context.SaveChanges();
        }

        #endregion
    }
}
