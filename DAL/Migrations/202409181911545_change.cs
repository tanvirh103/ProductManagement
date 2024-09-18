namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.ProductInfoes", name: "CategoryId", newName: "CId");
            RenameIndex(table: "dbo.ProductInfoes", name: "IX_CategoryId", newName: "IX_CId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.ProductInfoes", name: "IX_CId", newName: "IX_CategoryId");
            RenameColumn(table: "dbo.ProductInfoes", name: "CId", newName: "CategoryId");
        }
    }
}
