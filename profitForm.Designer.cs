
namespace HospitalManagementSystem
{
    partial class profitForm
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
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.radioButtonmonthly = new System.Windows.Forms.RadioButton();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxyear = new System.Windows.Forms.ComboBox();
            this.radioButtonyearly = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelexpensesDisplay = new System.Windows.Forms.Label();
            this.labelexpenses = new System.Windows.Forms.Label();
            this.labelincomeDisplay = new System.Windows.Forms.Label();
            this.labeltotalincom = new System.Windows.Forms.Label();
            this.labelprofitLossDisplay = new System.Windows.Forms.Label();
            this.labelprofitLoss = new System.Windows.Forms.Label();
            this.labelnurseSalary = new System.Windows.Forms.Label();
            this.labelNurseSalaryDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::HospitalManagementSystem.Properties.Resources.delete_icon;
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 23;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // radioButtonmonthly
            // 
            this.radioButtonmonthly.AutoSize = true;
            this.radioButtonmonthly.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonmonthly.Location = new System.Drawing.Point(181, 45);
            this.radioButtonmonthly.Name = "radioButtonmonthly";
            this.radioButtonmonthly.Size = new System.Drawing.Size(124, 19);
            this.radioButtonmonthly.TabIndex = 24;
            this.radioButtonmonthly.TabStop = true;
            this.radioButtonmonthly.Text = "Monthly Profit";
            this.radioButtonmonthly.UseVisualStyleBackColor = true;
            this.radioButtonmonthly.CheckedChanged += new System.EventHandler(this.radioButtonmonthly_CheckedChanged);
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMonth.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBoxMonth.Location = new System.Drawing.Point(181, 87);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(131, 23);
            this.comboBoxMonth.TabIndex = 25;
            // 
            // comboBoxyear
            // 
            this.comboBoxyear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboBoxyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxyear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxyear.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxyear.FormattingEnabled = true;
            this.comboBoxyear.Items.AddRange(new object[] {
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
            this.comboBoxyear.Location = new System.Drawing.Point(336, 87);
            this.comboBoxyear.Name = "comboBoxyear";
            this.comboBoxyear.Size = new System.Drawing.Size(131, 23);
            this.comboBoxyear.TabIndex = 26;
            // 
            // radioButtonyearly
            // 
            this.radioButtonyearly.AutoSize = true;
            this.radioButtonyearly.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonyearly.Location = new System.Drawing.Point(336, 45);
            this.radioButtonyearly.Name = "radioButtonyearly";
            this.radioButtonyearly.Size = new System.Drawing.Size(110, 19);
            this.radioButtonyearly.TabIndex = 27;
            this.radioButtonyearly.TabStop = true;
            this.radioButtonyearly.Text = "Yearly Profit";
            this.radioButtonyearly.UseVisualStyleBackColor = true;
            this.radioButtonyearly.CheckedChanged += new System.EventHandler(this.radioButtonyearly_CheckedChanged);
            // 
            // btnShow
            // 
            this.btnShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(521, 87);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(96, 23);
            this.btnShow.TabIndex = 28;
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
            this.tableLayoutPanel1.Controls.Add(this.labelexpensesDisplay, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelexpenses, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelincomeDisplay, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labeltotalincom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelprofitLossDisplay, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelprofitLoss, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelnurseSalary, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelNurseSalaryDisplay, 1, 2);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(77, 174);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.14286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.85714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(540, 266);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // labelexpensesDisplay
            // 
            this.labelexpensesDisplay.AutoSize = true;
            this.labelexpensesDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelexpensesDisplay.Font = new System.Drawing.Font("Lucida Bright", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelexpensesDisplay.Location = new System.Drawing.Point(274, 74);
            this.labelexpensesDisplay.Name = "labelexpensesDisplay";
            this.labelexpensesDisplay.Size = new System.Drawing.Size(260, 63);
            this.labelexpensesDisplay.TabIndex = 3;
            this.labelexpensesDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelexpenses
            // 
            this.labelexpenses.AutoSize = true;
            this.labelexpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelexpenses.Font = new System.Drawing.Font("Lucida Bright", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelexpenses.Location = new System.Drawing.Point(6, 74);
            this.labelexpenses.Name = "labelexpenses";
            this.labelexpenses.Size = new System.Drawing.Size(259, 63);
            this.labelexpenses.TabIndex = 2;
            this.labelexpenses.Text = "Total Expenses";
            this.labelexpenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelincomeDisplay
            // 
            this.labelincomeDisplay.AutoSize = true;
            this.labelincomeDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelincomeDisplay.Font = new System.Drawing.Font("Lucida Bright", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelincomeDisplay.Location = new System.Drawing.Point(274, 3);
            this.labelincomeDisplay.Name = "labelincomeDisplay";
            this.labelincomeDisplay.Size = new System.Drawing.Size(260, 68);
            this.labelincomeDisplay.TabIndex = 1;
            this.labelincomeDisplay.Text = "  ";
            this.labelincomeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labeltotalincom
            // 
            this.labeltotalincom.AutoSize = true;
            this.labeltotalincom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labeltotalincom.Font = new System.Drawing.Font("Lucida Bright", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotalincom.Location = new System.Drawing.Point(6, 3);
            this.labeltotalincom.Name = "labeltotalincom";
            this.labeltotalincom.Size = new System.Drawing.Size(259, 68);
            this.labeltotalincom.TabIndex = 0;
            this.labeltotalincom.Text = "Total Income";
            this.labeltotalincom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelprofitLossDisplay
            // 
            this.labelprofitLossDisplay.AutoSize = true;
            this.labelprofitLossDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelprofitLossDisplay.Font = new System.Drawing.Font("Lucida Bright", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprofitLossDisplay.Location = new System.Drawing.Point(274, 204);
            this.labelprofitLossDisplay.Name = "labelprofitLossDisplay";
            this.labelprofitLossDisplay.Size = new System.Drawing.Size(260, 59);
            this.labelprofitLossDisplay.TabIndex = 5;
            this.labelprofitLossDisplay.Text = "     ";
            this.labelprofitLossDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelprofitLoss
            // 
            this.labelprofitLoss.AutoSize = true;
            this.labelprofitLoss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelprofitLoss.Font = new System.Drawing.Font("Lucida Bright", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprofitLoss.Location = new System.Drawing.Point(6, 204);
            this.labelprofitLoss.Name = "labelprofitLoss";
            this.labelprofitLoss.Size = new System.Drawing.Size(259, 59);
            this.labelprofitLoss.TabIndex = 6;
            this.labelprofitLoss.Text = "Profit / Loss";
            this.labelprofitLoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelnurseSalary
            // 
            this.labelnurseSalary.AutoSize = true;
            this.labelnurseSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelnurseSalary.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnurseSalary.Location = new System.Drawing.Point(6, 140);
            this.labelnurseSalary.Name = "labelnurseSalary";
            this.labelnurseSalary.Size = new System.Drawing.Size(259, 61);
            this.labelnurseSalary.TabIndex = 7;
            this.labelnurseSalary.Text = "Total Nurser Salaries";
            this.labelnurseSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNurseSalaryDisplay
            // 
            this.labelNurseSalaryDisplay.AutoSize = true;
            this.labelNurseSalaryDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNurseSalaryDisplay.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNurseSalaryDisplay.Location = new System.Drawing.Point(274, 140);
            this.labelNurseSalaryDisplay.Name = "labelNurseSalaryDisplay";
            this.labelNurseSalaryDisplay.Size = new System.Drawing.Size(260, 61);
            this.labelNurseSalaryDisplay.TabIndex = 8;
            this.labelNurseSalaryDisplay.Text = "   ";
            this.labelNurseSalaryDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(720, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.radioButtonyearly);
            this.Controls.Add(this.comboBoxyear);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.radioButtonmonthly);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "profitForm";
            this.Text = "profitForm";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.RadioButton radioButtonmonthly;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.ComboBox comboBoxyear;
        private System.Windows.Forms.RadioButton radioButtonyearly;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelprofitLossDisplay;
        private System.Windows.Forms.Label labelexpensesDisplay;
        private System.Windows.Forms.Label labelexpenses;
        private System.Windows.Forms.Label labelincomeDisplay;
        private System.Windows.Forms.Label labeltotalincom;
        private System.Windows.Forms.Label labelprofitLoss;
        private System.Windows.Forms.Label labelnurseSalary;
        private System.Windows.Forms.Label labelNurseSalaryDisplay;
    }
}