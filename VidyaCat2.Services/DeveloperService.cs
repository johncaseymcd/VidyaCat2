using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyaCat2.Data;
using VidyaCat2.Models;

namespace VidyaCat2.Services
{
    public class DeveloperService
    {
        public bool CreateDeveloper(DeveloperCreate model)
        {
            var entity = new Developer
            {
                DeveloperName = model.DeveloperName,
                Region = model.Region,
                IsMajor = model.IsMajor,
                IsActive = model.IsActive
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Developers.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<DeveloperListItem> GetDevelopers()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Developers
                    .Select(d =>
                    new DeveloperListItem
                    {
                        DeveloperID = d.DeveloperID,
                        DeveloperName = d.DeveloperName,
                        Region = d.Region,
                        IsMajor = d.IsMajor,
                        IsActive = d.IsActive
                    });

                return query.ToList();
            }
        }

        public DeveloperDetail GetDeveloperByID(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Developers.Find(id);
                int games = ctx.Games.Where(g => g.DeveloperID == id).Count();

                return new DeveloperDetail
                {
                    DeveloperID = entity.DeveloperID,
                    DeveloperName = entity.DeveloperName,
                    Region = entity.Region,
                    IsMajor = entity.IsMajor,
                    IsActive = entity.IsActive,
                    GamesDeveloped = games
                };
            }
        }

        public IEnumerable<DeveloperListItem> GetDevelopersByRegion(Region region)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Developers
                    .Where(d => d.Region == region)
                    .Select(d =>
                    new DeveloperListItem
                    {
                        DeveloperID = d.DeveloperID,
                        DeveloperName = d.DeveloperName,
                        Region = d.Region,
                        IsMajor = d.IsMajor,
                        IsActive = d.IsActive
                    });

                return query.ToList();
            }
        }

        public IEnumerable<DeveloperListItem> GetDevelopersByStatus(bool status)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Developers
                    .Where(d => d.IsActive == status)
                    .Select(d =>
                    new DeveloperListItem
                    {
                        DeveloperID = d.DeveloperID,
                        DeveloperName = d.DeveloperName,
                        Region = d.Region,
                        IsMajor = d.IsMajor,
                        IsActive = d.IsActive
                    });

                return query.ToList();
            }
        }

        public IEnumerable<DeveloperListItem> GetDevelopersByType(bool type)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Developers
                    .Where(d => d.IsMajor == type)
                    .Select(d =>
                    new DeveloperListItem
                    {
                        DeveloperID = d.DeveloperID,
                        DeveloperName = d.DeveloperName,
                        Region = d.Region,
                        IsMajor = d.IsMajor,
                        IsActive = d.IsActive
                    });

                return query.ToList();
            }
        }

        public bool UpdateDeveloper(DeveloperEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Developers.Find(model.DeveloperID);

                entity.DeveloperName = model.DeveloperName;
                entity.Region = model.Region;
                entity.IsMajor = model.IsMajor;
                entity.IsActive = model.IsActive;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteDeveloper(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Developers.Find(id);
                ctx.Developers.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
