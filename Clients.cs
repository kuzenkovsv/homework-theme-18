namespace homework_theme_18
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clients
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string LFMName { get; set; }

        [Required]
        [StringLength(50)]
        public string Telephone { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }
    }
}
