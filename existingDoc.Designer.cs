
namespace HospitalManagementSystem
{
    partial class existingDoc
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
            this.doctorid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.doctorid,
            this.doctorname,
            this.phoneno,
            this.consultation,
            this.fee,
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
            this.existingDocdataGridView.TabIndex = 4;
            // 
            // doctorid
            // 
            this.doctorid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.doctorid.DefaultCellStyle = dataGridViewCellStyle5;
            this.doctorid.HeaderText = "Doctor ID";
            this.doctorid.Name = "doctorid";
            this.doctorid.ReadOnly = true;
            this.doctorid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.doctorid.Width = 72;
            // 
            // doctorname
            // 
            this.doctorname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.doctorname.FillWeight = 528.866F;
            this.doctorname.HeaderText = "Doctor Name";
            this.doctorname.Name = "doctorname";
            this.doctorname.ReadOnly = true;
            this.doctorname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.doctorname.Width = 87;
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
            // consultation
            // 
            this.consultation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.consultation.HeaderText = "Consultation";
            this.consultation.Name = "consultation";
            this.consultation.ReadOnly = true;
            this.consultation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.consultation.Width = 90;
            // 
            // fee
            // 
            this.fee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fee.HeaderText = "Fee";
            this.fee.Name = "fee";
            this.fee.ReadOnly = true;
            this.fee.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fee.Width = 50;
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
            // existingDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(720, 600);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.existingDocdataGridView);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "existingDoc";
            this.Text = "existingDoc";
            this.Load += new System.EventHandler(this.existingDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.existingDocdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView existingDocdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorid;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneno;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultation;
        private System.Windows.Forms.DataGridViewTextBoxColumn fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn joiningdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearsofservice;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.PictureBox btnClose;
    }
}