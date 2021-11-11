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
    public partial class ReportControl : UserControl
    {
        private const int size_student_number = 15;
        private const int size_model = 40;
        private const int size_employee_number = 15;
        private const int size_time_rented = 20;

        private MainForm main;
        private bool init_complete = false;

        public ReportControl(MainForm main)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.main = main;
            label_AverageTimeRented.Text = "";
            label_Best.Text = "";
            label_BicycleVariaty.Text = "";
            label_TotalRentals.Text = "";
            label_TotalStudents.Text = "";
            columnResize();
            report();
            init_complete = true;
        }

        private void columnResize()
        {
            int w = listView_Report.Width - 5;
            int total = size_student_number + size_model + size_employee_number + size_time_rented;

            columnHeader_StudentNumber.Width = size_student_number * w / total;
            columnHeader_Model.Width = size_model * w / total;
            columnHeader_EmployeeNumber.Width = size_employee_number * w / total;
            columnHeader_TimeRented.Width = size_time_rented * w / total;
        }

        private void ReportControl_Resize(object sender, EventArgs e)
        {
            columnResize();
        }

        private void radioButton_Times_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void report()
        {
            DateTime dt;
            if (radioButton_Days.Checked)
                dt = DateTime.Today.AddDays((double)numericUpDown_Time.Value * -1);
            else if (radioButton_Weeks.Checked)
                dt = DateTime.Today.AddDays((double)numericUpDown_Time.Value * -7);
            else if (radioButton_Months.Checked)
                dt = DateTime.Today.AddMonths((int)numericUpDown_Time.Value * -1);
            else
                dt = DateTime.Today.AddYears((int)numericUpDown_Time.Value * -1);

            int total_rentals = main.databaseEntities.rentals.Where(e => e.Rental_CheckOutTime > dt).Where(f => f.Rental_CheckInTime != null).Count();

            if (total_rentals > 0)
            {
                int total_Students = main.databaseEntities.rentals.Where(e => e.Rental_CheckOutTime > dt).Where(f => f.Rental_CheckInTime != null).Select(f => f.Student_Number).Distinct().Count();
                int bicycle_variaty = main.databaseEntities.rentals.Where(e => e.Rental_CheckOutTime > dt).Where(f => f.Rental_CheckInTime != null).Select(f => f.bicycle.Bicycle_ModelID).Distinct().Count();
                TimeSpan average_time_rented = new TimeSpan(0);
                int count = 0;
                bicycle best = main.databaseEntities.rentals.Where(e => e.bicycle != null)
                                    .GroupBy(b => b.Bicycle_Number)
                                    .OrderByDescending(gp => gp.Count()).First().ElementAt(0).bicycle;

                listView_Report.Items.Clear();
                foreach (rental r in main.databaseEntities.rentals.Where(e => e.Rental_CheckOutTime > dt).Where(f => f.Rental_CheckInTime != null).ToList())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = r.Student_Number;
                    item.SubItems.Add(r.bicycle != null ? r.bicycle.bmodel.Model_Type : "null");
                    item.SubItems.Add(r.Employee_Number.ToString());
                    TimeSpan time_rented = (TimeSpan)(r.Rental_CheckInTime - r.Rental_CheckOutTime);
                    item.SubItems.Add(time_rented.Days + " Days, " + time_rented.Hours + " Hours, " + (time_rented.Minutes == 0 ? 1 : time_rented.Minutes) + " Minutes");
                    listView_Report.Items.Add(item);
                    average_time_rented = average_time_rented.Add(time_rented);
                    count++;
                }

                if(count > 0)
                    average_time_rented = new TimeSpan(average_time_rented.Ticks / count);
                else
                    average_time_rented = new TimeSpan(0);

                label_AverageTimeRented.Text = average_time_rented.Days + " Days, " + average_time_rented.Hours + " Hours, " + average_time_rented.Minutes + " Minutes";
                label_TotalRentals.Text = total_rentals.ToString();
                label_TotalStudents.Text = total_Students.ToString();
                label_BicycleVariaty.Text = bicycle_variaty.ToString();
                label_Best.Text = best.bmodel.Model_Type;
            }
        }

        private void button_Report_Click(object sender, EventArgs e)
        {
            report();
        }

        private void ReportControl_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled && init_complete)
                report();
        }
    }
}
