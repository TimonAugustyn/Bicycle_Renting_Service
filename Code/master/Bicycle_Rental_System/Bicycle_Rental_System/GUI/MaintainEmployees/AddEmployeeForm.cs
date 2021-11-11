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

namespace Bicycle_Rental_System.GUI.MaintainEmployees
{
    public partial class AddEmployeeForm : Form
    {
        private MainForm main;
        private List<role> roles = new List<role>();

        public AddEmployeeForm(MainForm main)
        {
            InitializeComponent();
            this.main = main;
            label_Passwords.Text = "";
            loadRoles();
        }

        private void loadRoles()
        {
            comboBox_Role.Items.Clear();
            roles.Clear();
            foreach (role r in main.databaseEntities.roles)
            {
                comboBox_Role.Items.Add(r.Role_Description);
                roles.Add(r);
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox_Password.Text == "")
                label_Passwords.Text = "Please enter password!";
            else if (textBox_Password.Text != textBox_ConfirmPassword.Text)
                label_Passwords.Text = "Passwords don't match!";
            else
            {
                employee emp = new employee();
                emp.Employee_Name = textBox_Name.Text;
                emp.Employee_Surname = textBox_Surname.Text;
                emp.Employee_AccessLevel = Int32.Parse(textBox_Access_Level.Text);
                emp.Employee_RoleID = roles[comboBox_Role.SelectedIndex].Role_ID;
                emp.Employee_Password = textBox_Password.Text.ToString();
                main.databaseEntities.employees.Add(emp);
                main.databaseEntities.SaveChanges();
                this.Close();
            }
        }
    }
}
