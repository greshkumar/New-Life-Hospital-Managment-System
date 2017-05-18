namespace Hospital_Managerment_System
{
    partial class frmPatientC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientC));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbFatherName = new System.Windows.Forms.TextBox();
            this.tbCNIC = new System.Windows.Forms.TextBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.tbDisease = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPrescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.comboOccupation = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Father\'s Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "CNIC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact #";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Disease";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(199, 91);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(152, 20);
            this.tbName.TabIndex = 7;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            this.tbName.Leave += new System.EventHandler(this.tbName_Leave_1);
            // 
            // tbFatherName
            // 
            this.tbFatherName.Location = new System.Drawing.Point(199, 117);
            this.tbFatherName.Name = "tbFatherName";
            this.tbFatherName.Size = new System.Drawing.Size(152, 20);
            this.tbFatherName.TabIndex = 8;
            this.tbFatherName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFatherName_KeyPress);
            this.tbFatherName.Leave += new System.EventHandler(this.tbFatherName_Leave_1);
            // 
            // tbCNIC
            // 
            this.tbCNIC.Location = new System.Drawing.Point(199, 222);
            this.tbCNIC.Name = "tbCNIC";
            this.tbCNIC.Size = new System.Drawing.Size(152, 20);
            this.tbCNIC.TabIndex = 9;
            this.tbCNIC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCNIC_KeyPress);
            this.tbCNIC.Leave += new System.EventHandler(this.tbCNIC_Leave);
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(199, 248);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(152, 20);
            this.tbContact.TabIndex = 10;
            this.tbContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContact_KeyPress);
            this.tbContact.Leave += new System.EventHandler(this.tbContact_Leave);
            // 
            // tbDisease
            // 
            this.tbDisease.Location = new System.Drawing.Point(199, 274);
            this.tbDisease.Name = "tbDisease";
            this.tbDisease.Size = new System.Drawing.Size(152, 20);
            this.tbDisease.TabIndex = 11;
            this.tbDisease.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(199, 300);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(152, 20);
            this.tbAddress.TabIndex = 12;
            this.tbAddress.Leave += new System.EventHandler(this.tbAddress_Leave);
            // 
            // tbPrescription
            // 
            this.tbPrescription.Location = new System.Drawing.Point(199, 328);
            this.tbPrescription.Name = "tbPrescription";
            this.tbPrescription.Size = new System.Drawing.Size(152, 20);
            this.tbPrescription.TabIndex = 14;
            this.tbPrescription.TextChanged += new System.EventHandler(this.tbPrescription_TextChanged);
            this.tbPrescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrescription_KeyPress);
            this.tbPrescription.Leave += new System.EventHandler(this.tbPrescription_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Prescription";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(493, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "     Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(493, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "     Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(493, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "    E&xit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(351, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Enter appropriate Information for a Patient";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "Occupation";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 16);
            this.label10.TabIndex = 45;
            this.label10.Text = "RegistrationDate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 46;
            this.label11.Text = "Gender";
            // 
            // dtRegistrationDate
            // 
            this.dtRegistrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRegistrationDate.Location = new System.Drawing.Point(199, 173);
            this.dtRegistrationDate.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtRegistrationDate.Name = "dtRegistrationDate";
            this.dtRegistrationDate.Size = new System.Drawing.Size(152, 20);
            this.dtRegistrationDate.TabIndex = 47;
            this.dtRegistrationDate.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtRegistrationDate.ValueChanged += new System.EventHandler(this.dtbirthdate_ValueChanged);
            // 
            // comboGender
            // 
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboGender.Location = new System.Drawing.Point(199, 148);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(152, 21);
            this.comboGender.TabIndex = 48;
            // 
            // comboOccupation
            // 
            this.comboOccupation.FormattingEnabled = true;
            this.comboOccupation.Items.AddRange(new object[] {
            "Student",
            "Doctor",
            "Teacher",
            "Labour",
            "Social Worker",
            "Government Official",
            "Artist",
            "Businessman",
            "Driver",
            "Barber",
            "Banker",
            "Trader",
            "Engineer",
            "Other"});
            this.comboOccupation.Location = new System.Drawing.Point(199, 196);
            this.comboOccupation.Name = "comboOccupation";
            this.comboOccupation.Size = new System.Drawing.Size(152, 21);
            this.comboOccupation.TabIndex = 49;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(416, 279);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(228, 13);
            this.label15.TabIndex = 103;
            this.label15.Text = "To Teminate from Application, Click Exit Button";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(416, 254);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(202, 13);
            this.label14.TabIndex = 102;
            this.label14.Text = "To Close this Window, Click Close Button";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(416, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(207, 13);
            this.label13.TabIndex = 101;
            this.label13.Text = "To Clear the Textboxes, Click Clear Button";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(416, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(183, 13);
            this.label12.TabIndex = 100;
            this.label12.Text = "To Save the Data, Click Save Button";
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(493, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 104;
            this.button4.Text = "      Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmPatientC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(657, 361);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboOccupation);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.dtRegistrationDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPrescription);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbDisease);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.tbCNIC);
            this.Controls.Add(this.tbFatherName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPatientC";
            this.Text = "New Data Entry of a Patient";
            this.Load += new System.EventHandler(this.frmPatientC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbFatherName;
        private System.Windows.Forms.TextBox tbCNIC;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.TextBox tbDisease;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPrescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtRegistrationDate;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.ComboBox comboOccupation;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button4;
    }
}