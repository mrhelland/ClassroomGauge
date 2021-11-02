using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomEnvironmentGauge {

    [System.Configuration.SettingsSerializeAs(System.Configuration.SettingsSerializeAs.Xml)]
    public class WeeklySummary {

        private SortedList<DateTime, DailySummary> dailySummaries;
        public SortedList<DateTime, DailySummary> DailySummaries {
            get => dailySummaries;
            set => dailySummaries = value;
        }

        private DateTime startDate;
        public DateTime StartDate {
            get => startDate;
            set => startDate = value;
        }

        private CourseSection courseSection;
        public CourseSection CourseSection {
            get => courseSection;
            set => courseSection = value;
        }

        public WeeklySummary() {
            dailySummaries = new SortedList<DateTime, DailySummary>();
        }
    }
}
