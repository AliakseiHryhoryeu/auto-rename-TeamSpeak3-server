using System;

namespace ts3AutoUpdeteServer.DataModel
{
    class AddDb
    {
        public static void AddServerEf(int ServerId, string Login, string Password, string ServerIp, string Name1, string Name2)
        {

            var context = new ServersContext();

            Server server = new Server();
            server.ServerId = ServerId;
            server.Login = Login;
            server.Password = Password;
            server.ServerIp = ServerIp;
            server.Name1 = Name1;
            server.Name2 = Name2;
            server.DateUpdate = DateTime.Today;

            context.Servers.Add(server);
            context.SaveChanges();
        }
        public static void AddSettingsEf(int Id, int TimeAutoUpdate, DateTime LastTimeUpdate)
        {

            var context = new ServersContext();

            var settings = GetDb.GetSettingsEf();
            int temp = 0;
            foreach (var settingtemp in settings)
            {
                if (settingtemp.Id == Id)
                {
                    temp++;
                    break;
                }
            }
            if (temp > 0)
            {
                Settings setting = new Settings();
                setting.Id = Id;
                setting.TimeAutoUpdate = TimeAutoUpdate;
                setting.LastTimeUpdate = DateTime.Now;

                context.Settings.Add(setting);
                context.SaveChanges();

            }
        }
    }
}
