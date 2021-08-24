using System;

namespace ts3AutoUpdeteServer.DataModel
{
    class EditDb
    {
        public static void EditServerEf(int id, string Login, string Password, string ServerIp, string Name1, string Name2)
        {
            var context2 = new ServersContext();
            Server server = new Server { ServerId = id };
            context2.Servers.Attach(server);
            server.Login = Login;
            server.Password = Password;
            server.ServerIp = ServerIp;
            server.Name1 = Name1;
            server.Name2 = Name2;
            server.DateUpdate = DateTime.Today;
            context2.SaveChanges();

        }
        public static void EditSetingsEf(int id, int TimeAutoUpdate, DateTime LastTimeUpdate)
        {
            var context2 = new ServersContext();
            Settings setting = new Settings { Id = id };
            context2.Settings.Attach(setting);
            setting.TimeAutoUpdate = TimeAutoUpdate;
            setting.LastTimeUpdate = LastTimeUpdate;
            context2.SaveChanges();

        }
        public static void EditSetingsEf(int id, DateTime LastTimeUpdate)
        {
            var context2 = new ServersContext();
            Settings setting = new Settings { Id = id };
            context2.Settings.Attach(setting);
            setting.LastTimeUpdate = LastTimeUpdate;
            context2.SaveChanges();

        }

        public static void EditSetingsEf(int id, int TimeAutoUpdate)
        {
            var context2 = new ServersContext();
            Settings setting = new Settings { Id = id };
            context2.Settings.Attach(setting);
            setting.TimeAutoUpdate = TimeAutoUpdate;
            context2.SaveChanges();

        }

    }
}
