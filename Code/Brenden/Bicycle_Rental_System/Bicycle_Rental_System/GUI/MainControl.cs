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
using System.Runtime.CompilerServices;
using Bicycle_Rental_System.GUI.MaintainRoles;
using Bicycle_Rental_System.GUI.MaintainEmployees;

namespace Bicycle_Rental_System.GUI
{
    public partial class MainControl : UserControl
    {
        private MainForm main;
        private employee emp;

        public MainControl(MainForm main)
        {
            InitializeComponent();
            this.main = main;
            emp = main.emp;
            label_UserInfo.Text = emp.Employee_Name + " " + emp.Employee_Surname;
            this.Dock = DockStyle.Fill;
            activateTabs();
        }

        private TabPage createTab(UserControl control, String text)
        {
            TabPage tab = new TabPage();
            tab.Text = text;
            tab.Controls.Add(control);
            return tab;
        }

        private void activateTabs()
        {
            if (emp.Employee_AccessLevel <= 3)
            {
                tabControl_Main.TabPages.Add(createTab(new CheckInOutControl(main), "Check In & Out"));
            }
            if (emp.Employee_AccessLevel <= 2)
            {
                tabControl_Main.TabPages.Add(createTab(new MaintainBicycleControl(main), "Bicycles"));
                tabControl_Main.TabPages.Add(createTab(new MaintainModelsControl(main), "Models"));
                tabControl_Main.TabPages.Add(createTab(new MaintainStudentControl(main), "Students"));
                tabControl_Main.TabPages.Add(createTab(new ReportControl(main), "Report"));
            }
            if (emp.Employee_AccessLevel <= 1)
            {
                tabControl_Main.TabPages.Add(createTab(new MaintainEmployeeControl(main), "Employees"));
                tabControl_Main.TabPages.Add(createTab(new MaintainRoleControl(main), "Roles"));
                //tabControl_Main.TabPages.Add(createTab(new BackupControl(main), "Backup"));
            }
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            main.logout();
        }

        private void tabControl_Main_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl_Main.SelectedTab.Controls[0].Enabled = false;
            tabControl_Main.SelectedTab.Controls[0].Enabled = true;
        }
    }
}
