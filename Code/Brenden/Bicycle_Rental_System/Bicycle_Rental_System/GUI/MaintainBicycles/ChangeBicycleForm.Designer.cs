namespace Bicycle_Rental_System.GUI.MaintainBicycles
{
    partial class ChangeBicycleForm
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
            this.button_Change = new System.Windows.Forms.Button();
            this.numericUpDown_Size = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Model = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Number = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Size)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Change
            // 
            this.button_Change.Location = new System.Drawing.Point(15, 193);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(163, 23);
            this.button_Change.TabIndex = 11;
            this.button_Change.Text = "Change";
            this.button_Change.UseVisualStyleBackColor = true;
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // numericUpDown_Size
            // 
            this.numericUpDown_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Size.Location = new System.Drawing.Point(16, 127);
            this.numericUpDown_Size.Name = "numericUpDown_Size";
            this.numericUpDown_Size.Size = new System.Drawing.Size(162, 40);
            this.numericUpDown_Size.TabIndex = 10;
            this.numericUpDown_Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox_Model
            // 
            this.comboBox_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Model.FormattingEnabled = true;
            this.comboBox_Model.Location = new System.Drawing.Point(15, 78);
            this.comboBox_Model.Name = "comboBox_Model";
            this.comboBox_Model.Size = new System.Drawing.Size(163, 21);
            this.comboBox_Model.Sorted = true;
            this.comboBox_Model.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Number";
            // 
            // label_Number
            // 
            this.label_Number.AutoSize = true;
            this.label_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Number.Location = new System.Drawing.Point(10, 22);
            this.label_Number.Name = "label_Number";
            this.label_Number.Size = new System.Drawing.Size(83, 33);
            this.label_Number.TabIndex = 13;
            this.label_Number.Text = "0000";
            // 
            // ChangeBicycleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 230);
            this.Controls.Add(this.label_Number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Change);
            this.Controls.Add(this.numericUpDown_Size);
            this.Controls.Add(this.comboBox_Model);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangeBicycleForm";
            this.Text = "Change Bicycle";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.NumericUpDown numericUpDown_Size;
        private System.Windows.Forms.ComboBox comboBox_Model;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Number;
    }
}