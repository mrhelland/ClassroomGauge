namespace ClassroomEnvironmentGauge {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.weeklyView1 = new ClassroomEnvironmentGauge.WeeklyView();
            this.gaugeControl1 = new ClassroomEnvironmentGauge.GaugeControl();
            this.SuspendLayout();
            // 
            // weeklyView1
            // 
            this.weeklyView1.BackColor = System.Drawing.Color.Transparent;
            this.weeklyView1.Location = new System.Drawing.Point(854, 196);
            this.weeklyView1.MinimumSize = new System.Drawing.Size(150, 0);
            this.weeklyView1.Name = "weeklyView1";
            this.weeklyView1.Size = new System.Drawing.Size(183, 393);
            this.weeklyView1.TabIndex = 1;
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gaugeControl1.BackColor = System.Drawing.Color.Transparent;
            this.gaugeControl1.ImageCount = 80;
            this.gaugeControl1.Location = new System.Drawing.Point(12, 196);
            this.gaugeControl1.MaxValue = 100F;
            this.gaugeControl1.MinValue = 0F;
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(795, 393);
            this.gaugeControl1.TabIndex = 0;
            this.gaugeControl1.Value = 100F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1075, 601);
            this.Controls.Add(this.weeklyView1);
            this.Controls.Add(this.gaugeControl1);
            this.Name = "Form1";
            this.Text = "Classroom Gauge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GaugeControl gaugeControl1;
        private WeeklyView weeklyView1;
    }
}

