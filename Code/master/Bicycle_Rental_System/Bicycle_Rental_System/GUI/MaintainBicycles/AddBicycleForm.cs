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

namespace Bicycle_Rental_System.GUI.MaintainBicycles
{
    public partial class AddBicycleForm : Form
    {
        private MainForm main;

        public AddBicycleForm(MainForm main)
        {
            InitializeComponent();
            this.main = main;
            loadModels();
        }

        private void loadModels()
        {
            comboBox_Model.Items.Clear();
            foreach (bmodel m in main.databaseEntities.bmodels)
                comboBox_Model.Items.Add(m.Model_Type);
            if(comboBox_Model.Items.Count > 0)
                comboBox_Model.SelectedIndex = 0;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            bicycle b = new bicycle();
            b.Bicycle_ModelID = main.databaseEntities.bmodels.Where(f => f.Model_Type == comboBox_Model.Text).First().Model_ID;
            b.Bicycle_Size = (int)numericUpDown_Size.Value;
            b.Bicycle_CheckedStatus = false;
            main.databaseEntities.bicycles.Add(b);
            main.databaseEntities.SaveChanges();
            this.Close();
        }
    }
}
