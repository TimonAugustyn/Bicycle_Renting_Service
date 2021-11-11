using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bicycle_Rental_System.Database;

namespace Bicycle_Rental_System.GUI.MaintainRoles
{
    public partial class MaintainRoleControl : UserControl
    {
        private const int size_ID = 20;
        private const int size_Description = 20;
        private const int spacing = 3;

        private MainForm main;
        private bool init_complete = false;

        public MaintainRoleControl(MainForm main)
        {
            InitializeComponent();
            this.main = main;
            this.Dock = DockStyle.Fill;
            buttonResize();
            columnResize();
            updateList();
            init_complete = true;
        }

        private void buttonResize()
        {
            int w = this.Width;
            int b_w = (w - spacing * 4) / 3;

            button_AddRole.Width = button_ChangeRole.Width = button_DeleteRole.Width = b_w;

            button_AddRole.Location = new Point(spacing, spacing);
            button_ChangeRole.Location = new Point(b_w + 2 * spacing, spacing);
            button_DeleteRole.Location = new Point(2 * b_w + 3 * spacing, spacing);
        }

        private void columnResize()
        {
            int w = listView_Roles.Width;
            int total = size_ID + size_Description;

            columnHeader_RoleID.Width = size_ID * w / total;
            columnHeader_RoleDescription.Width = size_Description * w / total;
        }

        private void updateList()
        {
            listView_Roles.Items.Clear();
            foreach (role r in main.databaseEntities.roles)
            {
                ListViewItem item = new ListViewItem();
                item.Text = r.Role_ID.ToString();
                item.SubItems.Add(r.Role_Description);
                listView_Roles.Items.Add(item);
            }
        }

        private void listView_Role_Resize(object sender, EventArgs e)
        {
            buttonResize();
            columnResize();
        }

        private void button_AddRole_Click(object sender, EventArgs e)
        {
            AddRoleForm rf = new AddRoleForm(main);
            rf.ShowDialog();
            updateList();
        }

        private void button_ChangeRole_Click(object sender, EventArgs e)
        {
            ChangeRoleForm cr = new ChangeRoleForm(main, main.databaseEntities.roles.Find(Int32.Parse(listView_Roles.SelectedItems[0].Text)));
            cr.ShowDialog();
            updateList();
        }

        private void button_DeleteRole_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_Roles.SelectedItems)
                main.databaseEntities.roles.Remove(main.databaseEntities.roles.Find(Int32.Parse(item.Text)));
            main.databaseEntities.SaveChanges();
            updateList();
        }

        private void listView_Roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Roles.SelectedItems.Count > 0)
                button_ChangeRole.Enabled = button_DeleteRole.Enabled = true;
            else
                button_ChangeRole.Enabled = button_DeleteRole.Enabled = false;
        }

        private void MaintainRoleControl_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled && init_complete)
            {
                updateList();
            }
        }
    }
}
