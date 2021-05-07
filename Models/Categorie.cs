using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Categorie
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [Index(IsUnique = true)]
        public string Libelle { get; set; }
        [Required]
        public int PrixKm { get; set; }

        public override string ToString() => $"{Id} {Libelle} {PrixKm} Euro/Km";
    }
}
