using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace IoTProject.Model.EF
{
    [Table("Accounts")]
    public partial class Account
    {
        [Key]
        public int AccountID { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Office { get; set; }

        public int CategoryID { get; set; }
    }
}
