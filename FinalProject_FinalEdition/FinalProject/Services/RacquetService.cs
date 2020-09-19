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
    public class RacquetService : IService<RacquetDTO>
    {
        IGenericRepository<Racquet> repository;
        public RacquetService(IGenericRepository<Racquet> repository)
        {
            this.repository = repository;
        }
        public void Add(RacquetDTO item)
        {
            Racquet racquet = new Racquet
            {
                RacquetId = item.RacquetId,
                Title = item.RacquetTitle,
                Photo = item.Photo,
                Price = item.Price,
                StringSurfaceArea=item.StringSurfaceArea,
                Mass = item.Weight,
                Balance = item.Balance,
                Available = item.Available,
                ManufacturerId = item.ManufacturerId
            };
            repository.Add(racquet);
        }

        public void Delete(RacquetDTO item)
        {
            var racquet = repository.Get(item.RacquetId);
            repository.Delete(racquet);
        }

        public IEnumerable<RacquetDTO> GetAll()
        {
            return repository.GetAll().Select(x => new RacquetDTO
            {
                RacquetId = x.RacquetId,
                RacquetTitle = x.Title,
                Photo = x.Photo,
                Price = x.Price,
                StringSurfaceArea = x.StringSurfaceArea,
                Weight = x.Mass,
                Balance = x.Balance,
                Available = x.Available,
                ManufacturerId = x.ManufacturerId,
                ManufacturerName = x.Manufacturer?.ManufacturerName
            });
        }

        public void Update(RacquetDTO item)
        {
            foreach (var racquet in repository.GetAll())
                if (racquet.RacquetId == item.RacquetId)
                {
                    racquet.Title = item.RacquetTitle;
                    racquet.Photo = item.Photo;
                    racquet.Price = item.Price;
                    racquet.StringSurfaceArea = item.StringSurfaceArea;
                    racquet.Mass = item.Weight;
                    racquet.Balance = item.Balance;
                    racquet.Available = item.Available;
                    racquet.ManufacturerId = item.ManufacturerId;
                    repository.Update(racquet);
                }
        }
    }
}
