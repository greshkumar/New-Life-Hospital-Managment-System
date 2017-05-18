namespace Hospital_Managerment_System
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pharmacyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.retrieveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pharmacyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pharmacyToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pharmecyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kjsddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_time = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.doctorToolStripMenuItem,
            this.pharmecyToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.contactUsToolStripMenuItem,
            this.kjsddToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.retrieveToolStripMenuItem,
            this.deleteToolStripMenuItem2,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.fileToolStripMenuItem.Text = "Main Menu";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pharmacyToolStripMenuItem,
            this.patientToolStripMenuItem1,
            this.doctorToolStripMenuItem1});
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.newToolStripMenuItem.Text = "Register";
            // 
            // pharmacyToolStripMenuItem
            // 
            this.pharmacyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pharmacyToolStripMenuItem.Image")));
            this.pharmacyToolStripMenuItem.Name = "pharmacyToolStripMenuItem";
            this.pharmacyToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.pharmacyToolStripMenuItem.Text = "Pharmacy";
            this.pharmacyToolStripMenuItem.Click += new System.EventHandler(this.pharmacyToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem1
            // 
            this.patientToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("patientToolStripMenuItem1.Image")));
            this.patientToolStripMenuItem1.Name = "patientToolStripMenuItem1";
            this.patientToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.patientToolStripMenuItem1.Text = "Patient";
            this.patientToolStripMenuItem1.Click += new System.EventHandler(this.patientToolStripMenuItem1_Click);
            // 
            // doctorToolStripMenuItem1
            // 
            this.doctorToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("doctorToolStripMenuItem1.Image")));
            this.doctorToolStripMenuItem1.Name = "doctorToolStripMenuItem1";
            this.doctorToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.doctorToolStripMenuItem1.Text = "Doctor";
            this.doctorToolStripMenuItem1.Click += new System.EventHandler(this.doctorToolStripMenuItem1_Click);
            // 
            // retrieveToolStripMenuItem
            // 
            this.retrieveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pharmacyToolStripMenuItem1,
            this.patientToolStripMenuItem2,
            this.doctorToolStripMenuItem2});
            this.retrieveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("retrieveToolStripMenuItem.Image")));
            this.retrieveToolStripMenuItem.Name = "retrieveToolStripMenuItem";
            this.retrieveToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.retrieveToolStripMenuItem.Text = "Information";
            // 
            // pharmacyToolStripMenuItem1
            // 
            this.pharmacyToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("pharmacyToolStripMenuItem1.Image")));
            this.pharmacyToolStripMenuItem1.Name = "pharmacyToolStripMenuItem1";
            this.pharmacyToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.pharmacyToolStripMenuItem1.Text = "Pharmacy";
            this.pharmacyToolStripMenuItem1.Click += new System.EventHandler(this.pharmacyToolStripMenuItem1_Click);
            // 
            // patientToolStripMenuItem2
            // 
            this.patientToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("patientToolStripMenuItem2.Image")));
            this.patientToolStripMenuItem2.Name = "patientToolStripMenuItem2";
            this.patientToolStripMenuItem2.Size = new System.Drawing.Size(127, 22);
            this.patientToolStripMenuItem2.Text = "Patient";
            this.patientToolStripMenuItem2.Click += new System.EventHandler(this.patientToolStripMenuItem2_Click);
            // 
            // doctorToolStripMenuItem2
            // 
            this.doctorToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("doctorToolStripMenuItem2.Image")));
            this.doctorToolStripMenuItem2.Name = "doctorToolStripMenuItem2";
            this.doctorToolStripMenuItem2.Size = new System.Drawing.Size(127, 22);
            this.doctorToolStripMenuItem2.Text = "Doctor";
            this.doctorToolStripMenuItem2.Click += new System.EventHandler(this.doctorToolStripMenuItem2_Click);
            // 
            // deleteToolStripMenuItem2
            // 
            this.deleteToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pharmacyToolStripMenuItem2,
            this.patientToolStripMenuItem3,
            this.doctorToolStripMenuItem3});
            this.deleteToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem2.Image")));
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            this.deleteToolStripMenuItem2.Size = new System.Drawing.Size(173, 22);
            this.deleteToolStripMenuItem2.Text = "Delete Information";
            // 
            // pharmacyToolStripMenuItem2
            // 
            this.pharmacyToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("pharmacyToolStripMenuItem2.Image")));
            this.pharmacyToolStripMenuItem2.Name = "pharmacyToolStripMenuItem2";
            this.pharmacyToolStripMenuItem2.Size = new System.Drawing.Size(127, 22);
            this.pharmacyToolStripMenuItem2.Text = "Pharmacy";
            this.pharmacyToolStripMenuItem2.Click += new System.EventHandler(this.pharmacyToolStripMenuItem2_Click);
            // 
            // patientToolStripMenuItem3
            // 
            this.patientToolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("patientToolStripMenuItem3.Image")));
            this.patientToolStripMenuItem3.Name = "patientToolStripMenuItem3";
            this.patientToolStripMenuItem3.Size = new System.Drawing.Size(127, 22);
            this.patientToolStripMenuItem3.Text = "Patient";
            this.patientToolStripMenuItem3.Click += new System.EventHandler(this.patientToolStripMenuItem3_Click);
            // 
            // doctorToolStripMenuItem3
            // 
            this.doctorToolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("doctorToolStripMenuItem3.Image")));
            this.doctorToolStripMenuItem3.Name = "doctorToolStripMenuItem3";
            this.doctorToolStripMenuItem3.Size = new System.Drawing.Size(127, 22);
            this.doctorToolStripMenuItem3.Text = "Doctor";
            this.doctorToolStripMenuItem3.Click += new System.EventHandler(this.doctorToolStripMenuItem3_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem1.Image")));
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.readToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.patientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("patientToolStripMenuItem.Image")));
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createToolStripMenuItem.Image")));
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.createToolStripMenuItem.Text = "Register";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("readToolStripMenuItem.Image")));
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.readToolStripMenuItem.Text = "Information";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateToolStripMenuItem.Image")));
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.updateToolStripMenuItem.Text = "Update  Info";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.deleteToolStripMenuItem.Text = "Delete ";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem1,
            this.readToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.doctorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("doctorToolStripMenuItem.Image")));
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.doctorToolStripMenuItem.Text = "Doctor";
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("createToolStripMenuItem1.Image")));
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.createToolStripMenuItem1.Text = "Register Doctor";
            this.createToolStripMenuItem1.Click += new System.EventHandler(this.createToolStripMenuItem1_Click);
            // 
            // readToolStripMenuItem1
            // 
            this.readToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("readToolStripMenuItem1.Image")));
            this.readToolStripMenuItem1.Name = "readToolStripMenuItem1";
            this.readToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.readToolStripMenuItem1.Text = "Doctor Details";
            this.readToolStripMenuItem1.Click += new System.EventHandler(this.readToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem1.Image")));
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // pharmecyToolStripMenuItem
            // 
            this.pharmecyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicineToolStripMenuItem,
            this.readEntryToolStripMenuItem,
            this.deleteEntryToolStripMenuItem});
            this.pharmecyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pharmecyToolStripMenuItem.Image")));
            this.pharmecyToolStripMenuItem.Name = "pharmecyToolStripMenuItem";
            this.pharmecyToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.pharmecyToolStripMenuItem.Text = "Pharmacy";
            // 
            // medicineToolStripMenuItem
            // 
            this.medicineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("medicineToolStripMenuItem.Image")));
            this.medicineToolStripMenuItem.Name = "medicineToolStripMenuItem";
            this.medicineToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.medicineToolStripMenuItem.Text = "Add Stock";
            this.medicineToolStripMenuItem.Click += new System.EventHandler(this.medicineToolStripMenuItem_Click);
            // 
            // readEntryToolStripMenuItem
            // 
            this.readEntryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("readEntryToolStripMenuItem.Image")));
            this.readEntryToolStripMenuItem.Name = "readEntryToolStripMenuItem";
            this.readEntryToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.readEntryToolStripMenuItem.Text = "Check Stock";
            this.readEntryToolStripMenuItem.Click += new System.EventHandler(this.readEntryToolStripMenuItem_Click);
            // 
            // deleteEntryToolStripMenuItem
            // 
            this.deleteEntryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteEntryToolStripMenuItem.Image")));
            this.deleteEntryToolStripMenuItem.Name = "deleteEntryToolStripMenuItem";
            this.deleteEntryToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.deleteEntryToolStripMenuItem.Text = "Delete Stock";
            this.deleteEntryToolStripMenuItem.Click += new System.EventHandler(this.deleteEntryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Terminate Application";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.contactUsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contactUsToolStripMenuItem.Image")));
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.contactUsToolStripMenuItem.Text = "Contact us";
            this.contactUsToolStripMenuItem.Click += new System.EventHandler(this.contactUsToolStripMenuItem_Click);
            // 
            // kjsddToolStripMenuItem
            // 
            this.kjsddToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.kjsddToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kjsddToolStripMenuItem.Image")));
            this.kjsddToolStripMenuItem.Name = "kjsddToolStripMenuItem";
            this.kjsddToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.kjsddToolStripMenuItem.Text = "About";
            this.kjsddToolStripMenuItem.Click += new System.EventHandler(this.kjsddToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LightGray;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(0, 435);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(839, 15);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "NEW-LIFE A PROJECT OF SZABIST STUDENTS.";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_time.Location = new System.Drawing.Point(574, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_time.Size = new System.Drawing.Size(57, 24);
            this.lbl_time.TabIndex = 7;
            this.lbl_time.Text = "Time";
            this.lbl_time.Click += new System.EventHandler(this.lbl_time_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 612);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Welcome to New Life Hospital";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pharmecyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem medicineToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem kjsddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.ToolStripMenuItem readEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pharmacyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem retrieveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pharmacyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pharmacyToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

