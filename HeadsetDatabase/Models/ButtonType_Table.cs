namespace HeadsetDatabase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ButtonType_Table
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ButtonType_Id { get; set; }

        [StringLength(20)]
        public string ButtonType { get; set; }
    }
}
