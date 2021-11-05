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

    public partial class DailyView : UserControl {

        private DateTime date;
        public DateTime Date {
            get => date;
            set {
                date = value;
                UpdateView();
            }         
        }

        private DailySummary summary;
        public DailySummary Summary {
            get => summary;
            set {
                summary = value;
                UpdateView();
            }
        }

        public new bool Enabled {
            get => ctrlGauge.Enabled;
            set {
                ctrlGauge.Enabled = value;
            }
        }


        public DailyView() {
            InitializeComponent();
            date = DateTime.MinValue;
            ctrlGauge.Enabled = false;
            UpdateView();
        }

        public void UpdateView() {
            if(date == DateTime.MinValue) {
                ctrlGauge.Enabled = false;
                lblDate.Text = "--";
                lblDayOfWeek.Text = "--";
            } else {
                lblDate.Text = date.Date.ToString();
                lblDayOfWeek.Text = date.DayLetter();
            }
            if(summary == null) {
                ctrlGauge.Enabled = false;
            } else {
                ctrlGauge.Enabled = true;
                ctrlGauge.Value = summary.GetTotalValue();
            }
        }


    }
}
