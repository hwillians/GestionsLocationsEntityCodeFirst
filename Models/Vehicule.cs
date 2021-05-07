using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Vehicule
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Immatriculation { get; set; }
        [Required]
        [MaxLength(100)]
        public string Modele { get; set; }
        [Required]
        [MaxLength(50)]
        public string Couleur { get; set; }
        public int MarqueID { get; set; }
        public int CategorieID { get; set; }

        public virtual Marque Marque { get; set; }
        public virtual Categorie Categorie { get; set; }
        public virtual List<Location> Locations { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Immatriculation} {Modele} {Couleur}, {Categorie.Libelle} {Marque.Nom}";
        }
    }
}
