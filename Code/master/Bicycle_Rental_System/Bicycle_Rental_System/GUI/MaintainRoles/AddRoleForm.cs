using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bicycle_Rental_System.Database;

namespace Bicycle_Rental_System.GUI.MaintainRoles
{
    public partial class AddRoleForm : Form
    {
        private MainForm main;
        public AddRoleForm(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            role r = new role();
            r.Role_Description = maskedTextBox_RoleDescription.Text.ToString();
            main.databaseEntities.roles.Add(r);
            main.databaseEntities.SaveChanges();
            this.Close();
        }
    }
}
