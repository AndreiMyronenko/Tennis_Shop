namespace FinalProject.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Racquet")]
    public partial class Racquet
    {
        public int RacquetId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public int? ManufacturerId { get; set; }

        [Column(TypeName = "money")]
        public int Price { get; set; }

        public int StringSurfaceArea { get; set; }

        public int Mass { get; set; }

        public double Balance { get; set; }

        public bool Available { get; set; }

        [Required]
        [StringLength(500)]
        public string Photo { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }
    }
}
