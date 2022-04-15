namespace homework_theme_18
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orders
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string ClientEmail { get; set; }

        public int IdProduct { get; set; }

        [Required]
        public string ProductName { get; set; }

        public int Quantity { get; set; }
    }
}
