using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyaCat2.Data;
using VidyaCat2.Models;

namespace VidyaCat2.Services
{
    public class GameService
    {
        public bool CreateGame(GameCreate model)
        {
            var entity = new Game()
            {
                GameTitle = model.GameTitle,
                ReleaseDate = model.ReleaseDate,
                Genre = model.Genre,
                FirstSubgenre = model.FirstSubgenre,
                SecondSubgenre = model.SecondSubgenre,
                ThirdSubgenre = model.ThirdSubgenre,
                Rating = model.Rating,
                DeveloperID = model.DeveloperID,
                PlatformID = model.PlatformID
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Games.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<GameListItem> GetGames()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Games
                    .Select(g =>
                    new GameListItem
                    {
                        GameID = g.GameID,
                        GameTitle = g.GameTitle,
                        ReleaseDate = g.ReleaseDate,
                        Genre = g.Genre,
                        Rating = g.Rating,
                        DeveloperID = g.DeveloperID,
                        Developer = g.Developer,
                        PlatformID = g.PlatformID,
                        Platform = g.Platform
                    });

                return query.ToList();
            }
        }

        public GameDetail GetGameByID(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Games.Find(id);
                return new GameDetail
                {
                    GameID = entity.GameID,
                    GameTitle = entity.GameTitle,
                    ReleaseDate = entity.ReleaseDate,
                    Genre = entity.Genre,
                    FirstSubgenre = entity.FirstSubgenre,
                    SecondSubgenre = entity.SecondSubgenre,
                    ThirdSubgenre = entity.ThirdSubgenre,
                    Rating = entity.Rating,
                    DeveloperID = entity.DeveloperID,
                    Developer = entity.Developer,
                    PlatformID = entity.PlatformID,
                    Platform = entity.Platform
                };
            }
        }

        public IEnumerable<GameListItem> GetGamesByDeveloper(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Games
                    .Where(g => g.DeveloperID == id)
                    .Select(g =>
                    new GameListItem
                    {
                        GameID = g.GameID,
                        GameTitle = g.GameTitle,
                        ReleaseDate = g.ReleaseDate,
                        Genre = g.Genre,
                        Rating = g.Rating,
                        DeveloperID = g.DeveloperID,
                        Developer = g.Developer,
                        PlatformID = g.PlatformID,
                        Platform = g.Platform
                    });

                return query.ToList();
            }
        }

        public IEnumerable<GameListItem> GetGamesByPlatform(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Games
                    .Where(g => g.PlatformID == id)
                    .Select(g =>
                    new GameListItem
                    {
                        GameID = g.GameID,
                        GameTitle = g.GameTitle,
                        ReleaseDate = g.ReleaseDate,
                        Genre = g.Genre,
                        Rating = g.Rating,
                        DeveloperID = g.DeveloperID,
                        Developer = g.Developer,
                        PlatformID = g.PlatformID,
                        Platform = g.Platform
                    });

                return query.ToList();
            }
        }

        public IEnumerable<GameListItem> GetGamesByYear(int year)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Games
                    .Where(g => g.ReleaseDate.Year == year)
                    .Select(g =>
                    new GameListItem
                    {
                        GameID = g.GameID,
                        GameTitle = g.GameTitle,
                        ReleaseDate = g.ReleaseDate,
                        Genre = g.Genre,
                        Rating = g.Rating,
                        DeveloperID = g.DeveloperID,
                        Developer = g.Developer,
                        PlatformID = g.PlatformID,
                        Platform = g.Platform
                    });

                return query.ToList();
            }
        }

        public IEnumerable<GameListItem> GetGamesByGenre(Genre genre)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Games
                    .Where(g => g.Genre == genre)
                    .Select(g =>
                    new GameListItem
                    {
                        GameID = g.GameID,
                        GameTitle = g.GameTitle,
                        ReleaseDate = g.ReleaseDate,
                        Genre = g.Genre,
                        Rating = g.Rating,
                        DeveloperID = g.DeveloperID,
                        Developer = g.Developer,
                        PlatformID = g.PlatformID,
                        Platform = g.Platform
                    });

                return query.ToList();
            }
        }

        public IEnumerable<GameListItem> GetGamesByRating(Rating rating)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Games
                    .Where(g => g.Rating == rating)
                    .Select(g =>
                    new GameListItem
                    {
                        GameID = g.GameID,
                        GameTitle = g.GameTitle,
                        ReleaseDate = g.ReleaseDate,
                        Genre = g.Genre,
                        Rating = g.Rating,
                        DeveloperID = g.DeveloperID,
                        Developer = g.Developer,
                        PlatformID = g.PlatformID,
                        Platform = g.Platform
                    });

                return query.ToList();
            }
        }

        public bool UpdateGame(GameEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Games.Find(model.GameID);
                entity.GameTitle = model.GameTitle;
                entity.ReleaseDate = model.ReleaseDate;
                entity.Genre = model.Genre;
                entity.FirstSubgenre = model.FirstSubgenre;
                entity.SecondSubgenre = model.SecondSubgenre;
                entity.ThirdSubgenre = model.ThirdSubgenre;
                entity.Rating = model.Rating;
                entity.PlatformID = model.PlatformID;
                entity.DeveloperID = model.DeveloperID;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteGame(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Games.Find(id);
                ctx.Games.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
