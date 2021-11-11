namespace Bicycle_Rental_System.GUI.MaintainRoles
{
    partial class MaintainRoleControl
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
            this.button_AddRole = new System.Windows.Forms.Button();
            this.button_ChangeRole = new System.Windows.Forms.Button();
            this.button_DeleteRole = new System.Windows.Forms.Button();
            this.listView_Roles = new System.Windows.Forms.ListView();
            this.columnHeader_RoleID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_RoleDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button_AddRole
            // 
            this.button_AddRole.Location = new System.Drawing.Point(3, 3);
            this.button_AddRole.Name = "button_AddRole";
            this.button_AddRole.Size = new System.Drawing.Size(75, 23);
            this.button_AddRole.TabIndex = 0;
            this.button_AddRole.Text = "Add Role";
            this.button_AddRole.UseVisualStyleBackColor = true;
            this.button_AddRole.Click += new System.EventHandler(this.button_AddRole_Click);
            // 
            // button_ChangeRole
            // 
            this.button_ChangeRole.Enabled = false;
            this.button_ChangeRole.Location = new System.Drawing.Point(200, 3);
            this.button_ChangeRole.Name = "button_ChangeRole";
            this.button_ChangeRole.Size = new System.Drawing.Size(89, 23);
            this.button_ChangeRole.TabIndex = 1;
            this.button_ChangeRole.Text = "Change Role";
            this.button_ChangeRole.UseVisualStyleBackColor = true;
            this.button_ChangeRole.Click += new System.EventHandler(this.button_ChangeRole_Click);
            // 
            // button_DeleteRole
            // 
            this.button_DeleteRole.Enabled = false;
            this.button_DeleteRole.Location = new System.Drawing.Point(392, 3);
            this.button_DeleteRole.Name = "button_DeleteRole";
            this.button_DeleteRole.Size = new System.Drawing.Size(75, 23);
            this.button_DeleteRole.TabIndex = 2;
            this.button_DeleteRole.Text = "Delete Role";
            this.button_DeleteRole.UseVisualStyleBackColor = true;
            this.button_DeleteRole.Click += new System.EventHandler(this.button_DeleteRole_Click);
            // 
            // listView_Roles
            // 
            this.listView_Roles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Roles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_RoleID,
            this.columnHeader_RoleDescription});
            this.listView_Roles.FullRowSelect = true;
            this.listView_Roles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Roles.HideSelection = false;
            this.listView_Roles.Location = new System.Drawing.Point(4, 44);
            this.listView_Roles.Name = "listView_Roles";
            this.listView_Roles.Size = new System.Drawing.Size(463, 263);
            this.listView_Roles.TabIndex = 3;
            this.listView_Roles.UseCompatibleStateImageBehavior = false;
            this.listView_Roles.View = System.Windows.Forms.View.Details;
            this.listView_Roles.SelectedIndexChanged += new System.EventHandler(this.listView_Roles_SelectedIndexChanged);
            this.listView_Roles.Resize += new System.EventHandler(this.listView_Role_Resize);
            // 
            // columnHeader_RoleID
            // 
            this.columnHeader_RoleID.Text = "ID";
            this.columnHeader_RoleID.Width = 78;
            // 
            // columnHeader_RoleDescription
            // 
            this.columnHeader_RoleDescription.Text = "Descrption";
            this.columnHeader_RoleDescription.Width = 114;
            // 
            // MaintainRoleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView_Roles);
            this.Controls.Add(this.button_DeleteRole);
            this.Controls.Add(this.button_ChangeRole);
            this.Controls.Add(this.button_AddRole);
            this.Name = "MaintainRoleControl";
            this.Size = new System.Drawing.Size(470, 312);
            this.EnabledChanged += new System.EventHandler(this.MaintainRoleControl_EnabledChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AddRole;
        private System.Windows.Forms.Button button_ChangeRole;
        private System.Windows.Forms.Button button_DeleteRole;
        private System.Windows.Forms.ListView listView_Roles;
        private System.Windows.Forms.ColumnHeader columnHeader_RoleID;
        private System.Windows.Forms.ColumnHeader columnHeader_RoleDescription;
    }
}
