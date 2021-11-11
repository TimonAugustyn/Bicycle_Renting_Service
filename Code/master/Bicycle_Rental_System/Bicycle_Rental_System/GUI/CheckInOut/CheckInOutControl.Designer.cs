namespace Bicycle_Rental_System.GUI
{
    partial class CheckInOutControl
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listView_ActiveRentals = new System.Windows.Forms.ListView();
            this.columnHeader_StudentNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_BicycleNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_BicycleModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox_StudentNumber = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_BicycleNumber = new System.Windows.Forms.TextBox();
            this.button_CheckIn = new System.Windows.Forms.Button();
            this.listView_Unchecked = new System.Windows.Forms.ListView();
            this.columnHeader_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.button_Check = new System.Windows.Forms.Button();
            this.groupBox_StudentDetail = new System.Windows.Forms.GroupBox();
            this.label_Rating = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_Surname = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_BicycleDetail = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label_Model = new System.Windows.Forms.Label();
            this.label_Size = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button_CheckOut = new System.Windows.Forms.Button();
            this.groupBox_StudentDetail.SuspendLayout();
            this.groupBox_BicycleDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(-15, -15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // listView_ActiveRentals
            // 
            this.listView_ActiveRentals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_ActiveRentals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_StudentNumber,
            this.columnHeader_BicycleNumber,
            this.columnHeader_BicycleModel});
            this.listView_ActiveRentals.FullRowSelect = true;
            this.listView_ActiveRentals.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_ActiveRentals.HideSelection = false;
            this.listView_ActiveRentals.Location = new System.Drawing.Point(3, 234);
            this.listView_ActiveRentals.MultiSelect = false;
            this.listView_ActiveRentals.Name = "listView_ActiveRentals";
            this.listView_ActiveRentals.Size = new System.Drawing.Size(322, 229);
            this.listView_ActiveRentals.TabIndex = 1;
            this.listView_ActiveRentals.UseCompatibleStateImageBehavior = false;
            this.listView_ActiveRentals.View = System.Windows.Forms.View.Details;
            this.listView_ActiveRentals.SelectedIndexChanged += new System.EventHandler(this.listView_ActiveRentals_SelectedIndexChanged);
            // 
            // columnHeader_StudentNumber
            // 
            this.columnHeader_StudentNumber.Text = "Student Number";
            this.columnHeader_StudentNumber.Width = 93;
            // 
            // columnHeader_BicycleNumber
            // 
            this.columnHeader_BicycleNumber.Text = "Bicycle Number";
            this.columnHeader_BicycleNumber.Width = 86;
            // 
            // columnHeader_BicycleModel
            // 
            this.columnHeader_BicycleModel.Text = "Model";
            this.columnHeader_BicycleModel.Width = 139;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Active Rentals";
            // 
            // maskedTextBox_StudentNumber
            // 
            this.maskedTextBox_StudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_StudentNumber.Location = new System.Drawing.Point(3, 25);
            this.maskedTextBox_StudentNumber.Mask = "00000000";
            this.maskedTextBox_StudentNumber.Name = "maskedTextBox_StudentNumber";
            this.maskedTextBox_StudentNumber.Size = new System.Drawing.Size(121, 31);
            this.maskedTextBox_StudentNumber.TabIndex = 3;
            this.maskedTextBox_StudentNumber.ValidatingType = typeof(int);
            this.maskedTextBox_StudentNumber.TextChanged += new System.EventHandler(this.maskedTextBox_StudentNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Student Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bicycle Number";
            // 
            // textBox_BicycleNumber
            // 
            this.textBox_BicycleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BicycleNumber.Location = new System.Drawing.Point(153, 25);
            this.textBox_BicycleNumber.Name = "textBox_BicycleNumber";
            this.textBox_BicycleNumber.Size = new System.Drawing.Size(131, 30);
            this.textBox_BicycleNumber.TabIndex = 7;
            this.textBox_BicycleNumber.TextChanged += new System.EventHandler(this.textBox_BicycleNumber_TextChanged);
            // 
            // button_CheckIn
            // 
            this.button_CheckIn.Enabled = false;
            this.button_CheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CheckIn.Location = new System.Drawing.Point(308, 3);
            this.button_CheckIn.Name = "button_CheckIn";
            this.button_CheckIn.Size = new System.Drawing.Size(132, 192);
            this.button_CheckIn.TabIndex = 8;
            this.button_CheckIn.Text = "Check In";
            this.button_CheckIn.UseVisualStyleBackColor = true;
            this.button_CheckIn.Click += new System.EventHandler(this.button_CheckIn_Click);
            // 
            // listView_Unchecked
            // 
            this.listView_Unchecked.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Unchecked.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Number,
            this.columnHeader_Model,
            this.columnHeader_Size});
            this.listView_Unchecked.FullRowSelect = true;
            this.listView_Unchecked.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Unchecked.HideSelection = false;
            this.listView_Unchecked.Location = new System.Drawing.Point(331, 234);
            this.listView_Unchecked.MultiSelect = false;
            this.listView_Unchecked.Name = "listView_Unchecked";
            this.listView_Unchecked.Size = new System.Drawing.Size(257, 229);
            this.listView_Unchecked.TabIndex = 10;
            this.listView_Unchecked.UseCompatibleStateImageBehavior = false;
            this.listView_Unchecked.View = System.Windows.Forms.View.Details;
            this.listView_Unchecked.SelectedIndexChanged += new System.EventHandler(this.listView_Unchecked_SelectedIndexChanged);
            // 
            // columnHeader_Number
            // 
            this.columnHeader_Number.Text = "Number";
            this.columnHeader_Number.Width = 50;
            // 
            // columnHeader_Model
            // 
            this.columnHeader_Model.Text = "Model";
            this.columnHeader_Model.Width = 141;
            // 
            // columnHeader_Size
            // 
            this.columnHeader_Size.Text = "Size";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Unchecked";
            // 
            // button_Check
            // 
            this.button_Check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Check.Enabled = false;
            this.button_Check.Location = new System.Drawing.Point(513, 198);
            this.button_Check.Name = "button_Check";
            this.button_Check.Size = new System.Drawing.Size(75, 30);
            this.button_Check.TabIndex = 12;
            this.button_Check.Text = "Check";
            this.button_Check.UseVisualStyleBackColor = true;
            this.button_Check.Click += new System.EventHandler(this.button_Check_Click);
            // 
            // groupBox_StudentDetail
            // 
            this.groupBox_StudentDetail.Controls.Add(this.label_Rating);
            this.groupBox_StudentDetail.Controls.Add(this.label9);
            this.groupBox_StudentDetail.Controls.Add(this.label_Surname);
            this.groupBox_StudentDetail.Controls.Add(this.label7);
            this.groupBox_StudentDetail.Controls.Add(this.label_Name);
            this.groupBox_StudentDetail.Controls.Add(this.label5);
            this.groupBox_StudentDetail.Location = new System.Drawing.Point(3, 62);
            this.groupBox_StudentDetail.Name = "groupBox_StudentDetail";
            this.groupBox_StudentDetail.Size = new System.Drawing.Size(144, 133);
            this.groupBox_StudentDetail.TabIndex = 13;
            this.groupBox_StudentDetail.TabStop = false;
            this.groupBox_StudentDetail.Text = "Student Detail";
            // 
            // label_Rating
            // 
            this.label_Rating.AutoSize = true;
            this.label_Rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Rating.Location = new System.Drawing.Point(7, 106);
            this.label_Rating.Name = "label_Rating";
            this.label_Rating.Size = new System.Drawing.Size(53, 16);
            this.label_Rating.TabIndex = 5;
            this.label_Rating.Text = "Rating";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Rating:";
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Surname.Location = new System.Drawing.Point(7, 68);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(69, 16);
            this.label_Surname.TabIndex = 3;
            this.label_Surname.Text = "Surname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Surname:";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(7, 33);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(49, 16);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name: ";
            // 
            // groupBox_BicycleDetail
            // 
            this.groupBox_BicycleDetail.Controls.Add(this.label13);
            this.groupBox_BicycleDetail.Controls.Add(this.label_Model);
            this.groupBox_BicycleDetail.Controls.Add(this.label_Size);
            this.groupBox_BicycleDetail.Controls.Add(this.label11);
            this.groupBox_BicycleDetail.Location = new System.Drawing.Point(153, 62);
            this.groupBox_BicycleDetail.Name = "groupBox_BicycleDetail";
            this.groupBox_BicycleDetail.Size = new System.Drawing.Size(131, 133);
            this.groupBox_BicycleDetail.TabIndex = 14;
            this.groupBox_BicycleDetail.TabStop = false;
            this.groupBox_BicycleDetail.Text = "Bicycle Detail";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Model:";
            // 
            // label_Model
            // 
            this.label_Model.AutoSize = true;
            this.label_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Model.Location = new System.Drawing.Point(6, 33);
            this.label_Model.Name = "label_Model";
            this.label_Model.Size = new System.Drawing.Size(51, 16);
            this.label_Model.TabIndex = 7;
            this.label_Model.Text = "Model";
            // 
            // label_Size
            // 
            this.label_Size.AutoSize = true;
            this.label_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Size.Location = new System.Drawing.Point(6, 68);
            this.label_Size.Name = "label_Size";
            this.label_Size.Size = new System.Drawing.Size(38, 16);
            this.label_Size.TabIndex = 9;
            this.label_Size.Text = "Size";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Size:";
            // 
            // button_CheckOut
            // 
            this.button_CheckOut.Enabled = false;
            this.button_CheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CheckOut.Location = new System.Drawing.Point(456, 3);
            this.button_CheckOut.Name = "button_CheckOut";
            this.button_CheckOut.Size = new System.Drawing.Size(132, 192);
            this.button_CheckOut.TabIndex = 15;
            this.button_CheckOut.Text = "Check Out";
            this.button_CheckOut.UseVisualStyleBackColor = true;
            this.button_CheckOut.Click += new System.EventHandler(this.button_CheckOut_Click);
            // 
            // CheckInOutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_CheckOut);
            this.Controls.Add(this.groupBox_BicycleDetail);
            this.Controls.Add(this.groupBox_StudentDetail);
            this.Controls.Add(this.button_Check);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView_Unchecked);
            this.Controls.Add(this.button_CheckIn);
            this.Controls.Add(this.textBox_BicycleNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox_StudentNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_ActiveRentals);
            this.Controls.Add(this.checkBox1);
            this.Name = "CheckInOutControl";
            this.Size = new System.Drawing.Size(591, 466);
            this.EnabledChanged += new System.EventHandler(this.CheckInOutControl_EnabledChanged);
            this.groupBox_StudentDetail.ResumeLayout(false);
            this.groupBox_StudentDetail.PerformLayout();
            this.groupBox_BicycleDetail.ResumeLayout(false);
            this.groupBox_BicycleDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListView listView_ActiveRentals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_StudentNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_BicycleNumber;
        private System.Windows.Forms.Button button_CheckIn;
        private System.Windows.Forms.ListView listView_Unchecked;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Check;
        private System.Windows.Forms.GroupBox groupBox_StudentDetail;
        private System.Windows.Forms.GroupBox groupBox_BicycleDetail;
        private System.Windows.Forms.Label label_Rating;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_Model;
        private System.Windows.Forms.Label label_Size;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_CheckOut;
        private System.Windows.Forms.ColumnHeader columnHeader_StudentNumber;
        private System.Windows.Forms.ColumnHeader columnHeader_BicycleNumber;
        private System.Windows.Forms.ColumnHeader columnHeader_BicycleModel;
        private System.Windows.Forms.ColumnHeader columnHeader_Number;
        private System.Windows.Forms.ColumnHeader columnHeader_Model;
        private System.Windows.Forms.ColumnHeader columnHeader_Size;
    }
}
