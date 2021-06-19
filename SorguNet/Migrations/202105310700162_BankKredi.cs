namespace SorguNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BankKredi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BankKredis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerTC = c.String(maxLength: 128),
                        VadeTarihi = c.DateTime(nullable: false),
                        KapanmaTarihi = c.DateTime(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerTC)
                .Index(t => t.CustomerTC);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BankKredis", "CustomerTC", "dbo.Customers");
            DropIndex("dbo.BankKredis", new[] { "CustomerTC" });
            DropTable("dbo.BankKredis");
        }
    }
}
