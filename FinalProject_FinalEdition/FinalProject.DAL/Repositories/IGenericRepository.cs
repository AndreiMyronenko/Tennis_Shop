using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAL.Repositories
{
    public interface IGenericRepository<T> where T : class, new()
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        void Add(T item);
        void Update(T item);
        void Delete(T item);
    }
}
