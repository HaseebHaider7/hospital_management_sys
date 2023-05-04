
namespace HospitalManagementSystem
{
    partial class incomeForm
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
            this.btnToday = new System.Windows.Forms.Button();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.dateTimePickerSpecific = new System.Windows.Forms.DateTimePicker();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnYear = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPatient = new System.Windows.Forms.Label();
            this.labelIncubator = new System.Windows.Forms.Label();
            this.labelOxygen = new System.Windows.Forms.Label();
            this.labelphototherapy = new System.Windows.Forms.Label();
            this.labelWard = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioBtnSpecificMonth = new System.Windows.Forms.RadioButton();
            this.radioBtnSpecificDate = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.labelOther = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToday
            // 
            this.btnToday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToday.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.Location = new System.Drawing.Point(146, 12);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(138, 23);
            this.btnToday.TabIndex = 1;
            this.btnToday.Text = "Today Income";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxMonth.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxMonth.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "January",
            "Febuary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "Octobar",
            "November",
            "December"});
            this.comboBoxMonth.Location = new System.Drawing.Point(315, 68);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMonth.TabIndex = 4;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxYear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxYear.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029"});
            this.comboBoxYear.Location = new System.Drawing.Point(442, 69);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(121, 23);
            this.comboBoxYear.TabIndex = 5;
            // 
            // dateTimePickerSpecific
            // 
            this.dateTimePickerSpecific.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerSpecific.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerSpecific.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSpecific.Location = new System.Drawing.Point(410, 114);
            this.dateTimePickerSpecific.Name = "dateTimePickerSpecific";
            this.dateTimePickerSpecific.Size = new System.Drawing.Size(121, 23);
            this.dateTimePickerSpecific.TabIndex = 6;
            // 
            // btnMonth
            // 
            this.btnMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMonth.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonth.Location = new System.Drawing.Point(290, 12);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(146, 23);
            this.btnMonth.TabIndex = 2;
            this.btnMonth.Text = "This Month Income";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // btnYear
            // 
            this.btnYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYear.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYear.Location = new System.Drawing.Point(442, 12);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(121, 23);
            this.btnYear.TabIndex = 3;
            this.btnYear.Text = "This Year Income";
            this.btnYear.UseVisualStyleBackColor = true;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // btnShow
            // 
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShow.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnShow.Location = new System.Drawing.Point(585, 118);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelOther, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelPatient, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelIncubator, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelOxygen, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelphototherapy, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelWard, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelTotal, 1, 6);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(96, 201);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 285);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Of Patient";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Incubator Fees";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Oxygen Fees";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "PhotoTherapy Fees ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ward Charges";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPatient
            // 
            this.labelPatient.AutoSize = true;
            this.labelPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPatient.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatient.Location = new System.Drawing.Point(274, 3);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(259, 37);
            this.labelPatient.TabIndex = 6;
            this.labelPatient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIncubator
            // 
            this.labelIncubator.AutoSize = true;
            this.labelIncubator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIncubator.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncubator.Location = new System.Drawing.Point(274, 43);
            this.labelIncubator.Name = "labelIncubator";
            this.labelIncubator.Size = new System.Drawing.Size(259, 37);
            this.labelIncubator.TabIndex = 7;
            this.labelIncubator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOxygen
            // 
            this.labelOxygen.AutoSize = true;
            this.labelOxygen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOxygen.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOxygen.Location = new System.Drawing.Point(274, 83);
            this.labelOxygen.Name = "labelOxygen";
            this.labelOxygen.Size = new System.Drawing.Size(259, 39);
            this.labelOxygen.TabIndex = 8;
            this.labelOxygen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelphototherapy
            // 
            this.labelphototherapy.AutoSize = true;
            this.labelphototherapy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelphototherapy.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelphototherapy.Location = new System.Drawing.Point(274, 125);
            this.labelphototherapy.Name = "labelphototherapy";
            this.labelphototherapy.Size = new System.Drawing.Size(259, 35);
            this.labelphototherapy.TabIndex = 9;
            this.labelphototherapy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWard
            // 
            this.labelWard.AutoSize = true;
            this.labelWard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWard.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWard.Location = new System.Drawing.Point(274, 163);
            this.labelWard.Name = "labelWard";
            this.labelWard.Size = new System.Drawing.Size(259, 39);
            this.labelWard.TabIndex = 10;
            this.labelWard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotal.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(274, 244);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(259, 38);
            this.labelTotal.TabIndex = 11;
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 38);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(6, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 36);
            this.label7.TabIndex = 12;
            this.label7.Text = "Other Charges";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioBtnSpecificMonth
            // 
            this.radioBtnSpecificMonth.AutoSize = true;
            this.radioBtnSpecificMonth.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold);
            this.radioBtnSpecificMonth.Location = new System.Drawing.Point(106, 69);
            this.radioBtnSpecificMonth.Name = "radioBtnSpecificMonth";
            this.radioBtnSpecificMonth.Size = new System.Drawing.Size(203, 19);
            this.radioBtnSpecificMonth.TabIndex = 11;
            this.radioBtnSpecificMonth.TabStop = true;
            this.radioBtnSpecificMonth.Text = "Income By Specific Month";
            this.radioBtnSpecificMonth.UseVisualStyleBackColor = true;
            // 
            // radioBtnSpecificDate
            // 
            this.radioBtnSpecificDate.AutoSize = true;
            this.radioBtnSpecificDate.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold);
            this.radioBtnSpecificDate.Location = new System.Drawing.Point(106, 121);
            this.radioBtnSpecificDate.Name = "radioBtnSpecificDate";
            this.radioBtnSpecificDate.Size = new System.Drawing.Size(189, 19);
            this.radioBtnSpecificDate.TabIndex = 12;
            this.radioBtnSpecificDate.TabStop = true;
            this.radioBtnSpecificDate.Text = "Income By Specific Date";
            this.radioBtnSpecificDate.UseVisualStyleBackColor = true;
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
            // labelOther
            // 
            this.labelOther.AutoSize = true;
            this.labelOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOther.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOther.Location = new System.Drawing.Point(274, 205);
            this.labelOther.Name = "labelOther";
            this.labelOther.Size = new System.Drawing.Size(259, 36);
            this.labelOther.TabIndex = 13;
            this.labelOther.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // incomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(720, 600);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.radioBtnSpecificDate);
            this.Controls.Add(this.radioBtnSpecificMonth);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.btnMonth);
            this.Controls.Add(this.dateTimePickerSpecific);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.btnToday);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "incomeForm";
            this.Text = "incomeForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.DateTimePicker dateTimePickerSpecific;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.Label labelIncubator;
        private System.Windows.Forms.Label labelOxygen;
        private System.Windows.Forms.Label labelphototherapy;
        private System.Windows.Forms.Label labelWard;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.RadioButton radioBtnSpecificMonth;
        private System.Windows.Forms.RadioButton radioBtnSpecificDate;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelOther;
    }
}