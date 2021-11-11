using Bicycle_Rental_System.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bicycle_Rental_System.GUI.MaintainStudents
{
    public partial class AddStudentForm : Form
    {
        private MainForm main;
        public AddStudentForm(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            student s = new student();
            s.Student_Number = maskedTextBox_StudentNumber.Text;
            s.Student_Name = textBox_Name.Text;
            s.Student_Surname = textBox_Surname.Text;
            main.databaseEntities.students.Add(s);
            main.databaseEntities.SaveChanges();
            this.Close();
        }
    }
}
