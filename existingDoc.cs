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
    public partial class existingDoc : Form
    {
        connectionDB connection = new connectionDB();
        private ArrayList ListID = new ArrayList();
        public ArrayList ListdoctorName = new ArrayList();
        private ArrayList ListPhNo = new ArrayList();
        private ArrayList ListdoctorAddress = new ArrayList();
        private ArrayList Listconsultation = new ArrayList();
        private ArrayList ListDateOfJoining = new ArrayList();
        private ArrayList ListYearsOfService = new ArrayList();
        public ArrayList ListFee = new ArrayList();
        

        public existingDoc()
        {
            InitializeComponent();
        }

        private void existingDoc_Load(object sender, EventArgs e)
        {
            existingDocdataGridView.EnableHeadersVisualStyles = false;
            existingDocdataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            existingDocdataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            existingDocdataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);



            //getting Data
            getData();
            if (ListID.Count > 0)
            {
                updateGridView();
            }
            else
            {
                MessageBox.Show("Data not found");
            }
        }

       

        private void getData()
        {
            ListID.Clear();
            ListdoctorName.Clear();
            ListPhNo.Clear();
            Listconsultation.Clear();
            ListFee.Clear();
            ListDateOfJoining.Clear();
            ListYearsOfService.Clear();
            ListdoctorAddress.Clear();

            try
            {
                connection.Open();
                string gettingQuery = "SELECT * FROM doctordetails";
                MySqlDataReader row;
                row = connection.ExecuteReader(gettingQuery);

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        ListID.Add(row["doctor_id"].ToString());
                        ListdoctorName.Add(row["doctor_name"].ToString());
                        ListPhNo.Add(row["doctor_mobile_no"].ToString());
                        Listconsultation.Add(row["doctor_consultation"].ToString());
                        ListFee.Add(row["fee"].ToString());
                        ListDateOfJoining.Add(row["date_of_joining"].ToString());
                        ListYearsOfService.Add(row["years_of_service"].ToString());
                        ListdoctorAddress.Add(row["doctor_address"].ToString());

                       
                    }
                }
                else
                {
                    MessageBox.Show("Data not Found");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateGridView()
        {
            // admitteddataGridView.;

            for (int i = 0; i < ListID.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(existingDocdataGridView);
                newRow.Cells[0].Value = ListID[i];
                newRow.Cells[1].Value = ListdoctorName[i];
                newRow.Cells[2].Value = ListPhNo[i];
                newRow.Cells[3].Value = Listconsultation[i];
                newRow.Cells[4].Value = ListFee[i];
                newRow.Cells[5].Value = ListDateOfJoining[i];
                newRow.Cells[6].Value = ListYearsOfService[i];
                newRow.Cells[7].Value = ListdoctorAddress[i];
              
                existingDocdataGridView.Rows.Add(newRow);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
