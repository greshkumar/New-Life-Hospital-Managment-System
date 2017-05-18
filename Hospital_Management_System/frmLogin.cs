using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Hospital_Managerment_System
{
    public partial class frmLogin : Form
    {
        String Username = "admin";
        String Password = "admin";

        public frmLogin()
        {
            InitializeComponent();
            tbUsername.MaxLength = 5;
            tbPassword.PasswordChar ='*';
            tbPassword.MaxLength = 5;

            timer1.Start();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == Username)
            {
                if (tbPassword.Text == Password)
                {
                    frmMain oMain = new frmMain();
                    this.Hide();
                    oMain.Show();
                }
            }
            else if (tbUsername.Text != Username)
            {
                if (tbPassword.Text != Password) 
                {
                    MessageBox.Show("Wrong Username and Password, Please Try again");
                    
                }
                
            }
            
        }

        private void lbTime_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime DateTime = DateTime.Now;
            this.lbl_Time.Text = DateTime.ToString();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
