using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomEnvironmentGauge {
    public class CourseSection {
        private int period;
        private string name;

        public CourseSection(int period, string coursename) {
            this.name = coursename;
            this.period = period;
        }

        public static List<CourseSection> GetCourses() {
            StringCollection courseList = Properties.Settings.Default.CourseList;
            List<CourseSection> sections = new List<CourseSection>();
            foreach(string s in courseList) {
                string[] parts = s.Split('|');
                try {
                    sections.Add(new CourseSection(int.Parse(parts[0]), parts[1]));
                } catch {
                    Console.WriteLine("Could not load the course from string '" + s + "'.");
                }
            }
            return sections;
        }
    }
}
