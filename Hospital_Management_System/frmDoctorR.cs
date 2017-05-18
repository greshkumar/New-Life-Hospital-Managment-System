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
    public partial class frmDoctorR : Form
    {
        public frmDoctorR()
        {
            InitializeComponent();
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

        private void frmDoctorR_Load(object sender, EventArgs e)
        {
            OleDbDataReader oDataReader = cConnection.fDoctorRetrieveOnlyColumn();
            while (oDataReader.Read())
            {
                //this.listBox1.Items.Add(oDataReader.GetString(0));
                this.comboBox1.Items.Add(oDataReader.GetString(0));

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
