namespace Bicycle_Rental_System.GUI.MaintainEmployees
{
    partial class MaintainEmployeeControl
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
            this.button_AddEmployee = new System.Windows.Forms.Button();
            this.button_ChangeEmployee = new System.Windows.Forms.Button();
            this.button_DeleteEmployee = new System.Windows.Forms.Button();
            this.listView_Employees = new System.Windows.Forms.ListView();
            this.columnHeader_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_AccessLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_RoleID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button_AddEmployee
            // 
            this.button_AddEmployee.Location = new System.Drawing.Point(4, 4);
            this.button_AddEmployee.Name = "button_AddEmployee";
            this.button_AddEmployee.Size = new System.Drawing.Size(93, 23);
            this.button_AddEmployee.TabIndex = 0;
            this.button_AddEmployee.Text = "Add Employee";
            this.button_AddEmployee.UseVisualStyleBackColor = true;
            this.button_AddEmployee.Click += new System.EventHandler(this.button_AddEmployee_Click);
            // 
            // button_ChangeEmployee
            // 
            this.button_ChangeEmployee.Enabled = false;
            this.button_ChangeEmployee.Location = new System.Drawing.Point(181, 3);
            this.button_ChangeEmployee.Name = "button_ChangeEmployee";
            this.button_ChangeEmployee.Size = new System.Drawing.Size(114, 23);
            this.button_ChangeEmployee.TabIndex = 1;
            this.button_ChangeEmployee.Text = "Change Employee";
            this.button_ChangeEmployee.UseVisualStyleBackColor = true;
            this.button_ChangeEmployee.Click += new System.EventHandler(this.button_ChangeEmployee_Click);
            // 
            // button_DeleteEmployee
            // 
            this.button_DeleteEmployee.Enabled = false;
            this.button_DeleteEmployee.Location = new System.Drawing.Point(361, 4);
            this.button_DeleteEmployee.Name = "button_DeleteEmployee";
            this.button_DeleteEmployee.Size = new System.Drawing.Size(99, 23);
            this.button_DeleteEmployee.TabIndex = 2;
            this.button_DeleteEmployee.Text = "Delete Employee";
            this.button_DeleteEmployee.UseVisualStyleBackColor = true;
            this.button_DeleteEmployee.Click += new System.EventHandler(this.button_DeleteEmployee_Click);
            // 
            // listView_Employees
            // 
            this.listView_Employees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Employees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Number,
            this.columnHeader_Name,
            this.columnHeader_Surname,
            this.columnHeader_AccessLevel,
            this.columnHeader_RoleID,
            this.columnHeader_Password});
            this.listView_Employees.FullRowSelect = true;
            this.listView_Employees.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Employees.HideSelection = false;
            this.listView_Employees.Location = new System.Drawing.Point(3, 46);
            this.listView_Employees.Name = "listView_Employees";
            this.listView_Employees.Size = new System.Drawing.Size(457, 255);
            this.listView_Employees.TabIndex = 3;
            this.listView_Employees.UseCompatibleStateImageBehavior = false;
            this.listView_Employees.View = System.Windows.Forms.View.Details;
            this.listView_Employees.SelectedIndexChanged += new System.EventHandler(this.listView_Employees_SelectedIndexChanged);
            this.listView_Employees.Resize += new System.EventHandler(this.listView_Employee_Resize);
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
            // columnHeader_AccessLevel
            // 
            this.columnHeader_AccessLevel.Text = "Access Level";
            // 
            // columnHeader_RoleID
            // 
            this.columnHeader_RoleID.Text = "Role ID";
            // 
            // columnHeader_Password
            // 
            this.columnHeader_Password.Text = "Password";
            // 
            // MaintainEmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView_Employees);
            this.Controls.Add(this.button_DeleteEmployee);
            this.Controls.Add(this.button_ChangeEmployee);
            this.Controls.Add(this.button_AddEmployee);
            this.Name = "MaintainEmployeeControl";
            this.Size = new System.Drawing.Size(463, 307);
            this.EnabledChanged += new System.EventHandler(this.MaintainEmployeeControl_EnabledChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AddEmployee;
        private System.Windows.Forms.Button button_ChangeEmployee;
        private System.Windows.Forms.Button button_DeleteEmployee;
        private System.Windows.Forms.ListView listView_Employees;
        private System.Windows.Forms.ColumnHeader columnHeader_Number;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_Surname;
        private System.Windows.Forms.ColumnHeader columnHeader_AccessLevel;
        private System.Windows.Forms.ColumnHeader columnHeader_RoleID;
        private System.Windows.Forms.ColumnHeader columnHeader_Password;
    }
}
