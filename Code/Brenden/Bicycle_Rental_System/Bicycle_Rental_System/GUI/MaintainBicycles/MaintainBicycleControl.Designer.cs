namespace Bicycle_Rental_System
{
    partial class MaintainBicycleControl
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
            this.button_AddBicycle = new System.Windows.Forms.Button();
            this.button_DeleteBicycle = new System.Windows.Forms.Button();
            this.listView_Bicycles = new System.Windows.Forms.ListView();
            this.columnHeader_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_LastServiced = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Checked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_ChangeBicycle = new System.Windows.Forms.Button();
            this.button_Check = new System.Windows.Forms.Button();
            this.button_Serviced = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_AddBicycle
            // 
            this.button_AddBicycle.Location = new System.Drawing.Point(3, 3);
            this.button_AddBicycle.Name = "button_AddBicycle";
            this.button_AddBicycle.Size = new System.Drawing.Size(87, 24);
            this.button_AddBicycle.TabIndex = 0;
            this.button_AddBicycle.Text = "Add Bicycle";
            this.button_AddBicycle.UseVisualStyleBackColor = true;
            this.button_AddBicycle.Click += new System.EventHandler(this.button_AddBicycle_Click);
            // 
            // button_DeleteBicycle
            // 
            this.button_DeleteBicycle.Enabled = false;
            this.button_DeleteBicycle.Location = new System.Drawing.Point(199, 3);
            this.button_DeleteBicycle.Name = "button_DeleteBicycle";
            this.button_DeleteBicycle.Size = new System.Drawing.Size(90, 24);
            this.button_DeleteBicycle.TabIndex = 1;
            this.button_DeleteBicycle.Text = "Delete Bicycle";
            this.button_DeleteBicycle.UseVisualStyleBackColor = true;
            this.button_DeleteBicycle.Click += new System.EventHandler(this.button_DeleteBicycle_Click);
            // 
            // listView_Bicycles
            // 
            this.listView_Bicycles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Bicycles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_Bicycles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Number,
            this.columnHeader_Model,
            this.columnHeader_Size,
            this.columnHeader_LastServiced,
            this.columnHeader_Checked});
            this.listView_Bicycles.FullRowSelect = true;
            this.listView_Bicycles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Bicycles.HideSelection = false;
            this.listView_Bicycles.Location = new System.Drawing.Point(3, 33);
            this.listView_Bicycles.Name = "listView_Bicycles";
            this.listView_Bicycles.Size = new System.Drawing.Size(536, 363);
            this.listView_Bicycles.TabIndex = 2;
            this.listView_Bicycles.UseCompatibleStateImageBehavior = false;
            this.listView_Bicycles.View = System.Windows.Forms.View.Details;
            this.listView_Bicycles.SelectedIndexChanged += new System.EventHandler(this.listView_Bicycles_SelectedIndexChanged);
            // 
            // columnHeader_Number
            // 
            this.columnHeader_Number.Text = "Number";
            // 
            // columnHeader_Model
            // 
            this.columnHeader_Model.Text = "Model";
            // 
            // columnHeader_Size
            // 
            this.columnHeader_Size.Text = "Size";
            // 
            // columnHeader_LastServiced
            // 
            this.columnHeader_LastServiced.Text = "Last Serviced";
            // 
            // columnHeader_Checked
            // 
            this.columnHeader_Checked.Text = "Checked";
            // 
            // button_ChangeBicycle
            // 
            this.button_ChangeBicycle.Enabled = false;
            this.button_ChangeBicycle.Location = new System.Drawing.Point(96, 3);
            this.button_ChangeBicycle.Name = "button_ChangeBicycle";
            this.button_ChangeBicycle.Size = new System.Drawing.Size(97, 24);
            this.button_ChangeBicycle.TabIndex = 3;
            this.button_ChangeBicycle.Text = "Change Bicycle";
            this.button_ChangeBicycle.UseVisualStyleBackColor = true;
            this.button_ChangeBicycle.Click += new System.EventHandler(this.button_ChangeBicycle_Click);
            // 
            // button_Check
            // 
            this.button_Check.Enabled = false;
            this.button_Check.Location = new System.Drawing.Point(295, 3);
            this.button_Check.Name = "button_Check";
            this.button_Check.Size = new System.Drawing.Size(90, 24);
            this.button_Check.TabIndex = 4;
            this.button_Check.Text = "Check";
            this.button_Check.UseVisualStyleBackColor = true;
            this.button_Check.Click += new System.EventHandler(this.button_Check_Click);
            // 
            // button_Serviced
            // 
            this.button_Serviced.Enabled = false;
            this.button_Serviced.Location = new System.Drawing.Point(391, 3);
            this.button_Serviced.Name = "button_Serviced";
            this.button_Serviced.Size = new System.Drawing.Size(90, 24);
            this.button_Serviced.TabIndex = 5;
            this.button_Serviced.Text = "Serviced";
            this.button_Serviced.UseVisualStyleBackColor = true;
            this.button_Serviced.Click += new System.EventHandler(this.button_Serviced_Click);
            // 
            // MaintainBicycleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_Serviced);
            this.Controls.Add(this.button_Check);
            this.Controls.Add(this.button_ChangeBicycle);
            this.Controls.Add(this.listView_Bicycles);
            this.Controls.Add(this.button_DeleteBicycle);
            this.Controls.Add(this.button_AddBicycle);
            this.Name = "MaintainBicycleControl";
            this.Size = new System.Drawing.Size(542, 399);
            this.EnabledChanged += new System.EventHandler(this.MaintainBicycleControl_EnabledChanged);
            this.Resize += new System.EventHandler(this.MaintainBicycleControl_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AddBicycle;
        private System.Windows.Forms.Button button_DeleteBicycle;
        private System.Windows.Forms.ListView listView_Bicycles;
        private System.Windows.Forms.Button button_ChangeBicycle;
        private System.Windows.Forms.ColumnHeader columnHeader_Number;
        private System.Windows.Forms.ColumnHeader columnHeader_Model;
        private System.Windows.Forms.ColumnHeader columnHeader_Size;
        private System.Windows.Forms.ColumnHeader columnHeader_LastServiced;
        private System.Windows.Forms.ColumnHeader columnHeader_Checked;
        private System.Windows.Forms.Button button_Check;
        private System.Windows.Forms.Button button_Serviced;
    }
}
