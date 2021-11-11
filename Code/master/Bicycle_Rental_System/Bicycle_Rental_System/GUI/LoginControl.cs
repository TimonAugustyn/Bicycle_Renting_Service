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

namespace Bicycle_Rental_System.GUI
{
    public partial class LoginControl : UserControl
    {
        private MainForm main;

        public LoginControl(MainForm main)
        {
            InitializeComponent();
            label_Info.Text = "";
            this.main = main;
            main.AcceptButton = button_Login;
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            String employee_number = textBox_EmployeeNumber.Text;
            String password = textBox_Password.Text;

            label_Info.Text = "";

            employee emp;

            if (employee_number == "")
                label_Info.Text = "Please enter a employee number!";
            else if (password == "")
                label_Info.Text = "Please enter a password!";
            else if ((emp = main.databaseEntities.employees.Find(Int32.Parse(employee_number))) == null)
                label_Info.Text = "Employee Number does not exist!";
            else if (emp.Employee_Password != password)
                label_Info.Text = "Incorrect password!";
            else
                main.login(emp);
        }
    }
}
