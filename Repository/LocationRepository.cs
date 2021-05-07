using Models;
using Repository.Contracts;
using System.Collections.Generic;

namespace Repository
{
    public class LocationRepository : ILocationRepository
    {
        static LocationEntitys context = new LocationEntitys();
        public Location CreateLocation(Location location)
        {
            context.Locations.Add(location);
            context.SaveChanges();
            return location;
        }

        public List<Location> GetListLocations()
        {
            var locations = new List<Location>(context.Locations);

            return locations;
        }
    }
}
