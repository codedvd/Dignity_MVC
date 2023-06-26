using Dignity.DataAccess.Repository.IRepository;
using Dignity.Models;
using DignityBook.Models;
using DignityBookApp.DataAccess.Data;

namespace Dignity.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
            _db.Products.Update(obj);
        }
    }
}
