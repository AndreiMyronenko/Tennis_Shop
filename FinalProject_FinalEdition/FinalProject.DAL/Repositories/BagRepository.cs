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
    public class BagRepository : IGenericRepository<Bag>
    {
        ShopContext shopContext = new ShopContext();
        public void Add(Bag item)
        {
            shopContext.Bag.Add(item);
            shopContext.SaveChanges();
        }

        public void Delete(Bag item)
        {
            shopContext.Bag.Remove(item);
            shopContext.SaveChanges();
        }

        public IEnumerable<Bag> FindBy(Expression<Func<Bag, bool>> predicate)
        {
            return shopContext.Bag.Where(predicate).ToList();
        }

        public Bag Get(int id)
        {
            return shopContext.Bag.Find(id);
        }

        public IEnumerable<Bag> GetAll()
        {
            return shopContext.Bag.ToList();
        }

        public void Update(Bag item)
        {
            shopContext.Bag.AddOrUpdate(item);
            shopContext.SaveChanges();
        }

        ~BagRepository() => shopContext.Dispose();
    }
}
