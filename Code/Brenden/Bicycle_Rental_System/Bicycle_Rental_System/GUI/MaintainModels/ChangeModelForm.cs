using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bicycle_Rental_System.Database;

namespace Bicycle_Rental_System.GUI.MaintainModels
{
    public partial class ChangeModelForm : Form
    {
        private MainForm main;
        private bmodel mod;

        public ChangeModelForm(MainForm main, bmodel mod)
        {
            InitializeComponent();
            this.main = main;
            this.mod = mod;
            label_ModelID.Text = mod.Model_ID.ToString();
            textBox_ModelType.Text = mod.Model_Type;
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            mod.Model_Type = textBox_ModelType.Text;
            main.databaseEntities.SaveChanges();
            this.Close();
        }
    }
}
