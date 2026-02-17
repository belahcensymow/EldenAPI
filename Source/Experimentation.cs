using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Data.Sqlite;

namespace EldenAPI
{
    public class SiteOfGrace
    {
        public int ID { get; set; }
        public int IconId { get; set; }
        public int SubRegionId { get; set; }
        public string Text { get; set; }
        public Vector3 Coordinates { get; set; }


    }
    public static class Experimentation
    {
        public static void run()
        {
            using var connection = new SqliteConnection("Data Source=data.db");
            connection.Open();
        }
    }
}