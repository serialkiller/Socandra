namespace Socandra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateProductTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ProductTypes (ProductTypeName) VALUES('Car')");
            Sql("INSERT INTO ProductTypes (ProductTypeName) VALUES('Book')");
            Sql("INSERT INTO ProductTypes (ProductTypeName) VALUES('TV')");
            Sql("INSERT INTO ProductTypes (ProductTypeName) VALUES('Phone')");

        }
        
        public override void Down()
        {
            Sql("DELETE FROM ProductTypes where ProductTypeId IN (1,2,3,4)");
        }
    }
}
