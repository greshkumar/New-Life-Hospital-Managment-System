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
    public partial class frmPatientC : Form
    {
        cPatient oPatient = new cPatient();
        
        public frmPatientC()
        {
            InitializeComponent();
        }

       
        private void frmPatientC_Load(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tbName.Clear();
            this.tbFatherName.Clear();
            this.comboGender.ResetText();
            this.dtRegistrationDate.ResetText();
            this.comboOccupation.ResetText();
            this.tbDisease.Clear();
            this.tbCNIC.Clear();
            this.tbContact.Clear();
            this.tbAddress.Clear();
            ///this.tbPrescription.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            oPatient.FullName = this.tbName.Text;
            oPatient.FatherName = this.tbFatherName.Text;
            oPatient.Gender = this.comboGender.Text;
            oPatient.RegistrationDate = this.dtRegistrationDate.Text;
            oPatient.Occupation = this.comboOccupation.Text;
            oPatient.CNIC = this.tbCNIC.Text;
            oPatient.Contact = this.tbContact.Text;
            oPatient.Disease = this.tbDisease.Text;
            oPatient.Address = this.tbAddress.Text;
           oPatient.Prescription = this.tbPrescription.Text;

            cConnection.fPatientDataSave(oPatient);
            MessageBox.Show("Data Successfully inserted!");
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

        private void tbCNIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 ? true : false;
        }

        private void tbContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }

        private void tbPrescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                this.tbPrescription.BackColor = Color.Red;
                MessageBox.Show("Please Enter authentic Data");

                this.tbPrescription.BackColor = Color.White;

            }
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            cMessenger.fCheckTextBoxIsEmpty(tbName);
        }

        private void tbFatherName_Leave_1(object sender, EventArgs e)
        {
            cMessenger.fCheckTextBoxIsEmpty(tbFatherName);
        }

        private void tbCNIC_Leave(object sender, EventArgs e)
        {
            cMessenger.fCheckTextBoxIsEmpty(tbCNIC);
        }

        private void tbContact_Leave(object sender, EventArgs e)
        {
            cMessenger.fCheckTextBoxIsEmpty(tbContact);
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            cMessenger.fCheckTextBoxIsEmpty(tbDisease);
        }

        private void tbAddress_Leave(object sender, EventArgs e)
        {
            cMessenger.fCheckTextBoxIsEmpty(tbAddress);
        }

        private void tbPrescription_Leave(object sender, EventArgs e)
        {
            cMessenger.fCheckTextBoxIsEmpty(tbPrescription);
        }

        private void tbName_Leave_1(object sender, EventArgs e)
        {
            cMessenger.fCheckTextBoxIsEmpty(tbName);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtbirthdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbPrescription_TextChanged(object sender, EventArgs e)
        {

        }

        

    }
}
