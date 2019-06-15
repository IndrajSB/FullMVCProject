namespace FullMVCProject_FilmStation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAddedDateandAgeRating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "AgeRating", c => c.String());
            AlterColumn("dbo.Films", "ReleaseDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Films", "ReleaseDate", c => c.String());
            DropColumn("dbo.Films", "AgeRating");
        }
    }
}
