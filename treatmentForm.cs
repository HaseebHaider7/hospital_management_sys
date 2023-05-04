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
    public partial class treatmentForm : Form
    {
        string patientID;
        string patientstatus = "Admitted";
        String med1 = "", med2 = "", med3 = "", med4 = "", med5 = "", med6 = "", med7 = "", med8 = "", med9 = "", med10 = "";

        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=smc_database;username=root;password=3329992075i");
        public treatmentForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            patientID = comboBox1.Text;
        }

        private void treatmentForm_Load(object sender, EventArgs e)
        {
            try
            {

                String selectQuery = "SELECT patient_id FROM smc_database.patientdetails WHERE patient_status = '"+patientstatus+"'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString("patient_id"));

                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        


     

       


        private void btnSave_Click(object sender, EventArgs e)
        {
            
           if(comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please Select Patient");
            }
            else
            {
                try
                {
                    gettingTextbox1value();
                    gettingTextbox2value();
                    gettingTextbox3value();
                    gettingTextbox4value();
                    gettingTextbox5value();
                    gettingTextbox6value();
                    gettingTextbox7value();
                    gettingTextbox8value();
                    gettingTextbox9value();
                    gettingTextbox10value();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                updateDatabase();

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
                comboBox1.SelectedItem = null;
            }

            

        }



        #region gettingTextboxValue

        private string gettingTextbox1value()
        {
            if (textBox1.Text != null)
            {
                med1 = textBox1.Text;
            }
            else
            {
                med1 = "";
            }

            return med1;
        }
        private string gettingTextbox2value()
        {
            if (textBox2.Text != null)
            {
                med2 = textBox2.Text;
            }
            else
            {
                med2 = "";
            }

            return med2;
        }
        private string gettingTextbox3value()
        {
            if (textBox3.Text != null)
            {
                med3 = textBox3.Text;
            }
            else
            {
                med3 = "";
            }

            return med3;
        }
        private string gettingTextbox4value()
        {
            if (textBox4.Text != null)
            {
                med4 = textBox4.Text;
            }
            else
            {
                med4 = "";
            }

            return med4;
        }
        private string gettingTextbox5value()
        {
            if (textBox5.Text != null)
            {
                med5 = textBox5.Text;
            }
            else
            {
                med5 = "";
            }

            return med5;
        }
        private string gettingTextbox6value()
        {
            if (textBox6.Text != null)
            {
                med6 = textBox6.Text;
            }
            else
            {
                med6 = "";
            }

            return med6;
        }
        private string gettingTextbox7value()
        {
            if (textBox7.Text != null)
            {
                med7 = textBox7.Text;
            }
            else
            {
                med7 = "";
            }

            return med7;
        }
        private string gettingTextbox8value()
        {
            if (textBox8.Text != null)
            {
                med8 = textBox8.Text;
            }
            else
            {
                med8 = "";
            }

            return med8;
        }
        private string gettingTextbox9value()
        {
            if (textBox9.Text != null)
            {
                med9 = textBox9.Text;
            }
            else
            {
                med9 = "";
            }

            return med9;
        }
        private string gettingTextbox10value()
        {
            if (textBox10.Text != null)
            {
                med10 = textBox10.Text;
            }
            else
            {
                med10 = "";
            }

            return med10;
        }

        #endregion



        #region UpdatingDatabase

        private void updateDatabase()
        {
          //  string date = DateTime.Today.ToString("dd/MM/yyyy");
           
            try
            {
                connection.Open();
                string insertQuery = "INSERT INTO smc_database.medication (patient_id, med1, med2, med3, med4, med5, med6, med7, med8, med9, med10) "+
                                    "VALUES ('"+patientID+"','"+med1+"','"+med2+"','"+med3+"','"+med4+"','"+med5+"','"+med6+"','"+med7+"','"+med8+"','"+med9+"','"+med10+"')";

                MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                if (insertCmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Save");
                }
                else
                {
                    MessageBox.Show("Data Couldn't save");
                }
               
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
