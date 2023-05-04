using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class addNewDoc : Form
    {
        String doctorID, doctorName, doctorAddress, docConsultation, joiningDate, yearsOfService, doctorphno;
        private double? docfee;
        private DateTime presentYear;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPhNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 8 && ch!= 46)
            {
                e.Handled = true;
            }

        }

        private void textBoxFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private DateTime dob;
        readonly MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=smc_database;username=root;password=3329992075i");
      
        public addNewDoc()
        {
            InitializeComponent();
            GenerateID();
            joiningdateTimePicker.Value = DateTime.Now;
        }
        public void GenerateID()
        {
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("Select Max(doctor_id) from doctordetails", connection);
            var dr = cmd.ExecuteReader();
            string newId = string.Format("SMC-DOC-{0}-001", DateTime.Now.Year);
            if (dr.HasRows)
            {
                string prefix = string.Format("SMC-DOC-{0}", DateTime.Now.Year);
                while (dr.Read())
                {

                    string maxId = dr[0].ToString();
                    if (!string.IsNullOrWhiteSpace(maxId) && maxId.StartsWith(prefix))
                    {
                        int count = Convert.ToInt32(maxId.Split('-')[3]);
                        newId = string.Format("SMC-DOC-{0}-{1:000}", DateTime.Now.Year, count + 1);
                    }
                }
            }
            doctorID = newId;
            labeldocIDDisplay.Text = doctorID;
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
            doctorName = textBoxdoctorName.Text;
            doctorphno = textBoxPhNo.Text;
            doctorAddress = textBoxAddress.Text;
            docConsultation = textBoxConsultation.Text;
            joiningDate = joiningdateTimePicker.Value.ToString("dd/MM/yyyy");
            yearsOfService = calculateYearOfService();
            try
            {
                docfee = double.Parse(textBoxFee.Text);
            }
            catch
            {
                MessageBox.Show("Please enter only integer type value for Fee");
            }
            
            //fee = textBoxFee.Text;

            if(textBoxdoctorName.Text == "" ||  textBoxPhNo.Text == "" ||
                textBoxAddress.Text == "" || textBoxConsultation.Text == "" ||
                joiningdateTimePicker.Value == null || docfee == null)
            {
                MessageBox.Show("Please provide missing details");
            }
            else
            {
                double feetotal = 0, advance = 0, remainingfee = 0;
                string currentMonth = DateTime.Now.ToString("MMMM/yy");
                string notRecieved = "Not Recieved";
                string feesYear = DateTime.Now.ToString("yyyy");

                String insertQuery = "INSERT INTO smc_database.doctordetails (doctor_id, doctor_name,doctor_mobile_no,doctor_address,doctor_consultation,date_of_joining,years_of_service,fee)" +
                   " VALUES('" + doctorID + "','" + doctorName + "','" + doctorphno + "','" + doctorAddress + "','" + docConsultation + "','" + joiningDate + "','" + yearsOfService + "','"+docfee+"')";

                String insertQuery2 = "INSERT INTO smc_database.doctorfees (doctor_id,total_fee, advance, remaining_fee, fees_month, fees_year, fees_status)" +
                      "VALUES ('" + doctorID + "', '" + feetotal + "','" + advance + "', '" + remainingfee + "', '" + currentMonth + "','" + feesYear + "', '" + notRecieved + "')";

                MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                MySqlCommand insertCmd2 = new MySqlCommand(insertQuery2, connection);
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
