using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TworcyData;
using TworcyData.Models;

namespace TworcyServices
{
    public class TworcaAssetService : ITworcyAsset
    {
        private TworcyContext _context;

        public TworcaAssetService(TworcyContext context)
        {
            _context = context;
        }

        public void Add(Tworca newAsset)
        {
            _context.Add(newAsset);
            _context.SaveChanges();
        }

        public IEnumerable<Tworca> GetAll()
        {
            return _context.Tworcy;
        }

        public Tworca GetById(int id)
        {
            return GetAll().FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<Zdjecie> GetTworcaGallery(Tworca tworca)
        {
            return _context.Zdjecia
                .Include(p => p.Tworca)
                .Where(z => z.Tworca == tworca);
        }
    }
}
