using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class RacquetStringDTO
    {
        public int RacquetStringId { get; set; }
        public string RacquetStringTitle { get; set; }
        public int Price { get; set; }
        public string Photo { get; set; }
        public int Longitude { get; set; }
        public string Color { get; set; }
        public double Thickness { get; set; }
        public bool Available { get; set; }
        public int? ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }
    }
}
