namespace Bicycle_Rental_System.GUI
{
    partial class MaintainStudentControl
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
            this.button_AddStudent = new System.Windows.Forms.Button();
            this.button_ChangeStudent = new System.Windows.Forms.Button();
            this.button_DeleteStudent = new System.Windows.Forms.Button();
            this.listView_Students = new System.Windows.Forms.ListView();
            this.columnHeader_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button_AddStudent
            // 
            this.button_AddStudent.Location = new System.Drawing.Point(3, 3);
            this.button_AddStudent.Name = "button_AddStudent";
            this.button_AddStudent.Size = new System.Drawing.Size(75, 23);
            this.button_AddStudent.TabIndex = 0;
            this.button_AddStudent.Text = "Add Student";
            this.button_AddStudent.UseVisualStyleBackColor = true;
            this.button_AddStudent.Click += new System.EventHandler(this.button_AddStudent_Click);
            // 
            // button_ChangeStudent
            // 
            this.button_ChangeStudent.Enabled = false;
            this.button_ChangeStudent.Location = new System.Drawing.Point(156, 3);
            this.button_ChangeStudent.Name = "button_ChangeStudent";
            this.button_ChangeStudent.Size = new System.Drawing.Size(100, 23);
            this.button_ChangeStudent.TabIndex = 1;
            this.button_ChangeStudent.Text = "Change Student";
            this.button_ChangeStudent.UseVisualStyleBackColor = true;
            this.button_ChangeStudent.Click += new System.EventHandler(this.button_ChangeStudent_Click);
            // 
            // button_DeleteStudent
            // 
            this.button_DeleteStudent.Enabled = false;
            this.button_DeleteStudent.Location = new System.Drawing.Point(341, 3);
            this.button_DeleteStudent.Name = "button_DeleteStudent";
            this.button_DeleteStudent.Size = new System.Drawing.Size(97, 23);
            this.button_DeleteStudent.TabIndex = 2;
            this.button_DeleteStudent.Text = "Delete Student";
            this.button_DeleteStudent.UseVisualStyleBackColor = true;
            this.button_DeleteStudent.Click += new System.EventHandler(this.button_DeleteStudent_Click);
            // 
            // listView_Students
            // 
            this.listView_Students.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Students.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Number,
            this.columnHeader_Name,
            this.columnHeader_Surname,
            this.columnHeader_Rating});
            this.listView_Students.FullRowSelect = true;
            this.listView_Students.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Students.HideSelection = false;
            this.listView_Students.Location = new System.Drawing.Point(3, 32);
            this.listView_Students.Name = "listView_Students";
            this.listView_Students.Size = new System.Drawing.Size(438, 304);
            this.listView_Students.TabIndex = 3;
            this.listView_Students.UseCompatibleStateImageBehavior = false;
            this.listView_Students.View = System.Windows.Forms.View.Details;
            this.listView_Students.SelectedIndexChanged += new System.EventHandler(this.listView_Students_SelectedIndexChanged);
            // 
            // columnHeader_Number
            // 
            this.columnHeader_Number.Text = "Number";
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "Name";
            // 
            // columnHeader_Surname
            // 
            this.columnHeader_Surname.Text = "Surname";
            // 
            // columnHeader_Rating
            // 
            this.columnHeader_Rating.Text = "Rating";
            // 
            // MaintainStudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView_Students);
            this.Controls.Add(this.button_DeleteStudent);
            this.Controls.Add(this.button_ChangeStudent);
            this.Controls.Add(this.button_AddStudent);
            this.Name = "MaintainStudentControl";
            this.Size = new System.Drawing.Size(441, 338);
            this.EnabledChanged += new System.EventHandler(this.MaintainStudentControl_EnabledChanged);
            this.Resize += new System.EventHandler(this.MaintainStudentControl_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AddStudent;
        private System.Windows.Forms.Button button_ChangeStudent;
        private System.Windows.Forms.Button button_DeleteStudent;
        private System.Windows.Forms.ListView listView_Students;
        private System.Windows.Forms.ColumnHeader columnHeader_Number;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_Surname;
        private System.Windows.Forms.ColumnHeader columnHeader_Rating;
    }
}
