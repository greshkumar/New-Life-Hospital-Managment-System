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
    public partial class frmPharmacyD : Form
    {
        cPharmacy oPharmacy = new cPharmacy();
        public frmPharmacyD()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPharmacy oPharmacy = new cPharmacy();
            cConnection.fDataRetrieveWholeRecord2(oPharmacy, this.comboBox1.SelectedItem.ToString());
            this.tbName.Text = oPharmacy.Name;
            this.tbPrice.Text = oPharmacy.Price;
            this.tbType.Text = oPharmacy.Type;
            this.tbStock.Text = oPharmacy.Stock;
            this.tbCurrentDate.Text = oPharmacy.CurrentDate;
            this.tbExpiryDate.Text = oPharmacy.ExpiryDate;
            this.tbQuantity.Text = oPharmacy.Quantity;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cConnection.fPharmacy_Del(oPharmacy, this.comboBox1.SelectedItem.ToString());
            MessageBox.Show("Are you Sure your would like to Delete this STOCK?");
            MessageBox.Show("Deleted Successfully");
        }

        private void frmPharmacyD_Load(object sender, EventArgs e)
        {
            OleDbDataReader oDataReader = cConnection.fPharmacyRetrieveOnlyColumn();
            while (oDataReader.Read())
            {

                this.comboBox1.Items.Add(oDataReader.GetString(0));

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
