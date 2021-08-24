namespace ts3AutoUpdeteServer.DataModel
{
    class DeleteDb
    {
        public static void DeleteServer(int id)
        {
            var context = new ServersContext();
            Server server = new Server { ServerId = id };
            context.Servers.Attach(server);
            context.Servers.Remove(server);
            context.SaveChanges();

        }
        public static void DeleteSettings(int id)
        {
            var context = new ServersContext();
            Settings setting = new Settings { Id = id };
            context.Settings.Attach(setting);
            context.Settings.Remove(setting);
            context.SaveChanges();

        }

    }
}
