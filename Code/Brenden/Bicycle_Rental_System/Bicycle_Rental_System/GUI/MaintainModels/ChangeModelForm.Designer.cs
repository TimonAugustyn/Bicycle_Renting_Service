namespace Bicycle_Rental_System.GUI.MaintainModels
{
    partial class ChangeModelForm
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
            this.textBox_ModelType = new System.Windows.Forms.TextBox();
            this.label_ModelID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model Type:";
            // 
            // button_Change
            // 
            this.button_Change.Location = new System.Drawing.Point(12, 133);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(128, 23);
            this.button_Change.TabIndex = 4;
            this.button_Change.Text = "Change";
            this.button_Change.UseVisualStyleBackColor = true;
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // textBox_ModelType
            // 
            this.textBox_ModelType.Location = new System.Drawing.Point(13, 88);
            this.textBox_ModelType.Name = "textBox_ModelType";
            this.textBox_ModelType.Size = new System.Drawing.Size(127, 20);
            this.textBox_ModelType.TabIndex = 5;
            // 
            // label_ModelID
            // 
            this.label_ModelID.AutoSize = true;
            this.label_ModelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ModelID.Location = new System.Drawing.Point(7, 29);
            this.label_ModelID.Name = "label_ModelID";
            this.label_ModelID.Size = new System.Drawing.Size(64, 25);
            this.label_ModelID.TabIndex = 6;
            this.label_ModelID.Text = "0000";
            // 
            // ChangeModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(152, 173);
            this.Controls.Add(this.label_ModelID);
            this.Controls.Add(this.textBox_ModelType);
            this.Controls.Add(this.button_Change);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangeModelForm";
            this.Text = "ChangeModelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.TextBox textBox_ModelType;
        private System.Windows.Forms.Label label_ModelID;
    }
}