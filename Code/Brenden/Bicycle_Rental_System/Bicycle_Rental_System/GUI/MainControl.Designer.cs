namespace Bicycle_Rental_System.GUI
{
    partial class MainControl
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
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.label_UserInfo = new System.Windows.Forms.Label();
            this.button_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_Main.Location = new System.Drawing.Point(3, 29);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(780, 454);
            this.tabControl_Main.TabIndex = 0;
            this.tabControl_Main.SelectedIndexChanged += new System.EventHandler(this.tabControl_Main_SelectedIndexChanged);
            // 
            // label_UserInfo
            // 
            this.label_UserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_UserInfo.AutoSize = true;
            this.label_UserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserInfo.Location = new System.Drawing.Point(616, 9);
            this.label_UserInfo.Name = "label_UserInfo";
            this.label_UserInfo.Size = new System.Drawing.Size(62, 13);
            this.label_UserInfo.TabIndex = 1;
            this.label_UserInfo.Text = "User_Info";
            this.label_UserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_Logout
            // 
            this.button_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Logout.Location = new System.Drawing.Point(708, 4);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(75, 23);
            this.button_Logout.TabIndex = 2;
            this.button_Logout.Text = "Logout";
            this.button_Logout.UseVisualStyleBackColor = true;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_Logout);
            this.Controls.Add(this.label_UserInfo);
            this.Controls.Add(this.tabControl_Main);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(786, 486);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.Label label_UserInfo;
        private System.Windows.Forms.Button button_Logout;
    }
}
