using Microsoft.EntityFrameworkCore;
using TworcyData.Models;

namespace TworcyData
{
    public class TworcyContext : DbContext
    {
        public TworcyContext(DbContextOptions options) : base(options) { }

        public DbSet<Tworca> Tworcy { get; set; }
        public DbSet<Zdjecie> Zdjecia { get; set; }
    }
}
