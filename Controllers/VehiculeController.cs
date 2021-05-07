using Models;
using Repository.Contracts;
using System;
using System.Collections.Generic;

namespace Controllers
{
    public class VehiculeController
    {
        private IVehiculeRepository VehiculeRepository { get; }
        public VehiculeController(IVehiculeRepository vehiculeRepository)
        {
            VehiculeRepository = vehiculeRepository;
        }

        public List<Vehicule> GetVehicules() => VehiculeRepository.GetVehicules();

        public Vehicule CreateVehicule(Vehicule vehicule) => VehiculeRepository.CreateVehicule(vehicule);

        public void UpdateVehicule(Vehicule vehicule) => VehiculeRepository.UpdateVehicule(vehicule);

        public void DelateVehicule(int id) => VehiculeRepository.DelateVehicule(id);

        public Vehicule GetVehiculeById(int id) => VehiculeRepository.GetVehiculeById(id);
    }
}
