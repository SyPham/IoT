using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace IoTProject.Model.EF
{
    [Table("Categories")]
    public partial class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CaregoryID { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        
    }
}
