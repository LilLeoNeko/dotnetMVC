namespace dotNetFrameworkMVC_MoshProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipNameProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Memberships", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Memberships", "Name");
        }
    }
}
