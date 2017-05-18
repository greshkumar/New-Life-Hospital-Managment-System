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
    public partial class frmPatientR : Form
    {
        public frmPatientR()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPatientR_Load(object sender, EventArgs e)
        {

            OleDbDataReader oDataReader = cConnection.fDataRetrieveOnlyColumn();
            while (oDataReader.Read())
            {
                //this.listBox1.Items.Add(oDataReader.GetString(0));
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
            this.tbBirthdate.Text = oPatient.RegistrationDate;
            this.tbOccupation.Text = oPatient.Occupation;
            this.tbCNIC.Text = oPatient.CNIC;
            this.tbAddress.Text = oPatient.Address;
            this.tbEmail.Text = oPatient.Disease;
            this.tbContact.Text = oPatient.Contact;
            this.tbPresentCity.Text = oPatient.Prescription;





        }
    }
}
