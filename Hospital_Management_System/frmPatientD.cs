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
    public partial class frmPatientD : Form
    {

        cPatient oPatient = new cPatient();

        public frmPatientD()
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

        private void frmPatientD_Load(object sender, EventArgs e)
        {

            OleDbDataReader oDataReader = cConnection.fDataRetrieveOnlyColumn();
            while (oDataReader.Read())
            {
                
                this.comboBox1.Items.Add(oDataReader.GetString(0));

            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            cPatient oPatient = new cPatient();
            cConnection.fDataRetrieveWholeRecord(oPatient, this.comboBox1.SelectedItem.ToString());
            this.tbName.Text = oPatient.FullName;
            this.tbFatherName.Text = oPatient.FatherName;
            this.tbGender.Text = oPatient.Gender;
            this.tbBirthdate.Text = oPatient.Disease;
            this.tbOccupation.Text = oPatient.Occupation;
            this.tbCNIC.Text = oPatient.CNIC;
            this.tbAddress.Text = oPatient.Address;
            this.tbEmail.Text = oPatient.Disease;
            this.tbContact.Text = oPatient.Contact;
            this.tbPresentCity.Text = oPatient.Prescription;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cConnection.fPatient_Del(oPatient, this.comboBox1.SelectedItem.ToString());
            MessageBox.Show("Are you Sure your would like to Delete this Patient?");
            MessageBox.Show("SUPER SURE??");
            MessageBox.Show("Deleted Successfully");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }
    }
}
