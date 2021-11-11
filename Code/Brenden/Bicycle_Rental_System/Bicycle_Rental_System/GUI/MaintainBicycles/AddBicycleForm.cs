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
        private List<int> models = new List<int>();

        public AddBicycleForm(MainForm main)
        {
            InitializeComponent();
            this.main = main;
            loadModels();
        }

        private void loadModels()
        {
            comboBox_Model.Items.Clear();
            models.Clear();
            foreach (bmodel m in main.databaseEntities.bmodels)
            {
                comboBox_Model.Items.Add(m.Model_Type);
                models.Add(m.Model_ID);
            }
            if(comboBox_Model.Items.Count > 0)
                comboBox_Model.SelectedIndex = 0;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            bicycle b = new bicycle();
            b.Bicycle_ModelID = models[comboBox_Model.SelectedIndex];
            b.Bicycle_Size = (int)numericUpDown_Size.Value;
            b.Bicycle_CheckedStatus = false;
            main.databaseEntities.bicycles.Add(b);
            main.databaseEntities.SaveChanges();
            this.Close();
        }
    }
}
