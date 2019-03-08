using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tworcy.Models.Spis
{
    public class AssetIndexModel
    {
        public IEnumerable<AssetIndexListingModel> Assets { get; set; }
    }
}
