
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnThisWeekAllCourses = new System.Windows.Forms.Button();
            this.btnThisWeekSomeCourses = new System.Windows.Forms.Button();
            this.btnOtherWeekAllCourses = new System.Windows.Forms.Button();
            this.btnOtherWeekSomeCourses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.coursesView1 = new ClassroomEnvironmentGauge.CoursesView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnOtherWeekSomeCourses);
            this.splitContainer1.Panel1.Controls.Add(this.btnOtherWeekAllCourses);
            this.splitContainer1.Panel1.Controls.Add(this.btnThisWeekSomeCourses);
            this.splitContainer1.Panel1.Controls.Add(this.btnThisWeekAllCourses);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel2.Controls.Add(this.coursesView1);
            this.splitContainer1.Size = new System.Drawing.Size(911, 579);
            this.splitContainer1.SplitterDistance = 303;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnThisWeekAllCourses
            // 
            this.btnThisWeekAllCourses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThisWeekAllCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThisWeekAllCourses.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnThisWeekAllCourses.FlatAppearance.BorderSize = 5;
            this.btnThisWeekAllCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThisWeekAllCourses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisWeekAllCourses.Location = new System.Drawing.Point(8, 59);
            this.btnThisWeekAllCourses.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.btnThisWeekAllCourses.Name = "btnThisWeekAllCourses";
            this.btnThisWeekAllCourses.Size = new System.Drawing.Size(287, 78);
            this.btnThisWeekAllCourses.TabIndex = 0;
            this.btnThisWeekAllCourses.Text = "This Week (All Courses)";
            this.btnThisWeekAllCourses.UseVisualStyleBackColor = false;
            this.btnThisWeekAllCourses.Click += new System.EventHandler(this.btnThisWeekAllCourses_Click);
            // 
            // btnThisWeekSomeCourses
            // 
            this.btnThisWeekSomeCourses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThisWeekSomeCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThisWeekSomeCourses.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnThisWeekSomeCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThisWeekSomeCourses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisWeekSomeCourses.Location = new System.Drawing.Point(8, 143);
            this.btnThisWeekSomeCourses.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.btnThisWeekSomeCourses.Name = "btnThisWeekSomeCourses";
            this.btnThisWeekSomeCourses.Size = new System.Drawing.Size(287, 78);
            this.btnThisWeekSomeCourses.TabIndex = 1;
            this.btnThisWeekSomeCourses.Text = "This Week (Choose Courses)";
            this.btnThisWeekSomeCourses.UseVisualStyleBackColor = false;
            this.btnThisWeekSomeCourses.Click += new System.EventHandler(this.btnThisWeekSomeCourses_Click);
            // 
            // btnOtherWeekAllCourses
            // 
            this.btnOtherWeekAllCourses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOtherWeekAllCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOtherWeekAllCourses.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOtherWeekAllCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtherWeekAllCourses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtherWeekAllCourses.Location = new System.Drawing.Point(8, 227);
            this.btnOtherWeekAllCourses.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.btnOtherWeekAllCourses.Name = "btnOtherWeekAllCourses";
            this.btnOtherWeekAllCourses.Size = new System.Drawing.Size(287, 78);
            this.btnOtherWeekAllCourses.TabIndex = 2;
            this.btnOtherWeekAllCourses.Text = "Custom Week (All Courses)";
            this.btnOtherWeekAllCourses.UseVisualStyleBackColor = false;
            this.btnOtherWeekAllCourses.Click += new System.EventHandler(this.btnOtherWeekAllCourses_Click);
            // 
            // btnOtherWeekSomeCourses
            // 
            this.btnOtherWeekSomeCourses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOtherWeekSomeCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOtherWeekSomeCourses.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOtherWeekSomeCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtherWeekSomeCourses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtherWeekSomeCourses.Location = new System.Drawing.Point(8, 311);
            this.btnOtherWeekSomeCourses.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.btnOtherWeekSomeCourses.Name = "btnOtherWeekSomeCourses";
            this.btnOtherWeekSomeCourses.Size = new System.Drawing.Size(287, 78);
            this.btnOtherWeekSomeCourses.TabIndex = 3;
            this.btnOtherWeekSomeCourses.Text = "Custom Week (Choose Courses)";
            this.btnOtherWeekSomeCourses.UseVisualStyleBackColor = false;
            this.btnOtherWeekSomeCourses.Click += new System.EventHandler(this.btnOtherWeekSomeCourses_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quick Presets";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 25);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // coursesView1
            // 
            this.coursesView1.AllowSelection = true;
            this.coursesView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coursesView1.BackColor = System.Drawing.Color.Transparent;
            this.coursesView1.Courses = null;
            this.coursesView1.Location = new System.Drawing.Point(3, 145);
            this.coursesView1.Name = "coursesView1";
            this.coursesView1.ReadOnly = false;
            this.coursesView1.Size = new System.Drawing.Size(596, 430);
            this.coursesView1.TabIndex = 0;
            // 
            // CreateNewWeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 579);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CreateNewWeek";
            this.Text = "Create New Week";
            this.Load += new System.EventHandler(this.CreateNewWeek_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CoursesView coursesView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOtherWeekSomeCourses;
        private System.Windows.Forms.Button btnOtherWeekAllCourses;
        private System.Windows.Forms.Button btnThisWeekSomeCourses;
        private System.Windows.Forms.Button btnThisWeekAllCourses;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}