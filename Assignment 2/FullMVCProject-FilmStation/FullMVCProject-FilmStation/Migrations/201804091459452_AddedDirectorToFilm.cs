namespace FullMVCProject_FilmStation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDirectorToFilm : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "Director", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "Director");
        }
    }
}
