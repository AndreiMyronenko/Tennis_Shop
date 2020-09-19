using FinalProject.DAL.Models;
using FinalProject.DAL.Repositories;
using FinalProject.Models;
using FinalProject.Services;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Infrastructure
{
    class Module : NinjectModule
    {
        public override void Load()
        {
            Bind<ILogger>().To<FileLogger>();
            Bind<IGenericRepository<Racquet>>().To<RacquetRepository>();
            Bind<IService<RacquetDTO>>().To<RacquetService>();
            Bind<IGenericRepository<Manufacturer>>().To<ManufacturerRepository>();
            Bind<IService<ManufacturerDTO>>().To<ManufacturerService>();
            Bind<IGenericRepository<Bag>>().To<BagRepository>();
            Bind<IService<BagDTO>>().To<BagService>();
            Bind<IGenericRepository<RacquetString>>().To<RacquetStringRepository>();
            Bind<IService<RacquetStringDTO>>().To<RacquetStringService>();
        }
    }
}
