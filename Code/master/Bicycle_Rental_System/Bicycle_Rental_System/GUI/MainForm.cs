using Bicycle_Rental_System.Database;
using Bicycle_Rental_System.GUI;
using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Bicycle_Rental_System
{
    public partial class MainForm : Form
    {
        private UserControl active_control = new UserControl();

        public BicycleRentalSystemEntities databaseEntities = new BicycleRentalSystemEntities();
        public employee emp;

        private Point pre_mouse_pos = new Point(0, 0);
        private bool key_pressed = false;

        public MainForm()
        {
            InitializeComponent();
            logout();
            timer_LoginTimeout.Enabled = true;
        }

        private void updateControl(UserControl newControl)
        {
            this.Controls.Remove(active_control);
            active_control = newControl;
            this.Controls.Add(active_control);
        }

        private void timer_LoginTimeout_Tick(object sender, EventArgs e)
        {
            Point cur = Cursor.Position;
            if(cur == pre_mouse_pos && !key_pressed)
            {
                logout();
            }
            key_pressed = false;
            pre_mouse_pos = cur;
        }

        public void logout()
        {
            emp = null;
            updateControl(new LoginControl(this));
            centerControl();
        }

        public void login(employee emp)
        {
            this.emp = emp;
            updateControl(new MainControl(this));
        }

        private void centerControl()
        {
            int c_w = active_control.Width;
            int c_h = active_control.Height;
            int w = this.Width;
            int h = this.Height;

            int x = (w / 2) - (c_w / 2);
            int y = (h / 2) - (c_h / 2);

            active_control.Location = new Point(x, y);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (active_control is LoginControl)
                centerControl();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            key_pressed = true;
        }
    }
}
