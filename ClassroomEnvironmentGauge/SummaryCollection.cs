using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomEnvironmentGauge {

    [Obsolete()]
    public class SummaryCollection {

        private List<WeeklySummary> weeklySummaries;
        public List<WeeklySummary> WeeklySummaries {
            get => weeklySummaries;
            set => weeklySummaries = value;
        }

        public SummaryCollection() {
            this.weeklySummaries = new List<WeeklySummary>();
        }

        public void AddSummary() {
            
        }


    }
}
