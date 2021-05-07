using Models;
using Repository.Contracts;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class VehiculeRepository : IVehiculeRepository
    {
        private static LocationEntitys context = new LocationEntitys();

        public Vehicule CreateVehicule(Vehicule vehicule)
        {
            context.Vehicules.Add(vehicule);
            context.SaveChanges();

            return vehicule;
        }

        public void DelateVehicule(int Id)
        {
            throw new NotImplementedException();
        }

        public Vehicule GetVehiculeById(int Id) => context.Vehicules.Find(Id);

        public List<Vehicule> GetVehicules() => new List<Vehicule>(context.Vehicules);

        public void UpdateVehicule(Vehicule vehiculeUp)
        {
            var vehicule = context.Vehicules.Find(vehiculeUp.Id);

            vehicule.Immatriculation = vehiculeUp.Immatriculation;
            vehicule.Modele = vehiculeUp.Modele;
            vehicule.Couleur = vehiculeUp.Couleur;
            vehicule.MarqueID = vehiculeUp.MarqueID;
            vehicule.CategorieID = vehiculeUp.CategorieID;

            context.SaveChanges();
        }
    }
}
