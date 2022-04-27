namespace homework_theme_18.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB26042022 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    LFMName = c.String(nullable: false, maxLength: 50),
                    Telephone = c.String(nullable: false, maxLength: 50),
                    Email = c.String(nullable: false, maxLength: 50),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Orders",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    ClientEmail = c.String(nullable: false, maxLength: 20, fixedLength: true),
                    IdProduct = c.Int(nullable: false),
                    ProductName = c.String(nullable: false),
                    Quantity = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Product",
                c => new
                {
                    IdProduct = c.Int(nullable: false, identity: true),
                    ProductName = c.String(nullable: false, maxLength: 20, fixedLength: true),
                    Quantity = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.IdProduct);

        }
        
        public override void Down()
        {
            DropTable("dbo.Product");
            DropTable("dbo.Orders");
            DropTable("dbo.Clients");
        }
    }
}
