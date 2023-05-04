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
    public partial class existingNurseForm : Form
    {
        connectionDB connection = new connectionDB();
        private static ArrayList ListID = new ArrayList();
        private static ArrayList ListnurseName = new ArrayList();
        private static ArrayList ListPhNo = new ArrayList();
        private static ArrayList Listqualification = new ArrayList();
        private static ArrayList Listsalary = new ArrayList();
        private static ArrayList ListDateOfJoining = new ArrayList();
        private static ArrayList ListYearsOfService = new ArrayList();
        private static ArrayList ListnurseAddress = new ArrayList();
        public existingNurseForm()
        {
            InitializeComponent();
        }

       

        private void existingNurseForm_Load(object sender, EventArgs e)
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
            ListnurseName.Clear();
            ListPhNo.Clear();
            Listqualification.Clear();
            Listsalary.Clear();
            ListDateOfJoining.Clear();
            ListYearsOfService.Clear();
            ListnurseAddress.Clear();

            try
            {
                connection.Open();
                string gettingQuery = "SELECT * FROM nursedetails";
                MySqlDataReader row;
                row = connection.ExecuteReader(gettingQuery);

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        ListID.Add(row["nurse_id"].ToString());
                        ListnurseName.Add(row["nurse_name"].ToString());
                        ListPhNo.Add(row["phone_no"].ToString());
                        Listqualification.Add(row["qualification"].ToString());
                        Listsalary.Add(row["salary"].ToString());
                        ListDateOfJoining.Add(row["date_of_joining"].ToString());
                        ListYearsOfService.Add(row["years_of_service"].ToString());
                        ListnurseAddress.Add(row["address"].ToString());

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
                newRow.Cells[1].Value = ListnurseName[i];
                newRow.Cells[2].Value = ListPhNo[i];
                newRow.Cells[3].Value = Listqualification[i];
                newRow.Cells[4].Value = Listsalary[i];
                newRow.Cells[5].Value = ListDateOfJoining[i];
                newRow.Cells[6].Value = ListYearsOfService[i];
                newRow.Cells[7].Value = ListnurseAddress[i];

                existingDocdataGridView.Rows.Add(newRow);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
