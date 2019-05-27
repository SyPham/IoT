using IoTProject.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTProject.Model.dao
{
    public class MaxCycleTimeDao
    {
        WebApiDbContext db = null;
        public MaxCycleTimeDao()
        {
            db = new WebApiDbContext();
        }
        public List<MaxCycleTime> GetAll ()
        {
            return db.MaxCycleTimes.ToList();
        }
        public List<Arduino> ListArduinosViaIndex(int index)
        {
            return db.Arduinoes.Where(x => x.ADIndex == index).ToList();
        }

    }
}
