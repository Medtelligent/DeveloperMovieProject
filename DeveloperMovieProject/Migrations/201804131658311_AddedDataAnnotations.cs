namespace DeveloperMovieProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false));
        }
    }
}
