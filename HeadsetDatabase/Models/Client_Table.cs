namespace HeadsetDatabase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Client_Table
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Client_Id { get; set; }

        public int Shopping_Car_Id { get; set; }

        [Required]
        [StringLength(15)]
        public string Account_Number { get; set; }

        [Required]
        [StringLength(15)]
        public string Password { get; set; }

        public int? Community_Id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Birthday { get; set; }

        [Required]
        [StringLength(15)]
        public string Identity_Card { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [Required]
        [StringLength(20)]
        public string First_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Last_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Mail { get; set; }

        public int Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string FB { get; set; }

        [StringLength(50)]
        public string GooGle { get; set; }
    }
}
