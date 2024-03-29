﻿using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomEnvironmentGauge {

    [Serializable()]
    public class CourseSection {
        
        private string name;
        public string Name {
            get => name;
            set {
                if(value != null)
                    name = value.Trim();
                else
                    name = value;
            }
        }

        private int period;
        public int Period {
            get => period;
            set => period = value;
        }

        public CourseSection() {
            this.name = "undefined";
            this.period = 0;
        }

        public CourseSection(int period, string coursename) {
            this.name = coursename.Trim();
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

        public static void SetCourses(List<CourseSection> courseList) {
            StringCollection sc = new StringCollection();

            foreach(CourseSection c in courseList) {
                string temp = c.period.ToString() + "|" + c.name;
                sc.Add(temp);
            }
            Properties.Settings.Default.CourseList = sc;
            Properties.Settings.Default.Save();
        }

        public override string ToString() {
            return "Per " + period.ToString() + " - " + name;
        }

        public override int GetHashCode() {
            if(name != null) {
                return (period.ToString() + name.ToLower().Trim()).GetHashCode();
            } else {
                return period.ToString().GetHashCode();
            }
        }

        public override bool Equals(object obj) {
            CourseSection cs = obj as CourseSection;
            if(cs != null) {
                if(this.name.ToLower().Equals(cs.name.ToLower()) && this.period == cs.period) {
                    return true;
                }
            }
            return false;
        }
    }
}
