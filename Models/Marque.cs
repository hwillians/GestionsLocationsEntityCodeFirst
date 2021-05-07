using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Marque
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nom { get; set; }

        public override string ToString() => $"{Id} - {Nom}";
    }
}
