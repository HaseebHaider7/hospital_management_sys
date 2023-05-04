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
    public partial class DischargingPatient : Form
    {
        readonly MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=smc_database;username=root;password=3329992075i");
        readonly String dischargingDate = DateTime.Now.ToString("dddd  dd-MM-yyyy  hh:mm");
        public static String patientIDgiver;
        String patientID;
        readonly String patientStatus = "Discharged";
        
        public DischargingPatient()
        {
            InitializeComponent();
            labeldischargingDateDisplay.Text = dischargingDate;
           
        }

        private void BtnDischarge_Click(object sender, EventArgs e)
        {

            String insertQuery = "UPDATE smc_database.patientdetails SET patient_status = '" + patientStatus + "',discharging_date = '" + dischargingDate + "'" +
                                "WHERE patient_id = '" + patientID + "'";

            MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
            connection.Open();
            try
            {
                if (insertCmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Patient Discharged.");
                    printing_Form p = new printing_Form();
                    p.PatientID = patientID;
                    p.Show();
                }
                else
                {
                    MessageBox.Show("Provide Patient ID to proceed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
           // this.Close();




        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DischargingPatient_Load(object sender, EventArgs e)
        {
            string admitted = "Admitted";
            try
            {

                String selectQuery = "SELECT * FROM smc_database.patientdetails WHERE patient_status = '"+admitted+"'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxPatientID.Items.Add(reader.GetString("patient_id"));

                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboBoxPatientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            patientID = comboBoxPatientID.Text;
            patientIDgiver = patientID;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // new invoicing_Form().Show();
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
