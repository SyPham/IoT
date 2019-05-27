using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace IoTProject.Model.EF
{
    [Table("CycleTimes")]
    public partial class CycleTime
    {
        [Key]
        public int CycleTimeID { get; set; }

        public double? RealTimeCycleTime { get; set; }

        public double? AverageTimeCycleTime { get; set; }
    }
}
