using System;
namespace DataAccess.Data.Repository.IRepo
{
    public interface IUnitofWorkRepository : IDisposable
    {
        ICategoryRepository Category { get; }

        void Save(); 
    }
}
