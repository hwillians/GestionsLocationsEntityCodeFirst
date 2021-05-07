using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Location
    {
        public int Id { get; set; }
        [Required]
        public int ClientID { get; set; }
        [Required]
        public int VehiculeID { get; set; }
        [Required]
        public int NbKm { get; set; }
        [Required]
        public DateTime DateDebut { get; set; }
   
        public DateTime? DateFin { get; set; }

        public virtual Client Client { get; set; }
        public virtual Vehicule Vehicule { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - Id client : {1}, Id vehicule : {2}, {3}Km  du {4} au {5}",
                Id, ClientID, VehiculeID, NbKm, DateDebut.ToString("dd/MM/yyyy"), DateFin?.ToString("dd/MM/yyyy"));
        }
    }
}
