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
    public partial class ChangeBicycleForm : Form
    {
        private MainForm main;
        private bicycle bic;

        public ChangeBicycleForm(MainForm main, bicycle bic)
        {
            InitializeComponent();
            this.main = main;
            this.bic = bic;
            label_Number.Text = bic.Bicycle_Number.ToString();
            numericUpDown_Size.Value = bic.Bicycle_Size;
            loadModels();
        }

        private void loadModels()
        {
            comboBox_Model.Items.Clear();
            foreach (bmodel m in main.databaseEntities.bmodels)
                comboBox_Model.Items.Add(m.Model_Type);
            comboBox_Model.Text = bic.bmodel.Model_Type;
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            bic.Bicycle_ModelID = main.databaseEntities.bmodels.Where(f => f.Model_Type == comboBox_Model.Text).First().Model_ID;
            bic.Bicycle_Size = (int)numericUpDown_Size.Value;
            main.databaseEntities.SaveChanges();
            this.Close();
        }
    }
}
