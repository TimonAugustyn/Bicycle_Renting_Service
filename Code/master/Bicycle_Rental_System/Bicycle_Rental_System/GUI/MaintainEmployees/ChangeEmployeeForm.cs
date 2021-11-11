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
    public partial class ChangeEmployeeForm : Form
    {
        private MainForm main;
        private employee emp;
        private List<role> roles = new List<role>();

        public ChangeEmployeeForm(MainForm main, employee emp)
        {
            InitializeComponent();
            this.main = main;
            this.emp = emp;
            loadRoles();
            label_EmployeeNumber.Text = emp.Employee_Number.ToString();
            textBox_Name.Text = emp.Employee_Name;
            textBox_Surname.Text = emp.Employee_Surname;
            numericUpDown_AccessLevel.Value = emp.Employee_AccessLevel;
            textBox_Password.Text = textBox_ConfirmPassword.Text = emp.Employee_Password;
            label_Passwords.Text = "";
        }

        private void loadRoles()
        {
            comboBox_Role.Items.Clear();
            roles.Clear();
            foreach (role r in main.databaseEntities.roles)
            {
                comboBox_Role.Items.Add(r.Role_Description);
                roles.Add(r);
                if (r == emp.role)
                    comboBox_Role.SelectedIndex = comboBox_Role.Items.Count - 1;
            }
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            if (textBox_Password.Text == "")
                label_Passwords.Text = "Please enter password!";
            else if (textBox_Password.Text != textBox_ConfirmPassword.Text)
                label_Passwords.Text = "Passwords don't match!";
            else
            {
                emp.Employee_Number = Int32.Parse(label_EmployeeNumber.Text);
                emp.Employee_Name = textBox_Name.Text;
                emp.Employee_Surname = textBox_Surname.Text;
                emp.Employee_AccessLevel = (int)numericUpDown_AccessLevel.Value;
                emp.Employee_RoleID = roles[comboBox_Role.SelectedIndex].Role_ID;
                emp.Employee_Password = textBox_Password.Text;
                main.databaseEntities.SaveChanges();
                this.Close();
            }
        }
    }
}
