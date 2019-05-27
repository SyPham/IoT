using IoTProject.API.Models;
using IoTProject.Model.dao;
using IoTProject.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IoTProject.API.Controllers
{
    public class CycleTimesController : ApiController
    {
        [Route("api/maxcycletime")]
        public List<MaxCycleTime> GetMaxCycleTime()
        {
            return new MaxCycleTimeDao().GetAll().ToList();
        }

        [Route("api/arduinoes")]
        public List<CycleTimeViewModel> GetArduinoes()
        {
            var lists = new MaxCycleTimeDao().ListArduinosViaIndex(1);
            var lists2 = new MaxCycleTimeDao().ListArduinosViaIndex(2);
            TimeSpan timeSpan;
            DateTime lDate1;
            DateTime lDate2;
            double sec;
            List<CycleTimeViewModel> listcycleTimeVm = new List<CycleTimeViewModel>();

            double avgSec = 0;
            double totalSec = 0;
            int count = 1;
            int dem = 1;

            foreach (var item2 in lists2)
            {
                lDate2 = item2.DataTime;
                foreach (var item in lists)
                {
                    lDate1 = item.DataTime;
                    if (item2.Seq == item.Seq)
                    {
                        timeSpan = lDate2.Subtract(lDate1);
                        sec = Math.Abs(timeSpan.Seconds);

                        totalSec += sec;
                        avgSec = Math.Round((totalSec / count), 1);

                        CycleTimeViewModel cycleTimeVm = new CycleTimeViewModel();
                        cycleTimeVm.RealTimeCycleTime = sec;
                        cycleTimeVm.AverageTimeCycleTime = avgSec;
                        cycleTimeVm.ID = dem;
                        listcycleTimeVm.Add(cycleTimeVm);
                        dem++;
                        count++;
                    }
                }
            }

            return listcycleTimeVm.ToList();
        }

    }
}
