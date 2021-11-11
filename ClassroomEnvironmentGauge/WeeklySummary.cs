using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClassroomEnvironmentGauge {

    [Serializable()]
    public class WeeklySummary {

        public enum Days {
            Monday = 0,
            Tuesday = 1,
            Wednesday = 2,
            Thursday = 3,
            Friday = 4
        };

        private DailySummary[] dailySummaries = new DailySummary[5];
        public DailySummary[] DailySummaries {
            get => dailySummaries;
            set => dailySummaries = value;
        }

        private CourseSection courseSection;
        public CourseSection CourseSection {
            get => courseSection;
            set => courseSection = value;
        }

        public WeeklySummary() {
            this.courseSection = null;
        }

        public WeeklySummary(DateTime includes, CourseSection course) {
            this.courseSection = course;
            DateTime currentday = includes.StartOfWeek(DayOfWeek.Monday);
            for(int i = 0; i < 5; i++) {
                dailySummaries[i] = new DailySummary(currentday);
                currentday = currentday.AddDays(1);
            }
        }

        public override string ToString() {
            return courseSection.ToString() + " - Week of " + GetStartDate().ToShortDateString();
        }

        public DateTime GetStartDate() {
            if(dailySummaries[0] == null) {
                return DateTime.MinValue;
            }
            return dailySummaries[0].Date;
        }

        public override bool Equals(object obj) {
            WeeklySummary ws = obj as WeeklySummary;
            if(ws != null) {
                if(ws.GetStartDate() == this.GetStartDate() && ws.courseSection.Equals(this.courseSection)) {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode() {
            return this.ToString().GetHashCode();
        }


    }
}
