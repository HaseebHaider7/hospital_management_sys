
namespace HospitalManagementSystem
{
    partial class otherExpensesForm
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
            this.checkBoxOxygen = new System.Windows.Forms.CheckBox();
            this.checkBoxElectricity = new System.Windows.Forms.CheckBox();
            this.checkBoxSupply = new System.Windows.Forms.CheckBox();
            this.checkBoxOther = new System.Windows.Forms.CheckBox();
            this.textBoxOxygen = new System.Windows.Forms.TextBox();
            this.textBoxelectricity = new System.Windows.Forms.TextBox();
            this.textBoxsupply = new System.Windows.Forms.TextBox();
            this.textBoxother = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBoxEnterRecord = new System.Windows.Forms.GroupBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnEnterNewRecord = new System.Windows.Forms.Button();
            this.btnShowRecords = new System.Windows.Forms.Button();
            this.btnMonthly = new System.Windows.Forms.Button();
            this.btnyearly = new System.Windows.Forms.Button();
            this.paneldatagridview = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.billoxygen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billelectricity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billsupply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billother = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthyear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupBoxEnterRecord.SuspendLayout();
            this.paneldatagridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // checkBoxOxygen
            // 
            this.checkBoxOxygen.AutoSize = true;
            this.checkBoxOxygen.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOxygen.Location = new System.Drawing.Point(40, 51);
            this.checkBoxOxygen.Name = "checkBoxOxygen";
            this.checkBoxOxygen.Size = new System.Drawing.Size(103, 19);
            this.checkBoxOxygen.TabIndex = 0;
            this.checkBoxOxygen.Text = "Oxygen Bill";
            this.checkBoxOxygen.UseVisualStyleBackColor = true;
            // 
            // checkBoxElectricity
            // 
            this.checkBoxElectricity.AutoSize = true;
            this.checkBoxElectricity.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxElectricity.Location = new System.Drawing.Point(40, 101);
            this.checkBoxElectricity.Name = "checkBoxElectricity";
            this.checkBoxElectricity.Size = new System.Drawing.Size(121, 19);
            this.checkBoxElectricity.TabIndex = 3;
            this.checkBoxElectricity.Text = "Electricity Bill";
            this.checkBoxElectricity.UseVisualStyleBackColor = true;
            // 
            // checkBoxSupply
            // 
            this.checkBoxSupply.AutoSize = true;
            this.checkBoxSupply.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSupply.Location = new System.Drawing.Point(40, 151);
            this.checkBoxSupply.Name = "checkBoxSupply";
            this.checkBoxSupply.Size = new System.Drawing.Size(97, 19);
            this.checkBoxSupply.TabIndex = 5;
            this.checkBoxSupply.Text = "Supply Bill";
            this.checkBoxSupply.UseVisualStyleBackColor = true;
            // 
            // checkBoxOther
            // 
            this.checkBoxOther.AutoSize = true;
            this.checkBoxOther.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOther.Location = new System.Drawing.Point(40, 201);
            this.checkBoxOther.Name = "checkBoxOther";
            this.checkBoxOther.Size = new System.Drawing.Size(90, 19);
            this.checkBoxOther.TabIndex = 7;
            this.checkBoxOther.Text = "Other Bill";
            this.checkBoxOther.UseVisualStyleBackColor = true;
            // 
            // textBoxOxygen
            // 
            this.textBoxOxygen.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxOxygen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOxygen.Location = new System.Drawing.Point(249, 55);
            this.textBoxOxygen.Name = "textBoxOxygen";
            this.textBoxOxygen.Size = new System.Drawing.Size(126, 16);
            this.textBoxOxygen.TabIndex = 1;
            this.textBoxOxygen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxOxygen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOxygen_KeyPress);
            // 
            // textBoxelectricity
            // 
            this.textBoxelectricity.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxelectricity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxelectricity.Location = new System.Drawing.Point(249, 106);
            this.textBoxelectricity.Name = "textBoxelectricity";
            this.textBoxelectricity.Size = new System.Drawing.Size(126, 16);
            this.textBoxelectricity.TabIndex = 4;
            this.textBoxelectricity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxelectricity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxelectricity_KeyPress);
            // 
            // textBoxsupply
            // 
            this.textBoxsupply.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxsupply.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxsupply.Location = new System.Drawing.Point(249, 156);
            this.textBoxsupply.Name = "textBoxsupply";
            this.textBoxsupply.Size = new System.Drawing.Size(126, 16);
            this.textBoxsupply.TabIndex = 6;
            this.textBoxsupply.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxsupply.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxsupply_KeyPress);
            // 
            // textBoxother
            // 
            this.textBoxother.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxother.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxother.Location = new System.Drawing.Point(249, 205);
            this.textBoxother.Name = "textBoxother";
            this.textBoxother.Size = new System.Drawing.Size(126, 16);
            this.textBoxother.TabIndex = 8;
            this.textBoxother.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxother.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxother_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Amount";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dateTimePicker.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(438, 51);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(103, 23);
            this.dateTimePicker.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(581, 504);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBoxEnterRecord
            // 
            this.groupBoxEnterRecord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEnterRecord.Controls.Add(this.dateTimePicker);
            this.groupBoxEnterRecord.Controls.Add(this.label1);
            this.groupBoxEnterRecord.Controls.Add(this.textBoxother);
            this.groupBoxEnterRecord.Controls.Add(this.textBoxsupply);
            this.groupBoxEnterRecord.Controls.Add(this.textBoxelectricity);
            this.groupBoxEnterRecord.Controls.Add(this.textBoxOxygen);
            this.groupBoxEnterRecord.Controls.Add(this.checkBoxOther);
            this.groupBoxEnterRecord.Controls.Add(this.checkBoxSupply);
            this.groupBoxEnterRecord.Controls.Add(this.checkBoxElectricity);
            this.groupBoxEnterRecord.Controls.Add(this.checkBoxOxygen);
            this.groupBoxEnterRecord.Controls.Add(this.shapeContainer1);
            this.groupBoxEnterRecord.Font = new System.Drawing.Font("Lucida Bright", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEnterRecord.Location = new System.Drawing.Point(7, 24);
            this.groupBoxEnterRecord.Name = "groupBoxEnterRecord";
            this.groupBoxEnterRecord.Size = new System.Drawing.Size(647, 252);
            this.groupBoxEnterRecord.TabIndex = 39;
            this.groupBoxEnterRecord.TabStop = false;
            this.groupBoxEnterRecord.Text = "Entering Bill\'s Record";
            this.groupBoxEnterRecord.Visible = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 19);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineShape2,
            this.lineShape3,
            this.lineShape4});
            this.shapeContainer1.Size = new System.Drawing.Size(641, 230);
            this.shapeContainer1.TabIndex = 35;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 246;
            this.lineShape1.X2 = 370;
            this.lineShape1.Y1 = 53;
            this.lineShape1.Y2 = 53;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 246;
            this.lineShape2.X2 = 370;
            this.lineShape2.Y1 = 103;
            this.lineShape2.Y2 = 103;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 246;
            this.lineShape3.X2 = 370;
            this.lineShape3.Y1 = 153;
            this.lineShape3.Y2 = 153;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 247;
            this.lineShape4.X2 = 371;
            this.lineShape4.Y1 = 202;
            this.lineShape4.Y2 = 202;
            // 
            // btnEnterNewRecord
            // 
            this.btnEnterNewRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnterNewRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEnterNewRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnEnterNewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterNewRecord.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterNewRecord.Location = new System.Drawing.Point(151, 12);
            this.btnEnterNewRecord.Name = "btnEnterNewRecord";
            this.btnEnterNewRecord.Size = new System.Drawing.Size(165, 25);
            this.btnEnterNewRecord.TabIndex = 40;
            this.btnEnterNewRecord.Text = "Enter New Records";
            this.btnEnterNewRecord.UseVisualStyleBackColor = true;
            this.btnEnterNewRecord.Click += new System.EventHandler(this.btnEnterNewRecord_Click);
            // 
            // btnShowRecords
            // 
            this.btnShowRecords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowRecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnShowRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnShowRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowRecords.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowRecords.Location = new System.Drawing.Point(356, 12);
            this.btnShowRecords.Name = "btnShowRecords";
            this.btnShowRecords.Size = new System.Drawing.Size(165, 25);
            this.btnShowRecords.TabIndex = 41;
            this.btnShowRecords.Text = "Show Records";
            this.btnShowRecords.UseVisualStyleBackColor = true;
            this.btnShowRecords.Click += new System.EventHandler(this.btnShowRecords_Click);
            // 
            // btnMonthly
            // 
            this.btnMonthly.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMonthly.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMonthly.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthly.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthly.Location = new System.Drawing.Point(151, 58);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(165, 25);
            this.btnMonthly.TabIndex = 42;
            this.btnMonthly.Text = "Show Monthly Records";
            this.btnMonthly.UseVisualStyleBackColor = true;
            this.btnMonthly.Visible = false;
            this.btnMonthly.Click += new System.EventHandler(this.btnMonthly_Click);
            // 
            // btnyearly
            // 
            this.btnyearly.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnyearly.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnyearly.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnyearly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyearly.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyearly.Location = new System.Drawing.Point(356, 58);
            this.btnyearly.Name = "btnyearly";
            this.btnyearly.Size = new System.Drawing.Size(165, 25);
            this.btnyearly.TabIndex = 43;
            this.btnyearly.Text = "Show Yearly Records";
            this.btnyearly.UseVisualStyleBackColor = true;
            this.btnyearly.Visible = false;
            this.btnyearly.Click += new System.EventHandler(this.btnyearly_Click);
            // 
            // paneldatagridview
            // 
            this.paneldatagridview.Controls.Add(this.groupBoxEnterRecord);
            this.paneldatagridview.Controls.Add(this.dataGridView1);
            this.paneldatagridview.Location = new System.Drawing.Point(21, 121);
            this.paneldatagridview.Name = "paneldatagridview";
            this.paneldatagridview.Size = new System.Drawing.Size(662, 331);
            this.paneldatagridview.TabIndex = 44;
            this.paneldatagridview.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billoxygen,
            this.billelectricity,
            this.billsupply,
            this.billother,
            this.monthyear});
            this.dataGridView1.Location = new System.Drawing.Point(7, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(646, 296);
            this.dataGridView1.TabIndex = 40;
            // 
            // billoxygen
            // 
            this.billoxygen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.billoxygen.HeaderText = "Oxygen Bill";
            this.billoxygen.Name = "billoxygen";
            this.billoxygen.ReadOnly = true;
            // 
            // billelectricity
            // 
            this.billelectricity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.billelectricity.HeaderText = "Electricity Bill";
            this.billelectricity.Name = "billelectricity";
            this.billelectricity.ReadOnly = true;
            // 
            // billsupply
            // 
            this.billsupply.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.billsupply.HeaderText = "Supply Bill";
            this.billsupply.Name = "billsupply";
            this.billsupply.ReadOnly = true;
            // 
            // billother
            // 
            this.billother.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.billother.HeaderText = "Other Bill";
            this.billother.Name = "billother";
            this.billother.ReadOnly = true;
            // 
            // monthyear
            // 
            this.monthyear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.monthyear.HeaderText = "Month / Year";
            this.monthyear.Name = "monthyear";
            this.monthyear.ReadOnly = true;
            // 
            // otherExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(720, 600);
            this.Controls.Add(this.btnyearly);
            this.Controls.Add(this.btnMonthly);
            this.Controls.Add(this.btnShowRecords);
            this.Controls.Add(this.btnEnterNewRecord);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.paneldatagridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "otherExpensesForm";
            this.Text = "otherExpensesForm";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupBoxEnterRecord.ResumeLayout(false);
            this.groupBoxEnterRecord.PerformLayout();
            this.paneldatagridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.CheckBox checkBoxOxygen;
        private System.Windows.Forms.CheckBox checkBoxElectricity;
        private System.Windows.Forms.CheckBox checkBoxSupply;
        private System.Windows.Forms.CheckBox checkBoxOther;
        private System.Windows.Forms.TextBox textBoxOxygen;
        private System.Windows.Forms.TextBox textBoxelectricity;
        private System.Windows.Forms.TextBox textBoxsupply;
        private System.Windows.Forms.TextBox textBoxother;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBoxEnterRecord;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private System.Windows.Forms.Button btnEnterNewRecord;
        private System.Windows.Forms.Button btnShowRecords;
        private System.Windows.Forms.Button btnMonthly;
        private System.Windows.Forms.Button btnyearly;
        private System.Windows.Forms.Panel paneldatagridview;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn billoxygen;
        private System.Windows.Forms.DataGridViewTextBoxColumn billelectricity;
        private System.Windows.Forms.DataGridViewTextBoxColumn billsupply;
        private System.Windows.Forms.DataGridViewTextBoxColumn billother;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthyear;
    }
}