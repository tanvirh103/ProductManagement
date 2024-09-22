namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initdatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoryInfoes",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 50, unicode: false),
                        CategoryDescription = c.String(nullable: false, maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.ProductInfoes",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 50, unicode: false),
                        ProductDescription = c.String(nullable: false, maxLength: 200, unicode: false),
                        Quantity = c.Int(nullable: false),
                        ProductPrice = c.Double(nullable: false),
                        CId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.CategoryInfoes", t => t.CId, cascadeDelete: true)
                .Index(t => t.CId);
            
            CreateTable(
                "dbo.UserInfoes",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 50, unicode: false),
                        Email = c.String(nullable: false, maxLength: 30, unicode: false),
                        Phone = c.String(nullable: false, maxLength: 20, unicode: false),
                        Password = c.String(nullable: false, maxLength: 20, unicode: false),
                        Role = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductInfoes", "CId", "dbo.CategoryInfoes");
            DropIndex("dbo.ProductInfoes", new[] { "CId" });
            DropTable("dbo.UserInfoes");
            DropTable("dbo.ProductInfoes");
            DropTable("dbo.CategoryInfoes");
        }
    }
}
