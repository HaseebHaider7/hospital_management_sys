
namespace HospitalManagementSystem
{
    partial class admittedForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.admitteddataGridView = new System.Windows.Forms.DataGridView();
            this.patientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherCnic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofAdmission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.labeldisplay = new System.Windows.Forms.Label();
            this.labeltotalPatient = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.admitteddataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // admitteddataGridView
            // 
            this.admitteddataGridView.AllowUserToAddRows = false;
            this.admitteddataGridView.AllowUserToDeleteRows = false;
            this.admitteddataGridView.AllowUserToResizeColumns = false;
            this.admitteddataGridView.AllowUserToResizeRows = false;
            this.admitteddataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.admitteddataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.admitteddataGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.admitteddataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.admitteddataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.admitteddataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admitteddataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientId,
            this.patientName,
            this.dateofbirth,
            this.gender,
            this.age,
            this.fatherName,
            this.fatherCnic,
            this.address,
            this.assignedDoctor,
            this.dateofAdmission});
            this.admitteddataGridView.Location = new System.Drawing.Point(12, 62);
            this.admitteddataGridView.Name = "admitteddataGridView";
            this.admitteddataGridView.ReadOnly = true;
            this.admitteddataGridView.RowHeadersVisible = false;
            this.admitteddataGridView.Size = new System.Drawing.Size(695, 525);
            this.admitteddataGridView.TabIndex = 0;
            // 
            // patientId
            // 
            this.patientId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.LightSteelBlue;
            this.patientId.DefaultCellStyle = dataGridViewCellStyle13;
            this.patientId.FillWeight = 55.27477F;
            this.patientId.HeaderText = "Patient ID";
            this.patientId.Name = "patientId";
            this.patientId.ReadOnly = true;
            this.patientId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.patientId.Width = 78;
            // 
            // patientName
            // 
            this.patientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.LightSteelBlue;
            this.patientName.DefaultCellStyle = dataGridViewCellStyle14;
            this.patientName.FillWeight = 55.27477F;
            this.patientName.HeaderText = "Patient Name";
            this.patientName.Name = "patientName";
            this.patientName.ReadOnly = true;
            this.patientName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.patientName.Width = 98;
            // 
            // dateofbirth
            // 
            this.dateofbirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dateofbirth.DefaultCellStyle = dataGridViewCellStyle15;
            this.dateofbirth.FillWeight = 55.27477F;
            this.dateofbirth.HeaderText = "Date Of Birth";
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.ReadOnly = true;
            this.dateofbirth.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dateofbirth.Width = 93;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gender.DefaultCellStyle = dataGridViewCellStyle16;
            this.gender.FillWeight = 52.41809F;
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gender.Width = 73;
            // 
            // age
            // 
            this.age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.LightSteelBlue;
            this.age.DefaultCellStyle = dataGridViewCellStyle17;
            this.age.FillWeight = 60F;
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.age.Width = 53;
            // 
            // fatherName
            // 
            this.fatherName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.LightSteelBlue;
            this.fatherName.DefaultCellStyle = dataGridViewCellStyle18;
            this.fatherName.FillWeight = 55.27477F;
            this.fatherName.HeaderText = "Father Name";
            this.fatherName.Name = "fatherName";
            this.fatherName.ReadOnly = true;
            this.fatherName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fatherName.Width = 96;
            // 
            // fatherCnic
            // 
            this.fatherCnic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.LightSteelBlue;
            this.fatherCnic.DefaultCellStyle = dataGridViewCellStyle19;
            this.fatherCnic.FillWeight = 55.27477F;
            this.fatherCnic.HeaderText = "Father CNIC";
            this.fatherCnic.Name = "fatherCnic";
            this.fatherCnic.ReadOnly = true;
            this.fatherCnic.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fatherCnic.Width = 90;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.LightSteelBlue;
            this.address.DefaultCellStyle = dataGridViewCellStyle20;
            this.address.FillWeight = 55.27477F;
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // assignedDoctor
            // 
            this.assignedDoctor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.LightSteelBlue;
            this.assignedDoctor.DefaultCellStyle = dataGridViewCellStyle21;
            this.assignedDoctor.FillWeight = 55.27477F;
            this.assignedDoctor.HeaderText = "Assigned Doctor";
            this.assignedDoctor.Name = "assignedDoctor";
            this.assignedDoctor.ReadOnly = true;
            this.assignedDoctor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.assignedDoctor.Width = 111;
            // 
            // dateofAdmission
            // 
            this.dateofAdmission.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dateofAdmission.DefaultCellStyle = dataGridViewCellStyle22;
            this.dateofAdmission.FillWeight = 55.27477F;
            this.dateofAdmission.HeaderText = "Date of Admission";
            this.dateofAdmission.Name = "dateofAdmission";
            this.dateofAdmission.ReadOnly = true;
            this.dateofAdmission.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dateofAdmission.Width = 120;
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
            // labeldisplay
            // 
            this.labeldisplay.AutoSize = true;
            this.labeldisplay.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldisplay.Location = new System.Drawing.Point(364, 22);
            this.labeldisplay.Name = "labeldisplay";
            this.labeldisplay.Size = new System.Drawing.Size(27, 15);
            this.labeldisplay.TabIndex = 25;
            this.labeldisplay.Text = "     ";
            this.labeldisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labeltotalPatient
            // 
            this.labeltotalPatient.AutoSize = true;
            this.labeltotalPatient.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotalPatient.Location = new System.Drawing.Point(125, 22);
            this.labeltotalPatient.Name = "labeltotalPatient";
            this.labeltotalPatient.Size = new System.Drawing.Size(206, 15);
            this.labeltotalPatient.TabIndex = 26;
            this.labeltotalPatient.Text = "Total no. Currently Admitted";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(720, 600);
            this.shapeContainer1.TabIndex = 27;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 349;
            this.lineShape1.X2 = 406;
            this.lineShape1.Y1 = 38;
            this.lineShape1.Y2 = 38;
            // 
            // admittedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(720, 600);
            this.Controls.Add(this.labeltotalPatient);
            this.Controls.Add(this.labeldisplay);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.admitteddataGridView);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admittedForm";
            this.Text = "admittedForm";
            this.Load += new System.EventHandler(this.admittedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admitteddataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView admitteddataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherCnic;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofAdmission;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label labeldisplay;
        private System.Windows.Forms.Label labeltotalPatient;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}