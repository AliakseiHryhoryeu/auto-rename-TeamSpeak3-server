namespace ts3AutoUpdeteServer.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddDataAnnotations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Servers",
                c => new
                {
                    ServerId = c.Int(nullable: false, identity: true),
                    Login = c.String(nullable: false, maxLength: 500),
                    Password = c.String(nullable: false, maxLength: 500),
                    ServerIp = c.String(nullable: false, maxLength: 500),
                    Name1 = c.String(nullable: false, maxLength: 500),
                    Name2 = c.String(nullable: false, maxLength: 500),
                    DateUpdate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.ServerId);

        }

        public override void Down()
        {
            DropTable("dbo.Servers");
        }
    }
}
