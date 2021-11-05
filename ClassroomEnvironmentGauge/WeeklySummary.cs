using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.IO;

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
        }

        public WeeklySummary(DateTime includes) {
            DateTime currentday = includes.StartOfWeek(DayOfWeek.Monday);
            for(int i = 0; i < 5; i++) {
                dailySummaries.Add(currentday, new DailySummary());
                currentday = currentday.AddDays(1);                
            }
        }

        public void Save(FileInfo f) {
            // Insert code to set properties and fields of the object.  
            XmlSerializer serializer = new XmlSerializer(typeof(WeeklySummary));
            // To write to a file, create a StreamWriter object.  
            StreamWriter writer = new StreamWriter("myFileName.xml");
            serializer.Serialize(writer, this);
            writer.Close();
        }

        public static WeeklySummary Load(FileInfo f) {
            XmlSerializer serializer = new XmlSerializer(typeof(WeeklySummary));
            FileStream stream = new FileStream(f.FullName, FileMode.Open);
            return (WeeklySummary)serializer.Deserialize(stream);
        }
    }
}
