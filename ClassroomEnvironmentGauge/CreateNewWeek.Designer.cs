
namespace ClassroomEnvironmentGauge {
    partial class CreateNewWeek {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.coursesView1 = new ClassroomEnvironmentGauge.CoursesView();
            this.SuspendLayout();
            // 
            // coursesView1
            // 
            this.coursesView1.Courses = null;
            this.coursesView1.Location = new System.Drawing.Point(13, 13);
            this.coursesView1.Name = "coursesView1";
            this.coursesView1.ReadOnly = false;
            this.coursesView1.Size = new System.Drawing.Size(493, 405);
            this.coursesView1.TabIndex = 0;
            // 
            // CreateNewWeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 617);
            this.Controls.Add(this.coursesView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CreateNewWeek";
            this.Text = "Create New Week";
            this.ResumeLayout(false);

        }

        #endregion

        private CoursesView coursesView1;
    }
}