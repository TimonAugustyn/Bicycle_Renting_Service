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
    public partial class ChangeRoleForm : Form
    {
        private MainForm main;
        private role rol;

        public ChangeRoleForm(MainForm main, role rol)
        {
            InitializeComponent();
            this.main = main;
            this.rol = rol;
            label_RoleID.Text = rol.Role_ID.ToString();
            textBox_RoleDescription.Text = rol.Role_Description;
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            rol.Role_Description = textBox_RoleDescription.Text;
            main.databaseEntities.SaveChanges();
            this.Close();
        }
    }
}
