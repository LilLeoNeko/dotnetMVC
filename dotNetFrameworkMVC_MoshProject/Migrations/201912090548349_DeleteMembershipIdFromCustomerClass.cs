namespace dotNetFrameworkMVC_MoshProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteMembershipIdFromCustomerClass : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MembershipId", "dbo.Memberships");
            DropIndex("dbo.Customers", new[] { "MembershipId" });
            RenameColumn(table: "dbo.Customers", name: "MembershipId", newName: "Membership_Id");
            AlterColumn("dbo.Customers", "Membership_Id", c => c.Byte());
            CreateIndex("dbo.Customers", "Membership_Id");
            AddForeignKey("dbo.Customers", "Membership_Id", "dbo.Memberships", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "Membership_Id", "dbo.Memberships");
            DropIndex("dbo.Customers", new[] { "Membership_Id" });
            AlterColumn("dbo.Customers", "Membership_Id", c => c.Byte(nullable: false));
            RenameColumn(table: "dbo.Customers", name: "Membership_Id", newName: "MembershipId");
            CreateIndex("dbo.Customers", "MembershipId");
            AddForeignKey("dbo.Customers", "MembershipId", "dbo.Memberships", "Id", cascadeDelete: true);
        }
    }
}
