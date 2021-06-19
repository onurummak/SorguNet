namespace SorguNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Icra : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Icras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerTC = c.String(maxLength: 128),
                        Itirazli = c.Int(nullable: false),
                        AçılmaTarihi = c.DateTime(nullable: false),
                        KapanmaTarihi = c.DateTime(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerTC)
                .Index(t => t.CustomerTC);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Icras", "CustomerTC", "dbo.Customers");
            DropIndex("dbo.Icras", new[] { "CustomerTC" });
            DropTable("dbo.Icras");
        }
    }
}
