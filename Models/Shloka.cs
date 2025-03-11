using System.ComponentModel.DataAnnotations;

namespace The_voice_of_geeta.Models
{
    public class Shloka
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string SanskritText { get; set; }

        public string Translation { get; set; }

        public string Meaning { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
