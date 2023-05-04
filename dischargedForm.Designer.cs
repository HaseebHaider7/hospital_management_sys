
namespace HospitalManagementSystem
{
    partial class dischargedForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dischargeddataGridView = new System.Windows.Forms.DataGridView();
            this.patientid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathercnic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assigneddoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofadmission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofdischarged = new System.Windows.Forms.DataGridViewTextBoxColumn();
          
            this.patientdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
          
            this.btnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dischargeddataGridView)).BeginInit();
          
            ((System.ComponentModel.ISupportInitialize)(this.patientdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // dischargeddataGridView
            // 
            this.dischargeddataGridView.AllowUserToAddRows = false;
            this.dischargeddataGridView.AllowUserToDeleteRows = false;
            this.dischargeddataGridView.AllowUserToResizeColumns = false;
            this.dischargeddataGridView.AllowUserToResizeRows = false;
            this.dischargeddataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dischargeddataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dischargeddataGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dischargeddataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dischargeddataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dischargeddataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientid,
            this.patientname,
            this.dateofbirth,
            this.gender,
            this.age,
            this.fathername,
            this.fathercnic,
            this.address,
            this.assigneddoctor,
            this.dateofadmission,
            this.dateofdischarged});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dischargeddataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dischargeddataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dischargeddataGridView.Location = new System.Drawing.Point(12, 62);
            this.dischargeddataGridView.Name = "dischargeddataGridView";
            this.dischargeddataGridView.ReadOnly = true;
            this.dischargeddataGridView.RowHeadersVisible = false;
            this.dischargeddataGridView.Size = new System.Drawing.Size(695, 525);
            this.dischargeddataGridView.TabIndex = 0;
            // 
            // patientid
            // 
            this.patientid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.patientid.DefaultCellStyle = dataGridViewCellStyle2;
            this.patientid.HeaderText = "Patient ID";
            this.patientid.Name = "patientid";
            this.patientid.ReadOnly = true;
            this.patientid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.patientid.Width = 73;
            // 
            // patientname
            // 
            this.patientname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.patientname.FillWeight = 528.866F;
            this.patientname.HeaderText = "Patient Name";
            this.patientname.Name = "patientname";
            this.patientname.ReadOnly = true;
            this.patientname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.patientname.Width = 88;
            // 
            // dateofbirth
            // 
            this.dateofbirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateofbirth.FillWeight = 46.39175F;
            this.dateofbirth.HeaderText = "Date of Birth";
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.ReadOnly = true;
            this.dateofbirth.Width = 65;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gender.FillWeight = 46.39175F;
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gender.Width = 67;
            // 
            // age
            // 
            this.age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.age.FillWeight = 46.39175F;
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Width = 51;
            // 
            // fathername
            // 
            this.fathername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fathername.FillWeight = 46.39175F;
            this.fathername.HeaderText = "Father Name";
            this.fathername.Name = "fathername";
            this.fathername.ReadOnly = true;
            this.fathername.Width = 86;
            // 
            // fathercnic
            // 
            this.fathercnic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fathercnic.FillWeight = 46.39175F;
            this.fathercnic.HeaderText = "Father CNIC";
            this.fathercnic.Name = "fathercnic";
            this.fathercnic.ReadOnly = true;
            this.fathercnic.Width = 83;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.address.Width = 70;
            // 
            // assigneddoctor
            // 
            this.assigneddoctor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.assigneddoctor.FillWeight = 46.39175F;
            this.assigneddoctor.HeaderText = "Assigned Doctor";
            this.assigneddoctor.Name = "assigneddoctor";
            this.assigneddoctor.ReadOnly = true;
            this.assigneddoctor.Width = 101;
            // 
            // dateofadmission
            // 
            this.dateofadmission.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateofadmission.FillWeight = 46.39175F;
            this.dateofadmission.HeaderText = "Date of Admission";
            this.dateofadmission.Name = "dateofadmission";
            this.dateofadmission.ReadOnly = true;
            this.dateofadmission.Width = 107;
            // 
            // dateofdischarged
            // 
            this.dateofdischarged.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateofdischarged.FillWeight = 46.39175F;
            this.dateofdischarged.HeaderText = "Date of Discharged";
            this.dateofdischarged.Name = "dateofdischarged";
            this.dateofdischarged.ReadOnly = true;
            this.dateofdischarged.Width = 114;
            // 
            // smc_databaseDataSet
            // 
          
            // 
            // patientdetailsBindingSource
            // 
            this.patientdetailsBindingSource.DataMember = "patientdetails";
         
            // 
            // patientdetailsTableAdapter
            // 
         
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::HospitalManagementSystem.Properties.Resources.delete_icon;
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 22;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dischargedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(720, 600);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dischargeddataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dischargedForm";
            this.Text = "dischargedForm";
            this.Load += new System.EventHandler(this.dischargedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dischargeddataGridView)).EndInit();
          
            ((System.ComponentModel.ISupportInitialize)(this.patientdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dischargeddataGridView;
       
        private System.Windows.Forms.BindingSource patientdetailsBindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn patientid;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathername;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathercnic;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn assigneddoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofadmission;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofdischarged;
        private System.Windows.Forms.PictureBox btnClose;
    }
}