using System.Collections.Generic;
using System.Linq;

namespace ts3AutoUpdeteServer.DataModel
{
    class GetDb
    {
        public static List<Server> GetServerEf()
        {
            var context = new ServersContext();
            var servers = context.Servers.ToList();
            return servers;
        }
        public static List<Settings> GetSettingsEf()
        {
            var context = new ServersContext();
            var settings = context.Settings.ToList();
            return settings;
        }
        public static int GetSettingsEf(int id)
        {
            var context2 = new ServersContext();
            Settings setting = new Settings { Id = id };
            context2.Settings.Attach(setting);
            int time = setting.TimeAutoUpdate;
            return time;
        }

    }
}
