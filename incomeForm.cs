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
    public partial class incomeForm : Form
    {
        readonly MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;database=smc_database;username=root;password=3329992075i");
        double incubatorFees = 0, oxygenFees = 0, phototherapyFees = 0, wardCharges = 0, otherCharges = 0, total= 0;

        String noOfPatient, Today, month, year;
        String specificDate;

        private readonly ArrayList ListID = new ArrayList();
        readonly List<double> ListincubatorFee = new List<double>();
        readonly List<double> ListoxygenFee = new List<double>();
        readonly List<double> ListphototherapyFee = new List<double>();
        readonly List<double> ListwardCharges = new List<double>();
        readonly List<double> ListotherCharges = new List<double>();

        //connectionDB connection = new connectionDB();
        public incomeForm()
        {
            InitializeComponent();
           
        }

       

        private void btnToday_Click(object sender, EventArgs e)
        {
           gettingTodayData();

        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            gettingMonthData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            gettingYearData();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (radioBtnSpecificMonth.Checked)
            {
                if (comboBoxMonth.SelectedItem != null && comboBoxYear.SelectedItem != null)
                {
                    gettingSpecificMonthData();
                }
                else
                {
                    MessageBox.Show("Please select month and year");
                }
            }
            else if(radioBtnSpecificDate.Checked)
            { 
                gettingSpecificDateData();
            }
            else
            {
                MessageBox.Show("Please Select an Option to search");
            }
            
        }

        private void gettingMonthData()
        {
            
            month = DateTime.Now.ToString("MMMM/yy");
            ListID.Clear();
            ListincubatorFee.Clear();
            ListoxygenFee.Clear();
            ListphototherapyFee.Clear();
            ListwardCharges.Clear();
            ListotherCharges.Clear();
            incubatorFees = 0;
            oxygenFees = 0;
            phototherapyFees = 0;
            wardCharges = 0;
            otherCharges = 0;
            total = 0;
            connection.Open();

            String gettingQuery = "SELECT * FROM paymentdetails WHERE payment_month = '" + month + "'";
            MySqlCommand command = new MySqlCommand(gettingQuery, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    ListID.Add(reader["patientid"].ToString());
                    ListincubatorFee.Add((double)reader["incubator_fee"]);
                    ListoxygenFee.Add((double)reader["oxygen_fee"]);
                    ListphototherapyFee.Add((double)reader["phototherapy_fee"]);
                    ListwardCharges.Add((double)reader["ward_fee"]);
                    ListotherCharges.Add((double)reader["other_fee"]);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

            for(int i=0; i<ListincubatorFee.Count; i++)
            {
                incubatorFees = ListincubatorFee[i] + incubatorFees;
                oxygenFees = ListoxygenFee[i] + oxygenFees;
                phototherapyFees = ListphototherapyFee[i] + phototherapyFees;
                wardCharges = ListwardCharges[i] + wardCharges;
                otherCharges = ListotherCharges[i] + otherCharges;

            }
            noOfPatient = ListID.Count.ToString();
            labelPatient.Text = noOfPatient;
            labelIncubator.Text = incubatorFees.ToString();
            labelOxygen.Text = oxygenFees.ToString();
            labelphototherapy.Text = phototherapyFees.ToString();
            labelWard.Text = wardCharges.ToString();
            labelOther.Text = otherCharges.ToString();
            total = incubatorFees + oxygenFees + phototherapyFees + wardCharges + otherCharges;
            labelTotal.Text = total.ToString();
            connection.Close();
        }


        private void gettingTodayData()
          {
              Today = DateTime.Now.ToString("dd/MM/yyyy");
                ListID.Clear();
                ListincubatorFee.Clear();
                ListoxygenFee.Clear();
                ListphototherapyFee.Clear();
                ListwardCharges.Clear();
                ListotherCharges.Clear();
                incubatorFees = 0;
                oxygenFees = 0;
                phototherapyFees = 0;
                wardCharges = 0;
                otherCharges = 0;
                total = 0;

            connection.Open();

              String gettingQuery = "SELECT * FROM paymentdetails WHERE payment_date = '" + Today + "'";
              MySqlCommand command = new MySqlCommand(gettingQuery, connection);
              MySqlDataReader reader = command.ExecuteReader();
              while (reader.Read())
              {
                  try
                  {
                      ListID.Add(reader["patientid"].ToString());
                      ListincubatorFee.Add((double)reader["incubator_fee"]);
                      ListoxygenFee.Add((double)reader["oxygen_fee"]);
                      ListphototherapyFee.Add((double)reader["phototherapy_fee"]);
                      ListwardCharges.Add((double)reader["ward_fee"]);
                      ListotherCharges.Add((double)reader["other_fee"]);
                }
                  catch(Exception ex)
                  {
                      MessageBox.Show(ex.Message);
                  }

              }

              for(int i=0; i<ListincubatorFee.Count; i++)
              {
                  incubatorFees = ListincubatorFee[i] + incubatorFees;
                  oxygenFees = ListoxygenFee[i] + oxygenFees;
                  phototherapyFees = ListphototherapyFee[i] + phototherapyFees;
                  wardCharges = ListwardCharges[i] + wardCharges;
                  otherCharges = ListotherCharges[i] + otherCharges;

            }
              noOfPatient = ListID.Count.ToString();
              labelPatient.Text = noOfPatient;
              labelIncubator.Text = incubatorFees.ToString();
              labelOxygen.Text = oxygenFees.ToString();
              labelphototherapy.Text = phototherapyFees.ToString();
              labelWard.Text = wardCharges.ToString();
              labelOther.Text = otherCharges.ToString();
              total = incubatorFees + oxygenFees + phototherapyFees + wardCharges + otherCharges;
              labelTotal.Text = total.ToString();
              connection.Close();
          }

        private void gettingYearData()
        {
            year = DateTime.Now.ToString("yyyy");
            ListID.Clear();
            ListincubatorFee.Clear();
            ListoxygenFee.Clear();
            ListphototherapyFee.Clear();
            ListwardCharges.Clear();
            ListotherCharges.Clear();
            incubatorFees = 0;
            oxygenFees = 0;
            phototherapyFees = 0;
            wardCharges = 0;
            otherCharges = 0;
            total = 0;
            connection.Open();

            String gettingQuery = "SELECT * FROM paymentdetails WHERE payment_year = '" + year + "'";
            MySqlCommand command = new MySqlCommand(gettingQuery, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    ListID.Add(reader["patientid"].ToString());
                    ListincubatorFee.Add((double)reader["incubator_fee"]);
                    ListoxygenFee.Add((double)reader["oxygen_fee"]);
                    ListphototherapyFee.Add((double)reader["phototherapy_fee"]);
                    ListwardCharges.Add((double)reader["ward_fee"]);
                    ListotherCharges.Add((double)reader["other_fee"]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            for (int i = 0; i < ListincubatorFee.Count; i++)
            {
                incubatorFees = ListincubatorFee[i] + incubatorFees;
                oxygenFees = ListoxygenFee[i] + oxygenFees;
                phototherapyFees = ListphototherapyFee[i] + phototherapyFees;
                wardCharges = ListwardCharges[i] + wardCharges;
                otherCharges = ListotherCharges[i] + otherCharges;

            }
            noOfPatient = ListID.Count.ToString();
            labelPatient.Text = noOfPatient;
            labelIncubator.Text = incubatorFees.ToString();
            labelOxygen.Text = oxygenFees.ToString();
            labelphototherapy.Text = phototherapyFees.ToString();
            labelWard.Text = wardCharges.ToString();
            labelOther.Text = otherCharges.ToString();
            total = incubatorFees + oxygenFees + phototherapyFees + wardCharges + otherCharges;
            labelTotal.Text = total.ToString();
            connection.Close();
        }


        private void gettingSpecificMonthData()
        {
            month = comboBoxMonth.Text;
            year = comboBoxYear.Text;
            string subYear = year.Substring(year.Length - 2);
            String billingMonth = month + "/" + subYear;

            ListID.Clear();
            ListincubatorFee.Clear();
            ListoxygenFee.Clear();
            ListphototherapyFee.Clear();
            ListwardCharges.Clear();
            ListotherCharges.Clear();
            incubatorFees = 0;
            oxygenFees = 0;
            phototherapyFees = 0;
            wardCharges = 0;
            otherCharges = 0;
            total = 0;
            connection.Open();

            String gettingQuery = "SELECT * FROM paymentdetails WHERE payment_year = '" + year + "' and payment_month = '"+billingMonth+"'";
            MySqlCommand command = new MySqlCommand(gettingQuery, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    ListID.Add(reader["patientid"].ToString());
                    ListincubatorFee.Add((double)reader["incubator_fee"]);
                    ListoxygenFee.Add((double)reader["oxygen_fee"]);
                    ListphototherapyFee.Add((double)reader["phototherapy_fee"]);
                    ListwardCharges.Add((double)reader["ward_fee"]);
                    ListotherCharges.Add((double)reader["other_fee"]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            for (int i = 0; i < ListincubatorFee.Count; i++)
            {
                incubatorFees = ListincubatorFee[i] + incubatorFees;
                oxygenFees = ListoxygenFee[i] + oxygenFees;
                phototherapyFees = ListphototherapyFee[i] + phototherapyFees;
                wardCharges = ListwardCharges[i] + wardCharges;
                otherCharges = ListotherCharges[i] + otherCharges;
            }
            noOfPatient = ListID.Count.ToString();
            labelPatient.Text = noOfPatient;
            labelIncubator.Text = incubatorFees.ToString();
            labelOxygen.Text = oxygenFees.ToString();
            labelphototherapy.Text = phototherapyFees.ToString();
            labelWard.Text = wardCharges.ToString();
            labelOther.Text = otherCharges.ToString();
            total = incubatorFees + oxygenFees + phototherapyFees + wardCharges + otherCharges;
            labelTotal.Text = total.ToString();
            connection.Close();
        }
        private void gettingSpecificDateData()
        {
            specificDate = dateTimePickerSpecific.Value.ToString("dd/MM/yyyy");
            ListID.Clear();
            ListincubatorFee.Clear();
            ListoxygenFee.Clear();
            ListphototherapyFee.Clear();
            ListwardCharges.Clear();
            ListotherCharges.Clear();
            incubatorFees = 0;
            oxygenFees = 0;
            phototherapyFees = 0;
            wardCharges = 0;
            otherCharges = 0;
            total = 0;
            connection.Open();

            String gettingQuery = "SELECT * FROM paymentdetails WHERE payment_date = '" + specificDate + "'";
            MySqlCommand command = new MySqlCommand(gettingQuery, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    ListID.Add(reader["patientid"].ToString());
                    ListincubatorFee.Add((double)reader["incubator_fee"]);
                    ListoxygenFee.Add((double)reader["oxygen_fee"]);
                    ListphototherapyFee.Add((double)reader["phototherapy_fee"]);
                    ListwardCharges.Add((double)reader["ward_fee"]);
                    ListotherCharges.Add((double)reader["other_fee"]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            for (int i = 0; i < ListincubatorFee.Count; i++)
            {
                incubatorFees = ListincubatorFee[i] + incubatorFees;
                oxygenFees = ListoxygenFee[i] + oxygenFees;
                phototherapyFees = ListphototherapyFee[i] + phototherapyFees;
                wardCharges = ListwardCharges[i] + wardCharges;
                otherCharges = ListotherCharges[i] + otherCharges;

            }
            noOfPatient = ListID.Count.ToString();
            labelPatient.Text = noOfPatient;
            labelIncubator.Text = incubatorFees.ToString();
            labelOxygen.Text = oxygenFees.ToString();
            labelphototherapy.Text = phototherapyFees.ToString();
            labelWard.Text = wardCharges.ToString();
            labelOther.Text = otherCharges.ToString();
            total = incubatorFees + oxygenFees + phototherapyFees + wardCharges + otherCharges;
            labelTotal.Text = total.ToString();
            connection.Close();
        }
    }
}
