using System;
using DataAccess.Data.Repository.IRepo;
using Third.DataAccess;

namespace DataAccess.Data.Repository
{
    public class IUnitofWork: IUnitofWorkRepository
    {
        private readonly ApplicationDbContext _db;

        public IUnitofWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
        }

        public ICategoryRepository Category { get; private set; }

        public void Dispose()
        {
            _db.Dispose(); 
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
