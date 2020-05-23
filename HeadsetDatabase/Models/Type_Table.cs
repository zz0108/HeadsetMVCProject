namespace HeadsetDatabase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Type_Table
    {
        [Key]
        [Column(Order = 0)]
        public int Type_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Type { get; set; }
    }
}
