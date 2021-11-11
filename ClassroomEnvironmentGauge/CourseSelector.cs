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
    public partial class CourseSelector : UserControl {

        private List<CourseSection> sections;
        public List<CourseSection> Sections {
            get => sections;
            set => sections = value;
        }

        private CourseSection selected;
        public CourseSection Selected {
            get => selected;
        }

        public CourseSelector() {
            InitializeComponent();
            sections = CourseSection.GetCourses();
            FillComboBox();
            UpdateForm();
        }


        private void FillComboBox() {
            cbCourses.DataSource = sections;
        }

        private void UpdateForm() {
            if(cbCourses.SelectedItem != null) {
                lblCourseName.Text = selected.Name;
                lblPeriod.Text = selected.Period.ToString();
            } else {
                lblCourseName.Text = "No course selected";
                lblPeriod.Text = "No course selected";
            }
        }

        private void cbCourses_SelectedIndexChanged(object sender, EventArgs e) {
            if(cbCourses.SelectedItem != null) {
                selected = (CourseSection)cbCourses.SelectedItem;
            } else {
                selected = null;
            }
            UpdateForm();
            OnCourseSelectionChanged(new EventArgs());
        }

        public event EventHandler CourseSelectionChanged;

        protected virtual void OnCourseSelectionChanged(EventArgs e) {
            EventHandler raiseEvent = CourseSelectionChanged;
            raiseEvent?.Invoke(this, e);
        }


    }
}
