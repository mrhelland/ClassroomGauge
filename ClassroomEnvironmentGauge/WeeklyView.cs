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

        private WeeklySummary summary;
        public WeeklySummary Summary {
            get => summary;
            set {
                summary = value;
                UpdateView();
            }
        }


        public WeeklyView() {
            InitializeComponent();
        }



        private void UpdateView() {

        }



    }
}
