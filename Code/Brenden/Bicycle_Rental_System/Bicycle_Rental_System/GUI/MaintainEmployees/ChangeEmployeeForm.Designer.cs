namespace Bicycle_Rental_System.GUI.MaintainEmployees
{
    partial class ChangeEmployeeForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_Role = new System.Windows.Forms.ComboBox();
            this.label_Passwords = new System.Windows.Forms.Label();
            this.button_Change = new System.Windows.Forms.Button();
            this.textBox_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_AccessLevel = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label_EmployeeNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AccessLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Role
            // 
            this.comboBox_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Role.FormattingEnabled = true;
            this.comboBox_Role.Location = new System.Drawing.Point(12, 219);
            this.comboBox_Role.Name = "comboBox_Role";
            this.comboBox_Role.Size = new System.Drawing.Size(132, 21);
            this.comboBox_Role.TabIndex = 28;
            // 
            // label_Passwords
            // 
            this.label_Passwords.AutoSize = true;
            this.label_Passwords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Passwords.ForeColor = System.Drawing.Color.Red;
            this.label_Passwords.Location = new System.Drawing.Point(11, 345);
            this.label_Passwords.Name = "label_Passwords";
            this.label_Passwords.Size = new System.Drawing.Size(29, 13);
            this.label_Passwords.TabIndex = 27;
            this.label_Passwords.Text = "Info";
            // 
            // button_Change
            // 
            this.button_Change.Location = new System.Drawing.Point(12, 361);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(132, 23);
            this.button_Change.TabIndex = 26;
            this.button_Change.Text = "Change";
            this.button_Change.UseVisualStyleBackColor = true;
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // textBox_ConfirmPassword
            // 
            this.textBox_ConfirmPassword.Location = new System.Drawing.Point(12, 322);
            this.textBox_ConfirmPassword.Name = "textBox_ConfirmPassword";
            this.textBox_ConfirmPassword.Size = new System.Drawing.Size(132, 20);
            this.textBox_ConfirmPassword.TabIndex = 25;
            this.textBox_ConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Confirm Password:";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(12, 270);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(132, 20);
            this.textBox_Password.TabIndex = 23;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Location = new System.Drawing.Point(12, 120);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(132, 20);
            this.textBox_Surname.TabIndex = 21;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(12, 74);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(132, 20);
            this.textBox_Name.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Role:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Access Level:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name:";
            // 
            // numericUpDown_AccessLevel
            // 
            this.numericUpDown_AccessLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_AccessLevel.Location = new System.Drawing.Point(12, 169);
            this.numericUpDown_AccessLevel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_AccessLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_AccessLevel.Name = "numericUpDown_AccessLevel";
            this.numericUpDown_AccessLevel.Size = new System.Drawing.Size(134, 26);
            this.numericUpDown_AccessLevel.TabIndex = 31;
            this.numericUpDown_AccessLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_AccessLevel.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Number:";
            // 
            // label_EmployeeNumber
            // 
            this.label_EmployeeNumber.AutoSize = true;
            this.label_EmployeeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EmployeeNumber.Location = new System.Drawing.Point(7, 26);
            this.label_EmployeeNumber.Name = "label_EmployeeNumber";
            this.label_EmployeeNumber.Size = new System.Drawing.Size(77, 25);
            this.label_EmployeeNumber.TabIndex = 32;
            this.label_EmployeeNumber.Text = "00000";
            // 
            // ChangeEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(156, 394);
            this.Controls.Add(this.label_EmployeeNumber);
            this.Controls.Add(this.numericUpDown_AccessLevel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_Role);
            this.Controls.Add(this.label_Passwords);
            this.Controls.Add(this.button_Change);
            this.Controls.Add(this.textBox_ConfirmPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Surname);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangeEmployeeForm";
            this.Text = "Change Employee";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AccessLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Role;
        private System.Windows.Forms.Label label_Passwords;
        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.TextBox textBox_ConfirmPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_AccessLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_EmployeeNumber;
    }
}