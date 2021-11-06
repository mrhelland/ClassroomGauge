using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClassroomEnvironmentGauge {

    [Serializable()]
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
            startDate = DateTime.MinValue;
        }

        public WeeklySummary(DateTime includes, CourseSection course) {
            this.courseSection = course;
            DateTime currentday = includes.StartOfWeek(DayOfWeek.Monday);
            for(int i = 0; i < 5; i++) {
                dailySummaries.Add(currentday, new DailySummary());
                currentday = currentday.AddDays(1);                
            }
        }

        public override string ToString() {
            return courseSection.ToString() + " - Week of " + startDate.ToShortDateString();
        }

        public override bool Equals(object obj) {
            WeeklySummary ws = obj as WeeklySummary;
            if(ws != null) {
                if(ws.startDate == this.startDate && ws.courseSection.Equals(this.courseSection)) {
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
