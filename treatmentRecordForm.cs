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
    public partial class treatmentRecordForm : Form
    {
        string patientID;
        String med1 = "", med2 = "", med3 = "", med4 = "", med5 = "", med6 = "", med7 = "", med8 = "", med9 = "", med10 = "";
        string medicationDate;
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=smc_database;username=root;password=3329992075i");
        public treatmentRecordForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            patientID = textBoxPatientID.Text;
            textBoxMD.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";

            gettingMedicineData(patientID);


        }

        private void gettingMedicineData(string patient)
        {
            try
            {
                connection.Open();

                string selectQuery = "SELECT * From medication WHERE patient_id = '" + patient + "'";
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    medicationDate = reader.GetString("medication_date");
                    med1 = reader.GetString("med1");
                    med2 = reader.GetString("med2");
                    med3 = reader.GetString("med3");
                    med4 = reader.GetString("med4");
                    med5 = reader.GetString("med5");
                    med6 = reader.GetString("med6");
                    med7 = reader.GetString("med7");
                    med8 = reader.GetString("med8");
                    med9 = reader.GetString("med9");
                    med10 = reader.GetString("med10");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No Record Found");
                textBoxMD.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";

            }

            connection.Close();

            groupBox1.Visible = true;
            textBoxMD.Text = medicationDate;
            textBox1.Text = med1;
            textBox2.Text = med2;
            textBox3.Text = med3;
            textBox4.Text = med4;
            textBox5.Text = med5;
            textBox6.Text = med6;
            textBox7.Text = med7;
            textBox8.Text = med8;
            textBox9.Text = med9;
            textBox10.Text = med10;
        }
    }
}
