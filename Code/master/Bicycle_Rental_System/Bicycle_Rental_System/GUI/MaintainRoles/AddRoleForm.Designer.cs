namespace Bicycle_Rental_System.GUI.MaintainRoles
{
    partial class AddRoleForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox_RoleDescription = new System.Windows.Forms.MaskedTextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Role Description:";
            // 
            // maskedTextBox_RoleDescription
            // 
            this.maskedTextBox_RoleDescription.Location = new System.Drawing.Point(9, 36);
            this.maskedTextBox_RoleDescription.Name = "maskedTextBox_RoleDescription";
            this.maskedTextBox_RoleDescription.Size = new System.Drawing.Size(150, 20);
            this.maskedTextBox_RoleDescription.TabIndex = 3;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(9, 83);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(150, 23);
            this.button_Add.TabIndex = 4;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // AddRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 130);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.maskedTextBox_RoleDescription);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddRoleForm";
            this.Text = "Add Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_RoleDescription;
        private System.Windows.Forms.Button button_Add;
    }
}