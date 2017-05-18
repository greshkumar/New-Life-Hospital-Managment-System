using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Hospital_Managerment_System
{
    class cMessenger
    {
        
        public static void fCheckTextBoxIsEmpty(TextBox oTextBox)
        {
            if (oTextBox.Text == "")
            {
                oTextBox.BackColor = Color.Green;
                oTextBox.Focus();
                MessageBox.Show("Before Proceeding, Please Enter Data");
                oTextBox.BackColor = Color.Red;

            }
            else
            {
                oTextBox.BackColor = Color.White;
            }
        
        }

        public static void fIsEmpty(ComboBox oTextBox)
        {
            if (oTextBox.Text == "")
            {
                MessageBox.Show("Null values are not allowed");
                oTextBox.Focus();
                oTextBox.BackColor = Color.AntiqueWhite;
            }

            else
            {
                oTextBox.BackColor = Color.White;
            }
        }
    }
}
