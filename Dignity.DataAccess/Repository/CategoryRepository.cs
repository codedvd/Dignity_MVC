using Dignity.DataAccess.Repository.IRepository;
using Dignity.Models;
using DignityBookApp.DataAccess.Data;

namespace Dignity.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository 
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
