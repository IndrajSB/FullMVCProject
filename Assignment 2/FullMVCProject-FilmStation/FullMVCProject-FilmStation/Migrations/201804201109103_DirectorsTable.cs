namespace FullMVCProject_FilmStation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DirectorsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "FilmRating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "FilmRating");
        }
    }
}
