using Models;
using Repository.Contracts;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class VehiculeRepository : IVehiculeRepository
    {
        private static LocationEntitys context = new LocationEntitys();
        public List<Vehicule> GetVehicules() => new List<Vehicule>(context.Vehicules);

    }
}
