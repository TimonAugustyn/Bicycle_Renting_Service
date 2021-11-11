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

namespace Bicycle_Rental_System.GUI.MaintainEmployees
{
    public partial class MaintainEmployeeControl : UserControl
    {
        private const int size_number = 20;
        private const int size_name = 20;
        private const int size_surname = 20;
        private const int size_accessLevel = 20;
        private const int size_roleID = 20;
        private const int spacing = 3;

        private MainForm main;
        private bool init_complete = false;

        public MaintainEmployeeControl(MainForm main)
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

            button_AddEmployee.Width = button_ChangeEmployee.Width = button_DeleteEmployee.Width = b_w;

            button_AddEmployee.Location = new Point(spacing, spacing);
            button_ChangeEmployee.Location = new Point(b_w + 2 * spacing, spacing);
            button_DeleteEmployee.Location = new Point(2 * b_w + 3 * spacing, spacing);
        }

        private void columnResize()
        {
            int w = listView_Employees.Width;
            int total = size_number + size_name + size_surname + size_accessLevel + size_roleID;

            columnHeader_Number.Width = size_number * w / total;
            columnHeader_Name.Width = size_name * w / total;
            columnHeader_Surname.Width = size_surname * w / total;
            columnHeader_AccessLevel.Width = size_accessLevel * w / total;
            columnHeader_RoleID.Width = size_roleID * w / total;
        }

        private void updateList()
        {
            listView_Employees.Items.Clear();
            foreach (employee e in main.databaseEntities.employees)
            {
                ListViewItem item = new ListViewItem();
                item.Text = e.Employee_Number.ToString();
                item.SubItems.Add(e.Employee_Name);
                item.SubItems.Add(e.Employee_Surname);
                item.SubItems.Add(e.Employee_AccessLevel.ToString());
                item.SubItems.Add(e.Employee_RoleID.ToString());
                listView_Employees.Items.Add(item);
            }
        }

        private void listView_Employee_Resize(object sender, EventArgs e)
        {
            buttonResize();
            columnResize();
        }

        private void button_AddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm ef = new AddEmployeeForm(main);
            ef.ShowDialog();
            updateList();
        }

        private void button_ChangeEmployee_Click(object sender, EventArgs e)
        {
            ChangeEmployeeForm cf = new ChangeEmployeeForm(main, main.databaseEntities.employees.Find(Int32.Parse(listView_Employees.SelectedItems[0].Text)));
            cf.ShowDialog();
            updateList();
        }

        private void button_DeleteEmployee_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_Employees.SelectedItems)
                main.databaseEntities.employees.Remove(main.databaseEntities.employees.Find(Int32.Parse(item.Text)));
            main.databaseEntities.SaveChanges();
            updateList();
        }

        private void listView_Employees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Employees.SelectedItems.Count > 0)
                button_ChangeEmployee.Enabled = button_DeleteEmployee.Enabled = true;
            else
                button_ChangeEmployee.Enabled = button_DeleteEmployee.Enabled = false;
        }

        private void MaintainEmployeeControl_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled && init_complete)
            {
                updateList();
            }
        }
    }
}
