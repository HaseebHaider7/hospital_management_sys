
namespace HospitalManagementSystem
{
    partial class DischargingPatient
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
            this.labelpatientID = new System.Windows.Forms.Label();
            this.labeldischargingDate = new System.Windows.Forms.Label();
            this.btnDischarge = new System.Windows.Forms.Button();
            this.labeldischargingDateDisplay = new System.Windows.Forms.Label();
            this.groupBoxDischarging = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxPatientID = new System.Windows.Forms.ComboBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShapedischarging = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxDischarging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelpatientID
            // 
            this.labelpatientID.AutoSize = true;
            this.labelpatientID.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelpatientID.Location = new System.Drawing.Point(60, 50);
            this.labelpatientID.Name = "labelpatientID";
            this.labelpatientID.Size = new System.Drawing.Size(72, 15);
            this.labelpatientID.TabIndex = 2;
            this.labelpatientID.Text = "Patient ID";
            // 
            // labeldischargingDate
            // 
            this.labeldischargingDate.AutoSize = true;
            this.labeldischargingDate.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold);
            this.labeldischargingDate.Location = new System.Drawing.Point(60, 110);
            this.labeldischargingDate.Name = "labeldischargingDate";
            this.labeldischargingDate.Size = new System.Drawing.Size(123, 15);
            this.labeldischargingDate.TabIndex = 5;
            this.labeldischargingDate.Text = "Discharging Date";
            // 
            // btnDischarge
            // 
            this.btnDischarge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDischarge.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDischarge.Location = new System.Drawing.Point(340, 179);
            this.btnDischarge.Name = "btnDischarge";
            this.btnDischarge.Size = new System.Drawing.Size(90, 25);
            this.btnDischarge.TabIndex = 7;
            this.btnDischarge.Text = "Discharge";
            this.btnDischarge.UseVisualStyleBackColor = true;
            this.btnDischarge.Click += new System.EventHandler(this.BtnDischarge_Click);
            // 
            // labeldischargingDateDisplay
            // 
            this.labeldischargingDateDisplay.AutoSize = true;
            this.labeldischargingDateDisplay.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold);
            this.labeldischargingDateDisplay.Location = new System.Drawing.Point(228, 113);
            this.labeldischargingDateDisplay.Name = "labeldischargingDateDisplay";
            this.labeldischargingDateDisplay.Size = new System.Drawing.Size(47, 15);
            this.labeldischargingDateDisplay.TabIndex = 8;
            this.labeldischargingDateDisplay.Text = "label1";
            this.labeldischargingDateDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxDischarging
            // 
            this.groupBoxDischarging.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDischarging.Controls.Add(this.button1);
            this.groupBoxDischarging.Controls.Add(this.comboBoxPatientID);
            this.groupBoxDischarging.Controls.Add(this.labeldischargingDateDisplay);
            this.groupBoxDischarging.Controls.Add(this.btnDischarge);
            this.groupBoxDischarging.Controls.Add(this.labeldischargingDate);
            this.groupBoxDischarging.Controls.Add(this.labelpatientID);
            this.groupBoxDischarging.Controls.Add(this.shapeContainer2);
            this.groupBoxDischarging.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBoxDischarging.Location = new System.Drawing.Point(85, 139);
            this.groupBoxDischarging.Name = "groupBoxDischarging";
            this.groupBoxDischarging.Size = new System.Drawing.Size(509, 239);
            this.groupBoxDischarging.TabIndex = 9;
            this.groupBoxDischarging.TabStop = false;
            this.groupBoxDischarging.Text = "Discharging Details";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBoxPatientID
            // 
            this.comboBoxPatientID.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboBoxPatientID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPatientID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPatientID.FormattingEnabled = true;
            this.comboBoxPatientID.Location = new System.Drawing.Point(230, 47);
            this.comboBoxPatientID.Name = "comboBoxPatientID";
            this.comboBoxPatientID.Size = new System.Drawing.Size(199, 23);
            this.comboBoxPatientID.TabIndex = 10;
            this.comboBoxPatientID.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPatientID_SelectedIndexChanged);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 19);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShapedischarging});
            this.shapeContainer2.Size = new System.Drawing.Size(503, 217);
            this.shapeContainer2.TabIndex = 9;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShapedischarging
            // 
            this.lineShapedischarging.Name = "lineShapedischarging";
            this.lineShapedischarging.X1 = 227;
            this.lineShapedischarging.X2 = 427;
            this.lineShapedischarging.Y1 = 113;
            this.lineShapedischarging.Y2 = 113;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.delete_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DischargingPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(704, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxDischarging);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DischargingPatient";
            this.Text = "dischargingPatient";
            this.Load += new System.EventHandler(this.DischargingPatient_Load);
            this.groupBoxDischarging.ResumeLayout(false);
            this.groupBoxDischarging.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelpatientID;
        private System.Windows.Forms.Label labeldischargingDate;
        private System.Windows.Forms.Button btnDischarge;
        private System.Windows.Forms.Label labeldischargingDateDisplay;
        private System.Windows.Forms.GroupBox groupBoxDischarging;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShapedischarging;
        private System.Windows.Forms.ComboBox comboBoxPatientID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}