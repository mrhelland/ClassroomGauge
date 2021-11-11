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


        public CourseEditor() {
            InitializeComponent();
            this.courseView.Courses = CourseSection.GetCourses();
        }

        private void CourseEditor_Load(object sender, EventArgs e) {

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            courseView.SaveChanges();
            this.Close();
        }
    }
}
