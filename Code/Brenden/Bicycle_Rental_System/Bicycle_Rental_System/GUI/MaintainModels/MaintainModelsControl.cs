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
using Bicycle_Rental_System.GUI.MaintainModels;

namespace Bicycle_Rental_System.GUI
{
    public partial class MaintainModelsControl : UserControl
    {
        private const int size_modelID = 20;
        private const int size_model_type = 20;
        
        private MainForm main;
        private bool init_complete = false;

        public MaintainModelsControl(MainForm main)
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
            int spacing = 3;
            int w = this.Width;
            int b_w = (w - spacing * 4) / 3;

            button_AddModel.Width = button_ChangeModel.Width = button_DeleteModel.Width = b_w;

            button_AddModel.Location = new Point(spacing, spacing);
            button_ChangeModel.Location = new Point(b_w + 2 * spacing, spacing);
            button_DeleteModel.Location = new Point(2 * b_w + 3 * spacing, spacing);
        }

        private void columnResize()
        {
            int w = listView_Model.Width;
            int total = size_modelID + size_model_type;

            columnHeader_ModelID.Width = size_modelID * w / total;
            columnHeader_ModelType.Width = size_model_type * w / total;
        }

        private void updateList()
        {
            listView_Model.Items.Clear();
            foreach (bmodel m in main.databaseEntities.bmodels)
            {
                ListViewItem item = new ListViewItem();
                item.Text = m.Model_ID.ToString();
                item.SubItems.Add(m.Model_Type);
                listView_Model.Items.Add(item);
            }
        }

        private void MaintainModelsControl_Resize(object sender, EventArgs e)
        {
            buttonResize();
            columnResize();
        }

        private void button_AddModel_Click(object sender, EventArgs e)
        {
            AddModelForm mf = new AddModelForm(main);
            mf.ShowDialog();
            updateList();
        }

        private void button_ChangeModel_Click(object sender, EventArgs e)
        {
            ChangeModelForm cf = new ChangeModelForm(main, main.databaseEntities.bmodels.Find(Int32.Parse(listView_Model.SelectedItems[0].Text)));
            cf.ShowDialog();
            updateList();
        }

        private void listView_Model_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Model.SelectedItems.Count > 0)
                button_ChangeModel.Enabled = button_DeleteModel.Enabled = true;
            else
                button_ChangeModel.Enabled = button_DeleteModel.Enabled = false;
        }

        private void button_DeleteModel_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_Model.SelectedItems)
                main.databaseEntities.bmodels.Remove(main.databaseEntities.bmodels.Find(Int32.Parse(item.Text)));
            main.databaseEntities.SaveChanges();
            updateList();
        }

        private void MaintainModelsControl_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled && init_complete)
            {
                updateList();
            }
        }
    }
}
