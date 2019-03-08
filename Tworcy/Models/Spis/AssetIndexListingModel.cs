using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tworcy.Models.Spis
{
    public class AssetIndexListingModel
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Zdjecie { get; set; }
        public string Biogram { get; set; }
        public string Bibliografia { get; set; }
        public string Nagrody { get; set; }
        public string Wystawy { get; set; }
        public string Teksty { get; set; }
        public string Audio { get; set; }
        public string Kontakt { get; set; }
    }
}
