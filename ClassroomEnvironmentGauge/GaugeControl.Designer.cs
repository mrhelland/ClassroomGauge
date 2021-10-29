
namespace ClassroomEnvironmentGauge {
    partial class GaugeControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pbGauge = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGauge)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGauge
            // 
            this.pbGauge.BackColor = System.Drawing.Color.Transparent;
            this.pbGauge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbGauge.Location = new System.Drawing.Point(0, 0);
            this.pbGauge.Name = "pbGauge";
            this.pbGauge.Size = new System.Drawing.Size(790, 422);
            this.pbGauge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGauge.TabIndex = 0;
            this.pbGauge.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pbGauge);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(790, 422);
            ((System.ComponentModel.ISupportInitialize)(this.pbGauge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGauge;
    }
}
