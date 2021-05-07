using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nom { get; set; }
        [Required]
        [MaxLength(50)]
        public string Prenom { get; set; }

        [Required]
        public DateTime DateNaissance { get; set; }

        [MaxLength(150)]
        public string Adresse { get; set; }

        [MaxLength(15)]
        public string CodePostal { get; set; }

        [MaxLength(50)]
        public string Ville { get; set; }

        public virtual List<Location> Locations { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} {2} ({3}), {4} {5} - {6}",
                Id, Nom, Prenom, DateNaissance.ToString("dd/MM/yy"), Adresse, CodePostal, Ville);
        }

    }
}
