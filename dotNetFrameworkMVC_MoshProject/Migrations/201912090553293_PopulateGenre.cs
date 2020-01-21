namespace dotNetFrameworkMVC_MoshProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) Values ('Action')");
            Sql("INSERT INTO Genres (Name) Values ('Thriller')");
            Sql("INSERT INTO Genres (Name) Values ('Family')");
            Sql("INSERT INTO Genres (Name) Values ('Romance')");
            Sql("INSERT INTO Genres (Name) Values ('Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
