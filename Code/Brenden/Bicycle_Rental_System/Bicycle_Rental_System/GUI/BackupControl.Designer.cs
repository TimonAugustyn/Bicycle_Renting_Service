namespace Bicycle_Rental_System.GUI
{
    partial class BackupControl
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
            this.checkBox_Bicycles = new System.Windows.Forms.CheckBox();
            this.checkBox_Models = new System.Windows.Forms.CheckBox();
            this.checkBox_Students = new System.Windows.Forms.CheckBox();
            this.checkBox_Rentals = new System.Windows.Forms.CheckBox();
            this.checkBox_Employees = new System.Windows.Forms.CheckBox();
            this.checkBox_Roles = new System.Windows.Forms.CheckBox();
            this.checkBox_All = new System.Windows.Forms.CheckBox();
            this.groupBox_DataSelection = new System.Windows.Forms.GroupBox();
            this.groupBox_Backup = new System.Windows.Forms.GroupBox();
            this.button_Backup = new System.Windows.Forms.Button();
            this.button_BackupBrowse = new System.Windows.Forms.Button();
            this.textBox_BackupPath = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox_Restore = new System.Windows.Forms.GroupBox();
            this.radioButton_Merge = new System.Windows.Forms.RadioButton();
            this.radioButton_Overwrite = new System.Windows.Forms.RadioButton();
            this.button_Restore = new System.Windows.Forms.Button();
            this.button_RestoreBrowse = new System.Windows.Forms.Button();
            this.textBox_restorePath = new System.Windows.Forms.TextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog_Backup = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog_Restore = new System.Windows.Forms.OpenFileDialog();
            this.groupBox_DataSelection.SuspendLayout();
            this.groupBox_Backup.SuspendLayout();
            this.groupBox_Restore.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_Bicycles
            // 
            this.checkBox_Bicycles.AutoSize = true;
            this.checkBox_Bicycles.Location = new System.Drawing.Point(22, 42);
            this.checkBox_Bicycles.Name = "checkBox_Bicycles";
            this.checkBox_Bicycles.Size = new System.Drawing.Size(65, 17);
            this.checkBox_Bicycles.TabIndex = 0;
            this.checkBox_Bicycles.Text = "Bicycles";
            this.checkBox_Bicycles.UseVisualStyleBackColor = true;
            this.checkBox_Bicycles.CheckedChanged += new System.EventHandler(this.checkBox_Any_CheckedChanged);
            // 
            // checkBox_Models
            // 
            this.checkBox_Models.AutoSize = true;
            this.checkBox_Models.Location = new System.Drawing.Point(22, 65);
            this.checkBox_Models.Name = "checkBox_Models";
            this.checkBox_Models.Size = new System.Drawing.Size(60, 17);
            this.checkBox_Models.TabIndex = 2;
            this.checkBox_Models.Text = "Models";
            this.checkBox_Models.UseVisualStyleBackColor = true;
            this.checkBox_Models.CheckedChanged += new System.EventHandler(this.checkBox_Any_CheckedChanged);
            // 
            // checkBox_Students
            // 
            this.checkBox_Students.AutoSize = true;
            this.checkBox_Students.Location = new System.Drawing.Point(22, 88);
            this.checkBox_Students.Name = "checkBox_Students";
            this.checkBox_Students.Size = new System.Drawing.Size(68, 17);
            this.checkBox_Students.TabIndex = 3;
            this.checkBox_Students.Text = "Students";
            this.checkBox_Students.UseVisualStyleBackColor = true;
            this.checkBox_Students.CheckedChanged += new System.EventHandler(this.checkBox_Any_CheckedChanged);
            // 
            // checkBox_Rentals
            // 
            this.checkBox_Rentals.AutoSize = true;
            this.checkBox_Rentals.Location = new System.Drawing.Point(22, 111);
            this.checkBox_Rentals.Name = "checkBox_Rentals";
            this.checkBox_Rentals.Size = new System.Drawing.Size(62, 17);
            this.checkBox_Rentals.TabIndex = 4;
            this.checkBox_Rentals.Text = "Rentals";
            this.checkBox_Rentals.UseVisualStyleBackColor = true;
            this.checkBox_Rentals.CheckedChanged += new System.EventHandler(this.checkBox_Any_CheckedChanged);
            // 
            // checkBox_Employees
            // 
            this.checkBox_Employees.AutoSize = true;
            this.checkBox_Employees.Location = new System.Drawing.Point(22, 134);
            this.checkBox_Employees.Name = "checkBox_Employees";
            this.checkBox_Employees.Size = new System.Drawing.Size(77, 17);
            this.checkBox_Employees.TabIndex = 5;
            this.checkBox_Employees.Text = "Employees";
            this.checkBox_Employees.UseVisualStyleBackColor = true;
            this.checkBox_Employees.CheckedChanged += new System.EventHandler(this.checkBox_Any_CheckedChanged);
            // 
            // checkBox_Roles
            // 
            this.checkBox_Roles.AutoSize = true;
            this.checkBox_Roles.Location = new System.Drawing.Point(22, 157);
            this.checkBox_Roles.Name = "checkBox_Roles";
            this.checkBox_Roles.Size = new System.Drawing.Size(53, 17);
            this.checkBox_Roles.TabIndex = 6;
            this.checkBox_Roles.Text = "Roles";
            this.checkBox_Roles.UseVisualStyleBackColor = true;
            this.checkBox_Roles.CheckedChanged += new System.EventHandler(this.checkBox_Any_CheckedChanged);
            // 
            // checkBox_All
            // 
            this.checkBox_All.AutoSize = true;
            this.checkBox_All.Location = new System.Drawing.Point(6, 19);
            this.checkBox_All.Name = "checkBox_All";
            this.checkBox_All.Size = new System.Drawing.Size(37, 17);
            this.checkBox_All.TabIndex = 7;
            this.checkBox_All.Text = "All";
            this.checkBox_All.UseVisualStyleBackColor = true;
            this.checkBox_All.CheckedChanged += new System.EventHandler(this.checkBox_All_CheckedChanged);
            // 
            // groupBox_DataSelection
            // 
            this.groupBox_DataSelection.Controls.Add(this.checkBox_All);
            this.groupBox_DataSelection.Controls.Add(this.checkBox_Bicycles);
            this.groupBox_DataSelection.Controls.Add(this.checkBox_Roles);
            this.groupBox_DataSelection.Controls.Add(this.checkBox_Models);
            this.groupBox_DataSelection.Controls.Add(this.checkBox_Employees);
            this.groupBox_DataSelection.Controls.Add(this.checkBox_Students);
            this.groupBox_DataSelection.Controls.Add(this.checkBox_Rentals);
            this.groupBox_DataSelection.Location = new System.Drawing.Point(3, 3);
            this.groupBox_DataSelection.Name = "groupBox_DataSelection";
            this.groupBox_DataSelection.Size = new System.Drawing.Size(140, 184);
            this.groupBox_DataSelection.TabIndex = 8;
            this.groupBox_DataSelection.TabStop = false;
            this.groupBox_DataSelection.Text = "Data Selection";
            // 
            // groupBox_Backup
            // 
            this.groupBox_Backup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Backup.Controls.Add(this.button_Backup);
            this.groupBox_Backup.Controls.Add(this.button_BackupBrowse);
            this.groupBox_Backup.Controls.Add(this.textBox_BackupPath);
            this.groupBox_Backup.Location = new System.Drawing.Point(149, 3);
            this.groupBox_Backup.Name = "groupBox_Backup";
            this.groupBox_Backup.Size = new System.Drawing.Size(439, 86);
            this.groupBox_Backup.TabIndex = 9;
            this.groupBox_Backup.TabStop = false;
            this.groupBox_Backup.Text = "Backup";
            // 
            // button_Backup
            // 
            this.button_Backup.Enabled = false;
            this.button_Backup.Location = new System.Drawing.Point(6, 45);
            this.button_Backup.Name = "button_Backup";
            this.button_Backup.Size = new System.Drawing.Size(75, 35);
            this.button_Backup.TabIndex = 2;
            this.button_Backup.Text = "Backup";
            this.button_Backup.UseVisualStyleBackColor = true;
            this.button_Backup.Click += new System.EventHandler(this.button_Backup_Click);
            // 
            // button_BackupBrowse
            // 
            this.button_BackupBrowse.Location = new System.Drawing.Point(6, 19);
            this.button_BackupBrowse.Name = "button_BackupBrowse";
            this.button_BackupBrowse.Size = new System.Drawing.Size(75, 20);
            this.button_BackupBrowse.TabIndex = 1;
            this.button_BackupBrowse.Text = "Browse";
            this.button_BackupBrowse.UseVisualStyleBackColor = true;
            this.button_BackupBrowse.Click += new System.EventHandler(this.button_BackupBrowse_Click);
            // 
            // textBox_BackupPath
            // 
            this.textBox_BackupPath.Location = new System.Drawing.Point(85, 19);
            this.textBox_BackupPath.Name = "textBox_BackupPath";
            this.textBox_BackupPath.ReadOnly = true;
            this.textBox_BackupPath.Size = new System.Drawing.Size(348, 20);
            this.textBox_BackupPath.TabIndex = 0;
            // 
            // groupBox_Restore
            // 
            this.groupBox_Restore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Restore.Controls.Add(this.radioButton_Merge);
            this.groupBox_Restore.Controls.Add(this.radioButton_Overwrite);
            this.groupBox_Restore.Controls.Add(this.button_Restore);
            this.groupBox_Restore.Controls.Add(this.button_RestoreBrowse);
            this.groupBox_Restore.Controls.Add(this.textBox_restorePath);
            this.groupBox_Restore.Location = new System.Drawing.Point(149, 95);
            this.groupBox_Restore.Name = "groupBox_Restore";
            this.groupBox_Restore.Size = new System.Drawing.Size(439, 92);
            this.groupBox_Restore.TabIndex = 10;
            this.groupBox_Restore.TabStop = false;
            this.groupBox_Restore.Text = "Restore";
            // 
            // radioButton_Merge
            // 
            this.radioButton_Merge.AutoSize = true;
            this.radioButton_Merge.Location = new System.Drawing.Point(88, 69);
            this.radioButton_Merge.Name = "radioButton_Merge";
            this.radioButton_Merge.Size = new System.Drawing.Size(55, 17);
            this.radioButton_Merge.TabIndex = 5;
            this.radioButton_Merge.TabStop = true;
            this.radioButton_Merge.Text = "Merge";
            this.radioButton_Merge.UseVisualStyleBackColor = true;
            // 
            // radioButton_Overwrite
            // 
            this.radioButton_Overwrite.AutoSize = true;
            this.radioButton_Overwrite.Checked = true;
            this.radioButton_Overwrite.Location = new System.Drawing.Point(88, 46);
            this.radioButton_Overwrite.Name = "radioButton_Overwrite";
            this.radioButton_Overwrite.Size = new System.Drawing.Size(70, 17);
            this.radioButton_Overwrite.TabIndex = 4;
            this.radioButton_Overwrite.TabStop = true;
            this.radioButton_Overwrite.Text = "Overwrite";
            this.radioButton_Overwrite.UseVisualStyleBackColor = true;
            // 
            // button_Restore
            // 
            this.button_Restore.Enabled = false;
            this.button_Restore.Location = new System.Drawing.Point(6, 45);
            this.button_Restore.Name = "button_Restore";
            this.button_Restore.Size = new System.Drawing.Size(75, 41);
            this.button_Restore.TabIndex = 3;
            this.button_Restore.Text = "Restore";
            this.button_Restore.UseVisualStyleBackColor = true;
            this.button_Restore.Click += new System.EventHandler(this.button_Restore_Click);
            // 
            // button_RestoreBrowse
            // 
            this.button_RestoreBrowse.Location = new System.Drawing.Point(6, 19);
            this.button_RestoreBrowse.Name = "button_RestoreBrowse";
            this.button_RestoreBrowse.Size = new System.Drawing.Size(75, 20);
            this.button_RestoreBrowse.TabIndex = 3;
            this.button_RestoreBrowse.Text = "Browse";
            this.button_RestoreBrowse.UseVisualStyleBackColor = true;
            this.button_RestoreBrowse.Click += new System.EventHandler(this.button_RestoreBrowse_Click);
            // 
            // textBox_restorePath
            // 
            this.textBox_restorePath.Location = new System.Drawing.Point(85, 19);
            this.textBox_restorePath.Name = "textBox_restorePath";
            this.textBox_restorePath.ReadOnly = true;
            this.textBox_restorePath.Size = new System.Drawing.Size(348, 20);
            this.textBox_restorePath.TabIndex = 2;
            // 
            // saveFileDialog_Backup
            // 
            this.saveFileDialog_Backup.Filter = "BRS Backup Files(.brsbac)|*.brsbac";
            // 
            // openFileDialog_Restore
            // 
            this.openFileDialog_Restore.Filter = "BRS Backup Files(.brsbac)|*.brsbac";
            // 
            // BackupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_Restore);
            this.Controls.Add(this.groupBox_Backup);
            this.Controls.Add(this.groupBox_DataSelection);
            this.Name = "BackupControl";
            this.Size = new System.Drawing.Size(591, 192);
            this.groupBox_DataSelection.ResumeLayout(false);
            this.groupBox_DataSelection.PerformLayout();
            this.groupBox_Backup.ResumeLayout(false);
            this.groupBox_Backup.PerformLayout();
            this.groupBox_Restore.ResumeLayout(false);
            this.groupBox_Restore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_Bicycles;
        private System.Windows.Forms.CheckBox checkBox_Models;
        private System.Windows.Forms.CheckBox checkBox_Students;
        private System.Windows.Forms.CheckBox checkBox_Rentals;
        private System.Windows.Forms.CheckBox checkBox_Employees;
        private System.Windows.Forms.CheckBox checkBox_Roles;
        private System.Windows.Forms.CheckBox checkBox_All;
        private System.Windows.Forms.GroupBox groupBox_DataSelection;
        private System.Windows.Forms.GroupBox groupBox_Backup;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_BackupBrowse;
        private System.Windows.Forms.TextBox textBox_BackupPath;
        private System.Windows.Forms.GroupBox groupBox_Restore;
        private System.Windows.Forms.Button button_RestoreBrowse;
        private System.Windows.Forms.TextBox textBox_restorePath;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button button_Backup;
        private System.Windows.Forms.RadioButton radioButton_Merge;
        private System.Windows.Forms.RadioButton radioButton_Overwrite;
        private System.Windows.Forms.Button button_Restore;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_Backup;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Restore;
    }
}
