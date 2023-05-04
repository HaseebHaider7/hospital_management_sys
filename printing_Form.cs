using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HospitalManagementSystem
{
    public partial class printing_Form : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=smc_database;username=root;password=3329992075i");
        MySqlCommand cmd;
        MySqlCommand cmd1;
        MySqlDataAdapter adp;
     //   MySqlDataReader reader;

        public printing_Form()
        {
            InitializeComponent();
        }

        private string patientID;

        public string PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }

        private void printing_Form_Load(object sender, EventArgs e)
        {

            connection.Open();
            DataTable dt = new DataTable();
            cmd = new MySqlCommand("SELECT * FROM patientdetails WHERE patient_id = '" + PatientID + "'", connection);
            adp = new MySqlDataAdapter(cmd);
            adp.Fill(dt);


            DataTable dt1 = new DataTable();
            cmd1 = new MySqlCommand("SELECT * FROM paymentdetails WHERE patientid = '" + PatientID + "'", connection);
            adp = new MySqlDataAdapter(cmd1);
            adp.Fill(dt1);

            connection.Close();

            CrystalReport2 cr = new CrystalReport2();
            cr.Database.Tables["patientdetails"].SetDataSource(dt);
            cr.Database.Tables["paymentdetails"].SetDataSource(dt1);
            cr.SummaryInfo.ReportTitle = "" + patientID + " _report";

            // for show report a preview 

            this.crystalReportViewer1.ReportSource = cr;

            // fro printing the report

           // cr.PrintToPrinter(1, false, 0, 0);
        }

    }
}
