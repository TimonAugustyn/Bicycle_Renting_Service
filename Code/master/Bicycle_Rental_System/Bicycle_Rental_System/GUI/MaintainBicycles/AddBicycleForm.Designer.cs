namespace Bicycle_Rental_System.GUI.MaintainBicycles
{
    partial class AddBicycleForm
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
            this.comboBox_Model = new System.Windows.Forms.ComboBox();
            this.numericUpDown_Size = new System.Windows.Forms.NumericUpDown();
            this.button_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Size)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // comboBox_Model
            // 
            this.comboBox_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Model.FormattingEnabled = true;
            this.comboBox_Model.Location = new System.Drawing.Point(15, 25);
            this.comboBox_Model.Name = "comboBox_Model";
            this.comboBox_Model.Size = new System.Drawing.Size(163, 21);
            this.comboBox_Model.Sorted = true;
            this.comboBox_Model.TabIndex = 4;
            // 
            // numericUpDown_Size
            // 
            this.numericUpDown_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Size.Location = new System.Drawing.Point(16, 74);
            this.numericUpDown_Size.Name = "numericUpDown_Size";
            this.numericUpDown_Size.Size = new System.Drawing.Size(162, 40);
            this.numericUpDown_Size.TabIndex = 5;
            this.numericUpDown_Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(15, 153);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(163, 23);
            this.button_Add.TabIndex = 6;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // AddBicycleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 188);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.numericUpDown_Size);
            this.Controls.Add(this.comboBox_Model);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddBicycleForm";
            this.Text = "Add Bicycle";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Model;
        private System.Windows.Forms.NumericUpDown numericUpDown_Size;
        private System.Windows.Forms.Button button_Add;
    }
}