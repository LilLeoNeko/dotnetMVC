namespace dotNetFrameworkMVC_MoshProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomerBirthDate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = CAST('1994-07-24' AS DATETIME) WHERE Id = 1");
            Sql("UPDATE Customers SET BirthDate = CAST('1995-06-20' AS DATETIME) WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
