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
using System.Globalization;
using System.Data.SqlClient;
using System.Activities.Statements;
using System.Net.NetworkInformation;

namespace Bicycle_Rental_System.GUI
{
    public partial class BackupControl : UserControl
    {
        private MainForm main;

        private bool click_all = true;

        public BackupControl(MainForm main)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.main = main;
            checkBox_All.Checked = true;
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

        private void backup(String path)
        {
            if (checkBox_Bicycles.Checked || checkBox_Models.Checked || checkBox_Employees.Checked || checkBox_Roles.Checked || checkBox_Students.Checked || checkBox_Rentals.Checked)
            {
                long total = 0;
                long current = 0;

                int bicycles = 0;
                int models = 0;
                int employees = 0;
                int roles = 0;
                int students = 0;
                int rentals = 0;
                if (checkBox_Bicycles.Checked)
                    bicycles = main.databaseEntities.bicycles.Count();
                if (checkBox_Models.Checked)
                    models = main.databaseEntities.bmodels.Count();
                if (checkBox_Employees.Checked)
                    employees = main.databaseEntities.employees.Count();
                if (checkBox_Roles.Checked)
                    roles = main.databaseEntities.roles.Count();
                if (checkBox_Students.Checked)
                    students = main.databaseEntities.students.Count();
                if (checkBox_Rentals.Checked)
                    rentals = main.databaseEntities.rentals.Count();
                total = bicycles + models + employees + roles + students + rentals;

                progressBar_Progress.Visible = true;
                MessageBox.Show("begin");
                try
                {
                    StreamWriter sw = new StreamWriter(path, false);
                    sw.WriteLine(total.ToString());
                    if (checkBox_Models.Checked)
                        foreach (bmodel m in main.databaseEntities.bmodels)
                        {
                            sw.WriteLine("model,"
                                    + m.Model_ID.ToString() + ","
                                    + m.Model_Type.ToString()
                                    );
                            current++;
                            progressBar_Progress.Value = (int)(current * progressBar_Progress.Maximum / total);
                        }
                    if (checkBox_Bicycles.Checked)
                        foreach (bicycle b in main.databaseEntities.bicycles)
                        {
                            sw.WriteLine("bicycle,"
                                    + b.Bicycle_Number.ToString() + ","
                                    + b.Bicycle_ModelID.ToString() + ","
                                    + b.Bicycle_Size.ToString() + ","
                                    + (b.Bicycle_LastService.HasValue ? b.Bicycle_LastService.Value.ToString("yyyy/MM/dd hh:mm:ss tt") : "") + ","
                                    + b.Bicycle_CheckedStatus.ToString()
                                    );
                            current++;
                            progressBar_Progress.Value = (int)(current * progressBar_Progress.Maximum / total);
                        }
                    if (checkBox_Roles.Checked)
                        foreach (role r in main.databaseEntities.roles)
                        {
                            sw.WriteLine("role,"
                                    + r.Role_ID.ToString() + ","
                                    + r.Role_Description.ToString()
                                    );
                            current++;
                            progressBar_Progress.Value = (int)(current * progressBar_Progress.Maximum / total);
                        }
                    if (checkBox_Employees.Checked)
                        foreach (employee e in main.databaseEntities.employees)
                        {
                            sw.WriteLine("employee,"
                                    + e.Employee_Number.ToString() + ","
                                    + e.Employee_Name + ","
                                    + e.Employee_Surname + ","
                                    + e.Employee_RoleID.ToString() + ","
                                    + e.Employee_AccessLevel.ToString() + ","
                                    + e.Employee_Password
                                    );
                            current++;
                            progressBar_Progress.Value = (int)(current * progressBar_Progress.Maximum / total);
                        }
                    if (checkBox_Students.Checked)
                        foreach (student s in main.databaseEntities.students)
                        {
                            sw.WriteLine("student,"
                                    + s.Student_Number.ToString() + ","
                                    + s.Student_Name.ToString() + ","
                                    + s.Student_Surname.ToString() + ","
                                    + s.Student_Rating.ToString()
                                    );
                            current++;
                            progressBar_Progress.Value = (int)(current * progressBar_Progress.Maximum / total);
                        }
                    if (checkBox_Rentals.Checked)
                        foreach (rental r in main.databaseEntities.rentals)
                        {
                            sw.WriteLine("rental,"
                                    + r.Rental_Number.ToString() + ","
                                    + r.Student_Number.ToString() + ","
                                    + r.Bicycle_Number.ToString() + ","
                                    + r.Employee_Number.ToString() + ","
                                    + (r.Rental_CheckOutTime.HasValue ? r.Rental_CheckOutTime.Value.ToString("yyyy/MM/dd hh:mm:ss tt") : "") + ","
                                    + (r.Rental_CheckInTime.HasValue ? r.Rental_CheckInTime.Value.ToString("yyyy/MM/dd hh:mm:ss tt") : "")
                                    );
                            current++;
                            progressBar_Progress.Value = (int)(current * progressBar_Progress.Maximum / total);
                        }
                    sw.Close();
                    MessageBox.Show("Backup complete!\n"
                                  + "\nBicycles: " + bicycles
                                  + "\nModels: " + models
                                  + "\nEmployees: " + employees
                                  + "\nRoles: " + roles
                                  + "\nStudents: " + students
                                  + "\nRentals: " + rentals);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not backup database!\n" + e.Message);
                }
                progressBar_Progress.Visible = false;
            }
            else
                MessageBox.Show("Nothing selected to backup!");
        }

        private void restore(String path)
        {
            if (checkBox_Bicycles.Checked || checkBox_Models.Checked || checkBox_Employees.Checked || checkBox_Roles.Checked || checkBox_Students.Checked || checkBox_Rentals.Checked)
            {
                int bicycles = 0;
                int models = 0;
                int employees = 0;
                int roles = 0;
                int students = 0;
                int rentals = 0;
                try
                {
                    StreamReader sr = new StreamReader(path);
                    long total = Int32.Parse(sr.ReadLine());
                    long current = 0;

                    progressBar_Progress.Visible = true;
                    progressBar_Progress.Value = (int)(current * progressBar_Progress.Maximum / total);

                    while (!sr.EndOfStream)
                    {
                        try
                        {
                            string[] arr = sr.ReadLine().Split(',');
                            if (checkBox_Models.Checked && arr[0] == "model")
                            {
                                main.databaseEntities.Database.ExecuteSqlCommand(
                                    @"SET IDENTITY_INSERT bmodel ON;" +
                                    @"INSERT INTO [dbo].[bmodel] (Model_ID,Model_Type) VALUES(" + arr[1] + ",'" + arr[2] + "');" +
                                    @"SET IDENTITY_INSERT bmodel OFF;"
                                );
                                models++;
                            }
                            else if (checkBox_Bicycles.Checked && arr[0] == "bicycle")
                            {
                                main.databaseEntities.Database.ExecuteSqlCommand(
                                    @"SET IDENTITY_INSERT bicycle ON;" +
                                    @"INSERT INTO [dbo].[bicycle] (Bicycle_Number,Bicycle_ModelID,Bicycle_Size,Bicycle_LastService,Bicycle_CheckedStatus)" +
                                    @"VALUES(" + arr[1] + "," + arr[2] + "," + arr[3] + "," + (arr[4] == "" ? "null" : arr[4]) + ",'" + arr[5] + "');" +
                                    @"SET IDENTITY_INSERT bicycle OFF;"
                                );
                                bicycles++;
                            }
                            else if (checkBox_Roles.Checked && arr[0] == "role")
                            {
                                main.databaseEntities.Database.ExecuteSqlCommand(
                                    @"SET IDENTITY_INSERT role ON;" +
                                    @"INSERT INTO [dbo].[role] (Role_ID,Role_Description) VALUES(" + arr[1] + ",'" + arr[2] + "');" +
                                    @"SET IDENTITY_INSERT role OFF;"
                                );
                                roles++;
                            }
                            else if (checkBox_Employees.Checked && arr[0] == "employee")
                            {
                                main.databaseEntities.Database.ExecuteSqlCommand(
                                    @"SET IDENTITY_INSERT employee ON;" +
                                    @"INSERT INTO [dbo].[employee] (Employee_Number,Employee_Name,Employee_Surname,Employee_AccessLevel,Employee_RoleID,Employee_Password)" +
                                    @"VALUES(" + arr[1] + ",'" + arr[2] + "','" + arr[3] + "'," + arr[4] + "," + arr[5] + ",'" + arr[6] + "');" +
                                    @"SET IDENTITY_INSERT employee OFF;"
                                );
                                employees++;
                            }
                            else if (checkBox_Students.Checked && arr[0] == "student")
                            {
                                main.databaseEntities.Database.ExecuteSqlCommand(
                                    @"INSERT INTO [dbo].[student] (Student_Number,Student_Name,Student_Surname,Student_Rating)" +
                                    @"VALUES('" + arr[1] + "','" + arr[2] + "','" + arr[3] + "'," + (arr[4] == "" ? "null" : arr[4]) + ");"
                                );
                                students++;
                            }
                            else if (checkBox_Rentals.Checked && arr[0] == "rental")
                            {
                                main.databaseEntities.Database.ExecuteSqlCommand(
                                    @"SET IDENTITY_INSERT rental ON;" +
                                    @"INSERT INTO [dbo].[rental] (Rental_Number,Student_Number,Employee_Number,Bicycle_Number,Rental_CheckOutTime,Rental_CheckInTime)" +
                                    @"VALUES(" + arr[1] + "," + arr[2] + "," + arr[3] + "," + arr[4] + ",'" + arr[5] + "','" + arr[6] + "');" +
                                    @"SET IDENTITY_INSERT rental OFF;"
                                );
                                rentals++;
                            }
                        }
                        catch { }
                        
                        current++;
                        progressBar_Progress.Value = (int)(current * progressBar_Progress.Maximum / total);
                    }

                    MessageBox.Show("Restore complete!\n"
                                  + "\nBicycles: " + bicycles
                                  + "\nModels: " + models
                                  + "\nEmployees: " + employees
                                  + "\nRoles: " + roles
                                  + "\nStudents: " + students
                                  + "\nRentals: " + rentals);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not restore database!\n" + e.Message);
                }
                progressBar_Progress.Visible = false;
            }
            else
                MessageBox.Show("Nothing selected to restore!");
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
