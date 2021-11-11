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
    public partial class ChangeStudentForm : Form
    {
        private MainForm main;
        private student stu;
        public ChangeStudentForm(MainForm main, student stu)
        {
            InitializeComponent();
            this.main = main;
            this.stu = stu;
            label_StudentNumber.Text = stu.Student_Number;
            textBox_Name.Text = stu.Student_Name;
            textBox_Surname.Text = stu.Student_Surname;
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            stu.Student_Name = textBox_Name.Text;
            stu.Student_Surname = textBox_Surname.Text;
            main.databaseEntities.SaveChanges();
            this.Close();
        }
    }
}
