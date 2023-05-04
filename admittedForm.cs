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
    public partial class admittedForm : Form
    {
        connectionDB connection = new connectionDB();
        private static ArrayList ListID = new ArrayList();
        private static ArrayList ListPatientName = new ArrayList();
        private static ArrayList ListDOB = new ArrayList();
        private static ArrayList Listgender = new ArrayList(); 
        private static ArrayList Listage = new ArrayList();
        private static ArrayList ListfatherName = new ArrayList();
        private static ArrayList ListfatherCnic = new ArrayList();
        private static ArrayList ListPatientaddress = new ArrayList();
        private static ArrayList ListassignedDoctor = new ArrayList();
        private static ArrayList Listdateofadmission = new ArrayList();

      
        public admittedForm()
        {
            InitializeComponent();
            
            
        }
        

        private void admittedForm_Load(object sender, EventArgs e)
        {
            
            admitteddataGridView.EnableHeadersVisualStyles = false;
            admitteddataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;
            admitteddataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            admitteddataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Lucida Bright",9,FontStyle.Regular);
            

            getData();
            if (ListID.Count > 0)
            {
                updateGridView();
            }
            else
            {
                MessageBox.Show("Data not found");
            }
            labeldisplay.Text = ListID.Count.ToString();
          

        }

        private void getData()
        {

            ListID.Clear();
            ListPatientName.Clear();
            ListDOB.Clear();
            Listgender.Clear();
            Listage.Clear();
            ListfatherName.Clear();
            ListfatherCnic.Clear();
            ListPatientaddress.Clear();
            ListassignedDoctor.Clear();
            Listdateofadmission.Clear();

            String PatientStatus = "Admitted";
            try
            {
                connection.Open();
                string gettingQuery = "SELECT * FROM patientdetails WHERE patient_status = '" + PatientStatus + "'";
                MySqlDataReader row;
                row = connection.ExecuteReader(gettingQuery);

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        ListID.Add(row["patient_id"].ToString());
                        ListPatientName.Add(row["patient_name"].ToString());
                        ListDOB.Add(row["date_of_birth"].ToString());
                        Listgender.Add(row["gender"].ToString());
                        Listage.Add(row["age"].ToString());
                        ListfatherName.Add(row["Father_name"].ToString());
                        ListfatherCnic.Add(row["cnic"].ToString());
                        ListPatientaddress.Add(row["patient_address"].ToString());
                        ListassignedDoctor.Add(row["assigned_doctor"].ToString());
                        Listdateofadmission.Add(row["admission_date"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Data not Found");
                }
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateGridView()
        {
           // admitteddataGridView.;

            for (int i=0; i<ListID.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(admitteddataGridView);
                newRow.Cells[0].Value = ListID[i];
                newRow.Cells[1].Value = ListPatientName[i];
                newRow.Cells[2].Value = ListDOB[i];
                newRow.Cells[3].Value = Listgender[i];
                newRow.Cells[4].Value = Listage[i];
                newRow.Cells[5].Value = ListfatherName[i];
                newRow.Cells[6].Value = ListfatherCnic[i];
                newRow.Cells[7].Value = ListPatientaddress[i];
                newRow.Cells[8].Value = ListassignedDoctor[i];
                newRow.Cells[9].Value = Listdateofadmission[i];
                admitteddataGridView.Rows.Add(newRow);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
