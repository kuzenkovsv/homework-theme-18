namespace homework_theme_18
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        public int IdProduct { get; set; }

        [Required]
        [StringLength(20)]
        public string ProductName { get; set; }

        public int Quantity { get; set; }
    }
}
