using FinalProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAL.Repositories
{
    public class RacquetRepository : IGenericRepository<Racquet>
    {
        ShopContext shopContext = new ShopContext();
        public void Add(Racquet item)
        {
            shopContext.Racquet.AddOrUpdate(item);
            shopContext.SaveChanges();
        }

        public void Delete(Racquet item)
        {
            shopContext.Racquet.Remove(item);
            shopContext.SaveChanges();
        }

        public IEnumerable<Racquet> FindBy(Expression<Func<Racquet, bool>> predicate)
        {
            return shopContext.Racquet.Where(predicate);
        }

        public Racquet Get(int id)
        {
            return shopContext.Racquet.Find(id);
        }

        public IEnumerable<Racquet> GetAll()
        {
            return shopContext.Racquet;
        }

        public void Update(Racquet item)
        {
            shopContext.Racquet.AddOrUpdate(item);
            shopContext.SaveChanges();
        }

        ~RacquetRepository() => shopContext.Dispose();
    }
}
