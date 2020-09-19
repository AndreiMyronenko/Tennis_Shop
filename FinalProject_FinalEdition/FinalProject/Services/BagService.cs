using FinalProject.DAL.Models;
using FinalProject.DAL.Repositories;
using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Services
{
    public class BagService : IService<BagDTO>
    {
        IGenericRepository<Bag> repository;
        public BagService(IGenericRepository<Bag> repository)
        {
            this.repository = repository;
        }
        public void Add(BagDTO item)
        {
            Bag bag = new Bag
            {
                BagId = item.BagId,
                Title = item.BagTitle,
                Photo = item.Photo,
                Price = item.Price,
                Available = item.Available,
                ManufacturerId = item.ManufacturerId
            };
            repository.Add(bag);
        }

        public void Delete(BagDTO item)
        {
            var bag = repository.Get(item.BagId);
            repository.Delete(bag);
        }

        public IEnumerable<BagDTO> GetAll()
        {
            return repository.GetAll().Select(x => new BagDTO
            {
                BagId = x.BagId,
                BagTitle = x.Title,
                Photo = x.Photo,
                Price = x.Price,
                Available = x.Available,
                ManufacturerId = x.ManufacturerId,
                ManufacturerName = x.Manufacturer?.ManufacturerName
            });
        }

        public void Update(BagDTO item)
        {
            foreach (var bag in repository.GetAll())
                if (bag.BagId == item.BagId)
                {
                    bag.Title = item.BagTitle;
                    bag.Photo = item.Photo;
                    bag.Price = item.Price;
                    bag.Available = item.Available;
                    bag.ManufacturerId = item.ManufacturerId;
                    repository.Update(bag);
                }
        }
    }
}
