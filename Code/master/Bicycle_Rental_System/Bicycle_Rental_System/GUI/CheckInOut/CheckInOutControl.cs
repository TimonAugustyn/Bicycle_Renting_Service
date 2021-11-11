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
using Bicycle_Rental_System.GUI.CheckInOut;

namespace Bicycle_Rental_System.GUI
{
    public partial class CheckInOutControl : UserControl
    {
        private MainForm main;
        private List<rental> rentals = new List<rental>();
        private List<bicycle> unchecked_bicycles = new List<bicycle>();

        private bool selecting = false;
        private bool editing = false;
        private bool init_complete = false;

        public CheckInOutControl(MainForm main)
        {
            InitializeComponent();
            this.main = main;
            this.Dock = DockStyle.Fill;
            updateActiveRentals();
            updateUnchecked();
            updateLabels();
            init_complete = true;
        }

        private void updateActiveRentals()
        {
            rentals.Clear();
            listView_ActiveRentals.Items.Clear();
            foreach(rental r in main.databaseEntities.rentals.Where(e => e.Rental_CheckInTime == null))
            {
                ListViewItem item = new ListViewItem();
                item.Text = r.Student_Number;
                item.SubItems.Add(r.Bicycle_Number.ToString());
                item.SubItems.Add(r.bicycle != null ? r.bicycle.bmodel.Model_Type : "null");
                listView_ActiveRentals.Items.Add(item);
                rentals.Add(r);
            }
        }

        private void updateUnchecked()
        {
            unchecked_bicycles.Clear();
            listView_Unchecked.Items.Clear();
            foreach (bicycle b in main.databaseEntities.bicycles.Where(e => e.Bicycle_CheckedStatus == false).Where(f => f.rentals.All(g => g.Rental_CheckInTime != null)))
            {
                ListViewItem item = new ListViewItem();
                item.Text = b.Bicycle_Number.ToString();
                item.SubItems.Add(b.bmodel != null ? b.bmodel.Model_Type : "null");
                item.SubItems.Add(b.Bicycle_Size.ToString());
                listView_Unchecked.Items.Add(item);
                unchecked_bicycles.Add(b);
            }
        }

        private void listView_ActiveRentals_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecting = true;
            if (!editing)
            {
                if (listView_ActiveRentals.SelectedItems.Count > 0)
                {
                    maskedTextBox_StudentNumber.Text = rentals[listView_ActiveRentals.SelectedItems[0].Index].Student_Number;
                    textBox_BicycleNumber.Text = rentals[listView_ActiveRentals.SelectedItems[0].Index].Bicycle_Number.ToString();
                }
                else
                    maskedTextBox_StudentNumber.Text = textBox_BicycleNumber.Text = "";
            }
            selecting = false;
        }

        private void maskedTextBox_StudentNumber_TextChanged(object sender, EventArgs e)
        {
            editing = true;
            if (!selecting)
            {
                foreach (ListViewItem item in listView_ActiveRentals.SelectedItems)
                    item.Selected = false;
            }
            editing = false;
            updateLabels();
        }

        private void textBox_BicycleNumber_TextChanged(object sender, EventArgs e)
        {
            editing = true;
            if (!selecting)
            {
                foreach (ListViewItem item in listView_ActiveRentals.SelectedItems)
                    item.Selected = false;
            }
            editing = false;
            updateLabels();
        }

        private void updateLabels()
        {
            label_Model.Text = label_Name.Text = label_Rating.Text = label_Size.Text = label_Surname.Text = "";
            int num;
            bool b_found = false;
            bool b_in = true;
            if (Int32.TryParse(textBox_BicycleNumber.Text, out num))
            {
                bicycle b = main.databaseEntities.bicycles.Find(num);
                if (b != null)
                {
                    label_Model.Text = b.bmodel != null ? b.bmodel.Model_Type : "null";
                    label_Size.Text = b.Bicycle_Size.ToString();
                    b_found = true;
                    if(rentals.Where(f => f.Rental_CheckInTime == null).ToList().Exists(e => e.bicycle == b))
                        b_in = false;
                }
            }

            bool s_found = false;
            if (maskedTextBox_StudentNumber.MaskCompleted)
            {
                student s = main.databaseEntities.students.Find(maskedTextBox_StudentNumber.Text);
                if(s != null)
                {
                    label_Name.Text = s.Student_Name;
                    label_Surname.Text = s.Student_Surname;
                    label_Rating.Text = s.Student_Rating.ToString();
                    s_found = true;
                }
                if (s != null && s.rentals.Count > 0 && s.rentals.OrderByDescending(f => f.Rental_CheckOutTime).Last().Rental_CheckInTime == null)
                    s_found = false;
            }

            if(b_found && !b_in)
                button_CheckIn.Enabled = true;
            else
                button_CheckIn.Enabled = false;

            if (s_found && b_found && b_in)
                button_CheckOut.Enabled = true;
            else
                button_CheckOut.Enabled = false;
        }

        private void button_CheckIn_Click(object sender, EventArgs e)
        {
            rentals.Where(f => f.Bicycle_Number == Int32.Parse(textBox_BicycleNumber.Text)).FirstOrDefault().Rental_CheckInTime = DateTime.Now;
            main.databaseEntities.SaveChanges();
            textBox_BicycleNumber.Text = maskedTextBox_StudentNumber.Text = "";
            updateActiveRentals();
            updateUnchecked();
        }

        private void button_CheckOut_Click(object sender, EventArgs e)
        {
            rental r = new rental();
            r.Bicycle_Number = Int32.Parse(textBox_BicycleNumber.Text);
            r.employee = main.emp;
            r.Student_Number = maskedTextBox_StudentNumber.Text;
            r.Rental_CheckOutTime = DateTime.Now;
            main.databaseEntities.bicycles.Find(r.Bicycle_Number).Bicycle_CheckedStatus = false;
            main.databaseEntities.rentals.Add(r);
            main.databaseEntities.SaveChanges();
            textBox_BicycleNumber.Text = maskedTextBox_StudentNumber.Text = "";
            updateActiveRentals();
            updateUnchecked();
        }

        private void listView_Unchecked_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Unchecked.SelectedItems.Count > 0)
                button_Check.Enabled = true;
            else
                button_Check.Enabled = false;
        }

        private void button_Check_Click(object sender, EventArgs e)
        {
            CheckBicycle cb = new CheckBicycle();
            cb.ShowDialog();
            int rating = cb.rating;
            if (rating >= 1 && rating <= 10)
                foreach (ListViewItem item in listView_Unchecked.SelectedItems)
                {
                    bicycle b = unchecked_bicycles[item.Index];
                    unchecked_bicycles[item.Index].Bicycle_CheckedStatus = true;
                    rental r;
                    if (b.rentals.Count > 0)
                        r = b.rentals.OrderBy(f => f.Rental_CheckInTime).Last();
                    else
                        r = null;
                    if(r != null)
                        r.student.Student_Rating = rating;
                }
            main.databaseEntities.SaveChanges();
            updateUnchecked();
        }

        private void CheckInOutControl_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled && init_complete)
            {
                updateActiveRentals();
                updateUnchecked();
            }
        }
    }
}
