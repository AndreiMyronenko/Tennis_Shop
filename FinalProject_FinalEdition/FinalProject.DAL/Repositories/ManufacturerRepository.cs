using FinalProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace FinalProject.DAL.Repositories
{
    public class ManufacturerRepository : IGenericRepository<Manufacturer>
    {
        ShopContext shopContext = new ShopContext();
        public void Add(Manufacturer item)
        {
            shopContext.Manufacturer.Add(item);
            shopContext.SaveChanges();
        }

        public void Delete(Manufacturer item)
        {
            shopContext.Manufacturer.Remove(item);
            shopContext.SaveChanges();
        }

        public IEnumerable<Manufacturer> FindBy(Expression<Func<Manufacturer, bool>> predicate)
        {
            return shopContext.Manufacturer.Where(predicate).ToList();
        }

        public Manufacturer Get(int id)
        {
            return shopContext.Manufacturer.Find(id);
        }

        public IEnumerable<Manufacturer> GetAll()
        {
            return shopContext.Manufacturer;
        }

        public void Update(Manufacturer item)
        {
            shopContext.Manufacturer.AddOrUpdate(item);
            shopContext.SaveChanges();
        }

        ~ManufacturerRepository() => shopContext.Dispose();
    }
}
