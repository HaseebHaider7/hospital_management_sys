
namespace HospitalManagementSystem
{
    partial class existingNurseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.existingDocdataGridView = new System.Windows.Forms.DataGridView();
            this.nurseid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nursename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joiningdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearsofservice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.existingDocdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // existingDocdataGridView
            // 
            this.existingDocdataGridView.AllowUserToAddRows = false;
            this.existingDocdataGridView.AllowUserToDeleteRows = false;
            this.existingDocdataGridView.AllowUserToResizeColumns = false;
            this.existingDocdataGridView.AllowUserToResizeRows = false;
            this.existingDocdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.existingDocdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.existingDocdataGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.existingDocdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.existingDocdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.existingDocdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nurseid,
            this.nursename,
            this.phoneno,
            this.qualification,
            this.salary,
            this.joiningdate,
            this.yearsofservice,
            this.address});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.existingDocdataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.existingDocdataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.existingDocdataGridView.Location = new System.Drawing.Point(13, 63);
            this.existingDocdataGridView.Name = "existingDocdataGridView";
            this.existingDocdataGridView.ReadOnly = true;
            this.existingDocdataGridView.RowHeadersVisible = false;
            this.existingDocdataGridView.Size = new System.Drawing.Size(695, 525);
            this.existingDocdataGridView.TabIndex = 5;
            // 
            // nurseid
            // 
            this.nurseid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.nurseid.DefaultCellStyle = dataGridViewCellStyle5;
            this.nurseid.HeaderText = "Nurse ID";
            this.nurseid.Name = "nurseid";
            this.nurseid.ReadOnly = true;
            this.nurseid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nurseid.Width = 69;
            // 
            // nursename
            // 
            this.nursename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nursename.FillWeight = 528.866F;
            this.nursename.HeaderText = "Nurse Name";
            this.nursename.Name = "nursename";
            this.nursename.ReadOnly = true;
            this.nursename.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nursename.Width = 84;
            // 
            // phoneno
            // 
            this.phoneno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phoneno.FillWeight = 46.39175F;
            this.phoneno.HeaderText = "Phone No";
            this.phoneno.Name = "phoneno";
            this.phoneno.ReadOnly = true;
            this.phoneno.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.phoneno.Width = 74;
            // 
            // qualification
            // 
            this.qualification.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qualification.HeaderText = "Qualification";
            this.qualification.Name = "qualification";
            this.qualification.ReadOnly = true;
            this.qualification.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.qualification.Width = 90;
            // 
            // salary
            // 
            this.salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.salary.HeaderText = "Salary";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            this.salary.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.salary.Width = 61;
            // 
            // joiningdate
            // 
            this.joiningdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.joiningdate.FillWeight = 46.39175F;
            this.joiningdate.HeaderText = "Joining Date";
            this.joiningdate.Name = "joiningdate";
            this.joiningdate.ReadOnly = true;
            this.joiningdate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.joiningdate.Width = 84;
            // 
            // yearsofservice
            // 
            this.yearsofservice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.yearsofservice.HeaderText = "Years Of Service";
            this.yearsofservice.Name = "yearsofservice";
            this.yearsofservice.ReadOnly = true;
            this.yearsofservice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.yearsofservice.Width = 103;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // existingNurseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(720, 600);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.existingDocdataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "existingNurseForm";
            this.Text = "existingNurseForm";
            this.Load += new System.EventHandler(this.existingNurseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.existingDocdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView existingDocdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurseid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nursename;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneno;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn joiningdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearsofservice;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.PictureBox btnClose;
    }
}