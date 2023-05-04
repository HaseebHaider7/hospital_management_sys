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
    public partial class removingForm : Form
    {
        String staffID;
        readonly MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=smc_database;username=root;password=3329992075i");

        public removingForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            String staffName = comboBoxDoctor.Text;

            try
            {
                String selectQuery = "SELECT doctor_id FROM smc_database.doctordetails WHERE doctor_name = '" + staffName + "'";

                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    staffID = reader.GetString("doctor_id");
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
            String staffName = comboBoxNurse.Text;

            try
            {
                String selectQuery = "SELECT nurse_id FROM smc_database.nursedetails WHERE  nurse_name = '" + staffName + "'";

                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    staffID = reader.GetString("nurse_id");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonDoctor_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxNurse.Items.Clear();
            label1.Visible = true;
            comboBoxDoctor.Visible = true;
            if(label2.Visible == true && comboBoxNurse.Visible == true)
            {
                label2.Visible = false;
                comboBoxNurse.Visible = false;
            }

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

        private void radioButtonNurse_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDoctor.Items.Clear();
            label2.Visible = true;
            comboBoxNurse.Visible = true;

            if(label1.Visible == true && comboBoxDoctor.Visible == true)
            {
                label1.Visible = false;
                comboBoxDoctor.Visible = false;
            }

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonDoctor.Checked)
            {
                if(comboBoxDoctor.Text == "")
                {
                    MessageBox.Show("Please Select Doctor From Doctor List");
                }
                else if(MessageBox.Show("Do You Really Want To Delete This ??","Message",MessageBoxButtons.YesNo)== DialogResult.Yes)
                {
                    try
                    {
                        connection.Open();
                        String DeleteQuery = "DELETE FROM smc_database.doctordetails WHERE doctor_id = '" + staffID + "'";
                        MySqlCommand deletingcmd = new MySqlCommand(DeleteQuery, connection);
                        deletingcmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                MessageBox.Show("Record Deleted");
                this.Close();

            }
            else if (radioButtonNurse.Checked)
            {
                if(comboBoxNurse.Text == "")
                {
                    MessageBox.Show("Please Selct Nurse From Nurse List");
                }
                else if(MessageBox.Show("Do You Really Want To Delete This??", "Message",MessageBoxButtons.YesNo)== DialogResult.Yes)
                {
                    try
                    {
                        connection.Open();
                        String DeleteQuery = "DELETE FROM smc_database.nursedetails WHERE nurse_id = '" + staffID + "'";
                        MySqlCommand deletingcmd = new MySqlCommand(DeleteQuery, connection);
                        deletingcmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                MessageBox.Show("Record Deleted");
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Please Select an Option");
            }


        }
    }
}
