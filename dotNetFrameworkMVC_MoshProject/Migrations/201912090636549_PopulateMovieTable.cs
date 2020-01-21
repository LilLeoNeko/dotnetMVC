namespace dotNetFrameworkMVC_MoshProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name,Genre_Id,ReleaseDate,AddedDate,NumberInStock) Values ('Hangover',5,CAST('2009-11-06' AS DATETIME),CAST('2019-12-09' AS DATETIME),5)");
            Sql("INSERT INTO Movies (Name,Genre_Id,ReleaseDate,AddedDate,NumberInStock) Values ('Die Hard',1,CAST('1988-10-06' AS DATETIME),CAST('2019-12-09' AS DATETIME),5)");
            Sql("INSERT INTO Movies (Name,Genre_Id,ReleaseDate,AddedDate,NumberInStock) Values ('The Terminator',1,CAST('1984-12-20' AS DATETIME),CAST('2019-12-09' AS DATETIME),5)");
            Sql("INSERT INTO Movies (Name,Genre_Id,ReleaseDate,AddedDate,NumberInStock) Values ('Toy Story',3,CAST('1995-12-07' AS DATETIME),CAST('2019-12-09' AS DATETIME),5)");
            Sql("INSERT INTO Movies (Name,Genre_Id,ReleaseDate,AddedDate,NumberInStock) Values ('Titanic',4,CAST('1997-12-17' AS DATETIME),CAST('2019-12-09' AS DATETIME),5)");
        }
        
        public override void Down()
        {
        }
    }
}
