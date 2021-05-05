namespace VidyaCat2.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThreeSeed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Developers",
                c => new
                    {
                        DeveloperID = c.Int(nullable: false, identity: true),
                        DeveloperName = c.String(nullable: false),
                        Region = c.Int(nullable: false),
                        IsMajor = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        GamesDeveloped = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DeveloperID);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameID = c.Int(nullable: false, identity: true),
                        GameTitle = c.String(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        Genre = c.Int(nullable: false),
                        FirstSubgenre = c.Int(nullable: false),
                        SecondSubgenre = c.Int(nullable: false),
                        ThirdSubgenre = c.Int(nullable: false),
                        Rating = c.Int(nullable: false),
                        PlatformID = c.Int(nullable: false),
                        DeveloperID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GameID)
                .ForeignKey("dbo.Developers", t => t.DeveloperID, cascadeDelete: true)
                .ForeignKey("dbo.Platforms", t => t.PlatformID, cascadeDelete: true)
                .Index(t => t.PlatformID)
                .Index(t => t.DeveloperID);
            
            CreateTable(
                "dbo.Platforms",
                c => new
                    {
                        PlatformID = c.Int(nullable: false, identity: true),
                        Brand = c.Int(nullable: false),
                        PlatformName = c.String(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        GamesOnPlatform = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PlatformID);            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Games", "PlatformID", "dbo.Platforms");
            DropForeignKey("dbo.Games", "DeveloperID", "dbo.Developers");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Games", new[] { "DeveloperID" });
            DropIndex("dbo.Games", new[] { "PlatformID" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Platforms");
            DropTable("dbo.Games");
            DropTable("dbo.Developers");
        }
    }
}
