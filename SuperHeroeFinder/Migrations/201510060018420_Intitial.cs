namespace SuperHeroeFinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Intitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NumberOfComics = c.Int(nullable: false),
                        NumberOfSeries = c.Int(nullable: false),
                        ProfilePage = c.String(),
                        CharacterType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CharacterTypes", t => t.CharacterType_Id)
                .Index(t => t.CharacterType_Id);
            
            CreateTable(
                "dbo.CharacterTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Characters", "CharacterType_Id", "dbo.CharacterTypes");
            DropIndex("dbo.Characters", new[] { "CharacterType_Id" });
            DropTable("dbo.CharacterTypes");
            DropTable("dbo.Characters");
        }
    }
}
