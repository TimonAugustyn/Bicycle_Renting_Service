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
using Bicycle_Rental_System.GUI.MaintainStudents;

namespace Bicycle_Rental_System.GUI
{
    

    public partial class MaintainStudentControl : UserControl
    {
        private const int size_number = 20;
        private const int size_name = 20;
        private const int size_surname = 20;
        private const int size_rating = 20;
        private const int spacing = 3;

        private MainForm main;
        private bool init_complete = false;

        public MaintainStudentControl(MainForm main)
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

            button_AddStudent.Width = button_ChangeStudent.Width = button_DeleteStudent.Width = b_w;

            button_AddStudent.Location = new Point(spacing, spacing);
            button_ChangeStudent.Location = new Point(b_w + 2 * spacing, spacing);
            button_DeleteStudent.Location = new Point(2 * b_w + 3 * spacing, spacing);
        }

        private void columnResize()
        {
            int w = listView_Students.Width - 5;
            int total = size_number + size_name + size_surname + size_rating;

            columnHeader_Number.Width = size_number * w / total;
            columnHeader_Name.Width = size_name * w  / total ;
            columnHeader_Surname.Width = size_surname * w  / total ;
            columnHeader_Rating.Width = size_rating * w / total ;
            
        }

        private void updateList()
        {
            listView_Students.Items.Clear();
            foreach (student s in main.databaseEntities.students)
            {
                ListViewItem item = new ListViewItem();
                item.Text = s.Student_Number.ToString();
                item.SubItems.Add(s.Student_Name);
                item.SubItems.Add(s.Student_Surname);
                item.SubItems.Add(s.Student_Rating.ToString());
                listView_Students.Items.Add(item);
            }
        }

        private void MaintainStudentControl_Resize(object sender, EventArgs e)
        {
            buttonResize();
            columnResize();
        }

        private void button_AddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm sf = new AddStudentForm(main);
            sf.ShowDialog();
            updateList();
        }

        private void button_ChangeStudent_Click(object sender, EventArgs e)
        {
            ChangeStudentForm cf = new ChangeStudentForm(main, main.databaseEntities.students.Find(listView_Students.SelectedItems[0].Text));
            cf.ShowDialog();
            updateList();
        }

        private void listView_Students_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView_Students.SelectedItems.Count > 0)
            {
                button_ChangeStudent.Enabled = true;
                button_DeleteStudent.Enabled = true;
            }
            else
            {
                button_ChangeStudent.Enabled = false;
                button_DeleteStudent.Enabled = false;
            }
        }

        private void button_DeleteStudent_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_Students.SelectedItems)
                main.databaseEntities.students.Remove(main.databaseEntities.students.Find(item.Text));
            main.databaseEntities.SaveChanges();
            updateList();
        }

        private void MaintainStudentControl_EnabledChanged(object sender, EventArgs e)
        {
            if(this.Enabled && init_complete)
            {
                updateList();
            }
        }
    }
}
