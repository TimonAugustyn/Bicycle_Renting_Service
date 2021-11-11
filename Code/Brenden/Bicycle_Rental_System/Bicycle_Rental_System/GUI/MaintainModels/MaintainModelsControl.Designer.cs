namespace Bicycle_Rental_System.GUI
{
    partial class MaintainModelsControl
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
            this.button_AddModel = new System.Windows.Forms.Button();
            this.button_ChangeModel = new System.Windows.Forms.Button();
            this.button_DeleteModel = new System.Windows.Forms.Button();
            this.listView_Model = new System.Windows.Forms.ListView();
            this.columnHeader_ModelID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_ModelType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button_AddModel
            // 
            this.button_AddModel.Location = new System.Drawing.Point(3, 3);
            this.button_AddModel.Name = "button_AddModel";
            this.button_AddModel.Size = new System.Drawing.Size(75, 23);
            this.button_AddModel.TabIndex = 0;
            this.button_AddModel.Text = "Add Model";
            this.button_AddModel.UseVisualStyleBackColor = true;
            this.button_AddModel.Click += new System.EventHandler(this.button_AddModel_Click);
            // 
            // button_ChangeModel
            // 
            this.button_ChangeModel.Enabled = false;
            this.button_ChangeModel.Location = new System.Drawing.Point(184, 3);
            this.button_ChangeModel.Name = "button_ChangeModel";
            this.button_ChangeModel.Size = new System.Drawing.Size(75, 23);
            this.button_ChangeModel.TabIndex = 1;
            this.button_ChangeModel.Text = "Change Model";
            this.button_ChangeModel.UseVisualStyleBackColor = true;
            this.button_ChangeModel.Click += new System.EventHandler(this.button_ChangeModel_Click);
            // 
            // button_DeleteModel
            // 
            this.button_DeleteModel.Enabled = false;
            this.button_DeleteModel.Location = new System.Drawing.Point(366, 3);
            this.button_DeleteModel.Name = "button_DeleteModel";
            this.button_DeleteModel.Size = new System.Drawing.Size(75, 23);
            this.button_DeleteModel.TabIndex = 2;
            this.button_DeleteModel.Text = "Delete Model";
            this.button_DeleteModel.UseVisualStyleBackColor = true;
            this.button_DeleteModel.Click += new System.EventHandler(this.button_DeleteModel_Click);
            // 
            // listView_Model
            // 
            this.listView_Model.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Model.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_ModelID,
            this.columnHeader_ModelType});
            this.listView_Model.FullRowSelect = true;
            this.listView_Model.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Model.HideSelection = false;
            this.listView_Model.Location = new System.Drawing.Point(3, 41);
            this.listView_Model.Name = "listView_Model";
            this.listView_Model.Size = new System.Drawing.Size(438, 286);
            this.listView_Model.TabIndex = 3;
            this.listView_Model.UseCompatibleStateImageBehavior = false;
            this.listView_Model.View = System.Windows.Forms.View.Details;
            this.listView_Model.SelectedIndexChanged += new System.EventHandler(this.listView_Model_SelectedIndexChanged);
            // 
            // columnHeader_ModelID
            // 
            this.columnHeader_ModelID.Text = "ID";
            // 
            // columnHeader_ModelType
            // 
            this.columnHeader_ModelType.Text = "Type";
            // 
            // MaintainModelsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView_Model);
            this.Controls.Add(this.button_DeleteModel);
            this.Controls.Add(this.button_ChangeModel);
            this.Controls.Add(this.button_AddModel);
            this.Name = "MaintainModelsControl";
            this.Size = new System.Drawing.Size(445, 331);
            this.EnabledChanged += new System.EventHandler(this.MaintainModelsControl_EnabledChanged);
            this.Resize += new System.EventHandler(this.MaintainModelsControl_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AddModel;
        private System.Windows.Forms.Button button_ChangeModel;
        private System.Windows.Forms.Button button_DeleteModel;
        private System.Windows.Forms.ListView listView_Model;
        private System.Windows.Forms.ColumnHeader columnHeader_ModelID;
        private System.Windows.Forms.ColumnHeader columnHeader_ModelType;
    }
}
