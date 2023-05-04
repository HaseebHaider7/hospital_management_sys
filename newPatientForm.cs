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
    public partial class newPatientForm : Form
    {
        readonly MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=smc_database;username=root;password=3329992075i");
        DateTime dob,presentYear;
        String paymentMonth, paymentDate, paymentYear;
        Double doctorFee = 0.0, wardFee = 0.0, incubatorFee = 0.0, oxygenFee = 0.0, phototherapyFee = 0.0 , operationFee = 0.0, balance = 0.0, totalFee = 0.0, otherFee = 0.0, recordFee = 0.0;

        int  doctorDays = 0, wardDays = 0, incubatorDays = 0, oxygenDays = 0, phototherapyDays = 0, otherDays =0;

        String PatientName, DateOfBirth, Gender, Age, FatherName, PatientAddress, AssignedDoctor, doctorConsultation, PatientID , CNIC, docfee, paymentID, doctorID;

        
        double doctorTotalFee = 0, remainingfee = 0;


        private void checkBoxFree_CheckedChanged(object sender, EventArgs e)
        {
            labelFeeDisplay.Text = "0";
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        String patientStatus = "Admitted";
        String cnic1, cnic2, cnic3;

       
        double deposite = 0;
        readonly String admissionDate = DateTime.Now.ToString("dddd  dd-MM-yyyy  hh:mm");


        public newPatientForm()
        {

            InitializeComponent();
            labelcurrentDate.Text = admissionDate;
            GenerateID();
            GeneratingPaymentID();
            DOBdateTimePicker.Value = DateTime.Now;

        }

        private void genderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            presentYear = DateTime.Now;
            dob = DOBdateTimePicker.Value;

            TimeSpan ts = presentYear - dob;

            int age = ts.Days / 365;

            Age = age.ToString();
            Age = (Age + " years");
            labelAgeDisplay.Text = Age;
        }

        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedDoc = comboBoxDoctor.Text;

            try
            {
                String selectQuery = "SELECT fee, doctor_consultation, doctor_id FROM smc_database.doctordetails WHERE doctor_name = '" + selectedDoc + "'";
               
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    doctorID = reader.GetString("doctor_id");
                    labelFeeDisplay.Text = reader.GetString("fee");
                    doctorConsultation = reader.GetString("doctor_consultation");
                    
                }

                connection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if(doctorConsultation == "Surgeon")
            {
                checkBoxoperation.Visible = true;
                textBoxOperation.Visible = true;
                lineShape11.Visible = true;
            }
            else
            {
                checkBoxoperation.Visible = false;
                textBoxOperation.Visible = false;
                lineShape11.Visible = false;
            }

        }

        #region restrictingCharotherThanNumeric


        private void textBoxCNIC1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxCNIC2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        
        private void textBoxCNIC3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxOperation_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxWardFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxIncubatorFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxOxygenFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxPhotoTherapy_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxother_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

       




        #endregion


        private void newPatientForm_Load(object sender, EventArgs e)
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

            textBoxDeposite.Text = deposite.ToString();


        }

        public String cnicMaker()
        {

            cnic1 = textBoxCNIC1.Text;
            cnic2 = textBoxCNIC2.Text;
            cnic3 = textBoxCNIC3.Text;
            
            CNIC = cnic1 + "-" + cnic2 + "-" + cnic3;

            return CNIC;
        }
        public void GenerateID()
        {
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("Select Max(patient_id) from patientdetails", connection);

            var dr = cmd.ExecuteReader();
            string newId = string.Format("SMC-{0}-000001", DateTime.Now.Year);
            if (dr.HasRows)
            {
                string prefix = string.Format("SMC-{0}", DateTime.Now.Year);
                while (dr.Read())
                {

                    string maxId = dr[0].ToString();
                    if (!string.IsNullOrWhiteSpace(maxId) && maxId.StartsWith(prefix))
                    {
                        int count = Convert.ToInt32(maxId.Split('-')[2]);
                        newId = string.Format("SMC-{0}-{1:000000}", DateTime.Now.Year, count + 1);
                    }
                }
            }
            PatientID = newId;
            labelPatientIDDisplay.Text = PatientID;
            connection.Close();

            
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
        public String calculateAge()
        {
            presentYear = DateTime.Now;
            dob = DOBdateTimePicker.Value;

            TimeSpan ts = presentYear - dob;

            int age = ts.Days / 365;

            Age = age.ToString();
            Age = (Age + " years");
            return Age;
        }


        private void textboxChangeFocus(object sender, EventArgs e)
        {
            if(textBoxCNIC1.TextLength > 4)
            {
                textBoxCNIC2.Focus();
            }
            else if(textBoxCNIC2.TextLength > 6)
            {
                textBoxCNIC3.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            labelAgeDisplay.Text = calculateAge();
        }


        #region checkboxchecking
        private void wardcheckboxChecking()
        {
            try
            {
                if (checkBoxWard.Checked)
                {
                    wardFee = double.Parse(textBoxWardFee.Text);
                    wardDays = 1;
                }
                else if(textBoxWardFee.Text != "" && checkBoxWard.Checked == false)
                {
                    MessageBox.Show("Please Check the corresponding Checked box");
                }
               
               
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }
        private void incubatorChecking()
        {
            try
            {
                if (checkBoxIncubator.Checked)
                {
                    incubatorFee = double.Parse(textBoxIncubatorFee.Text);
                    incubatorDays = 1;
                }
                else if (textBoxIncubatorFee.Text != "" && checkBoxIncubator.Checked == false)
                {
                    MessageBox.Show("Please Check the corresponding Checked box");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void oxygenChecking()
        {
            try
            {
                if (checkBoxOxygen.Checked)
                {
                    oxygenFee = double.Parse(textBoxOxygenFee.Text);
                    oxygenDays = 1;
                }
                else if (textBoxOxygenFee.Text != "" && checkBoxOxygen.Checked == false)
                {
                    MessageBox.Show("Please Check the corresponding Checked box");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void phototherapyChecking()
        {
            try
            {
                if (checkBoxphototherapy.Checked)
                {
                    phototherapyFee = double.Parse(textBoxPhotoTherapy.Text);
                    phototherapyDays = 1;
                }
                else if (textBoxPhotoTherapy.Text != "" && checkBoxphototherapy.Checked == false)
                {
                    MessageBox.Show("Please Check the corresponding Checked box");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void otherChecking()
        {
            try
            {
                if (checkBoxOther.Checked)
                {
                    otherFee = double.Parse(textBoxother.Text);
                    otherDays = 1;
                }
                else if (textBoxother.Text != "" && checkBoxOther.Checked == false)
                {
                    MessageBox.Show("Please Check the corresponding Checked box");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private double operationcheckboxChecking()
        {
           if (checkBoxoperation.Checked==true)
           {
                try
                {
                    operationFee = double.Parse(textBoxOperation.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


           }
           else if (textBoxOperation.Text != "" && checkBoxoperation.Checked == false)
           {
                    MessageBox.Show("Please Check the corresponding Checked box");
           }
            else
            {
                operationFee = 0.0;
            }

            return operationFee;

        }
        #endregion

        #region updatingDatabase


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
           // remainingfee = 0;
            double updateDocfee = 0, updateRemainingFee = 0;
            double currentDocFee = gettingDoctorTotalfee();
            double currentRemaining = gettingRemainingfee();
            if (currentDocFee > 0 && currentRemaining < 0)
            {
                updateDocfee = currentDocFee + doctorFee + operationFee;
                updateRemainingFee = currentRemaining + doctorFee + operationFee;
                string notRecieved = "Not Recieved";
                try
                {
                    connection.Open();
                    string updateQuery = "UPDATE smc_database.doctorfees SET total_fee = '" + updateDocfee + "', remaining_fee = '" + updateRemainingFee + "', fees_status = '" + notRecieved + "' WHERE doctor_id = '" + doctorID + "' and fees_month = '" + paymentMonth + "'";
                    MySqlCommand command = new MySqlCommand(updateQuery, connection);
                    if (command.ExecuteNonQuery() == 1)
                    {
                      //  MessageBox.Show("done 2");
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"this");
                }

            }
            else if (currentDocFee > 0 && currentRemaining > 0)
            {
                updateDocfee = currentDocFee + doctorFee + operationFee;
                updateRemainingFee = currentRemaining + doctorFee + operationFee;
                string notRecieved = "Not Recieved";
                try
                {
                    connection.Open();
                    string updateQuery = "UPDATE smc_database.doctorfees SET total_fee = '" + updateDocfee + "', remaining_fee = '" + updateRemainingFee + "', fees_status = '"+notRecieved+"' WHERE doctor_id = '" + doctorID + "' and fees_month = '" + paymentMonth + "'";
                    MySqlCommand command = new MySqlCommand(updateQuery, connection);
                    if (command.ExecuteNonQuery() == 1)
                    {
                       // MessageBox.Show("done");
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
                double combineFee = doctorFee + operationFee;
                try
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO smc_database.doctorfees (doctor_id, total_fee,advance, remaining_fee, fees_month, fees_year, fees_status) " +
                                            "VALUES ('" + doctorID + "','" + combineFee + "','" + advance + "','" + combineFee + "','" + paymentMonth + "','" + paymentYear + "','" + notRecieved + "')";

                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    if (command.ExecuteNonQuery() == 1)
                    {
                       // MessageBox.Show("done");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                combineFee = 0;
            }

        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            PatientName = textBoxPname.Text;
            DateOfBirth = DOBdateTimePicker.Value.ToString("dd/MM/yyyy");
            Gender = genderBox.Text;
            Age = calculateAge();
            FatherName = textBoxFname.Text;
            AssignedDoctor = comboBoxDoctor.Text;
            PatientAddress = textBoxPatientAddress.Text;
            CNIC = cnicMaker();
            docfee = labelFeeDisplay.Text;
            paymentMonth = DateTime.Now.ToString("MMMM/yy");
            paymentYear  = DateTime.Now.ToString("yyyy");
            paymentDate  = DateTime.Now.ToString("dd/MM/yyyy");
            wardcheckboxChecking();
            incubatorChecking();
            oxygenChecking();
            phototherapyChecking();
            operationcheckboxChecking();
            otherChecking();
            
            doctorDays = 1;
            deposite = double.Parse(textBoxDeposite.Text);
            if (checkBoxFree.Checked)
            {
                doctorFee = 0.0;
            }
            else
            {
                try
                {
                    doctorFee = double.Parse(docfee);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            totalFee = doctorFee + operationFee + wardFee + incubatorFee + oxygenFee + phototherapyFee + otherFee;
            balance = totalFee - deposite;
            recordFee = totalFee - doctorFee;
            if (textBoxPname.Text == "" || DOBdateTimePicker.Value==null   || genderBox.Text==""||
                textBoxFname.Text == "" || textBoxCNIC1.Text ==""          || textBoxCNIC2.Text =="" ||
                textBoxCNIC3.Text ==""  || textBoxPatientAddress.Text =="" || comboBoxDoctor.Text == ""||
                (checkBoxoperation.Checked && textBoxOperation.Text == "") ||
                (checkBoxWard.Checked && textBoxWardFee.Text =="")    || (checkBoxIncubator.Checked && textBoxIncubatorFee.Text =="") ||
                (checkBoxOxygen.Checked && textBoxOxygenFee.Text=="") || (checkBoxphototherapy.Checked && textBoxPhotoTherapy.Text == "")
                || (checkBoxOther.Checked && textBoxother.Text == ""))
            {
                MessageBox.Show("Please provide missing details");
            }
            else 
            {
                String insertQuery = "INSERT INTO smc_database.patientdetails (patient_id, patient_name,date_of_birth,gender,age,father_name,cnic,patient_address,admission_date,assigned_doctor,patient_status,doctor_fee_charged,doctor_id, operationfee)" +
                    " VALUES('" + PatientID + "','" + PatientName + "','" + DateOfBirth + "','" + Gender + "','" + Age + "','" + FatherName + "','" + CNIC + "','" + PatientAddress + "','" + admissionDate + "','" + AssignedDoctor + "','" + patientStatus + "','"+docfee+"','"+doctorID+"', '"+operationFee+"')";
                
                String insertQuery2 = "INSERT INTO smc_database.paymentdetails (payment_id,patientid,doctorid, doctor_fee,operation_fee, ward_fee, incubator_fee, oxygen_fee, phototherapy_fee,other_fee, deposite, total_fee, record_fee, balance, payment_month, payment_year, payment_date)" +
                                        "VALUES ('" + paymentID + "','" + PatientID + "','"+doctorID+"','" + doctorFee + "','"+operationFee+"','" + wardFee + "','" + incubatorFee + "','" + oxygenFee + "','" + phototherapyFee + "','"+otherFee+"','"+deposite+ "','" + totalFee + "', '"+recordFee+"','" + balance + "','" + paymentMonth + "','" + paymentYear + "','" + paymentDate + "')";

                String insertQuery3 = "INSERT INTO smc_database.patientstatus (patient_id,doctor_id,assigned_doctor,doctors_day,wards_day,incubators_day,oxygen_day,phototherapy_day,other_day)" +
                                       "VALUES ('" + PatientID + "','"+doctorID+"','"+AssignedDoctor+"','"+doctorDays+"','"+wardDays+"','"+incubatorDays+"','"+oxygenDays+"','"+phototherapyDays+"','"+otherDays+"')";

               
                MySqlCommand insertCmd  = new MySqlCommand(insertQuery, connection);
                MySqlCommand insertCmd2 = new MySqlCommand(insertQuery2, connection);
                MySqlCommand insertCmd3 = new MySqlCommand(insertQuery3, connection);

                connection.Open();

                try
                {
                    if (insertCmd.ExecuteNonQuery() == 1 && insertCmd2.ExecuteNonQuery() == 1 && insertCmd3.ExecuteNonQuery()==1 )
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
    }
}
