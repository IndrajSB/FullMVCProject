namespace FullMVCProject_FilmStation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        FilmId = c.Int(nullable: false, identity: true),
                        FilmName = c.String(),
                        FilmLength = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FilmId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Films");
        }
    }
}
