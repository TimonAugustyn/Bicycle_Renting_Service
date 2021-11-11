using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bicycle_Rental_System.GUI.CheckInOut
{
    public partial class CheckBicycle : Form
    {
        public int rating = 0;

        public CheckBicycle()
        {
            InitializeComponent();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            rating = (int)numericUpDown_Rating.Value;
            this.Close();
        }
    }
}
