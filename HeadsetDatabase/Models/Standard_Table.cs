namespace HeadsetDatabase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Standard_Table
    {
        [Key]
        public int Standard_Id { get; set; }

        [StringLength(20)]
        public string Anyi_Noise { get; set; }

        [StringLength(20)]
        public string Impedance { get; set; }

        [StringLength(200)]
        public string Seneitivity { get; set; }

        [StringLength(200)]
        public string Size { get; set; }

        [StringLength(200)]
        public string Monomer { get; set; }

        [StringLength(200)]
        public string Frequency { get; set; }

        [StringLength(50)]
        public string Endurance { get; set; }

        public int ButtonType_Id { get; set; }
    }
}
