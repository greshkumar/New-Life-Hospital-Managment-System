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
    public partial class frmPatientU : Form
    {
        cPatient oPatient = new cPatient();

        public frmPatientU()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oPatient.FullName = this.tbName.Text;
            oPatient.FatherName = this.tbFatherName.Text;
            oPatient.Gender = this.comboGender.Text;
            oPatient.RegistrationDate = this.dtbirthdate.Text;
            oPatient.Occupation = this.comboOccupation.Text;
            oPatient.CNIC = this.tbCNIC.Text;
            oPatient.Disease = this.tbEmail.Text;
            oPatient.Contact = this.tbContact.Text;
            oPatient.Address = this.tbAddress.Text;
            oPatient.Prescription = this.tbPresentCity.Text;
            cConnection.fPatient_Update(oPatient, this.comboBox1.SelectedItem.ToString());
            MessageBox.Show("Successfully Updated");

        }

        private void frmPatientU_Load(object sender, EventArgs e)
        {
            OleDbDataReader oDataReader = cConnection.fDataRetrieveOnlyColumn();
            while (oDataReader.Read())
            {
                //this.listBox1.Items.Add(oDataReader.GetString(0));
                this.comboBox1.Items.Add(oDataReader.GetString(0));

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            cPatient oPatient = new cPatient();
            cConnection.fDataRetrieveWholeRecord(oPatient, this.comboBox1.SelectedItem.ToString());
            this.tbName.Text = oPatient.FullName;
            this.tbFatherName.Text = oPatient.FatherName;
            this.comboGender.Text = oPatient.Gender;
            this.dtbirthdate.Text = oPatient.RegistrationDate;
            this.comboOccupation.Text = oPatient.Occupation;
            this.tbCNIC.Text = oPatient.CNIC;
            this.tbAddress.Text = oPatient.Address;
            this.tbEmail.Text = oPatient.Disease;
            this.tbContact.Text = oPatient.Contact;
            this.tbPresentCity.Text = oPatient.Prescription;

        }

        private void tbContact_TextChanged(object sender, EventArgs e)
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

        
    }
}
