namespace FinalProject.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bag")]
    public partial class Bag
    {
        public int BagId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public int Price { get; set; }

        public int? ManufacturerId { get; set; }

        public bool Available { get; set; }

        [Required]
        [StringLength(200)]
        public string Photo { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }
    }
}
