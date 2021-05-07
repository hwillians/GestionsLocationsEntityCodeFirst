using Models;
using System.Collections.Generic;

namespace Repository.Contracts
{
    public interface IVehiculeRepository
    {
        List<Vehicule> GetVehicules();
    }
}
