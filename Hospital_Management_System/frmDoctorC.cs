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
    public partial class frmDoctorC : Form
    {
        
        cDoctor oDoctor = new cDoctor();

        public frmDoctorC()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            oDoctor.Name = this.tbName.Text;
            oDoctor.FatherName = this.tbFatherName.Text;
            oDoctor.CNIC = this.tbCNIC.Text;
            oDoctor.Type = this.tbType.Text;
            oDoctor.Contact = this.tbContact.Text;
            oDoctor.Disease = this.tbDisease.Text;
            oDoctor.Address = this.tbAddress.Text;
            oDoctor.Prescription = this.tbPresentCity.Text;
            oDoctor.Payroll = this.tbPayroll.Text;
            oDoctor.Timing = this.tbTiming.Text;

            cConnection.fDoctorDataSave(oDoctor);
            MessageBox.Show("Data Successfully inserted!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tbName.Clear();
            this.tbFatherName.Clear();
            this.tbDisease.Clear();
            this.tbCNIC.Clear();
            this.tbAddress.Clear();
            this.tbPayroll.Clear();
            this.tbPresentCity.Clear();
            this.tbContact.Clear();
            this.tbType.Clear();
            this.tbTiming.Clear();
        }

        private void comboName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }

        private void tbCNIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 ? true : false;
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                this.tbName.BackColor = Color.Red;
                MessageBox.Show("Please Enter authentic Data");

                this.tbName.BackColor = Color.White;

            }
        }

        private void tbFatherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                this.tbFatherName.BackColor = Color.Red;
                MessageBox.Show("Please Enter authentic Data");

                this.tbFatherName.BackColor = Color.White;

            }
        }

        private void tbPresentCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                this.tbPresentCity.BackColor = Color.Red;
                MessageBox.Show("Please Enter authentic Data");

                this.tbPresentCity.BackColor = Color.White;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            cMessenger.fCheckTextBoxIsEmpty(tbName);
        }

        private void tbFatherName_Leave(object sender, EventArgs e)
        {
            cMessenger.fCheckTextBoxIsEmpty(tbName);
        }

        private void tbCNIC_Leave(object sender, EventArgs e)
        {
            cMessenger.fCheckTextBoxIsEmpty(tbName);
        }

        private void tbContact_Leave(object sender, EventArgs e)
        {
            cMessenger.fCheckTextBoxIsEmpty(tbName);
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            cMessenger.fCheckTextBoxIsEmpty(tbName);
        }

        private void tbAddress_Leave(object sender, EventArgs e)
        {
            cMessenger.fCheckTextBoxIsEmpty(tbName);
        }

        private void tbPresentCity_Leave(object sender, EventArgs e)
        {
            cMessenger.fCheckTextBoxIsEmpty(tbName);
        }

        private void tbTiming_Leave(object sender, EventArgs e)
        {
            cMessenger.fCheckTextBoxIsEmpty(tbName);
        }

        private void tbType_Leave(object sender, EventArgs e)
        {
            cMessenger.fCheckTextBoxIsEmpty(tbName);
        }

        private void tbPayroll_Leave(object sender, EventArgs e)
        {
            cMessenger.fCheckTextBoxIsEmpty(tbName);
        }
    }
}
