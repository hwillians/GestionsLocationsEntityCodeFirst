using Models;
using System.Collections.Generic;

namespace Repository.Contracts
{
    public interface IVehiculeRepository
    {
        List<Vehicule> GetVehicules();
        Vehicule CreateVehicule(Vehicule vehicule);
        Vehicule GetVehiculeById(int Id);
        void UpdateVehicule(Vehicule vehicule);
        void DelateVehicule(int Id);
    }
}
