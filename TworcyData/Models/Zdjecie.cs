using System.ComponentModel.DataAnnotations;

namespace TworcyData.Models
{
    public class Zdjecie
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public Tworca Tworca { get; set; }

        [Required]
        public string zdjecieUrl { get; set; }
    }
}
