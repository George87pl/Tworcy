using System.ComponentModel.DataAnnotations;

namespace TworcyData.Models
{
    public class Tworca
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Imie { get; set; }

        [Required]
        public string Nazwisko { get; set; }

        public string Zdjecie { get; set; }

        public string Biogram { get; set; }

        public string Bibliografia { get; set; }

        public string Nagrody { get; set; }

        public string Wystawy { get; set; }

        public string Teksty { get; set; }

        public string Audio { get; set; }

        public string Kontakt { get; set; }

        [Required]
        public bool Gotowe { get; set; }
    }
}
