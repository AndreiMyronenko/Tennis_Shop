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
    class ManufacturerService : IService<ManufacturerDTO>
    {
        IGenericRepository<Manufacturer> repository;
        public ManufacturerService(IGenericRepository<Manufacturer> repository)
        {
            this.repository = repository;
        }
        public void Add(ManufacturerDTO item)
        {
            repository.Add(new Manufacturer
            {
                ManufacturerId = item.ManufacturerId,
                ManufacturerName = item.ManufacturerName
            });
        }

        public void Delete(ManufacturerDTO item)
        {
            var manufacturer = repository.Get(item.ManufacturerId);
            repository.Delete(manufacturer);
        }

        public IEnumerable<ManufacturerDTO> GetAll()
        {
            return repository.GetAll().Select(x => new ManufacturerDTO
            {
                ManufacturerId = x.ManufacturerId,
                ManufacturerName = x.ManufacturerName
            });
        }

        public void Update(ManufacturerDTO item)
        {
            foreach (var manufacturer in repository.GetAll())
                if (manufacturer.ManufacturerId == item.ManufacturerId)
                {
                    manufacturer.ManufacturerName = item.ManufacturerName;
                    repository.Update(manufacturer);
                }
        }
    }
}
