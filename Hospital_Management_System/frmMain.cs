using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Hospital_Managerment_System
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatientC o = new frmPatientC();
            o.MdiParent = this;
            o.Show();
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatientR o = new frmPatientR();
            o.MdiParent = this;
            o.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatientU o = new frmPatientU();
            o.MdiParent = this;
            o.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatientD o = new frmPatientD();
            o.MdiParent = this;
            o.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDoctorC d = new frmDoctorC();
            d.MdiParent = this;
            d.Show();
        }

        private void readToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDoctorR d = new frmDoctorR();
            d.MdiParent = this;
            d.Show();
        }

        
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDoctorD d = new frmDoctorD();
            d.MdiParent = this;
            d.Show();
        }

        private void medicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPharmacy p = new frmPharmacy();
            p.MdiParent = this;
            p.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime DateTime = DateTime.Now;
            this.lbl_time.Text = DateTime.ToString();
        }

        private void lbl_time_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp Help = new frmHelp();
            Help.MdiParent = this;
            Help.Show();
        }

        private void kjsddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout About = new frmAbout();
           /// About.MdiParent = this;
            About.Show();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContactus contact = new frmContactus();
            contact.MdiParent = this;
            contact.Show();
        }

        private void readEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPharmacyR pharmacy = new frmPharmacyR();
            pharmacy.MdiParent = this;
            pharmacy.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are You Sure to Terminate it?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Thanks for using NEWLIFE :)");
        }

        private void deleteEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPharmacyD Pd = new frmPharmacyD();
            Pd.MdiParent = this;
            Pd.Show();
        }

        private void pharmacyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPharmacy n = new frmPharmacy();
            n.MdiParent = this;
            n.Show();
        }

        private void patientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPatientC n = new frmPatientC();
            n.MdiParent = this;
            n.Show();
        }

        private void doctorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDoctorC n = new frmDoctorC();
            n.MdiParent = this;
            n.Show();
        }

        private void pharmacyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPharmacyR r = new frmPharmacyR();
            r.MdiParent = this;
            r.Show();
        }

        private void patientToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmPatientR r = new frmPatientR();
            r.MdiParent = this;
            r.Show();
        }

        private void doctorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmDoctorR r = new frmDoctorR();
            r.MdiParent = this;
            r.Show();
        }

        private void pharmacyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmPharmacyD d = new frmPharmacyD();
            d.MdiParent = this;
            d.Show();
        }

        private void patientToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmPatientD d = new frmPatientD();
            d.MdiParent = this;
            d.Show();
        }

        private void doctorToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmDoctorD d = new frmDoctorD();
            d.MdiParent = this;
            d.Show();
        }

    }
}
