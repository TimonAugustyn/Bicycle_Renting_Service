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
    public partial class AddModelForm : Form
    {
        private MainForm main;

        public AddModelForm(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            bmodel m = new bmodel();
            m.Model_Type= textBox_ModelType.Text.ToString();
            main.databaseEntities.bmodels.Add(m);
            main.databaseEntities.SaveChanges();
            this.Close();
        }
    }
}
