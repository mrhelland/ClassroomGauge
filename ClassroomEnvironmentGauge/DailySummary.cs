using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomEnvironmentGauge {

    [System.Configuration.SettingsSerializeAs(System.Configuration.SettingsSerializeAs.Xml)]
    public class DailySummary {
        private List<Observation> observations;
        private List<Observation> Observations {
            get => observations;
            set => observations = value;
        }

        private DateTime date;
        public DateTime Date {
            get => date;
            set => date = value;
        }

        public DailySummary() {
            observations = new List<Observation>();
        }

    }
}
