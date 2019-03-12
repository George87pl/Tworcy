using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TworcyData.Models;

namespace Tworcy.Models.Spis
{
    public class AssetDetailModel
    {
        public Tworca Tworca { get; set; }
        public IEnumerable<Zdjecie> Zdjecia { get; set; }
    }
}
