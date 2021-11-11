namespace Bicycle_Rental_System.GUI.CheckInOut
{
    partial class CheckBicycle
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
            this.numericUpDown_Rating = new System.Windows.Forms.NumericUpDown();
            this.button_Submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Rating)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rating";
            // 
            // numericUpDown_Rating
            // 
            this.numericUpDown_Rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Rating.Location = new System.Drawing.Point(15, 25);
            this.numericUpDown_Rating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Rating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Rating.Name = "numericUpDown_Rating";
            this.numericUpDown_Rating.Size = new System.Drawing.Size(75, 40);
            this.numericUpDown_Rating.TabIndex = 1;
            this.numericUpDown_Rating.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(15, 71);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(75, 23);
            this.button_Submit.TabIndex = 2;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // CheckBicycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(105, 108);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.numericUpDown_Rating);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CheckBicycle";
            this.Text = "CheckBicycle";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Rating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Rating;
        private System.Windows.Forms.Button button_Submit;
    }
}