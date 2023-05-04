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
    public partial class nurseSalaryForm : Form
    {
        String nurseID, nurseName, salaryStatus;
        double advancePayment = 0, remainingSalary;
        String notRecieved = "Not Recieved";
        String recieved = "Recieved";
        string overRecieved = "Over Recieved";
        String previousMonth, currentMonth, year;


        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=smc_database;username=root;password=3329992075i");

        public nurseSalaryForm()
        {
            InitializeComponent();
        }

        private void nurseSalaryForm_Load(object sender, EventArgs e)
        {
            try
            {

                String selectQuery = "SELECT * FROM smc_database.nursedetails";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxNurse.Items.Add(reader.GetString("nurse_name"));

                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBoxNurse_SelectedIndexChanged(object sender, EventArgs e)
        {
            nurseName = comboBoxNurse.Text;

            try
            {
                String selectQuery = "SELECT nurse_id FROM smc_database.nursedetails WHERE nurse_name = '" + nurseName + "'";

                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    nurseID = reader.GetString("nurse_id");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (radioButtonAdvanceNurse.Checked)
            {
               if(textBoxAdvance.Text == "")
                {
                    MessageBox.Show("Please Enter Advance Amount");
                }
                else
                {

                    double advance_payment = double.Parse(textBoxAdvance.Text);
                    if (advance_payment > remainingSalary)
                    {
                        if (MessageBox.Show("Are You Sure To give this Amount ??", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            updateAdvanceSalary(advance_payment);
                            updateRemainingSalary(advance_payment);
                            updateSalaryStatus(overRecieved);
                            MessageBox.Show("Data Updated");
                        }
                    }
                    else if (advance_payment == remainingSalary)
                    {
                        updateAdvanceSalary(advance_payment);
                        updateRemainingSalary(advance_payment);
                        updateSalaryStatus(recieved);
                        MessageBox.Show("Data Updated");
                    }
                    else
                    {

                        updateAdvanceSalary(advance_payment);
                        updateRemainingSalary(advance_payment);
                        MessageBox.Show("Data Updated");

                    }
                    this.Close();
                }

            }
            else if (radioButtonFullSalaryNurse.Checked)
            {
                gettingRemainingSalary();

                updateRemainingSalary(remainingSalary);
                updateSalaryStatus(recieved);
                MessageBox.Show("Data Updated");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Select one option");
            }
        }

        private void btnCheckStatus_Click(object sender, EventArgs e)
        {
            textBoxRemainingSalary.Text = "";
            if (comboBoxNurse.Text == "")
            {
                MessageBox.Show("Please Select Nurse");
            }
            else
            {
                insertNewRecordEveryMonth();


                if (salaryStatus == recieved)
                {
                    if (labeloverRecieved.Visible == true)
                    {
                        labeloverRecieved.Visible = false;
                    }
                    labelStatusDisplay.Text = salaryStatus;
                    groupBoxsalaryDetail.Visible = false;
                }
                else if (salaryStatus == overRecieved)
                {
                    gettingRemainingSalary();
                    remainingSalary = remainingSalary * (-1);
                    labelStatusDisplay.Text = salaryStatus;
                    labeloverRecieved.Visible = true;
                    labeloverRecieved.Text = "" + nurseName + " OWE  Hospital  "+remainingSalary+"";
                    remainingSalary = 0;
                   
                }
                else
                {
                    if(labeloverRecieved.Visible == true)
                    {
                        labeloverRecieved.Visible = false;
                    }
                    labelStatusDisplay.Text = salaryStatus;

                    gettingRemainingSalary();

                    groupBoxsalaryDetail.Visible = true;

                    textBoxRemainingSalary.Text = remainingSalary.ToString();
                }

            }
        }


        #region gettingData

        private string gettingSalaryMonth()
        {
            string databaseMonth = "";

            try
            {
                connection.Open();
                String gettingQuery = "SELECT salary_month FROM smc_database.nurse_salary Where nurse_id = '" + nurseID + "'";
                MySqlCommand command = new MySqlCommand(gettingQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    databaseMonth = reader.GetString("salary_month");
                }
                connection.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            return databaseMonth;
        }

        private double gettingOriginalSalary()
        {
            double originalSalary = 0;
            try
            {
                connection.Open();
                String selectQuery = "SELECT salary FROM smc_database.nursedetails WHERE nurse_id = '" + nurseID + "'";
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    originalSalary = reader.GetDouble("salary");
                }
                connection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            return originalSalary;
        }

        private void gettingAdvanceSalary()
        {

            try
            {
                connection.Open();
                String selectQuery = "SELECT advance FROM smc_database.nurse_salary WHERE nurse_id = '" + nurseID + "' and salary_status = '" + notRecieved + "'";
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    advancePayment = reader.GetDouble("advance");
                }
                connection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }


        }

        private void gettingSalaryStatus()
        {

            try
            {
                connection.Open();
                String gettingQuery = "SELECT salary_status FROM smc_database.nurse_salary WHERE nurse_id = '" + nurseID + "'";
                MySqlCommand command = new MySqlCommand(gettingQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    salaryStatus = reader.GetString("salary_status");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void gettingRemainingSalary()
        {

            try
            {
                connection.Open();
                String selectQuery = "SELECT remaining_salary FROM smc_database.nurse_salary WHERE nurse_id = '" + nurseID + "'";
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    remainingSalary = reader.GetDouble("remaining_salary");
                }
                connection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        

        #endregion

        #region updating Data

        private void updateAdvanceSalary(double a)
        {
            double updateAdvance = 0;
            gettingAdvanceSalary();

            updateAdvance = advancePayment + a;

            try
            {
                connection.Open();
                string updateQuery = "UPDATE smc_database.nurse_salary SET advance = '" + updateAdvance + "' WHERE nurse_id = '" + nurseID + "' and salary_month= '" + currentMonth + "'";
                MySqlCommand command = new MySqlCommand(updateQuery, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                   // MessageBox.Show("advance updated");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
            advancePayment = 0;
        }

        private void updateRemainingSalary(double a)
        {
            gettingRemainingSalary();
            double updateRemaining = remainingSalary - a;

            try
            {
                connection.Open();
                string updateQuery = "UPDATE smc_database.nurse_salary SET remaining_salary = '" + updateRemaining + "' WHERE nurse_id = '" + nurseID + "' and salary_month = '" + currentMonth + "'";
                MySqlCommand command = new MySqlCommand(updateQuery, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                  //  MessageBox.Show("Remaining updated");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
            remainingSalary = 0;
            updateRemaining = 0;
        }

        private void updateSalaryStatus(string a)
        {
            string updateStatus = a;

            try
            {
                connection.Open();
                string updateQuery = "UPDATE smc_database.nurse_salary SET salary_status = '" + updateStatus + "' WHERE nurse_id = '" + nurseID + "' and salary_month = '" + currentMonth + "'";
                MySqlCommand command = new MySqlCommand(updateQuery, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                  //  MessageBox.Show("status updated");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
            salaryStatus = "";

        }

        #endregion

        #region insertingData
        private void insertNewRecordEveryMonth()
        {

            double salary = 0;
            currentMonth = DateTime.Now.ToString("MMMM/yy");
            previousMonth = gettingSalaryMonth();
            year = DateTime.Now.ToString("yyyy");


            if (currentMonth != previousMonth)
            {
                advancePayment = 0;

                salary = gettingOriginalSalary();

                try
                {
                    connection.Open();
                    String insertQuery = "INSERT INTO smc_database.nurse_salary (nurse_id,total_salary, advance, remaining_salary, salary_month, salary_year, salary_status)" +
                       "VALUES ('" + nurseID + "', '" + salary + "','" + advancePayment + "', '" + salary + "', '" + currentMonth + "','" + year + "', '" + notRecieved + "')";
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                       // salary = reader.GetDouble("salary");
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                connection.Close();
                gettingSalaryStatus();
            }
            else
            {
                gettingSalaryStatus();
            }


        }

        #endregion
    }
}
