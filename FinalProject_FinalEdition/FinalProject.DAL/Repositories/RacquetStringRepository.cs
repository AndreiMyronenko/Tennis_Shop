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
    public class RacquetStringRepository : IGenericRepository<RacquetString>
    {
        ShopContext shopContext = new ShopContext();
        public void Add(RacquetString item)
        {
            shopContext.RacquetString.Add(item);
            shopContext.SaveChanges();
        }

        public void Delete(RacquetString item)
        {
            shopContext.RacquetString.Remove(item);
            shopContext.SaveChanges();
        }

        public IEnumerable<RacquetString> FindBy(Expression<Func<RacquetString, bool>> predicate)
        {
            return shopContext.RacquetString.Where(predicate).ToList();
        }

        public RacquetString Get(int id)
        {
            return shopContext.RacquetString.Find(id);
        }

        public IEnumerable<RacquetString> GetAll()
        {
            return shopContext.RacquetString.ToList();
        }

        public void Update(RacquetString item)
        {
            shopContext.RacquetString.AddOrUpdate(item);
            shopContext.SaveChanges();
        }

        ~RacquetStringRepository() => shopContext.Dispose();
    }
}
