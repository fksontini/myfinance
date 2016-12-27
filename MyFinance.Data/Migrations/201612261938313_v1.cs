namespace MyFinance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        NameCategory = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        DateProd = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Description = c.String(),
                        Name = c.String(nullable: false, maxLength: 50),
                        fullprice_Price = c.Double(nullable: false),
                        fullprice_Quantity = c.Int(nullable: false),
                        CategoryFK = c.Int(),
                        Herbs = c.String(),
                        City = c.String(),
                        LabName = c.String(),
                        StreetAddress = c.String(),
                        custom = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Categories", t => t.CategoryFK)
                .Index(t => t.CategoryFK);
            
            CreateTable(
                "dbo.Providers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        login_UserName = c.String(),
                        login_Password = c.String(),
                        DateCreated = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Email = c.String(),
                        IsApproved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tableAssocia",
                c => new
                    {
                        po = c.Int(nullable: false),
                        pr = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.po, t.pr })
                .ForeignKey("dbo.Products", t => t.po, cascadeDelete: true)
                .ForeignKey("dbo.Providers", t => t.pr, cascadeDelete: true)
                .Index(t => t.po)
                .Index(t => t.pr);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tableAssocia", "pr", "dbo.Providers");
            DropForeignKey("dbo.tableAssocia", "po", "dbo.Products");
            DropForeignKey("dbo.Products", "CategoryFK", "dbo.Categories");
            DropIndex("dbo.tableAssocia", new[] { "pr" });
            DropIndex("dbo.tableAssocia", new[] { "po" });
            DropIndex("dbo.Products", new[] { "CategoryFK" });
            DropTable("dbo.tableAssocia");
            DropTable("dbo.Providers");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
