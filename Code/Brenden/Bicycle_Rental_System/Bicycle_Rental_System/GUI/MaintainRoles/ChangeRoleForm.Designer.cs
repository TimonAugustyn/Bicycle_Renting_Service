namespace Bicycle_Rental_System.GUI.MaintainRoles
{
    partial class ChangeRoleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Change = new System.Windows.Forms.Button();
            this.textBox_RoleDescription = new System.Windows.Forms.TextBox();
            this.label_RoleID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Role ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Role Description:";
            // 
            // button_Change
            // 
            this.button_Change.Location = new System.Drawing.Point(12, 123);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(128, 23);
            this.button_Change.TabIndex = 4;
            this.button_Change.Text = "Change";
            this.button_Change.UseVisualStyleBackColor = true;
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // textBox_RoleDescription
            // 
            this.textBox_RoleDescription.Location = new System.Drawing.Point(13, 79);
            this.textBox_RoleDescription.Name = "textBox_RoleDescription";
            this.textBox_RoleDescription.Size = new System.Drawing.Size(127, 20);
            this.textBox_RoleDescription.TabIndex = 5;
            // 
            // label_RoleID
            // 
            this.label_RoleID.AutoSize = true;
            this.label_RoleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RoleID.Location = new System.Drawing.Point(13, 26);
            this.label_RoleID.Name = "label_RoleID";
            this.label_RoleID.Size = new System.Drawing.Size(64, 25);
            this.label_RoleID.TabIndex = 6;
            this.label_RoleID.Text = "0000";
            // 
            // ChangeRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 159);
            this.Controls.Add(this.label_RoleID);
            this.Controls.Add(this.textBox_RoleDescription);
            this.Controls.Add(this.button_Change);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangeRoleForm";
            this.Text = "ChangeRoleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.TextBox textBox_RoleDescription;
        private System.Windows.Forms.Label label_RoleID;
    }
}