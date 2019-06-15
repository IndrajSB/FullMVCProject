namespace FullMVCProject_FilmStation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "ReleaseDate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "ReleaseDate");
        }
    }
}
