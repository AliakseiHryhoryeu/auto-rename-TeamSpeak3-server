using System.Data.Entity;

namespace ts3AutoUpdeteServer.DataModel
{
    public class ServersContext : DbContext
    {
        public ServersContext()
            : base("name=ServersContext")
        {

        }
        public DbSet<Server> Servers { get; set; }
        public DbSet<Settings> Settings { get; set; }
    }

}



