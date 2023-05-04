
namespace HospitalManagementSystem
{
    partial class removingForm
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
            this.radioButtonDoctor = new System.Windows.Forms.RadioButton();
            this.radioButtonNurse = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxNurse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonDoctor
            // 
            this.radioButtonDoctor.AutoSize = true;
            this.radioButtonDoctor.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDoctor.Location = new System.Drawing.Point(212, 124);
            this.radioButtonDoctor.Name = "radioButtonDoctor";
            this.radioButtonDoctor.Size = new System.Drawing.Size(111, 18);
            this.radioButtonDoctor.TabIndex = 0;
            this.radioButtonDoctor.TabStop = true;
            this.radioButtonDoctor.Text = "Remove Doctor";
            this.radioButtonDoctor.UseVisualStyleBackColor = true;
            this.radioButtonDoctor.CheckedChanged += new System.EventHandler(this.radioButtonDoctor_CheckedChanged);
            // 
            // radioButtonNurse
            // 
            this.radioButtonNurse.AutoSize = true;
            this.radioButtonNurse.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNurse.Location = new System.Drawing.Point(338, 124);
            this.radioButtonNurse.Name = "radioButtonNurse";
            this.radioButtonNurse.Size = new System.Drawing.Size(105, 18);
            this.radioButtonNurse.TabIndex = 1;
            this.radioButtonNurse.TabStop = true;
            this.radioButtonNurse.Text = "Remove Nurse";
            this.radioButtonNurse.UseVisualStyleBackColor = true;
            this.radioButtonNurse.CheckedChanged += new System.EventHandler(this.radioButtonNurse_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.delete_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboBoxDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(290, 184);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(176, 21);
            this.comboBoxDoctor.TabIndex = 2;
            this.comboBoxDoctor.Visible = false;
            this.comboBoxDoctor.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoctor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Removing Staff";
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(583, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxNurse
            // 
            this.comboBoxNurse.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboBoxNurse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNurse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxNurse.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNurse.FormattingEnabled = true;
            this.comboBoxNurse.Location = new System.Drawing.Point(290, 184);
            this.comboBoxNurse.Name = "comboBoxNurse";
            this.comboBoxNurse.Size = new System.Drawing.Size(176, 22);
            this.comboBoxNurse.TabIndex = 2;
            this.comboBoxNurse.Visible = false;
            this.comboBoxNurse.SelectedIndexChanged += new System.EventHandler(this.comboBoxNurse_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Removing Staff";
            this.label2.Visible = false;
            // 
            // removingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(720, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxNurse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDoctor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioButtonNurse);
            this.Controls.Add(this.radioButtonDoctor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "removingForm";
            this.Text = "removingForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonDoctor;
        private System.Windows.Forms.RadioButton radioButtonNurse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxDoctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxNurse;
        private System.Windows.Forms.Label label2;
    }
}