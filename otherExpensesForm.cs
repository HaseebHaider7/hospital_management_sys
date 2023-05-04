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
    public partial class otherExpensesForm : Form
    {
        double oxygenBill = 0, electricityBill = 0, supplyBill = 0, otherBill = 0, totalBill = 0;
        String date, billingmonth, billingYear;

        
        List<double> Listoxygenbill = new List<double>();
        List<double> Listelectricitybill = new List<double>();
        List<double> Listsupplybill = new List<double>();
        List<double> Listotherbill = new List<double>();
        List<string> Listbillmonth = new List<string>();
        List<string> Listbillyear = new List<string>();
        

        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=smc_database;username=root;password=3329992075i");
        connectionDB con = new connectionDB();
        public otherExpensesForm()
        {
            InitializeComponent();
            dateTimePicker.Value = DateTime.Now;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            date = dateTimePicker.Value.ToString("dd/MM/yy");
            billingmonth = dateTimePicker.Value.ToString("MMMM/yy");
            billingYear = dateTimePicker.Value.ToString("yyyy");
         
            oxygenChecking();
            electricityChecking();
            supplyChecking();
            otherChecking();

            totalBill = oxygenBill + electricityBill + supplyBill + otherBill;
      
            String insertQuery = "INSERT INTO smc_database.expenses (oxygen_bill, electricity_bill, supply_bill, other_bill,total_bill, billing_month, billing_year, date)"+
                                    "VALUES ('"+oxygenBill+ "','"+electricityBill+ "','"+supplyBill+ "','"+otherBill+ "','"+totalBill+"','"+billingmonth+ "','"+billingYear+"','"+date+"')";

            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            connection.Open();

            try
            {
                if(command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Saved");
                }
                else
                {
                    MessageBox.Show("Data Couldn't save");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            textBoxOxygen.Text = "";
            textBoxelectricity.Text = "";
            textBoxother.Text = "";
            textBoxsupply.Text = "";
            checkBoxOxygen.Checked = false;
            checkBoxElectricity.Checked = false;
            checkBoxSupply.Checked = false;
            checkBoxOther.Checked = false;

        }

        private void btnEnterNewRecord_Click(object sender, EventArgs e)
        {
            btnMonthly.Visible = false;
            btnyearly.Visible = false;
            dataGridView1.Visible = false;
            groupBoxEnterRecord.Visible = true;
            paneldatagridview.Visible = true;
            btnSave.Visible = true;
            
        }

        private void btnShowRecords_Click(object sender, EventArgs e)
        {
            groupBoxEnterRecord.Visible = false;
            btnSave.Visible = false;
            btnMonthly.Visible = true;
            btnyearly.Visible = true;
        }


        private void btnyearly_Click(object sender, EventArgs e)
        {
           // groupBoxEnterRecord.Visible = false;
            paneldatagridview.Visible = true;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Lucida Bright", 9, FontStyle.Regular);
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = true;
            getYearlyData();

            if (Listbillyear.Count > 0)
            {

                updateYearlyGridView();

            }
            else
            {
                MessageBox.Show("Data not found");
            }
        }


        private void btnMonthly_Click(object sender, EventArgs e)
        {
            paneldatagridview.Visible = true;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Lucida Bright", 9, FontStyle.Regular);
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = true;
            getMonthlyData();

            if (Listbillmonth.Count > 0)
            {

                updateMonthlyGridView();

            }
            else
            {
                MessageBox.Show("Data not found");
            }
        }
        #region updateGridView

        private void updateMonthlyGridView()
        {

            for (int i = 0; i < Listbillmonth.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dataGridView1);
              
                newRow.Cells[0].Value = Listoxygenbill[i];
                
                newRow.Cells[1].Value = Listelectricitybill[i];
                newRow.Cells[2].Value = Listsupplybill[i];
                newRow.Cells[3].Value = Listotherbill[i];
                newRow.Cells[4].Value = Listbillmonth[i];
              

                dataGridView1.Rows.Add(newRow);
                
            }

        }


        private void updateYearlyGridView()
        {

            for (int i = 0; i < Listbillyear.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dataGridView1);

                newRow.Cells[0].Value = Listoxygenbill[i];

                newRow.Cells[1].Value = Listelectricitybill[i];
                newRow.Cells[2].Value = Listsupplybill[i];
                newRow.Cells[3].Value = Listotherbill[i];
                newRow.Cells[4].Value = Listbillyear[i];


                dataGridView1.Rows.Add(newRow);

               
            }
            

        }

        private void textBoxOxygen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private void textBoxelectricity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private void textBoxsupply_KeyPress(object sender, KeyPressEventArgs e)
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

        #region gettingdata

        private void getMonthlyData()
        {
            Listoxygenbill.Clear();
            Listelectricitybill.Clear();
            Listsupplybill.Clear();
            Listotherbill.Clear();
            Listbillmonth.Clear();


            try
            {

            con.Open();
            String gettingQuery = "SELECT billing_month, SUM(oxygen_bill) AS oxygen_Bill, SUM(electricity_bill) AS electricity_bill, SUM(supply_bill) AS supply_bill, SUM(other_bill) AS other_bill FROM smc_database.expenses GROUP BY billing_month";


            MySqlDataReader reader;
            reader = con.ExecuteReader(gettingQuery);

                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                   
                        Listoxygenbill.Add((double)reader["oxygen_bill"]);
                        Listelectricitybill.Add((double)reader["electricity_bill"]);
                        Listsupplybill.Add((double)reader["supply_bill"]);
                        Listotherbill.Add((double)reader["other_bill"]);
                        Listbillmonth.Add(reader["billing_month"].ToString());
                      
                    

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }


        private void getYearlyData()
        {
            Listoxygenbill.Clear();
            Listelectricitybill.Clear();
            Listsupplybill.Clear();
            Listotherbill.Clear();
            Listbillyear.Clear();


            try
            {

                con.Open();
                String gettingQuery = "SELECT billing_year, SUM(oxygen_bill) AS oxygen_Bill, SUM(electricity_bill) AS electricity_bill, SUM(supply_bill) AS supply_bill, SUM(other_bill) AS other_bill FROM smc_database.expenses GROUP BY billing_year";


                MySqlDataReader reader;
                reader = con.ExecuteReader(gettingQuery);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        Listoxygenbill.Add((double)reader["oxygen_bill"]);
                        Listelectricitybill.Add((double)reader["electricity_bill"]);
                        Listsupplybill.Add((double)reader["supply_bill"]);
                        Listotherbill.Add((double)reader["other_bill"]);
                        Listbillyear.Add(reader["billing_year"].ToString());



                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }




        #endregion


        #region checkboxchecking

        private void oxygenChecking()
        {
            try
            {
                if (checkBoxOxygen.Checked)
                {
                    oxygenBill = double.Parse(textBoxOxygen.Text);
                    
                }
                else if (textBoxOxygen.Text != "" && checkBoxOxygen.Checked == false)
                {
                    MessageBox.Show("Please Check the corresponding Checked box");
                }


            }
            catch (Exception ex)
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
                    otherBill = double.Parse(textBoxother.Text);

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

        private void electricityChecking()
        {
            try
            {
                if (checkBoxElectricity.Checked)
                {
                    electricityBill = double.Parse(textBoxelectricity.Text);

                }
                else if (textBoxelectricity.Text != "" && checkBoxElectricity.Checked == false)
                {
                    MessageBox.Show("Please Check the corresponding Checked box");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void supplyChecking()
        {
            try
            {
                if (checkBoxSupply.Checked)
                {
                    supplyBill = double.Parse(textBoxsupply.Text);

                }
                else if (textBoxsupply.Text != "" && checkBoxSupply.Checked == false)
                {
                    MessageBox.Show("Please Check the corresponding Checked box");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
