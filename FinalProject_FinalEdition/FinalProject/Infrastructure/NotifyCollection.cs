using FinalProject.DAL.Repositories;
using FinalProject.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Infrastructure
{
    public class NotifyCollection<T> : ObservableCollection<T> where T : class
    {
        IService<T> service;

        public NotifyCollection(IService<T> service)
        {
            this.service = service;
            foreach (var i in service.GetAll())
                base.Add(i);
        }

        public new void Remove(T item)
        {
            base.Remove(item);
            service.Delete(item);
        }
        public void Adding(T newItem)
        {
            base.Add(newItem);
            service.Add(newItem);
        }

        public void Update(T newItem)
        {
            service.Update(newItem);
        }
    }
}
