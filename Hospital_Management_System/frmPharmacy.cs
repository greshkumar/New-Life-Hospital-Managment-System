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
    public partial class frmPharmacy : Form
    {
        cPharmacy oPharmacy = new cPharmacy();

        public frmPharmacy()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oPharmacy.Name = this.tbName.Text;
            oPharmacy.Type = this.tbType.Text;
            oPharmacy.Quantity = this.tbQuantity.Text;
            oPharmacy.Stock = this.tbStock.Text;
            oPharmacy.CurrentDate = this.dtCurrent.Text;
            oPharmacy.ExpiryDate = this.dtExpiry.Text;
            oPharmacy.Price = this.tbPrice.Text;

            cConnection.fPharmacyDataSave(oPharmacy);
            MessageBox.Show("Data Successfully Entered");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tbType.Clear();
            this.tbName.Clear();
            this.tbQuantity.Clear();
            this.tbStock.Clear();
            this.dtCurrent.ResetText();
            this.dtExpiry.ResetText();
            this.tbPrice.Clear();
        }

        private void tbType_Leave(object sender, EventArgs e)
        {
            cMessenger.fCheckTextBoxIsEmpty(tbName);
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            cMessenger.fCheckTextBoxIsEmpty(tbName);
        }

        private void tbQuantity_Leave(object sender, EventArgs e)
        {
            cMessenger.fCheckTextBoxIsEmpty(tbName);
        }

        private void tbStock_Leave(object sender, EventArgs e)
        {
            cMessenger.fCheckTextBoxIsEmpty(tbName);
        }

        private void tbPrice_Leave(object sender, EventArgs e)
        {
            cMessenger.fCheckTextBoxIsEmpty(tbName);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
