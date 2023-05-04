
namespace HospitalManagementSystem
{
    partial class doctorFeesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.labelSalaryStatus = new System.Windows.Forms.Label();
            this.labelStatusDisplay = new System.Windows.Forms.Label();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnCheckStatus = new System.Windows.Forms.Button();
            this.groupBoxsalaryDetail = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.radioButtonFullSalary = new System.Windows.Forms.RadioButton();
            this.textBoxAdvance = new System.Windows.Forms.TextBox();
            this.radioButtonAdvance = new System.Windows.Forms.RadioButton();
            this.textBoxRemainingSalary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupBoxsalaryDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Doctor ID";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::HospitalManagementSystem.Properties.Resources.delete_icon;
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 25;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboBoxDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(153, 104);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(167, 21);
            this.comboBoxDoctor.TabIndex = 31;
            this.comboBoxDoctor.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoctor_SelectedIndexChanged);
            // 
            // labelSalaryStatus
            // 
            this.labelSalaryStatus.AutoSize = true;
            this.labelSalaryStatus.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalaryStatus.Location = new System.Drawing.Point(357, 107);
            this.labelSalaryStatus.Name = "labelSalaryStatus";
            this.labelSalaryStatus.Size = new System.Drawing.Size(86, 15);
            this.labelSalaryStatus.TabIndex = 32;
            this.labelSalaryStatus.Text = "Fees Status";
            // 
            // labelStatusDisplay
            // 
            this.labelStatusDisplay.AutoSize = true;
            this.labelStatusDisplay.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusDisplay.Location = new System.Drawing.Point(522, 105);
            this.labelStatusDisplay.Name = "labelStatusDisplay";
            this.labelStatusDisplay.Size = new System.Drawing.Size(27, 15);
            this.labelStatusDisplay.TabIndex = 33;
            this.labelStatusDisplay.Text = "     ";
            this.labelStatusDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.shapeContainer1.TabIndex = 34;
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
            this.btnCheckStatus.TabIndex = 35;
            this.btnCheckStatus.Text = "Check Status";
            this.btnCheckStatus.UseVisualStyleBackColor = true;
            this.btnCheckStatus.Click += new System.EventHandler(this.btnCheckStatus_Click);
            // 
            // groupBoxsalaryDetail
            // 
            this.groupBoxsalaryDetail.Controls.Add(this.btnSave);
            this.groupBoxsalaryDetail.Controls.Add(this.radioButtonFullSalary);
            this.groupBoxsalaryDetail.Controls.Add(this.textBoxAdvance);
            this.groupBoxsalaryDetail.Controls.Add(this.radioButtonAdvance);
            this.groupBoxsalaryDetail.Controls.Add(this.textBoxRemainingSalary);
            this.groupBoxsalaryDetail.Controls.Add(this.label2);
            this.groupBoxsalaryDetail.Controls.Add(this.shapeContainer2);
            this.groupBoxsalaryDetail.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBoxsalaryDetail.Location = new System.Drawing.Point(86, 217);
            this.groupBoxsalaryDetail.Name = "groupBoxsalaryDetail";
            this.groupBoxsalaryDetail.Size = new System.Drawing.Size(552, 282);
            this.groupBoxsalaryDetail.TabIndex = 36;
            this.groupBoxsalaryDetail.TabStop = false;
            this.groupBoxsalaryDetail.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(453, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radioButtonFullSalary
            // 
            this.radioButtonFullSalary.AutoSize = true;
            this.radioButtonFullSalary.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFullSalary.Location = new System.Drawing.Point(33, 158);
            this.radioButtonFullSalary.Name = "radioButtonFullSalary";
            this.radioButtonFullSalary.Size = new System.Drawing.Size(111, 19);
            this.radioButtonFullSalary.TabIndex = 5;
            this.radioButtonFullSalary.TabStop = true;
            this.radioButtonFullSalary.Text = "Full Payment";
            this.radioButtonFullSalary.UseVisualStyleBackColor = true;
            // 
            // textBoxAdvance
            // 
            this.textBoxAdvance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxAdvance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAdvance.Location = new System.Drawing.Point(192, 98);
            this.textBoxAdvance.Name = "textBoxAdvance";
            this.textBoxAdvance.Size = new System.Drawing.Size(110, 16);
            this.textBoxAdvance.TabIndex = 4;
            this.textBoxAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButtonAdvance
            // 
            this.radioButtonAdvance.AutoSize = true;
            this.radioButtonAdvance.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdvance.Location = new System.Drawing.Point(33, 98);
            this.radioButtonAdvance.Name = "radioButtonAdvance";
            this.radioButtonAdvance.Size = new System.Drawing.Size(85, 19);
            this.radioButtonAdvance.TabIndex = 3;
            this.radioButtonAdvance.TabStop = true;
            this.radioButtonAdvance.Text = "Advance";
            this.radioButtonAdvance.UseVisualStyleBackColor = true;
            // 
            // textBoxRemainingSalary
            // 
            this.textBoxRemainingSalary.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxRemainingSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRemainingSalary.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRemainingSalary.Location = new System.Drawing.Point(192, 40);
            this.textBoxRemainingSalary.Name = "textBoxRemainingSalary";
            this.textBoxRemainingSalary.Size = new System.Drawing.Size(110, 16);
            this.textBoxRemainingSalary.TabIndex = 1;
            this.textBoxRemainingSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Remaining Fee";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 19);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3});
            this.shapeContainer2.Size = new System.Drawing.Size(546, 260);
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
            // doctorFeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(720, 600);
            this.Controls.Add(this.groupBoxsalaryDetail);
            this.Controls.Add(this.btnCheckStatus);
            this.Controls.Add(this.labelStatusDisplay);
            this.Controls.Add(this.labelSalaryStatus);
            this.Controls.Add(this.comboBoxDoctor);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "doctorFeesForm";
            this.Text = "doctorFeesForm";
            this.Load += new System.EventHandler(this.doctorFeesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupBoxsalaryDetail.ResumeLayout(false);
            this.groupBoxsalaryDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.ComboBox comboBoxDoctor;
        private System.Windows.Forms.Label labelSalaryStatus;
        private System.Windows.Forms.Label labelStatusDisplay;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button btnCheckStatus;
        private System.Windows.Forms.GroupBox groupBoxsalaryDetail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton radioButtonFullSalary;
        private System.Windows.Forms.TextBox textBoxAdvance;
        private System.Windows.Forms.RadioButton radioButtonAdvance;
        private System.Windows.Forms.TextBox textBoxRemainingSalary;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
    }
}