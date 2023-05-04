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
    public partial class updatepatientStatsuForm : Form
    {
        String patientID;
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=smc_database;username=root;password=3329992075i");
      
        double deposite = 0;
        string admittedPatient = "Admitted";
        double doctorTotalFee = 0, remainingfee = 0;

        //for getting data

        string paymentMonth, paymentDate, paymentYear;
        double doctorFee = 0.0, operationFee = 0.0, wardFee = 0.0, incubatorFee = 0.0, oxygenFee = 0.0, phototherapyFee = 0.0, otherFee = 0.0, balance = 0.0, totalFee = 0.0, recordFee = 0.0;
        double DBdoctorfee,DBoperationfee, DBwardfee, DBincubatorFee, DBoxygenfee, DBphototherapyfee, DBother, DBdeposite;



        #region restrictionONChar
        private void textBoxdoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxward_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxincubator_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxoxygen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxPhototherapy_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxOther_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxDeposite_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        #endregion


        string paymentID, doctorID;
        //newPatientForm payid = new newPatientForm();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public updatepatientStatsuForm()
        {
            InitializeComponent();
         
        }

        private void updatepatientStatsuForm_Load(object sender, EventArgs e)
        {
            try
            {
                String gettingQuery = "SELECT patient_id FROM smc_database.patientdetails WHERE patient_status = '"+admittedPatient+"'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(gettingQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxPatientID.Items.Add(reader.GetString("patient_id"));

                }

                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxPatientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;

            textBoxdoctor.Text = "";
            textBoxward.Text = "";
            textBoxincubator.Text = "";
            textBoxoxygen.Text = "";
            textBoxPhototherapy.Text = "";
            textBoxDeposite.Text = "";
            textBoxOther.Text = "";

            patientID = comboBoxPatientID.Text;
            try
            {
                connection.Open();
                string getDoctor = "SELECT doctor_id,doctor_fee_charged FROM smc_database.patientdetails WHERE patient_id = '" + patientID + "'";
               
                MySqlCommand comd = new MySqlCommand(getDoctor, connection);
               

                MySqlDataReader reader = comd.ExecuteReader();
               
                while (reader.Read())
                {
                    doctorID = reader.GetString("doctor_id");
                    doctorFee = double.Parse(reader.GetString("doctor_fee_charged"));

                }

                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            gettingFee();

        }

        private void gettingFee()
        {
            try
            {
                connection.Open();
                string get_fees = "SELECT doctor_fee, operation_fee, ward_fee, incubator_fee, oxygen_fee, phototherapy_fee, other_fee, deposite FROM smc_database.paymentdetails WHERE patientid = '" + patientID + "'";

                MySqlCommand cmd1 = new MySqlCommand(get_fees, connection);
                MySqlDataReader rdr = cmd1.ExecuteReader();
                while (rdr.Read())
                {
                    DBdoctorfee = rdr.GetDouble("doctor_fee");
                    DBoperationfee = rdr.GetDouble("operation_fee");
                    DBwardfee = rdr.GetDouble("ward_fee");
                    DBincubatorFee = rdr.GetDouble("incubator_fee");
                    DBoxygenfee = rdr.GetDouble("oxygen_fee");
                    DBphototherapyfee = rdr.GetDouble("phototherapy_fee");
                    DBother = rdr.GetDouble("other_fee");
                    DBdeposite = rdr.GetDouble("deposite");
                }
                connection.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
     
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(comboBoxPatientID.Text == "")
            {
                MessageBox.Show("Please Select Patient ID");
            }
            else if(textBoxdoctor.Text != "" && checkBox1.Checked == false || textBoxward.Text != "" && checkBox2.Checked == false 
                || textBoxincubator.Text != "" && checkBox3.Checked == false || textBoxoxygen.Text != "" && checkBox4.Checked == false
                || textBoxPhototherapy.Text != "" && checkBox5.Checked == false || textBoxDeposite.Text != "" && checkBox6.Checked == false)
            {
                MessageBox.Show("Please Check the corresponding Checked box");
            }
            else
            {
                
                checkbox1Checking();
                checkbox2Checking();
                checkbox3Checking();
                checkbox4Checking();
                checkbox5Checking();
                checkbox6Checking();
                checkbox7Checking();

                doctorFee += DBdoctorfee;
                operationFee += DBoperationfee;
                wardFee += DBwardfee;
                incubatorFee += DBincubatorFee;
                oxygenFee += DBoxygenfee;
                phototherapyFee += DBphototherapyfee;
                otherFee += DBother;
                deposite += DBdeposite;

                totalFee = doctorFee + operationFee + wardFee + incubatorFee + oxygenFee + phototherapyFee + otherFee;
                balance = totalFee - deposite;
                recordFee = totalFee - doctorFee;

                paymentMonth = DateTime.Now.ToString("MMMM/yy");
                paymentYear = DateTime.Now.ToString("yyyy");
                paymentDate = DateTime.Now.ToString("dd/MM/yyyy");

                try
                {
                    String updateQuery = "UPDATE smc_database.paymentdetails SET doctor_fee = '" + doctorFee + "', operation_fee = '" + operationFee + "', ward_fee = '" + wardFee + "', incubator_fee = '" + incubatorFee + "', oxygen_fee = '" + oxygenFee + "', phototherapy_fee = '" + phototherapyFee + "',other_fee = '"+otherFee+"', deposite = '" + deposite + "', total_fee = '" + totalFee + "',record_fee = '"+recordFee+"', balance = '" + balance + "' WHERE patientid = '" + patientID+"'";


                    MySqlCommand insertCmd2 = new MySqlCommand(updateQuery, connection);

                    connection.Open();
                    if (insertCmd2.ExecuteNonQuery() == 1)
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
                updateDocfee();
                this.Close();
                





            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxdoctor.Text = doctorFee.ToString();
        }

        public string GeneratingPaymentID()
        {
            connection.Open();
            MySqlCommand cmd2 = new MySqlCommand("Select Max(payment_id) from smc_database.paymentdetails", connection);

            var dr = cmd2.ExecuteReader();
            string newId = string.Format("PAY-{0}-000001", DateTime.Now.Year);
            if (dr.HasRows)
            {
                string prefix = string.Format("PAY-{0}", DateTime.Now.Year);
                while (dr.Read())
                {

                    string maxId = dr[0].ToString();
                    if (!string.IsNullOrWhiteSpace(maxId) && maxId.StartsWith(prefix))
                    {
                        int count = Convert.ToInt32(maxId.Split('-')[2]);
                        newId = string.Format("PAY-{0}-{1:000000}", DateTime.Now.Year, count + 1);
                    }
                }
            }
            paymentID = newId;
            connection.Close();

            return paymentID;
        }


        #region checkboxChecking

        private void checkbox1Checking()
        {
            if(checkBox1.Checked == true)
            {
                try
                {
                   
                        doctorFee = double.Parse(textBoxdoctor.Text);
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                doctorFee = 0;
            }


        }
        private void checkbox2Checking()
        {
            try
            {
                if (checkBox2.Checked && textBoxward.Text == "")
                {
                    MessageBox.Show("Please Type in Ward Fee");

                }
                else if(textBoxward.Text =="" && checkBox2.Checked == false)
                {
                    wardFee = 0;
                }

                else
                {
                    wardFee = double.Parse(textBoxward.Text);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void checkbox3Checking()
        {
            try
            {
                if (checkBox3.Checked && textBoxincubator.Text == "")
                {
                    MessageBox.Show("Please Type in Doctor Fee");
                    

                }
                else if (textBoxincubator.Text == "" && checkBox3.Checked == false)
                {
                    incubatorFee = 0;
                }
                else
                {
                    incubatorFee = double.Parse(textBoxincubator.Text);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void checkbox4Checking()
        {
            try
            {
                if (checkBox4.Checked && textBoxoxygen.Text == "")
                {
                    MessageBox.Show("Please Type in Doctor Fee");
                    

                }
                else if (textBoxoxygen.Text == "" && checkBox4.Checked == false)
                {
                    oxygenFee = 0;
                }
                else
                {
                    oxygenFee = double.Parse(textBoxoxygen.Text);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void checkbox5Checking()
        {
            try
            {
                if (checkBox5.Checked && textBoxPhototherapy.Text == "")
                {
                    MessageBox.Show("Please Type in Doctor Fee");
                   

                }
                else if (textBoxPhototherapy.Text == "" && checkBox5.Checked == false)
                {
                    phototherapyFee = 0;
                }
                else
                {
                    phototherapyFee = double.Parse(textBoxPhototherapy.Text);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void checkbox6Checking()
        {
            try
            {
                if (checkBox6.Checked && textBoxDeposite.Text == "")
                {
                    MessageBox.Show("Please Type in Deposite");
                    

                }
                else if (textBoxDeposite.Text == "" && checkBox6.Checked == false)
                {
                    deposite = 0;
                }
                else
                {
                    deposite = double.Parse(textBoxDeposite.Text);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void checkbox7Checking()
        {
            try
            {
                if (checkBox7.Checked && textBoxOther.Text == "")
                {
                    MessageBox.Show("Please Type in Other charges");


                }
                else if (textBoxOther.Text == "" && checkBox7.Checked == false)
                {
                    otherFee = 0;
                }
                else
                {
                    otherFee = double.Parse(textBoxOther.Text);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        #endregion

        #region Updating
        private double gettingDoctorTotalfee()
        {
            try
            {
                connection.Open();
                string getDoctotal = "SELECT total_fee,remaining_fee FROM smc_database.doctorfees WHERE doctor_id = '" + doctorID + "' and fees_month = '" + paymentMonth + "'";

                MySqlCommand command = new MySqlCommand(getDoctotal, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    doctorTotalFee = reader.GetDouble("total_fee");
                    remainingfee = reader.GetDouble("remaining_fee");
                }
            }
            catch (Exception ex)
            {
                doctorTotalFee = 0;
                MessageBox.Show(ex.Message);
            }
            connection.Close();

            return doctorTotalFee;
        }
        private double gettingRemainingfee()
        {
            try
            {
                connection.Open();
                string getDoctotal = "SELECT remaining_fee FROM smc_database.doctorfees WHERE doctor_id = '" + doctorID + "' and fees_month = '" + paymentMonth + "'";

                MySqlCommand command = new MySqlCommand(getDoctotal, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    remainingfee = reader.GetDouble("remaining_fee");
                }
            }
            catch (Exception ex)
            {
                doctorTotalFee = 0;
                MessageBox.Show(ex.Message);
            }
            connection.Close();

            return remainingfee;
        }
        private void updateDocfee()
        {
            double updateDocfee = 0, updateRemainingFee = 0;
            double currentDocFee = gettingDoctorTotalfee();
            double currentRemaining = gettingRemainingfee();

            if (currentDocFee > 0 && currentRemaining < 0)
            {
                updateDocfee = currentDocFee + doctorFee;
                updateRemainingFee = currentRemaining + doctorFee;
                string notRecieved = "Not Recieved";
                try
                {
                    connection.Open();
                    string updateQuery = "UPDATE smc_database.doctorfees SET total_fee = '" + updateDocfee + "', remaining_fee = '" + updateRemainingFee + "', fees_status = '" + notRecieved + "' WHERE doctor_id = '" + doctorID + "' and fees_month = '" + paymentMonth + "'";
                    MySqlCommand command = new MySqlCommand(updateQuery, connection);
                    if (command.ExecuteNonQuery() == 1)
                    {
                       // MessageBox.Show("done 2");
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (currentDocFee > 0 && currentRemaining > 0)
            {
                updateDocfee = currentDocFee + doctorFee;
                updateRemainingFee = currentRemaining + doctorFee;
                string notRecieved = "Not Recieved";
                try
                {
                    connection.Open();
                    string updateQuery = "UPDATE smc_database.doctorfees SET total_fee = '" + updateDocfee + "', remaining_fee = '" + updateRemainingFee + "', fees_status = '" + notRecieved + "' WHERE doctor_id = '" + doctorID + "' and fees_month = '" + paymentMonth + "'";
                    MySqlCommand command = new MySqlCommand(updateQuery, connection);
                    if (command.ExecuteNonQuery() == 1)
                    {
                       // MessageBox.Show("done", "11");
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                double advance = 0;
                string notRecieved = "Not Recieved";

                try
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO smc_database.doctorfees (doctor_id, total_fee,advance, remaining_fee, fees_month, fees_year, fees_status) " +
                                            "VALUES ('" + doctorID + "','" + doctorFee + "','" + advance + "','" + doctorFee + "','" + paymentMonth + "','" + paymentYear + "','" + notRecieved + "')";

                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    if (command.ExecuteNonQuery() == 1)
                    {
                       // MessageBox.Show("done", "22");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "this last one");
                }
            }

        }

        #endregion
    }
}
