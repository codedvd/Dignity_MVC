using Dignity.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DignityBook.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IProductRepository Product { get; }
        ICategoryRepository Category { get; }
        void Save();
    }
}
