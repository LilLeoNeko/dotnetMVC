namespace dotNetFrameworkMVC_MoshProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembership : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Memberships (Id, SignUpFee, DurationInMonths, Discount) VALUES (1,0,0,0)");
            Sql("INSERT INTO Memberships (Id, SignUpFee, DurationInMonths, Discount) VALUES (2,30,1,10)");
            Sql("INSERT INTO Memberships (Id, SignUpFee, DurationInMonths, Discount) VALUES (3,90,3,15)");
            Sql("INSERT INTO Memberships (Id, SignUpFee, DurationInMonths, Discount) VALUES (4,300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
