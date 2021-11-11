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
    public partial class CourseEditor : Form {

        private List<CourseSection> courses;

        public CourseEditor() {
            courses = CourseSection.GetCourses();
            InitializeComponent();
            this.bsCourses.DataSource = courses;
            this.dgvCourses.DataSource = this.bsCourses;
        }

        private void CourseEditor_Load(object sender, EventArgs e) {

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            courses.Sort((CourseSection A, CourseSection B) => A.Period.CompareTo(B.Period));
            CourseSection.SetCourses(courses);
            this.Close();
        }
    }
}
