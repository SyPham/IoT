using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace IoTProject.Model.EF
{

    [Table("Arduinoes")]
    public partial class Arduino
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArduinoID { get; set; }

        public int ADIndex { get; set; }

        public DateTime DataTime { get; set; }

        public int Seq { get; set; }
    }
}
