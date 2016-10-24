namespace Socandra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProduct1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ChangedAt = c.DateTime(nullable: false),
                        ProductType_ProductTypeId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.ProductTypes", t => t.ProductType_ProductTypeId)
                .Index(t => t.ProductType_ProductTypeId);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        ProductTypeId = c.Int(nullable: false, identity: true),
                        ProductTypeName = c.String(),
                    })
                .PrimaryKey(t => t.ProductTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductType_ProductTypeId", "dbo.ProductTypes");
            DropIndex("dbo.Products", new[] { "ProductType_ProductTypeId" });
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Products");
        }
    }
}
