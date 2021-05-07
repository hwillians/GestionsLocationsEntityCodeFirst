using Models;
using Repository.Contracts;
using System;
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

        public Location GetLocationById(int id) => LocationRepository.GetLocationById(id);

        public void UpdateLocation(Location location) => LocationRepository.UpdateLocation(location);
    }
}
