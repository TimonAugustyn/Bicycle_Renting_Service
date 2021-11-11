using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Bicycle_Rental_System.Database;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Bicycle_Rental_System.GUI
{
    public partial class BackupControl : UserControl
    {
        private MainForm main;

        private bool click_all = true;

        public BackupControl(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void checkBox_All_CheckedChanged(object sender, EventArgs e)
        {
            bool state = checkBox_All.Checked;
            if (click_all)
            {
                if (checkBox_All.Checked)
                    checkBox_Bicycles.Checked = checkBox_Employees.Checked = checkBox_Models.Checked = checkBox_Rentals.Checked = checkBox_Roles.Checked = checkBox_Students.Checked = true;
                else
                    checkBox_Bicycles.Checked = checkBox_Employees.Checked = checkBox_Models.Checked = checkBox_Rentals.Checked = checkBox_Roles.Checked = checkBox_Students.Checked = false;
            }
            checkBox_All.Checked = state;
        }

        private void checkBox_Any_CheckedChanged(object sender, EventArgs e)
        {
            click_all = false;
            checkBox_All.Checked = false;
            click_all = true;
        }

        private void button_BackupBrowse_Click(object sender, EventArgs e)
        {
            saveFileDialog_Backup.ShowDialog();
            textBox_BackupPath.Text = saveFileDialog_Backup.FileName;
            if (saveFileDialog_Backup.FileName.Contains(".brsbac"))
                button_Backup.Enabled = true;
        }

        private void button_RestoreBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog_Restore.ShowDialog();
            textBox_restorePath.Text = openFileDialog_Restore.FileName;
            if (File.Exists(openFileDialog_Restore.FileName))
                button_Restore.Enabled = true;
        }

        public class data
        {
            public List<bicycle> bicycles = new List<bicycle>();
            public List<bmodel> models = new List<bmodel>();
            public List<student> students = new List<student>();
            public List<employee> employees = new List<employee>();
            public List<role> roles = new List<role>();
            public List<rental> rentals = new List<rental>();
        }

        private void backup(String path)
        {
            data d = new data();
            if (checkBox_Bicycles.Checked)
                foreach (bicycle b in main.databaseEntities.bicycles)
                    d.bicycles.Add(b);
            if (checkBox_Models.Checked)
                foreach (bmodel m in main.databaseEntities.bmodels)
                    d.models.Add(m);
            if (checkBox_Employees.Checked)
                foreach (employee e in main.databaseEntities.employees)
                    d.employees.Add(e);
            if (checkBox_Roles.Checked)
                foreach (role r in main.databaseEntities.roles)
                    d.roles.Add(r);
            if (checkBox_Students.Checked)
                foreach (student s in main.databaseEntities.students)
                    d.students.Add(s);
            if (checkBox_Rentals.Checked)
                foreach (rental r in main.databaseEntities.rentals)
                    d.rentals.Add(r);

            try
            {
                //IFormatter formatter = new BinaryFormatter();
                //Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
                //formatter.Serialize(stream, d);
                //stream.Close();
                XmlSerializer ser = new XmlSerializer(typeof(data));
                TextWriter writer = new StreamWriter(path);
                ser.Serialize(writer, d);
                writer.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not backup database!" + e.ToString());
            }
        }

        private void restore(String path)
        {
            try
            {
                Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                IFormatter formatter = new BinaryFormatter();
                data d = (data)formatter.Deserialize(stream);

                if (checkBox_Bicycles.Checked)
                {
                    if (radioButton_Overwrite.Checked)
                        main.databaseEntities.bicycles.RemoveRange(main.databaseEntities.bicycles);
                    foreach (bicycle b in d.bicycles)
                        if ((radioButton_Merge.Checked && !main.databaseEntities.bicycles.Contains(b)) || radioButton_Overwrite.Checked)
                            main.databaseEntities.bicycles.Add(b);
                    main.databaseEntities.SaveChanges();
                }
                if (checkBox_Models.Checked)
                {
                    if (radioButton_Overwrite.Checked)
                        main.databaseEntities.bmodels.RemoveRange(main.databaseEntities.bmodels);
                    foreach (bmodel m in d.models)
                        if ((radioButton_Merge.Checked && !main.databaseEntities.bmodels.Contains(m)) || radioButton_Overwrite.Checked)
                            main.databaseEntities.bmodels.Add(m);
                    main.databaseEntities.SaveChanges();
                }
                if (checkBox_Employees.Checked)
                {
                    if (radioButton_Overwrite.Checked)
                        main.databaseEntities.employees.RemoveRange(main.databaseEntities.employees);
                    foreach (employee e in d.employees)
                        if ((radioButton_Merge.Checked && !main.databaseEntities.employees.Contains(e)) || radioButton_Overwrite.Checked)
                            main.databaseEntities.employees.Add(e);
                    main.databaseEntities.SaveChanges();
                }
                if (checkBox_Roles.Checked)
                {
                    if (radioButton_Overwrite.Checked)
                        main.databaseEntities.roles.RemoveRange(main.databaseEntities.roles);
                    foreach (role r in d.roles)
                        if ((radioButton_Merge.Checked && !main.databaseEntities.roles.Contains(r)) || radioButton_Overwrite.Checked)
                            main.databaseEntities.roles.Add(r);
                    main.databaseEntities.SaveChanges();
                }
                if (checkBox_Students.Checked)
                {
                    if (radioButton_Overwrite.Checked)
                        main.databaseEntities.students.RemoveRange(main.databaseEntities.students);
                    foreach (student s in d.students)
                        if ((radioButton_Merge.Checked && !main.databaseEntities.students.Contains(s)) || radioButton_Overwrite.Checked)
                            main.databaseEntities.students.Add(s);
                    main.databaseEntities.SaveChanges();
                }
                if (checkBox_Rentals.Checked)
                {
                    if (radioButton_Overwrite.Checked)
                        main.databaseEntities.rentals.RemoveRange(main.databaseEntities.rentals);
                    foreach (rental r in d.rentals)
                        if ((radioButton_Merge.Checked && !main.databaseEntities.rentals.Contains(r)) || radioButton_Overwrite.Checked)
                            main.databaseEntities.rentals.Add(r);
                    main.databaseEntities.SaveChanges();
                }
            }
            catch
            {
                MessageBox.Show("Could not restore database!");
            }
        }

        private void button_Backup_Click(object sender, EventArgs e)
        {
            backup(saveFileDialog_Backup.FileName);
        }

        private void button_Restore_Click(object sender, EventArgs e)
        {
            restore(openFileDialog_Restore.FileName);
        }
    }
}
