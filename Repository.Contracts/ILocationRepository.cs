using Models;
using System.Collections.Generic;

namespace Repository.Contracts
{
    public interface ILocationRepository
    {
        Location CreateLocation(Location location);
        List<Location> GetLocations();
        Location GetLocationById(int id);
        void UpdateLocation(Location location);
        void DeleteLocation(Location location);
    }
}
