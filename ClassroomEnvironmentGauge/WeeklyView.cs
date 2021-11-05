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
    public partial class WeeklyView : UserControl {

        private DateTime startDate;
        public DateTime StartDate {
            get => startDate;
            set {
                startDate = value;

            }
        }

        private CourseSection section;
        public CourseSection Section {
            get => section;
            set => section = value;
        }

 
        public WeeklyView() {
            startDate = DateTime.MinValue;
            InitializeComponent();
        }

        private void UpdateView() {
            if(startDate == DateTime.MinValue) {
                
            }
        }



    }
}
