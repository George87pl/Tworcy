using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tworcy.Models.Spis;
using TworcyData;

namespace Tworcy.Controllers
{
    public class SpisController : Controller
    {
        private ITworcyAsset _assets;

        public SpisController(ITworcyAsset assets)
        {
            _assets = assets;
        }

        public IActionResult Index()
        {
            var assetModels = _assets.GetAll();

            var listingResult = assetModels
                .Select(result => new AssetIndexListingModel
                {
                    Id = result.Id,
                    Imie = result.Imie,
                    Nazwisko = result.Nazwisko,
                    Zdjecie = result.Zdjecie,
                    Biogram = result.Biogram,
                    Bibliografia = result.Bibliografia,
                    Nagrody = result.Nagrody,
                    Wystawy = result.Wystawy,
                    Teksty = result.Teksty,
                    Audio = result.Audio,
                    Kontakt = result.Kontakt
                });

            var model = new AssetIndexModel()
            {
                Assets = listingResult
            };

            return View(model);
        }
    }
}