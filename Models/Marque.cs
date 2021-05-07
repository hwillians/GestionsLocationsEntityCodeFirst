using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Marque
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Index(IsUnique = true)]
        public string Nom { get; set; }
        public virtual List<Vehicule> Vehicules { get; set; }

        public override string ToString() => $"{Id} - {Nom}";
    }
}
