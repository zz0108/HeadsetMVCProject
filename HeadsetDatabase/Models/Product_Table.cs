namespace HeadsetDatabase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product_Table
    {
        [Key]
        public int Product_Id { get; set; }

        public int Type_Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Color1 { get; set; }

        [Required]
        public string Picture1 { get; set; }

        public int Quantity1 { get; set; }

        [StringLength(20)]
        public string Color2 { get; set; }

        public string Picture2 { get; set; }

        public int? Quantity2 { get; set; }

        [StringLength(20)]
        public string Color3 { get; set; }

        public string Picture3 { get; set; }

        public int? Quantity3 { get; set; }

        [StringLength(20)]
        public string Color4 { get; set; }

        public string Picture4 { get; set; }

        public int? Quantity4 { get; set; }

        [StringLength(20)]
        public string Color5 { get; set; }

        public string Picture5 { get; set; }

        public int? Quantity5 { get; set; }

        [StringLength(20)]
        public string Color6 { get; set; }

        public string Picture6 { get; set; }

        public int? Quantity6 { get; set; }

        public int Price { get; set; }

        public int Standard_Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Product_Name { get; set; }
    }
}
