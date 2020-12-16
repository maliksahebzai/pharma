using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbauth.Text == "windows")
                    connectivity.setconn();
                if (cmbauth.Text == "SQL server")
                    connectivity.setconn(txtname.Text, txtpassword.Text);
                connectivity.openDb();
                connectivity.closeDb();
                Program.uas = true;
                this.Close();
                
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           // MessageBox.Show("conected");
        }

        private void cmbauth_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (cmbauth.Text == "windows")
                txtname.Enabled=false;
            txtpassword.Enabled=false;
            if (cmbauth.Text == "SQL server")
                txtname.Enabled = true;
            txtpassword.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // btnlogin.PerformClick();

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
        //    btnlogin.PerformClick();
        }
    }
}
