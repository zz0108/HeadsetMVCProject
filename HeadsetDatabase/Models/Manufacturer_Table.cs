namespace HeadsetDatabase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Manufacturer_Table
    {
        [Key]
        public int Manufacturer_Id { get; set; }

        public int Country { get; set; }

        [Required]
        [StringLength(50)]
        public string Manufacturer { get; set; }
    }
}
