using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ClassroomEnvironmentGauge {

    [Serializable()]
    public class WeeklySummaryCollection {

        private List<WeeklySummary> weeklySummaries;
        public List<WeeklySummary> WeeklySummaries {
            get => weeklySummaries;
            set => weeklySummaries = value;
        }

        private DateTime startDate;
        public DateTime StartDate {
            get => startDate;
            set => startDate = value;
        }

        public WeeklySummaryCollection() {
            this.weeklySummaries = new List<WeeklySummary>();
        }

        public WeeklySummaryCollection(DateTime contains) {
            this.startDate = contains.StartOfWeek(DayOfWeek.Monday);
            this.weeklySummaries = new List<WeeklySummary>();
        }

        public void Save(FileInfo f) {
            // Insert code to set properties and fields of the object.  
            XmlSerializer serializer = new XmlSerializer(typeof(WeeklySummaryCollection));
            // To write to a file, create a StreamWriter object.  
            StreamWriter writer = new StreamWriter(f.FullName);
            serializer.Serialize(writer, this);
            writer.Close();
        }

        public static WeeklySummaryCollection Load(FileInfo f) {
            XmlSerializer serializer = new XmlSerializer(typeof(WeeklySummaryCollection));
            FileStream stream = new FileStream(f.FullName, FileMode.Open);
            return (WeeklySummaryCollection)serializer.Deserialize(stream);
        }

        public override string ToString() {
            return "Weekly Summary Collection for " + startDate.ToShortDateString();
        }

        public bool AddNewCourseSummary(CourseSection course) {
            foreach(WeeklySummary ws in weeklySummaries) {
                if(ws.CourseSection.Equals(course)) {
                    return false;
                }
            }
            weeklySummaries.Add(new WeeklySummary(this.startDate, course));
            return true;
        }

    }
}
