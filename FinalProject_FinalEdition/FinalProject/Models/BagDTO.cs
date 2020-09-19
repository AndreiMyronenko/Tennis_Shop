using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class BagDTO
    {
        public int BagId { get; set; }
        public string BagTitle { get; set; }
        public int Price { get; set; }
        public string Photo { get; set; }
        public int? ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }
        public bool Available { get; set; }
    }
}
