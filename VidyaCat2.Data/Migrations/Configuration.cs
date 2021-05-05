namespace VidyaCat2.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<VidyaCat2.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "VidyaCat2.Data.ApplicationDbContext";
        }

        protected override void Seed(VidyaCat2.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Developers.AddOrUpdate(d => d.DeveloperID,
                new Developer { DeveloperID = 1, DeveloperName = "Nintendo", Region = Region.Asia, IsActive = true, IsMajor = true },
                new Developer { DeveloperID = 2, DeveloperName = "Naughty Dog", Region = Region.North_America, IsActive = true, IsMajor = true },
                new Developer { DeveloperID = 3, DeveloperName = "Heart Machine", Region = Region.North_America, IsActive = true, IsMajor = false },
                new Developer { DeveloperID = 4, DeveloperName = "Croteam", Region = Region.Europe, IsActive = true, IsMajor = false },
                new Developer { DeveloperID = 5, DeveloperName = "Team Bondi", Region = Region.Australia, IsActive = false, IsMajor = false },
                new Developer { DeveloperID = 6, DeveloperName = "Sega", Region = Region.Asia, IsActive = true, IsMajor = true },
                new Developer { DeveloperID = 7, DeveloperName = "Polyphony Digital", Region = Region.Asia, IsActive = true, IsMajor = true },
                new Developer { DeveloperID = 8, DeveloperName = "CD Projekt", Region = Region.Europe, IsActive = true, IsMajor = true },
                new Developer { DeveloperID = 9, DeveloperName = "HAL Laboratory", Region = Region.Asia, IsActive = true, IsMajor = true },
                new Developer { DeveloperID = 10, DeveloperName = "Red Hook Studios", Region = Region.North_America, IsActive = true, IsMajor = false }
            );

            context.Platforms.AddOrUpdate(p => p.PlatformID,
                new Platform { PlatformID = 1, Brand = Brand.Atari, PlatformName = "2600", ReleaseDate = new DateTime(1977, 09, 11) },
                new Platform { PlatformID = 2, Brand = Brand.Nintendo, PlatformName = "Nintendo Entertainment System", ReleaseDate = new DateTime(1985, 10, 18) },
                new Platform { PlatformID = 3, Brand = Brand.Sega, PlatformName = "Genesis", ReleaseDate = new DateTime(1989, 08, 14) },
                new Platform { PlatformID = 4, Brand = Brand.Nintendo, PlatformName = "Super Nintendo Entertainment System", ReleaseDate = new DateTime(1991, 08, 23) },
                new Platform { PlatformID = 5, Brand = Brand.Phillips, PlatformName = "CD-i", ReleaseDate = new DateTime(1991, 12, 03) },
                new Platform { PlatformID = 6, Brand = Brand.Sega, PlatformName = "Saturn", ReleaseDate = new DateTime(1995, 05, 11) },
                new Platform { PlatformID = 7, Brand = Brand.Sony, PlatformName = "PlayStation", ReleaseDate = new DateTime(1995, 09, 09) },
                new Platform { PlatformID = 8, Brand = Brand.Nintendo, PlatformName = "Nintendo 64", ReleaseDate = new DateTime(1996, 09, 29) },
                new Platform { PlatformID = 9, Brand = Brand.Sega, PlatformName = "Dreamcast", ReleaseDate = new DateTime(1999, 09, 09) },
                new Platform { PlatformID = 10, Brand = Brand.PC, PlatformName = "PC", ReleaseDate = new DateTime(1976, 01, 01) },
                new Platform { PlatformID = 11, Brand = Brand.Sony, PlatformName = "PlayStation 2", ReleaseDate = new DateTime(2000, 10, 26) },
                new Platform { PlatformID = 12, Brand = Brand.Nintendo, PlatformName = "GameCube", ReleaseDate = new DateTime(2001, 11, 18) },
                new Platform { PlatformID = 13, Brand = Brand.Microsoft, PlatformName = "Xbox", ReleaseDate = new DateTime(2001, 11, 15) },
                new Platform { PlatformID = 14, Brand = Brand.Sony, PlatformName = "PlayStation 3", ReleaseDate = new DateTime(2006, 11, 17) },
                new Platform { PlatformID = 15, Brand = Brand.Nintendo, PlatformName = "Wii", ReleaseDate = new DateTime(2006, 11, 19) },
                new Platform { PlatformID = 16, Brand = Brand.Microsoft, PlatformName = "Xbox 360", ReleaseDate = new DateTime(2005, 11, 22) },
                new Platform { PlatformID = 17, Brand = Brand.Sony, PlatformName = "PlayStation 4", ReleaseDate = new DateTime(2013, 11, 15) },
                new Platform { PlatformID = 18, Brand = Brand.Nintendo, PlatformName = "Wii U", ReleaseDate = new DateTime(2012, 11, 18) },
                new Platform { PlatformID = 19, Brand = Brand.Microsoft, PlatformName = "Xbox One", ReleaseDate = new DateTime(2013, 11, 22) },
                new Platform { PlatformID = 20, Brand = Brand.Nintendo, PlatformName = "Switch", ReleaseDate = new DateTime(2017, 03, 03) }
            );

            context.Games.AddOrUpdate(g => g.GameID,
                new Game { GameID = 1, GameTitle = "Super Mario World", ReleaseDate = new DateTime(1990, 11, 21), Genre = Genre.Platformer, FirstSubgenre = Subgenre.TwoD, SecondSubgenre = Subgenre.Sixteen_Bit, Rating = Rating.E, DeveloperID = 1, PlatformID = 4 },
                new Game { GameID = 2, GameTitle = "Crash Bandicoot", ReleaseDate = new DateTime(1996, 09, 09), Genre = Genre.Platformer, FirstSubgenre = Subgenre.ThreeD, Rating = Rating.KA, DeveloperID = 2, PlatformID = 7 },
                new Game { GameID = 3, GameTitle = "Hyper Light Drifter", ReleaseDate = new DateTime(2016, 03, 31), Genre = Genre.Adventure, FirstSubgenre = Subgenre.TwoD, SecondSubgenre = Subgenre.Sixteen_Bit, ThirdSubgenre = Subgenre.Indie, Rating = Rating.T, DeveloperID = 3, PlatformID = 10 },
                new Game { GameID = 4, GameTitle = "The Talos Principle", ReleaseDate = new DateTime(2014, 12, 11), Genre = Genre.Puzzle, FirstSubgenre = Subgenre.Open_World, SecondSubgenre = Subgenre.Post_Apocalyptic, ThirdSubgenre = Subgenre.ThreeD, Rating = Rating.E, DeveloperID = 4, PlatformID = 10 },
                new Game { GameID = 5, GameTitle = "L.A. Noire", ReleaseDate = new DateTime(2011, 05, 17), Genre = Genre.Action, FirstSubgenre = Subgenre.Open_World, SecondSubgenre = Subgenre.Third_Person, Rating = Rating.M, DeveloperID = 5, PlatformID = 16 },
                new Game { GameID = 6, GameTitle = "Streets Of Rage", ReleaseDate = new DateTime(1991, 09, 18), Genre = Genre.Action, FirstSubgenre = Subgenre.Beat_Em_Up, SecondSubgenre = Subgenre.TwoD, ThirdSubgenre = Subgenre.Sixteen_Bit, Rating = Rating.NR, DeveloperID = 6, PlatformID = 3 },
                new Game { GameID = 7, GameTitle = "Gran Turismo 4", ReleaseDate = new DateTime(2005, 02, 22), Genre = Genre.Racing, FirstSubgenre = Subgenre.Multiplayer, Rating = Rating.E, DeveloperID = 7, PlatformID = 11 },
                new Game { GameID = 8, GameTitle = "The Witcher", ReleaseDate = new DateTime(2007, 10, 30), Genre = Genre.RPG, FirstSubgenre = Subgenre.Real_Time, SecondSubgenre = Subgenre.Open_World, ThirdSubgenre = Subgenre.Fantasy, Rating = Rating.M, DeveloperID = 8, PlatformID = 10 },
                new Game { GameID = 9, GameTitle = "Earthbound (Mother 2)", ReleaseDate = new DateTime(1995, 06, 05), Genre = Genre.RPG, FirstSubgenre = Subgenre.Turn_Based, SecondSubgenre = Subgenre.Sixteen_Bit, ThirdSubgenre = Subgenre.JRPG, Rating = Rating.KA, DeveloperID = 9, PlatformID = 4 },
                new Game { GameID = 10, GameTitle = "Darkest Dungeon", ReleaseDate = new DateTime(2016, 01, 19), Genre = Genre.RPG, FirstSubgenre = Subgenre.Turn_Based, SecondSubgenre = Subgenre.Art, ThirdSubgenre = Subgenre.TwoD, Rating = Rating.T, DeveloperID = 10, PlatformID = 10 }
            );
        }
    }
}
