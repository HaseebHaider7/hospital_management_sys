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
    public partial class doctorFeesForm : Form
    {

        String doctorID, feeStatus = "not changed yet";
        
        String notRecieved = "Not Recieved";
        String recieved = "Recieved";
        string overRecieved = "Over Recieved";
        String currentMonth;
        double remainingDocFee = 0 , advance;
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=smc_database;username=root;password=3329992075i");
        public doctorFeesForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (radioButtonAdvance.Checked)
            {
                if(textBoxAdvance.Text == "")
                {
                    MessageBox.Show("Please Enter advance AMOUNT");

                }
                else
                {
                    gettingadvanceFee();
                    gettingremainingFee();
                    double advancepayment = double.Parse(textBoxAdvance.Text);
                    if (advancepayment > remainingDocFee)
                    {
                        if (MessageBox.Show("Are You Sure To give this Amount ??", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            updateAdvanceFee(advancepayment);
                            updateRemainingFee(advancepayment);
                            updateFeeStatus(overRecieved);
                            MessageBox.Show("Data Updated");
                        }
                    }
                    else if (advancepayment == remainingDocFee)
                    {
                        updateAdvanceFee(advancepayment);
                        updateRemainingFee(advancepayment);
                        updateFeeStatus(recieved);
                        MessageBox.Show("Data Updated");
                    }
                    else
                    {
                        updateAdvanceFee(advancepayment);
                        updateRemainingFee(advancepayment);
                        MessageBox.Show("Data Updated");
                    }
                    this.Close();
                }


            }
            else if (radioButtonFullSalary.Checked)
            {
                gettingremainingFee();

                updateRemainingFee(remainingDocFee);
                updateFeeStatus(recieved);
                MessageBox.Show("Data Updated");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Select one option");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        



        private void doctorFeesForm_Load(object sender, EventArgs e)
        {
            try
            {

                String selectQuery = "SELECT * FROM smc_database.doctordetails";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxDoctor.Items.Add(reader.GetString("doctor_name"));

                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            String doctorName = comboBoxDoctor.Text;

            try
            {
                String selectQuery = "SELECT doctor_id FROM smc_database.doctordetails WHERE doctor_name = '" + doctorName + "'";

                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    doctorID = reader.GetString("doctor_id");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

       

      
        private void btnCheckStatus_Click(object sender, EventArgs e)
        {
            currentMonth = DateTime.Now.ToString("MMMM/yy");
            textBoxRemainingSalary.Text = "";
            if (comboBoxDoctor.Text == "")
            {
                MessageBox.Show("Please Select Doctor ");
            }
            else
            {
                gettingFeeStatus();
                gettingremainingFee();
                gettingadvanceFee();
                if (feeStatus == recieved)
                {
                    groupBoxsalaryDetail.Visible = false;
                    labelStatusDisplay.Text = feeStatus;
                }
                else if(feeStatus == notRecieved)
                {
                    groupBoxsalaryDetail.Visible = true;
                    labelStatusDisplay.Text = feeStatus;
                   
                    if(remainingDocFee>= 0)
                    {
                        textBoxRemainingSalary.Text = remainingDocFee.ToString();
                    }
                }
                else if(feeStatus == overRecieved)
                {
                    labelStatusDisplay.Text = feeStatus;
                }
                else
                {
                    MessageBox.Show("No Record Found");
                }
                
            }
            remainingDocFee = 0;
            advance = 0;
            feeStatus = "";
            
        }



        #region gettingData
        private void gettingadvanceFee()
        {
           
            try
            {
                connection.Open();
                String selectQuery = "SELECT advance FROM smc_database.doctorfees WHERE doctor_id = '" + doctorID + "'and fees_month = '" + currentMonth + "'";
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    advance = reader.GetDouble("advance");
                }
                    
                
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void gettingremainingFee()
        {
          
            try
            {
                connection.Open();
                String selectQuery = "SELECT remaining_fee FROM smc_database.doctorfees WHERE doctor_id = '" + doctorID + "'and fees_month = '"+currentMonth+"'";
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    remainingDocFee = reader.GetDouble("remaining_fee");
                }
                
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void gettingFeeStatus()
        {
            //string getstatus = "";
            try
            {
                connection.Open();
                String selectQuery = "SELECT fees_status FROM smc_database.doctorfees WHERE doctor_id = '" + doctorID + "'and fees_month = '" + currentMonth + "'";
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    feeStatus = reader.GetString("fees_status");

                }
                    
              
             
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

  
        }


        #endregion

        #region updateData

        private void updateAdvanceFee(double a)
        {
            gettingadvanceFee();
            double updateAdvance = advance + a;

            try
            {
                connection.Open();
                string updateQuery = "UPDATE smc_database.doctorfees SET advance = '" + updateAdvance + "' WHERE doctor_id = '" + doctorID + "' and fees_month = '" + currentMonth + "'";
                MySqlCommand command = new MySqlCommand(updateQuery, connection);
                if(command.ExecuteNonQuery() == 1)
                {
                   // MessageBox.Show("advance updated");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
            advance = 0;
        }

        private void updateRemainingFee(double a)
        {
            gettingremainingFee();
            double updateRemaining = remainingDocFee - a;

            try
            {
                connection.Open();
                string updateQuery = "UPDATE smc_database.doctorfees SET remaining_fee = '" + updateRemaining + "' WHERE doctor_id = '" + doctorID + "' and fees_month = '" + currentMonth + "'";
                MySqlCommand command = new MySqlCommand(updateQuery, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                   // MessageBox.Show("Remaining updated");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
            remainingDocFee = 0;
        }

        private void updateFeeStatus(string a)
        {
            string updateStatus =  a;

            try
            {
                connection.Open();
                string updateQuery = "UPDATE smc_database.doctorfees SET fees_status = '" + updateStatus + "' WHERE doctor_id = '" + doctorID + "' and fees_month = '" + currentMonth + "'";
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

        }


        #endregion

    }
}
