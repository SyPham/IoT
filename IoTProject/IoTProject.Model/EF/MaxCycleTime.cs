using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace IoTProject.Model.EF
{
    [Table("MaxCycleTimes")]
    public partial class MaxCycleTime
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(10)]
        public string Station { get; set; }

        public double Value { get; set; }
    }
}
