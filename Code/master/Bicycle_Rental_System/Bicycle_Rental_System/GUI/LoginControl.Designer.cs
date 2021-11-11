namespace Bicycle_Rental_System.GUI
{
    partial class LoginControl
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
            this.label_LoginHeader = new System.Windows.Forms.Label();
            this.label_EmployeeNumber = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_EmployeeNumber = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.label_Info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_LoginHeader
            // 
            this.label_LoginHeader.AutoSize = true;
            this.label_LoginHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LoginHeader.Location = new System.Drawing.Point(48, 17);
            this.label_LoginHeader.Name = "label_LoginHeader";
            this.label_LoginHeader.Size = new System.Drawing.Size(138, 42);
            this.label_LoginHeader.TabIndex = 0;
            this.label_LoginHeader.Text = "LOGIN";
            // 
            // label_EmployeeNumber
            // 
            this.label_EmployeeNumber.AutoSize = true;
            this.label_EmployeeNumber.Location = new System.Drawing.Point(12, 79);
            this.label_EmployeeNumber.Name = "label_EmployeeNumber";
            this.label_EmployeeNumber.Size = new System.Drawing.Size(96, 13);
            this.label_EmployeeNumber.TabIndex = 1;
            this.label_EmployeeNumber.Text = "Employee Number:";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(52, 127);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(56, 13);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Password:";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(114, 120);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(100, 20);
            this.textBox_Password.TabIndex = 2;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // textBox_EmployeeNumber
            // 
            this.textBox_EmployeeNumber.Location = new System.Drawing.Point(114, 79);
            this.textBox_EmployeeNumber.Name = "textBox_EmployeeNumber";
            this.textBox_EmployeeNumber.Size = new System.Drawing.Size(100, 20);
            this.textBox_EmployeeNumber.TabIndex = 1;
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(15, 166);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(199, 23);
            this.button_Login.TabIndex = 3;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Info.ForeColor = System.Drawing.Color.Red;
            this.label_Info.Location = new System.Drawing.Point(12, 202);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(29, 13);
            this.label_Info.TabIndex = 6;
            this.label_Info.Text = "Info";
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_EmployeeNumber);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_EmployeeNumber);
            this.Controls.Add(this.label_LoginHeader);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(232, 229);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_LoginHeader;
        private System.Windows.Forms.Label label_EmployeeNumber;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_EmployeeNumber;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label label_Info;
    }
}
