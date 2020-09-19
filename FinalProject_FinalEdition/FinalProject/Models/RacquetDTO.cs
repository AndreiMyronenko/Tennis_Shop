using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class RacquetDTO
    {
        public int RacquetId { get; set; }
        public string RacquetTitle { get; set; }
        public int Price { get; set; }
        public string Photo { get; set; }
        public int StringSurfaceArea { get; set; }
        public int Weight { get; set; }
        public double Balance { get; set; }
        public bool Available { get; set; }
        public int? ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }
    }
}
