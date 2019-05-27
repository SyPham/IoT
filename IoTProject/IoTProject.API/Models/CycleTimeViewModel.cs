using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IoTProject.API.Models
{
    public class CycleTimeViewModel
    {
        public int ID { get; set; }
        public double RealTimeCycleTime { get; set; }
        public double AverageTimeCycleTime { get; set; }
    }
}