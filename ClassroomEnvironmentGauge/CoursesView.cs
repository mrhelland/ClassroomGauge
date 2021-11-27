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
                dgvCourses.AllowUserToAddRows = !isReadOnly;
            }
        }

        private bool allowSelection = true;
        public bool AllowSelection {
            get => allowSelection;
            set => allowSelection = value;
        }

        public List<CourseSection> SelectedCourses {
            get {
                List<CourseSection> temp = new List<CourseSection>();
                
                foreach(DataGridViewRow dgvr in dgvCourses.SelectedRows) {
                    CourseSection cs = (CourseSection)(dgvr.DataBoundItem);
                    temp.Add(cs);
                }
                return temp;
            }
        }


        public CoursesView() {
            InitializeComponent();
            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void SaveChanges() {
            courses.Sort((CourseSection A, CourseSection B) => A.Period.CompareTo(B.Period));
            CourseSection.SetCourses(courses);
        }

        public void SelectAll() {
            dgvCourses.SelectAll();
        }

        public void SelectNone() {
            dgvCourses.ClearSelection();
        }

        private void dgvCourses_SelectionChanged(object sender, EventArgs e) {
            if(!this.allowSelection) {
                dgvCourses.ClearSelection();
            }
            
        }
    }
}
