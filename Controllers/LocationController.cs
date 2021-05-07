using Models;
using Repository.Contracts;
using System.Collections.Generic;

namespace Controllers
{
    public class LocationController
    {
        private ILocationRepository LocationRepository { get; }
        public LocationController(ILocationRepository locationRepo)
        {
            LocationRepository = locationRepo;
        }

        public Location CreateLocation(Location location) => LocationRepository.CreateLocation(location);

        public List<Location> GetLocations() => LocationRepository.GetLocations();

    }
}
