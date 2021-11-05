using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomEnvironmentGauge {

    [System.Configuration.SettingsSerializeAs(System.Configuration.SettingsSerializeAs.Xml)]
    class Observation {

        private string description;
        public string Description {
            get => description;
            set => description = value;
        }

        private float value;
        public float Value {
            get => value;
            set => this.value = value;
        }

        private bool isPositive;
        public bool IsPositive {
            get => isPositive;
            set => isPositive = value;
        }

        private DateTime time;
        public DateTime Time {
            get => time;
            set => time = value;
        }

        public Observation() {
            this.time = DateTime.Now;
            this.description = "No Description.";
            this.isPositive = true;
            this.value = 0;

        }

        public Observation(DateTime time, string description, bool isPositive, float value) {
            this.time = time;
            this.description = description;
            this.isPositive = isPositive;
            this.value = value;
        }

    }
}
