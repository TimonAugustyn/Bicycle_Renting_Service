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
using Bicycle_Rental_System.GUI.MaintainBicycles;

namespace Bicycle_Rental_System
{
    public partial class MaintainBicycleControl : UserControl
    {
        private const int size_number = 15;
        private const int size_model = 40;
        private const int size_size = 5;
        private const int size_last_serviced = 20;
        private const int size_checked = 10;

        private const int spacing = 3;

        private MainForm main;
        private bool init_complete = false;

        public MaintainBicycleControl(MainForm main)
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
            int b_w = (w - spacing * 6) / 5;

            button_AddBicycle.Width = button_ChangeBicycle.Width = button_DeleteBicycle.Width = button_Check.Width = button_Serviced.Width = b_w;

            button_AddBicycle.Location = new Point(spacing, spacing);
            button_ChangeBicycle.Location = new Point(b_w + 2 * spacing, spacing);
            button_DeleteBicycle.Location = new Point(2 * b_w + 3 * spacing, spacing);
            button_Check.Location = new Point(3 * b_w + 4 * spacing, spacing);
            button_Serviced.Location = new Point(4 * b_w + 5 * spacing, spacing);
        }

        private void columnResize()
        {
            int w = listView_Bicycles.Width-5;
            int total = size_number + size_model + size_size + size_last_serviced + size_checked;

            columnHeader_Number.Width = size_number * w / total;
            columnHeader_Model.Width = size_model * w / total;
            columnHeader_Size.Width = size_size * w / total;
            columnHeader_LastServiced.Width = size_last_serviced * w / total;
            columnHeader_Checked.Width = size_checked * w / total;
        }

        private void updateList()
        {
            listView_Bicycles.Items.Clear();
            foreach (bicycle b in main.databaseEntities.bicycles)
            {
                ListViewItem item = new ListViewItem();
                item.Text = b.Bicycle_Number.ToString();
                item.SubItems.Add(b.bmodel.Model_Type);
                item.SubItems.Add(b.Bicycle_Size.ToString());
                item.SubItems.Add(b.Bicycle_LastService.ToString());
                item.SubItems.Add(b.Bicycle_CheckedStatus == true ? "Yes" : "No");
                listView_Bicycles.Items.Add(item);
            }
        }

        private void MaintainBicycleControl_Resize(object sender, EventArgs e)
        {
            buttonResize();
            columnResize();
        }

        private void button_AddBicycle_Click(object sender, EventArgs e)
        {
            AddBicycleForm bf = new AddBicycleForm(main);
            bf.ShowDialog();
            updateList();
        }

        private void listView_Bicycles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Bicycles.SelectedItems.Count > 0)
                button_ChangeBicycle.Enabled = button_DeleteBicycle.Enabled = button_Check.Enabled = button_Serviced.Enabled = true;
            else
                button_ChangeBicycle.Enabled = button_DeleteBicycle.Enabled = button_Check.Enabled = button_Serviced.Enabled = false;
        }

        private void button_ChangeBicycle_Click(object sender, EventArgs e)
        {
            ChangeBicycleForm cf = new ChangeBicycleForm(main, main.databaseEntities.bicycles.Find(Int32.Parse(listView_Bicycles.SelectedItems[0].Text)));
            cf.ShowDialog();
            updateList();
        }

        private void button_DeleteBicycle_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_Bicycles.SelectedItems)
                main.databaseEntities.bicycles.Remove(main.databaseEntities.bicycles.Find(Int32.Parse(item.Text)));
            main.databaseEntities.SaveChanges();
            updateList();
        }

        private void button_Check_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_Bicycles.SelectedItems)
                main.databaseEntities.bicycles.Find(Int32.Parse(item.Text)).Bicycle_CheckedStatus = true;
            main.databaseEntities.SaveChanges();
            updateList();
        }

        private void button_Serviced_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_Bicycles.SelectedItems)
                main.databaseEntities.bicycles.Find(Int32.Parse(item.Text)).Bicycle_LastService = DateTime.Now;
            main.databaseEntities.SaveChanges();
            updateList();
        }

        private void MaintainBicycleControl_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled && init_complete)
            {
                updateList();
            }
        }
    }
}
