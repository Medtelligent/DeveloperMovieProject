namespace DeveloperMovieProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Action')");
            Sql("INSERT INTO Genres (Name) VALUES ('Documentary')");
            Sql("INSERT INTO Genres (Name) VALUES ('Drama')");
            Sql("INSERT INTO Genres (Name) VALUES ('Romance')");
            Sql("INSERT INTO Genres (Name) VALUES ('Comedy')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres Where Name IN ('Action', 'Documentary', 'Drama', 'Romance', 'Comedy')");
        }
    }
}
