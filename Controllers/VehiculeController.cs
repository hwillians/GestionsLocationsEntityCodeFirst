using Models;
using Repository.Contracts;
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

    }
}
