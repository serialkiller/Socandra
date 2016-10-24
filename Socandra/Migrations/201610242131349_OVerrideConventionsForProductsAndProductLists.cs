namespace Socandra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OVerrideConventionsForProductsAndProductLists : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "ProductType_ProductTypeId", "dbo.ProductTypes");
            DropIndex("dbo.Products", new[] { "ProductType_ProductTypeId" });
            AlterColumn("dbo.Products", "ProductName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Products", "ProductType_ProductTypeId", c => c.Int(nullable: false));
            AlterColumn("dbo.ProductTypes", "ProductTypeName", c => c.String(nullable: false));
            CreateIndex("dbo.Products", "ProductType_ProductTypeId");
            AddForeignKey("dbo.Products", "ProductType_ProductTypeId", "dbo.ProductTypes", "ProductTypeId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductType_ProductTypeId", "dbo.ProductTypes");
            DropIndex("dbo.Products", new[] { "ProductType_ProductTypeId" });
            AlterColumn("dbo.ProductTypes", "ProductTypeName", c => c.String());
            AlterColumn("dbo.Products", "ProductType_ProductTypeId", c => c.Int());
            AlterColumn("dbo.Products", "ProductName", c => c.String());
            CreateIndex("dbo.Products", "ProductType_ProductTypeId");
            AddForeignKey("dbo.Products", "ProductType_ProductTypeId", "dbo.ProductTypes", "ProductTypeId");
        }
    }
}
