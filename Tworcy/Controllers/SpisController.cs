using Microsoft.AspNetCore.Mvc;
using System.Linq;
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
                    Biogram = result.Biogram
                });

            var model = new AssetIndexModel()
            {
                Assets = listingResult
            };

            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var tworca = _assets.GetById(id);
            var galeria = _assets.GetTworcaGallery(tworca);

            var model = new AssetDetailModel
            {
                Tworca = tworca,
                Zdjecia = galeria
            };

            return View(model);
        }
    }
}