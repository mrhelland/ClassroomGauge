
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOtherWeekSomeCourses = new System.Windows.Forms.Button();
            this.btnOtherWeekAllCourses = new System.Windows.Forms.Button();
            this.btnThisWeekSomeCourses = new System.Windows.Forms.Button();
            this.btnThisWeekAllCourses = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chkFri = new System.Windows.Forms.CheckBox();
            this.chkThu = new System.Windows.Forms.CheckBox();
            this.chkWed = new System.Windows.Forms.CheckBox();
            this.chkTue = new System.Windows.Forms.CheckBox();
            this.chkMon = new System.Windows.Forms.CheckBox();
            this.dtpStartDate = new ClassroomEnvironmentGauge.SizableDateTimePicker();
            this.cvCourses = new ClassroomEnvironmentGauge.CoursesView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer1.Panel2.Controls.Add(this.btnCreate);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.cvCourses);
            this.splitContainer1.Size = new System.Drawing.Size(911, 579);
            this.splitContainer1.SplitterDistance = 303;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
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
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(496, 520);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 47);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(395, 520);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(95, 47);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.chkFri, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkThu, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkWed, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkTue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkMon, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpStartDate, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(594, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // chkFri
            // 
            this.chkFri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFri.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkFri.Checked = true;
            this.chkFri.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFri.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFri.Location = new System.Drawing.Point(475, 53);
            this.chkFri.Name = "chkFri";
            this.chkFri.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.chkFri.Size = new System.Drawing.Size(116, 44);
            this.chkFri.TabIndex = 6;
            this.chkFri.Text = "Fri";
            this.chkFri.UseVisualStyleBackColor = true;
            // 
            // chkThu
            // 
            this.chkThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkThu.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkThu.Checked = true;
            this.chkThu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkThu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThu.Location = new System.Drawing.Point(357, 53);
            this.chkThu.Name = "chkThu";
            this.chkThu.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.chkThu.Size = new System.Drawing.Size(112, 44);
            this.chkThu.TabIndex = 5;
            this.chkThu.Text = "Thu";
            this.chkThu.UseVisualStyleBackColor = true;
            // 
            // chkWed
            // 
            this.chkWed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkWed.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkWed.Checked = true;
            this.chkWed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWed.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWed.Location = new System.Drawing.Point(239, 53);
            this.chkWed.Name = "chkWed";
            this.chkWed.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.chkWed.Size = new System.Drawing.Size(112, 44);
            this.chkWed.TabIndex = 4;
            this.chkWed.Text = "Wed";
            this.chkWed.UseVisualStyleBackColor = true;
            // 
            // chkTue
            // 
            this.chkTue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTue.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkTue.Checked = true;
            this.chkTue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTue.Location = new System.Drawing.Point(121, 53);
            this.chkTue.Name = "chkTue";
            this.chkTue.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.chkTue.Size = new System.Drawing.Size(112, 44);
            this.chkTue.TabIndex = 3;
            this.chkTue.Text = "Tue";
            this.chkTue.UseVisualStyleBackColor = true;
            // 
            // chkMon
            // 
            this.chkMon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkMon.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkMon.Checked = true;
            this.chkMon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMon.Location = new System.Drawing.Point(3, 53);
            this.chkMon.Name = "chkMon";
            this.chkMon.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.chkMon.Size = new System.Drawing.Size(112, 44);
            this.chkMon.TabIndex = 2;
            this.chkMon.Text = "Mon";
            this.chkMon.UseVisualStyleBackColor = true;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.SetColumnSpan(this.dtpStartDate, 5);
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(3, 3);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(588, 29);
            this.dtpStartDate.TabIndex = 7;
            // 
            // cvCourses
            // 
            this.cvCourses.AllowSelection = true;
            this.cvCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cvCourses.BackColor = System.Drawing.Color.Transparent;
            this.cvCourses.Courses = null;
            this.cvCourses.Location = new System.Drawing.Point(3, 145);
            this.cvCourses.Name = "cvCourses";
            this.cvCourses.ReadOnly = false;
            this.cvCourses.Size = new System.Drawing.Size(594, 369);
            this.cvCourses.TabIndex = 0;
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CoursesView cvCourses;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOtherWeekSomeCourses;
        private System.Windows.Forms.Button btnOtherWeekAllCourses;
        private System.Windows.Forms.Button btnThisWeekSomeCourses;
        private System.Windows.Forms.Button btnThisWeekAllCourses;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chkFri;
        private System.Windows.Forms.CheckBox chkThu;
        private System.Windows.Forms.CheckBox chkWed;
        private System.Windows.Forms.CheckBox chkTue;
        private System.Windows.Forms.CheckBox chkMon;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private SizableDateTimePicker dtpStartDate;
    }
}