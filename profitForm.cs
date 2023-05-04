using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class profitForm : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;database=smc_database;username=root;password=3329992075i");
        double incubatorFees = 0, oxygenFees = 0, phototherapyFees = 0, wardCharges = 0, othercharges = 0, totalIncome = 0, profitloss= 0;
        double totalSalaries = 0, oxygenbill = 0, electricitybill = 0, supplybill = 0, otherbill = 0, billsexpenses = 0, totalexpenses;
        string recieved = "Recieved";
        
        private string month;
        private string year;
        

        private void radioButtonyearly_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxMonth.Visible = false;
        }

        private void radioButtonmonthly_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxMonth.Visible = true;
        }

        List<double> Listotherbill = new List<double>();


        public profitForm()
        {
            InitializeComponent();
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(radioButtonmonthly.Checked == true)
            {

                
                if (comboBoxMonth.Text == "" || comboBoxyear.Text== "")
                {
                    MessageBox.Show("Please Select Month and Year");
                }
                else
                {
   

                    totalexpenses = gettingMonthlyExpenses() + gettingMonthlysalaries();
                    labelincomeDisplay.Text = gettingMonthlyIncome().ToString();
                    labelexpensesDisplay.Text =  gettingMonthlyExpenses().ToString();
                    labelNurseSalaryDisplay.Text = gettingMonthlysalaries().ToString();

                    if (gettingMonthlyIncome() > totalexpenses)
                    {
                        profitloss = gettingMonthlyIncome() - totalexpenses;
                        labelprofitLossDisplay.Text = profitloss.ToString();
                        labelprofitLossDisplay.ForeColor = System.Drawing.Color.Green;
                    }
                    else if(totalexpenses > gettingMonthlyIncome())
                    {
                        profitloss = totalexpenses - gettingMonthlyIncome();
                        labelprofitLossDisplay.Text = profitloss.ToString();
                        labelprofitLossDisplay.ForeColor = System.Drawing.Color.Red;
                    }
                    else if(totalexpenses == gettingMonthlyIncome())
                    {
                        labelprofitLossDisplay.Text = "No Profit Or Loss";
                    }
                }
            }
            else if(radioButtonyearly.Checked == true)
            {
               
                
                if (comboBoxyear.Text == "")
                {
                    MessageBox.Show("Please Select Year");
                }
                else
                {
                    totalexpenses = gettingYearlyExpenses() + gettingYearlysalaries();
                    labelincomeDisplay.Text = gettingYearlyIncome().ToString();
                    labelexpensesDisplay.Text = gettingYearlyExpenses().ToString();
                    labelNurseSalaryDisplay.Text = gettingYearlysalaries().ToString();
                    if(gettingYearlyIncome() > totalexpenses)
                    {
                        profitloss = gettingYearlyIncome() - totalexpenses;
                        labelprofitLossDisplay.Text = profitloss.ToString();
                        labelprofitLossDisplay.ForeColor = System.Drawing.Color.Green;
                    }
                    else if(totalexpenses > gettingYearlyIncome())
                    {
                        profitloss = totalexpenses - gettingYearlyIncome();
                        labelprofitLossDisplay.Text = profitloss.ToString();
                        labelprofitLossDisplay.ForeColor = System.Drawing.Color.Red;
                    }
                    else if(gettingYearlyIncome() == totalexpenses)
                    {
                        labelprofitLossDisplay.Text = "No Profit Or Loss";
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select one Radio Button");
            }
        }



        #region gettingIncome

        public double gettingMonthlyIncome()
        {
            month = comboBoxMonth.Text;
            year = comboBoxyear.Text;
            string subYear = year.Substring(year.Length - 2);
            String billingMonth = month + "/" + subYear;

            incubatorFees = 0;
            oxygenFees = 0;
            phototherapyFees = 0;
            wardCharges = 0;
            othercharges = 0;
            totalIncome = 0;
            connection.Open();
            try
            {
                string selectQuery = "SELECT Sum(ward_fee) AS Ward_fee, sum(incubator_fee) AS Incubator_fee, sum(oxygen_fee) AS Oxygen_fee, sum(phototherapy_fee) AS Phototherapy_fee, sum(other_fee) AS Other_fee from smc_database.paymentdetails where payment_month = '"+billingMonth+"'"; 
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    wardCharges = reader.GetDouble("Ward_fee");
                    incubatorFees = reader.GetDouble("Incubator_fee");
                    oxygenFees = reader.GetDouble("Oxygen_fee");
                    phototherapyFees = reader.GetDouble("Phototherapy_fee");
                    othercharges = reader.GetDouble("Other_fee");
                }
            }

            catch
            {
              //  MessageBox.Show("No Record Found For this month's Income ");
            }
            connection.Close();

            totalIncome = wardCharges + incubatorFees + oxygenFees + phototherapyFees+ othercharges;


            return totalIncome;
        }

        private double gettingYearlyIncome()
        {
            
            year = comboBoxyear.Text;


            incubatorFees = 0;
            oxygenFees = 0;
            phototherapyFees = 0;
            wardCharges = 0;
            othercharges = 0;
            totalIncome = 0;
            connection.Open();
            try
            {
                string selectQuery = "SELECT Sum(ward_fee) AS Ward_fee, sum(incubator_fee) AS Incubator_fee, sum(oxygen_fee) AS Oxygen_fee, sum(phototherapy_fee) AS Phototherapy_fee, sum(other_fee) AS Other_fee from smc_database.paymentdetails where payment_year = '" + year + "'";
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    wardCharges = reader.GetDouble("Ward_fee");
                    incubatorFees = reader.GetDouble("Incubator_fee");
                    oxygenFees = reader.GetDouble("Oxygen_fee");
                    phototherapyFees = reader.GetDouble("Phototherapy_fee");
                    othercharges = reader.GetDouble("Other_fee");
                }
            }

            catch
            {
              //  MessageBox.Show("No Record Found ");
            }
            connection.Close();

            totalIncome = wardCharges + incubatorFees + oxygenFees + phototherapyFees + othercharges;


            return totalIncome;
        }

        #endregion


        #region gettingExpenses


        private double gettingMonthlyExpenses()
        {
            month = comboBoxMonth.Text;
            year = comboBoxyear.Text;
            string subYear = year.Substring(year.Length - 2);
            String billingMonth = month + "/" + subYear;

            totalSalaries = 0;
            oxygenbill = 0;
            electricitybill = 0;
            supplybill = 0;
            otherbill = 0;
            billsexpenses = 0;
            connection.Open();

            String gettingQuery = "SELECT sum(oxygen_bill) AS oxygen_bill, sum(electricity_bill) AS electricity_bill, sum(supply_bill) AS supply_bill, sum(other_bill) AS other_bill FROM smc_database.expenses where billing_month = '" + billingMonth +"'";
            MySqlCommand command = new MySqlCommand(gettingQuery, connection);
            MySqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                try
                {
                    //ListID.Add(reader["idexpenses"].ToString());
                    oxygenbill = reader.GetDouble("oxygen_bill");
                    electricitybill = reader.GetDouble("electricity_bill");
                    supplybill = reader.GetDouble("supply_bill");
                    otherbill = reader.GetDouble("other_bill");

                    billsexpenses = oxygenbill + electricitybill + supplybill + otherbill;
                }
                catch (Exception)
                {
                   // MessageBox.Show(ex.Message, "1");
                    billsexpenses = 0;
                }
               
            }
            else
            {
                billsexpenses = 0;
            }
            connection.Close();

            

            return billsexpenses;
        }

        private double gettingYearlyExpenses()
        {
          
            year = comboBoxyear.Text;


            totalSalaries = 0;
            oxygenbill = 0;
            electricitybill = 0;
            supplybill = 0;
            otherbill = 0;
            billsexpenses = 0;
            connection.Open();

            String gettingQuery = "SELECT sum(oxygen_bill) AS oxygen_bill, sum(electricity_bill) AS electricity_bill, sum(supply_bill) AS supply_bill, sum(other_bill) AS other_bill FROM smc_database.expenses where billing_year = '" + year + "'";
            MySqlCommand command = new MySqlCommand(gettingQuery, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    //ListID.Add(reader["idexpenses"].ToString());
                    oxygenbill = reader.GetDouble("oxygen_bill");
                    electricitybill = reader.GetDouble("electricity_bill");
                    supplybill = reader.GetDouble("supply_bill");
                    otherbill = reader.GetDouble("other_bill");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            connection.Close();

            billsexpenses = oxygenbill + electricitybill + supplybill + otherbill;

            return billsexpenses;
        }

        #endregion

        #region gettingSalaries

        private double gettingMonthlysalaries()
        {
            month = comboBoxMonth.Text;
            year = comboBoxyear.Text;
            string subYear = year.Substring(year.Length - 2);
            String salaryMonth = month + "/" + subYear;
            connection.Open();
            try
            {
                string selectQuery = "SELECT SUM(total_salary) As total_salaries FROM smc_database.nurse_salary where salary_status = '"+recieved+"' and salary_month = '"+salaryMonth+"'";
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    totalSalaries = reader.GetDouble("total_salaries");
                }
            }
            
            catch
            {
               // MessageBox.Show("No Record Found ");
            }
            connection.Close();
            return totalSalaries;
        }

        private double gettingYearlysalaries()
        {
            
            year = comboBoxyear.Text;
            
            connection.Open();
            try
            {
                string selectQuery = "SELECT SUM(total_salary) As total_salaries FROM smc_database.nurse_salary where salary_status = '" + recieved + "' and salary_year = '" + year + "'";
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    totalSalaries = reader.GetDouble("total_salaries");
                }
            }

            catch 
            {
               // MessageBox.Show("No Record Found ");
            }
            connection.Close();
            return totalSalaries;
        }


        #endregion
    }
}
