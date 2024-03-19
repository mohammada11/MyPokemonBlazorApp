using System.ComponentModel.DataAnnotations;

namespace MyPokemonBlazorApp.Model
{
    public class Pokemon
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }

        [Required]
        [Range(1, 800, ErrorMessage = "Total must be between 1 and 800")]
        public int Total { get; set; }

        [Required]
        [Range(1, 800, ErrorMessage = "HP must be between 1 and 800")]
        public int HP { get; set; }

        [Required]
        [Range(1, 800, ErrorMessage = "Attack must be between 1 and 800")]
        public int Attack { get; set; }

        [Required]
        [Range(1, 800, ErrorMessage = "Defence must be between 1 and 800")]
        public int Defence { get; set; }

        [Required]
        [Range(1, 800, ErrorMessage = "Speed must be between 1 and 800")]
        public int Speed { get; set; }

        [Required]
        [Range(1, 800, ErrorMessage = "Generation must be between 1 and 10")]
        public int Generation { get; set; }

        [Required]
        
        public bool Legendary { get; set; }

        [Required]
        public List<Trainer> Trainers { get; set; }
      


     
    }
}
