
namespace HospitalManagementSystem
{
    partial class nurseSalaryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNurse = new System.Windows.Forms.ComboBox();
            this.labelStatusDisplay = new System.Windows.Forms.Label();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnCheckStatus = new System.Windows.Forms.Button();
            this.groupBoxsalaryDetail = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.radioButtonFullSalaryNurse = new System.Windows.Forms.RadioButton();
            this.textBoxAdvance = new System.Windows.Forms.TextBox();
            this.radioButtonAdvanceNurse = new System.Windows.Forms.RadioButton();
            this.textBoxRemainingSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.labeloverRecieved = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupBoxsalaryDetail.SuspendLayout();
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
            this.btnClose.TabIndex = 26;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nurse ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Salary Status";
            // 
            // comboBoxNurse
            // 
            this.comboBoxNurse.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboBoxNurse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNurse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNurse.FormattingEnabled = true;
            this.comboBoxNurse.Location = new System.Drawing.Point(153, 104);
            this.comboBoxNurse.Name = "comboBoxNurse";
            this.comboBoxNurse.Size = new System.Drawing.Size(167, 21);
            this.comboBoxNurse.TabIndex = 29;
            this.comboBoxNurse.SelectedIndexChanged += new System.EventHandler(this.comboBoxNurse_SelectedIndexChanged);
            // 
            // labelStatusDisplay
            // 
            this.labelStatusDisplay.AutoSize = true;
            this.labelStatusDisplay.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusDisplay.Location = new System.Drawing.Point(522, 105);
            this.labelStatusDisplay.Name = "labelStatusDisplay";
            this.labelStatusDisplay.Size = new System.Drawing.Size(15, 15);
            this.labelStatusDisplay.TabIndex = 30;
            this.labelStatusDisplay.Text = "  ";
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 486;
            this.lineShape2.X2 = 652;
            this.lineShape2.Y1 = 123;
            this.lineShape2.Y2 = 123;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(720, 600);
            this.shapeContainer1.TabIndex = 31;
            this.shapeContainer1.TabStop = false;
            // 
            // btnCheckStatus
            // 
            this.btnCheckStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCheckStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnCheckStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckStatus.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckStatus.Location = new System.Drawing.Point(285, 149);
            this.btnCheckStatus.Name = "btnCheckStatus";
            this.btnCheckStatus.Size = new System.Drawing.Size(139, 33);
            this.btnCheckStatus.TabIndex = 32;
            this.btnCheckStatus.Text = "Check Status";
            this.btnCheckStatus.UseVisualStyleBackColor = true;
            this.btnCheckStatus.Click += new System.EventHandler(this.btnCheckStatus_Click);
            // 
            // groupBoxsalaryDetail
            // 
            this.groupBoxsalaryDetail.Controls.Add(this.btnSave);
            this.groupBoxsalaryDetail.Controls.Add(this.radioButtonFullSalaryNurse);
            this.groupBoxsalaryDetail.Controls.Add(this.textBoxAdvance);
            this.groupBoxsalaryDetail.Controls.Add(this.radioButtonAdvanceNurse);
            this.groupBoxsalaryDetail.Controls.Add(this.textBoxRemainingSalary);
            this.groupBoxsalaryDetail.Controls.Add(this.label3);
            this.groupBoxsalaryDetail.Controls.Add(this.shapeContainer2);
            this.groupBoxsalaryDetail.Location = new System.Drawing.Point(86, 217);
            this.groupBoxsalaryDetail.Name = "groupBoxsalaryDetail";
            this.groupBoxsalaryDetail.Size = new System.Drawing.Size(552, 282);
            this.groupBoxsalaryDetail.TabIndex = 37;
            this.groupBoxsalaryDetail.TabStop = false;
            this.groupBoxsalaryDetail.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(453, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radioButtonFullSalaryNurse
            // 
            this.radioButtonFullSalaryNurse.AutoSize = true;
            this.radioButtonFullSalaryNurse.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFullSalaryNurse.Location = new System.Drawing.Point(33, 158);
            this.radioButtonFullSalaryNurse.Name = "radioButtonFullSalaryNurse";
            this.radioButtonFullSalaryNurse.Size = new System.Drawing.Size(103, 19);
            this.radioButtonFullSalaryNurse.TabIndex = 5;
            this.radioButtonFullSalaryNurse.TabStop = true;
            this.radioButtonFullSalaryNurse.Text = "Full Payment";
            this.radioButtonFullSalaryNurse.UseVisualStyleBackColor = true;
            // 
            // textBoxAdvance
            // 
            this.textBoxAdvance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxAdvance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAdvance.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdvance.Location = new System.Drawing.Point(192, 98);
            this.textBoxAdvance.Name = "textBoxAdvance";
            this.textBoxAdvance.Size = new System.Drawing.Size(110, 13);
            this.textBoxAdvance.TabIndex = 4;
            this.textBoxAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButtonAdvanceNurse
            // 
            this.radioButtonAdvanceNurse.AutoSize = true;
            this.radioButtonAdvanceNurse.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdvanceNurse.Location = new System.Drawing.Point(33, 98);
            this.radioButtonAdvanceNurse.Name = "radioButtonAdvanceNurse";
            this.radioButtonAdvanceNurse.Size = new System.Drawing.Size(79, 19);
            this.radioButtonAdvanceNurse.TabIndex = 3;
            this.radioButtonAdvanceNurse.TabStop = true;
            this.radioButtonAdvanceNurse.Text = "Advance";
            this.radioButtonAdvanceNurse.UseVisualStyleBackColor = true;
            // 
            // textBoxRemainingSalary
            // 
            this.textBoxRemainingSalary.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxRemainingSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRemainingSalary.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRemainingSalary.Location = new System.Drawing.Point(192, 40);
            this.textBoxRemainingSalary.Name = "textBoxRemainingSalary";
            this.textBoxRemainingSalary.Size = new System.Drawing.Size(110, 13);
            this.textBoxRemainingSalary.TabIndex = 1;
            this.textBoxRemainingSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Remaining Fee";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3});
            this.shapeContainer2.Size = new System.Drawing.Size(546, 263);
            this.shapeContainer2.TabIndex = 2;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 188;
            this.lineShape4.X2 = 296;
            this.lineShape4.Y1 = 97;
            this.lineShape4.Y2 = 97;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 190;
            this.lineShape3.X2 = 298;
            this.lineShape3.Y1 = 39;
            this.lineShape3.Y2 = 39;
            // 
            // labeloverRecieved
            // 
            this.labeloverRecieved.AutoSize = true;
            this.labeloverRecieved.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeloverRecieved.Location = new System.Drawing.Point(258, 199);
            this.labeloverRecieved.Name = "labeloverRecieved";
            this.labeloverRecieved.Size = new System.Drawing.Size(15, 15);
            this.labeloverRecieved.TabIndex = 38;
            this.labeloverRecieved.Text = "  ";
            this.labeloverRecieved.Visible = false;
            // 
            // nurseSalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(720, 600);
            this.Controls.Add(this.labeloverRecieved);
            this.Controls.Add(this.groupBoxsalaryDetail);
            this.Controls.Add(this.btnCheckStatus);
            this.Controls.Add(this.labelStatusDisplay);
            this.Controls.Add(this.comboBoxNurse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "nurseSalaryForm";
            this.Text = "nurseSalaryForm";
            this.Load += new System.EventHandler(this.nurseSalaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupBoxsalaryDetail.ResumeLayout(false);
            this.groupBoxsalaryDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxNurse;
        private System.Windows.Forms.Label labelStatusDisplay;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button btnCheckStatus;
        private System.Windows.Forms.GroupBox groupBoxsalaryDetail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton radioButtonFullSalaryNurse;
        private System.Windows.Forms.TextBox textBoxAdvance;
        private System.Windows.Forms.RadioButton radioButtonAdvanceNurse;
        private System.Windows.Forms.TextBox textBoxRemainingSalary;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.Label labeloverRecieved;
    }
}