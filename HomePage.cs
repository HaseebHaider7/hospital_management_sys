using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HospitalManagementSystem
{
    public partial class HomePage : Form
    {
        readonly MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;database=hms_database;username=root;password=root@admin");
        static String datestamp = DateTime.Now.ToString("yyyy_MM_dd_HH-mm");
        string file = "C:\\Users\\imran\\Documents\\Visual Studio 2019\\Projects\\HospitalManagementSystem\\Backup\\backup_"+datestamp+".sql";//This is path to save the backup db file..

        public HomePage()
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
            InitializeComponent();
            customizeDesign();
            dbconnection();
            backup();
           // restore();
        }

        public void dbconnection()
        {
            connection.Open();
            if(connection != null)
            {
                labelCon.Text = "Connected";

            }
            else
            {
                labelCon.Text = "Not Connected";
            }
            connection.Close();
        }
        private void customizeDesign()
        {
            panelPatientSideMenu.Visible = false;
            panelStaffSideMenu.Visible = false;
            panelHospitalSideMenu.Visible = false;
            panelTreatmentSideMenu.Visible = false;
        }

        private void hideSidemenu()
        {
            if(panelPatientSideMenu.Visible == true)
            {
                panelPatientSideMenu.Visible = false;
            }
            if (panelStaffSideMenu.Visible == true)
            {
                panelStaffSideMenu.Visible = false;
            }
            if (panelHospitalSideMenu.Visible == true)
            {
                panelHospitalSideMenu.Visible = false;
            }
            if(panelTreatmentSideMenu.Visible == true)
            {
                panelTreatmentSideMenu.Visible = false;
            }
        }


        private void showSideMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSidemenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }


        #region patient

        private void btnPatient_Click(object sender, EventArgs e)
        {
            showSideMenu(panelPatientSideMenu);
        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {

            // Code here
            openChildForm(new newPatientForm());
            hideSidemenu();
        }

        private void btnDischarepatient_Click(object sender, EventArgs e)
        {
            // Code here
            openChildForm(new DischargingPatient());

            hideSidemenu();
        }

        private void BtnAdmittedPatient_Click(object sender, EventArgs e)
        {
            // Code here
            
         
            openChildForm(new admittedForm());

            hideSidemenu();
        }

        private void btnupdatestatus_Click(object sender, EventArgs e)
        {

            openChildForm(new updatepatientStatsuForm());
            hideSidemenu();
        }

        private void btnDischargedPatients_Click(object sender, EventArgs e)
        {
            // Code here
            openChildForm(new dischargedForm());
            hideSidemenu();
        }
        #endregion


        #region Staff
        private void btnStaff_Click(object sender, EventArgs e)
        {
            showSideMenu(panelStaffSideMenu);
        }

        private void btnNewDoc_Click(object sender, EventArgs e)
        {
            // Code here
            openChildForm(new addNewDoc());
            hideSidemenu();
        }

        private void btnExistingDoc_Click(object sender, EventArgs e)
        {
            // Code here
            openChildForm(new existingDoc());
            hideSidemenu();
        }

        private void btnnewNurse_Click(object sender, EventArgs e)
        {
            // Code here
            openChildForm(new addnewNurseForm());
            hideSidemenu();
        }
        private void btnNurse_Click(object sender, EventArgs e)
        {
            // Code here
            openChildForm(new existingNurseForm());
            hideSidemenu();
        }
        private void btnRemovingStaff_Click(object sender, EventArgs e)
        {
            openChildForm(new removingForm());
            hideSidemenu();
        }

        #endregion


        #region Hospital
        private void btnHospital_Click(object sender, EventArgs e)
        {
            showSideMenu(panelHospitalSideMenu);
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            // Code here
            openChildForm(new incomeForm());
            hideSidemenu();
        }

        private void btnProfit_Click(object sender, EventArgs e)
        {
            openChildForm(new profitForm());
            hideSidemenu();
        }

        private void btnDoctorFee_Click(object sender, EventArgs e)
        {
            openChildForm(new doctorFeesForm());
            hideSidemenu();
        }

        private void btnNurseSalary_Click(object sender, EventArgs e)
        {
            openChildForm(new nurseSalaryForm());
            hideSidemenu();
        }

        private void btnOtherExpenses_Click(object sender, EventArgs e)
        {
            openChildForm(new otherExpensesForm());
            hideSidemenu();
        }



        #endregion

        #region treatment
        private void btnTreatment_Click(object sender, EventArgs e)
        {
            showSideMenu(panelTreatmentSideMenu);
        }

        private void buttonEntry_Click(object sender, EventArgs e)
        {
            openChildForm(new treatmentForm());
            hideSidemenu();
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            openChildForm(new treatmentRecordForm());
            hideSidemenu();
        }

        #endregion

        private Form activeForm = null;

        public void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelHome.Controls.Add(childForm);
            panelHome.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBoxPanelLogo_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            openChildForm(new aboutForm());
            hideSidemenu();
        }


        #region Backup and restoring

        private void backup()
        {
            
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = connection;
                        connection.Open();
                        mb.ExportToFile(file);//This line will export the file to given path.
                        connection.Close();
                        //MessageBox.Show("Backup Completed...!!!");
                    }
                }
            
        }



        /*
        private void restore()
        {

            var directory = new DirectoryInfo("C:\\Users\\imran\\Documents\\Visual Studio 2019\\Projects\\HospitalManagementSystem\\Backup\\");
            var myFile = (from f in directory.GetFiles()
                          orderby f.LastWriteTime descending
                          select f).First();

            string myF = myFile.ToString();
            MessageBox.Show(myF);
            using (MySqlCommand cmd = new MySqlCommand())
            {
                using (MySqlBackup mb = new MySqlBackup(cmd))
                {
                    //cmd.Connection = connection;
                    //connection.Open();
                    //mb.ImportFromFile(myF);//This line will export the file to given path.
                    //connection.Close();
                   // MessageBox.Show("DB Restore Completed...!!!");
                }
            }
        }
        */

        #endregion
    }
}
