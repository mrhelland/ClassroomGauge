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
        }

        private void CreateNewWeek_Load(object sender, EventArgs e) {

        }

        private void ChooseThisWeek() {
            
        }

        private void btnThisWeekAllCourses_Click(object sender, EventArgs e) {
            UpdatePresetButtons((Button)sender);
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

        private void btnThisWeekSomeCourses_Click(object sender, EventArgs e) {
            UpdatePresetButtons((Button)sender);
        }

        private void btnOtherWeekAllCourses_Click(object sender, EventArgs e) {
            UpdatePresetButtons((Button)sender);
        }

        private void btnOtherWeekSomeCourses_Click(object sender, EventArgs e) {
            UpdatePresetButtons((Button)sender);
        }
    }
}
