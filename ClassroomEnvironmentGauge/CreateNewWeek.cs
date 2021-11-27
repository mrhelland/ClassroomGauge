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
    public partial class CreateNewWeek : Form {

        public CreateNewWeek() {
            InitializeComponent();
            cvCourses.ReadOnly = true;
            dtpStartDate.Value = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
            cvCourses.Courses = CourseSection.GetCourses();
        }

        private void CreateNewWeek_Load(object sender, EventArgs e) {

        }

        private void btnThisWeekAllCourses_Click(object sender, EventArgs e) {
            UpdatePresetButtons((Button)sender);
            dtpStartDate.Value = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
            dtpStartDate.Enabled = false;
            cvCourses.ReadOnly = true;
            cvCourses.SelectAll();
            SetCheckBoxesChecked(true);
            SetCheckBoxesEnabled(true);

        }

        private void btnThisWeekSomeCourses_Click(object sender, EventArgs e) {
            UpdatePresetButtons((Button)sender);
            dtpStartDate.Value = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
            dtpStartDate.Enabled = false;
            cvCourses.ReadOnly = true;
            cvCourses.SelectNone();
            SetCheckBoxesChecked(true);
            SetCheckBoxesEnabled(true);
        }

        private void btnOtherWeekAllCourses_Click(object sender, EventArgs e) {
            UpdatePresetButtons((Button)sender);
            dtpStartDate.Enabled = true;
            cvCourses.ReadOnly = true;
            cvCourses.SelectAll();
            SetCheckBoxesChecked(true);
            SetCheckBoxesEnabled(true);
        }

        private void btnOtherWeekSomeCourses_Click(object sender, EventArgs e) {
            UpdatePresetButtons((Button)sender);
            dtpStartDate.Enabled = true;
            cvCourses.ReadOnly = true;
            cvCourses.SelectNone();
            SetCheckBoxesChecked(true);
            SetCheckBoxesEnabled(true);
        }

        private List<DayOfWeek> GetSelectedDays() {
            List<DayOfWeek> dow = new List<DayOfWeek>();
            if(chkMon.Checked) {
                dow.Add(DayOfWeek.Monday);
            }
            if(chkTue.Checked) {
                dow.Add(DayOfWeek.Tuesday);
            }
            if(chkWed.Checked) {
                dow.Add(DayOfWeek.Wednesday);
            }
            if(chkThu.Checked) {
                dow.Add(DayOfWeek.Thursday);
            }
            if(chkFri.Checked) {
                dow.Add(DayOfWeek.Friday);
            }
            return dow;
        }

        private void UpdatePresetButtons(Button sender) {
            foreach(Control c in splitContainer1.Panel1.Controls) {
                if(c is Button) {
                    Button b = c as Button;
                    b.FlatAppearance.BorderColor = Color.Black;
                    b.FlatAppearance.BorderSize = 1;
                }
            }
            sender.FlatAppearance.BorderColor = ControlPaint.Dark(sender.BackColor);
            sender.FlatAppearance.BorderSize = 5;
        }


        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e) {

        }

        private void SetCheckBoxesEnabled(bool isEnabled) {
            chkMon.Enabled = isEnabled;
            chkTue.Enabled = isEnabled;
            chkWed.Enabled = isEnabled;
            chkThu.Enabled = isEnabled;
            chkFri.Enabled = isEnabled;
        }

        private void SetCheckBoxesChecked(bool isChecked) {
            chkMon.Checked = isChecked;
            chkTue.Checked = isChecked;
            chkWed.Checked = isChecked;
            chkThu.Checked = isChecked;
            chkFri.Checked = isChecked;

        }
    }
}
