namespace FullMVCProject_FilmStation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "Language", c => c.String());
            DropColumn("dbo.Films", "Director");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Films", "Director", c => c.String());
            DropColumn("dbo.Films", "Language");
        }
    }
}
