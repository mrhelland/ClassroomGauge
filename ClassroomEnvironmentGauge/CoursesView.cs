using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassroomEnvironmentGauge {
    public partial class CoursesView : UserControl {

        private List<CourseSection> courses;
        public List<CourseSection> Courses {
            get => courses;
            set {
                courses = value;
                this.bsCourses.DataSource = courses;
                this.dgvCourses.DataSource = this.bsCourses;
            }
        }

        private bool isReadOnly = false;
        public bool ReadOnly {
            get => isReadOnly;
            set { 
                isReadOnly = value;
                dgvCourses.ReadOnly = isReadOnly;
            }
        }

        public CoursesView() {
            InitializeComponent();
        }

        public void SaveChanges() {
            courses.Sort((CourseSection A, CourseSection B) => A.Period.CompareTo(B.Period));
            CourseSection.SetCourses(courses);
        }


    }
}
