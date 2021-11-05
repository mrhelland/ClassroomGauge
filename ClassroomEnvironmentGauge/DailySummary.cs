using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomEnvironmentGauge {

    [System.Configuration.SettingsSerializeAs(System.Configuration.SettingsSerializeAs.Xml)]
    public class DailySummary {
        public static float START_VALUE = 50f;
        public static float MIN_VALUE = 0f;
        public static float MAX_VALUE = 100f;

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

        public float GetTotalValue() {
            float value = START_VALUE;
            foreach(Observation obs in observations) {
                if(obs.IsPositive)
                    value += obs.Value;
                else
                    value -= obs.Value;
            }
            return value.Clamp(MIN_VALUE, MAX_VALUE);
        }

    }
}
