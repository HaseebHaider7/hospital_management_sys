using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class addnewNurseForm : Form
    {
        String nurseID, nurseName, nurseAddress, nurseQualification, nursephno, joiningDate, yearsOfService;
        double salary;
        private DateTime presentYear;
        private DateTime dob;


        // for Salary
        
        double  advance = 0, remainingSalary;
        String salaryMonth = DateTime.Now.ToString("MMMM/yy");

        private void textBoxPhNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        String salaryStatus = "Not Recieved";

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=smc_database;username=root;password=3329992075i");

        public addnewNurseForm()
        {
            InitializeComponent();
            GenerateID();
            joiningdateTimePicker.Value = DateTime.Now;
        }

        public void GenerateID()
        {
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("Select Max(nurse_id) from nursedetails", connection);
            var dr = cmd.ExecuteReader();
            string newId = string.Format("SMC-NUR-{0}-001", DateTime.Now.Year);
            if (dr.HasRows)
            {
                string prefix = string.Format("SMC-NUR-{0}", DateTime.Now.Year);
                while (dr.Read())
                {

                    string maxId = dr[0].ToString();
                    if (!string.IsNullOrWhiteSpace(maxId) && maxId.StartsWith(prefix))
                    {
                        int count = Convert.ToInt32(maxId.Split('-')[3]);
                        newId = string.Format("SMC-NUR-{0}-{1:000}", DateTime.Now.Year, count + 1);
                    }
                }
            }
            nurseID = newId;
            labelnurseIDDisplay.Text = nurseID;
            connection.Close();


        }

        public String calculateYearOfService()
        {
            presentYear = DateTime.Now;
            dob = joiningdateTimePicker.Value;

            TimeSpan ts = presentYear - dob;

            int yearofservice = ts.Days / 365;

            yearsOfService = yearofservice.ToString();
            yearsOfService = (yearsOfService + " years");
            return yearsOfService;
        }


       


        private void btnSave_Click(object sender, EventArgs e)
        {
            nurseName = textBoxnurseName.Text;
            nursephno = textBoxPhNo.Text;
            nurseAddress = textBoxAddress.Text;
            nurseQualification = textBoxQualification.Text;
            joiningDate = joiningdateTimePicker.Value.ToString("dd/MM/yyyy");
            yearsOfService = calculateYearOfService();
            try
            {
                salary = double.Parse(textBoxSalary.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (textBoxnurseName.Text == "" || textBoxPhNo.Text == "" ||
                textBoxAddress.Text == "" || textBoxQualification.Text == "" ||
                joiningdateTimePicker.Value == null || textBoxSalary.Text == "" )
            {
                MessageBox.Show("Please provide missing details");
            }
            else
            {
                remainingSalary = salary;
                String insertQuery = "INSERT INTO smc_database.nursedetails (nurse_id, nurse_name,phone_no,salary,qualification,date_of_joining,years_of_service,address)" +
                   " VALUES('" + nurseID + "','" + nurseName + "','" + nursephno + "','"+salary+"','" + nurseQualification + "','" + joiningDate + "','" + yearsOfService + "','" + nurseAddress + "')";


                String insertQ = "INSERT INTO smc_database.nurse_salary (nurse_id, advance, remaining_salary, salary_month, salary_status)"+
                                "VALUES ('"+nurseID+ "','"+advance+ "','"+remainingSalary+ "','"+salaryMonth+ "','"+salaryStatus+"')";

                MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                MySqlCommand insertCmd2 = new MySqlCommand(insertQ, connection);
                connection.Open();
                try
                {
                    if (insertCmd.ExecuteNonQuery() == 1 && insertCmd2.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Save");
                    }
                    else
                    {
                        MessageBox.Show("Data Couldn't save");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
                this.Close();
            }
        }
    }
}
