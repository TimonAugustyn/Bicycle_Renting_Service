namespace Bicycle_Rental_System.GUI
{
    partial class ReportControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Timespan = new System.Windows.Forms.GroupBox();
            this.radioButton_Days = new System.Windows.Forms.RadioButton();
            this.numericUpDown_Time = new System.Windows.Forms.NumericUpDown();
            this.radioButton_Years = new System.Windows.Forms.RadioButton();
            this.radioButton_Months = new System.Windows.Forms.RadioButton();
            this.radioButton_Weeks = new System.Windows.Forms.RadioButton();
            this.listView_Report = new System.Windows.Forms.ListView();
            this.columnHeader_StudentNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_EmployeeNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_TimeRented = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Report = new System.Windows.Forms.Button();
            this.groupBox_Summary = new System.Windows.Forms.GroupBox();
            this.label_TotalStudents = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_AverageTimeRented = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_Best = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_BicycleVariaty = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_TotalRentals = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Timespan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Time)).BeginInit();
            this.groupBox_Summary.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Timespan
            // 
            this.groupBox_Timespan.Controls.Add(this.radioButton_Days);
            this.groupBox_Timespan.Controls.Add(this.numericUpDown_Time);
            this.groupBox_Timespan.Controls.Add(this.radioButton_Years);
            this.groupBox_Timespan.Controls.Add(this.radioButton_Months);
            this.groupBox_Timespan.Controls.Add(this.radioButton_Weeks);
            this.groupBox_Timespan.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Timespan.Name = "groupBox_Timespan";
            this.groupBox_Timespan.Size = new System.Drawing.Size(130, 158);
            this.groupBox_Timespan.TabIndex = 0;
            this.groupBox_Timespan.TabStop = false;
            this.groupBox_Timespan.Text = "Timespan";
            // 
            // radioButton_Days
            // 
            this.radioButton_Days.AutoSize = true;
            this.radioButton_Days.Checked = true;
            this.radioButton_Days.Location = new System.Drawing.Point(6, 65);
            this.radioButton_Days.Name = "radioButton_Days";
            this.radioButton_Days.Size = new System.Drawing.Size(49, 17);
            this.radioButton_Days.TabIndex = 4;
            this.radioButton_Days.TabStop = true;
            this.radioButton_Days.Text = "Days";
            this.radioButton_Days.UseVisualStyleBackColor = true;
            this.radioButton_Days.CheckedChanged += new System.EventHandler(this.radioButton_Times_CheckedChanged);
            // 
            // numericUpDown_Time
            // 
            this.numericUpDown_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Time.Location = new System.Drawing.Point(6, 19);
            this.numericUpDown_Time.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numericUpDown_Time.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Time.Name = "numericUpDown_Time";
            this.numericUpDown_Time.Size = new System.Drawing.Size(112, 40);
            this.numericUpDown_Time.TabIndex = 3;
            this.numericUpDown_Time.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radioButton_Years
            // 
            this.radioButton_Years.AutoSize = true;
            this.radioButton_Years.Location = new System.Drawing.Point(6, 134);
            this.radioButton_Years.Name = "radioButton_Years";
            this.radioButton_Years.Size = new System.Drawing.Size(52, 17);
            this.radioButton_Years.TabIndex = 2;
            this.radioButton_Years.Text = "Years";
            this.radioButton_Years.UseVisualStyleBackColor = true;
            this.radioButton_Years.CheckedChanged += new System.EventHandler(this.radioButton_Times_CheckedChanged);
            // 
            // radioButton_Months
            // 
            this.radioButton_Months.AutoSize = true;
            this.radioButton_Months.Location = new System.Drawing.Point(6, 111);
            this.radioButton_Months.Name = "radioButton_Months";
            this.radioButton_Months.Size = new System.Drawing.Size(60, 17);
            this.radioButton_Months.TabIndex = 1;
            this.radioButton_Months.Text = "Months";
            this.radioButton_Months.UseVisualStyleBackColor = true;
            this.radioButton_Months.CheckedChanged += new System.EventHandler(this.radioButton_Times_CheckedChanged);
            // 
            // radioButton_Weeks
            // 
            this.radioButton_Weeks.AutoSize = true;
            this.radioButton_Weeks.Location = new System.Drawing.Point(6, 88);
            this.radioButton_Weeks.Name = "radioButton_Weeks";
            this.radioButton_Weeks.Size = new System.Drawing.Size(59, 17);
            this.radioButton_Weeks.TabIndex = 0;
            this.radioButton_Weeks.Text = "Weeks";
            this.radioButton_Weeks.UseVisualStyleBackColor = true;
            this.radioButton_Weeks.CheckedChanged += new System.EventHandler(this.radioButton_Times_CheckedChanged);
            // 
            // listView_Report
            // 
            this.listView_Report.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Report.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_StudentNumber,
            this.columnHeader_Model,
            this.columnHeader_EmployeeNumber,
            this.columnHeader_TimeRented});
            this.listView_Report.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Report.HideSelection = false;
            this.listView_Report.Location = new System.Drawing.Point(3, 167);
            this.listView_Report.Name = "listView_Report";
            this.listView_Report.Size = new System.Drawing.Size(714, 394);
            this.listView_Report.TabIndex = 1;
            this.listView_Report.UseCompatibleStateImageBehavior = false;
            this.listView_Report.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_StudentNumber
            // 
            this.columnHeader_StudentNumber.Text = "Student Number";
            // 
            // columnHeader_Model
            // 
            this.columnHeader_Model.Text = "Model";
            // 
            // columnHeader_EmployeeNumber
            // 
            this.columnHeader_EmployeeNumber.Text = "Employee Number";
            this.columnHeader_EmployeeNumber.Width = 117;
            // 
            // columnHeader_TimeRented
            // 
            this.columnHeader_TimeRented.Text = "Time Rented";
            this.columnHeader_TimeRented.Width = 115;
            // 
            // button_Report
            // 
            this.button_Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Report.Location = new System.Drawing.Point(139, 7);
            this.button_Report.Name = "button_Report";
            this.button_Report.Size = new System.Drawing.Size(132, 154);
            this.button_Report.TabIndex = 2;
            this.button_Report.Text = "Report";
            this.button_Report.UseVisualStyleBackColor = true;
            this.button_Report.Click += new System.EventHandler(this.button_Report_Click);
            // 
            // groupBox_Summary
            // 
            this.groupBox_Summary.Controls.Add(this.label_TotalStudents);
            this.groupBox_Summary.Controls.Add(this.label11);
            this.groupBox_Summary.Controls.Add(this.label_AverageTimeRented);
            this.groupBox_Summary.Controls.Add(this.label10);
            this.groupBox_Summary.Controls.Add(this.label_Best);
            this.groupBox_Summary.Controls.Add(this.label6);
            this.groupBox_Summary.Controls.Add(this.label_BicycleVariaty);
            this.groupBox_Summary.Controls.Add(this.label4);
            this.groupBox_Summary.Controls.Add(this.label_TotalRentals);
            this.groupBox_Summary.Controls.Add(this.label1);
            this.groupBox_Summary.Location = new System.Drawing.Point(277, 3);
            this.groupBox_Summary.Name = "groupBox_Summary";
            this.groupBox_Summary.Size = new System.Drawing.Size(440, 158);
            this.groupBox_Summary.TabIndex = 3;
            this.groupBox_Summary.TabStop = false;
            this.groupBox_Summary.Text = "Summary";
            // 
            // label_TotalStudents
            // 
            this.label_TotalStudents.AutoSize = true;
            this.label_TotalStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalStudents.Location = new System.Drawing.Point(156, 29);
            this.label_TotalStudents.Name = "label_TotalStudents";
            this.label_TotalStudents.Size = new System.Drawing.Size(64, 25);
            this.label_TotalStudents.TabIndex = 11;
            this.label_TotalStudents.Text = "0000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(158, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Total Students:";
            // 
            // label_AverageTimeRented
            // 
            this.label_AverageTimeRented.AutoSize = true;
            this.label_AverageTimeRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AverageTimeRented.Location = new System.Drawing.Point(6, 105);
            this.label_AverageTimeRented.Name = "label_AverageTimeRented";
            this.label_AverageTimeRented.Size = new System.Drawing.Size(64, 25);
            this.label_AverageTimeRented.TabIndex = 9;
            this.label_AverageTimeRented.Text = "0000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Average Time Rented:";
            // 
            // label_Best
            // 
            this.label_Best.AutoSize = true;
            this.label_Best.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Best.Location = new System.Drawing.Point(158, 67);
            this.label_Best.Name = "label_Best";
            this.label_Best.Size = new System.Drawing.Size(143, 25);
            this.label_Best.TabIndex = 5;
            this.label_Best.Text = "Model Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Best Performing Bicycle:";
            // 
            // label_BicycleVariaty
            // 
            this.label_BicycleVariaty.AutoSize = true;
            this.label_BicycleVariaty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BicycleVariaty.Location = new System.Drawing.Point(6, 65);
            this.label_BicycleVariaty.Name = "label_BicycleVariaty";
            this.label_BicycleVariaty.Size = new System.Drawing.Size(64, 25);
            this.label_BicycleVariaty.TabIndex = 3;
            this.label_BicycleVariaty.Text = "0000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bicycle Variaty:";
            // 
            // label_TotalRentals
            // 
            this.label_TotalRentals.AutoSize = true;
            this.label_TotalRentals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalRentals.Location = new System.Drawing.Point(6, 29);
            this.label_TotalRentals.Name = "label_TotalRentals";
            this.label_TotalRentals.Size = new System.Drawing.Size(64, 25);
            this.label_TotalRentals.TabIndex = 1;
            this.label_TotalRentals.Text = "0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Rentals:";
            // 
            // ReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_Summary);
            this.Controls.Add(this.button_Report);
            this.Controls.Add(this.listView_Report);
            this.Controls.Add(this.groupBox_Timespan);
            this.Name = "ReportControl";
            this.Size = new System.Drawing.Size(720, 564);
            this.EnabledChanged += new System.EventHandler(this.ReportControl_EnabledChanged);
            this.Resize += new System.EventHandler(this.ReportControl_Resize);
            this.groupBox_Timespan.ResumeLayout(false);
            this.groupBox_Timespan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Time)).EndInit();
            this.groupBox_Summary.ResumeLayout(false);
            this.groupBox_Summary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Timespan;
        private System.Windows.Forms.RadioButton radioButton_Days;
        private System.Windows.Forms.NumericUpDown numericUpDown_Time;
        private System.Windows.Forms.RadioButton radioButton_Years;
        private System.Windows.Forms.RadioButton radioButton_Months;
        private System.Windows.Forms.RadioButton radioButton_Weeks;
        private System.Windows.Forms.ListView listView_Report;
        private System.Windows.Forms.ColumnHeader columnHeader_StudentNumber;
        private System.Windows.Forms.ColumnHeader columnHeader_Model;
        private System.Windows.Forms.ColumnHeader columnHeader_EmployeeNumber;
        private System.Windows.Forms.ColumnHeader columnHeader_TimeRented;
        private System.Windows.Forms.Button button_Report;
        private System.Windows.Forms.GroupBox groupBox_Summary;
        private System.Windows.Forms.Label label_TotalStudents;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_AverageTimeRented;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_Best;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_BicycleVariaty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_TotalRentals;
        private System.Windows.Forms.Label label1;
    }
}
