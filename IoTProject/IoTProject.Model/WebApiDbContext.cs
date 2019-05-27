using IoTProject.Model.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTProject.Model
{
    public partial class WebApiDbContext : DbContext
    {
        public WebApiDbContext()
            : base("name=WebApiDbContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Arduino> Arduinoes { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CycleTime> CycleTimes { get; set; }
        public virtual DbSet<MaxCycleTime> MaxCycleTimes { get; set; }
        public virtual DbSet<Error> Errors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
    }
}
