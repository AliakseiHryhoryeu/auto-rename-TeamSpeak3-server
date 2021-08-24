namespace ts3AutoUpdeteServer.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class settingscontext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Settings",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    TimeAutoUpdate = c.Int(nullable: false),
                    LastTimeUpdate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropTable("dbo.Settings");
        }
    }
}
