namespace SorguNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitD : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        TC = c.String(nullable: false, maxLength: 128),
                        AdSoyad = c.String(),
                        Telefon = c.String(),
                        KrediNot = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TC);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Rol = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Customers");
        }
    }
}
