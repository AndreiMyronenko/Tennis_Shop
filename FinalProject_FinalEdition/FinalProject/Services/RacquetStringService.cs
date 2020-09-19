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
    class RacquetStringService : IService<RacquetStringDTO>
    { 
            IGenericRepository<RacquetString> repository;
            public RacquetStringService(IGenericRepository<RacquetString> repository)
            {
                this.repository = repository;
            }
            public void Add(RacquetStringDTO item)
            {
                RacquetString racquet = new RacquetString
                {
                    StringId = item.RacquetStringId,
                    Title = item.RacquetStringTitle,
                    Photo = item.Photo,
                    Price = item.Price,
                    Longitude = item.Longitude,
                    Color = item.Color,
                    Thickness = item.Thickness,
                    Available = item.Available,
                    ManufacturerId = item.ManufacturerId
                };
                repository.Add(racquet);
            }

            public void Delete(RacquetStringDTO item)
            {
                var racquetString = repository.Get(item.RacquetStringId);
                repository.Delete(racquetString);
            }

            public IEnumerable<RacquetStringDTO> GetAll()
            {
                return repository.GetAll().Select(x => new RacquetStringDTO
                {
                    RacquetStringId = x.StringId,
                    RacquetStringTitle = x.Title,
                    Photo = x.Photo,
                    Price = x.Price,
                    Longitude = x.Longitude,
                    Color = x.Color,
                    Thickness = x.Thickness,
                    Available = x.Available,
                    ManufacturerId = x.ManufacturerId,
                    ManufacturerName = x.Manufacturer?.ManufacturerName
                });
            }

            public void Update(RacquetStringDTO item)
            {
                foreach (var racquetString in repository.GetAll())
                    if (racquetString.StringId == item.RacquetStringId)
                    {
                        racquetString.Title = item.RacquetStringTitle;
                        racquetString.Photo = item.Photo;
                        racquetString.Price = item.Price;
                        racquetString.Longitude = item.Longitude;
                        racquetString.Color = item.Color;
                        racquetString.Thickness = item.Thickness;
                        racquetString.Available = item.Available;
                        racquetString.ManufacturerId = item.ManufacturerId;
                        repository.Update(racquetString);
                    }
            }
        }
}
