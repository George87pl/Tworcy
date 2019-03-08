using System.Collections.Generic;
using TworcyData.Models;

namespace TworcyData
{
    public interface ITworcyAsset
    {
        IEnumerable<Tworca> GetAll();
        Tworca GetById(int id);
        void Add(Tworca newAsset);
        IEnumerable<Zdjecie> GetTworcaGallery(Tworca tworca);
    }
}
