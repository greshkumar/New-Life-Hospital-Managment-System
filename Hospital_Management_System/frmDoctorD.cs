using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hospital_Managerment_System
{
    public partial class frmDoctorD : Form
    {
        cDoctor oDoctor = new cDoctor();
        
        public frmDoctorD()
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

        private void button4_Click(object sender, EventArgs e)
        {
            cConnection.fDoctor_Del(oDoctor, this.comboBox1.SelectedItem.ToString());
            MessageBox.Show("Are you Sure your would like to Delete this Doctor");
            MessageBox.Show("Deleted Successfully");
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            cDoctor oDoctor = new cDoctor();
            cConnection.fDataRetrieveWholeRecord1(oDoctor, this.comboBox1.SelectedItem.ToString());

            this.tbName.Text = oDoctor.Name;
            this.tbFatherName.Text = oDoctor.FatherName;
            this.tbCNIC.Text = oDoctor.CNIC;
            this.tbAddress.Text = oDoctor.Address;
            this.tbEmail.Text = oDoctor.Disease;
            this.tbContact.Text = oDoctor.Contact;
            this.tbPresentCity.Text = oDoctor.Prescription;
            this.tbTiming.Text = oDoctor.Timing;
            this.tbPayroll.Text = oDoctor.Payroll;
            this.tbType.Text = oDoctor.Type;

        }

        private void frmDoctorD_Load(object sender, EventArgs e)
        {
            OleDbDataReader oDataReader = cConnection.fDoctorRetrieveOnlyColumn();
            while (oDataReader.Read())
            {

                this.comboBox1.Items.Add(oDataReader.GetString(0));

            }
        }

    }

        
}
