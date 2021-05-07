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
            using (context)
            {
                context.Locations.Add(location);
                context.SaveChanges();
                return location;
            }
        }

        public void DeleteLocation(Location location)
        {
            throw new System.NotImplementedException();
        }

        public Location GetLocationById(int id)
        {
            using (context)
            {
                return context.Locations.Find(id); ;
            }
        }

        public List<Location> GetLocations()
        {
            using (context)
            {
                return new List<Location>(context.Locations);
            }
        }

        public void UpdateLocation(Location locationUp)
        {
            using (context)
            {
                Location location = context.Locations.Find(locationUp.Id);

                location.ClientID = locationUp.ClientID;
                location.VehiculeID = locationUp.VehiculeID;
                location.NbKm = locationUp.NbKm;
                location.DateDebut = locationUp.DateDebut;
                location.DateFin = locationUp.DateFin;
                context.SaveChanges();
            }
        }
    }
}
