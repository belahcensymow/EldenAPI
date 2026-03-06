using System.Numerics;
using EldenRingDataExtractor;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EldenAPI.Source
{
    public class AppDbContext : DbContext
    {
        public DbSet<SiteOfGrace> SitesOfGrace { get; set; }
        public string DbPath { get; set; }
        public AppDbContext()
        {
            var path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../"));
            DbPath = Path.Combine(path, "SitesOfGrace.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }

    public static class Experimentation
    {
        public static void Run()
        {
            string gameDir = @"/mnt/F81CEC961CEC50E4/Games/ELDEN RING/Game";
            RegulationHandler regulation = new(gameDir);
        }
    }

    public class SiteOfGrace
    {
        public int ID { get; set; } = -1;
        public int IconId { get; set; } = -1;
        public int SubRegionId { get; set; } = -1;
        public string Text1 { get; set; } = "";
        public string Text2 { get; set; } = "";
        public string Text3 { get; set; } = "";
        public string Text4 { get; set; } = "";
        public string Text5 { get; set; } = "";
        public string Text6 { get; set; } = "";
        public string Text7 { get; set; } = "";
        public string Text8 { get; set; } = "";
        public float PosX { get; set; } = -1;
        public float PosY { get; set; } = -1;
        public float PosZ { get; set; } = -1;
        public int AreaNo { get; set; } = -1;
        public int GridXNo { get; set; } = -1;
        public int GridZNo { get; set; } = -1;
    }
}
