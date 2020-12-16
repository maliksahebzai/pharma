using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PharmacyApp
{
    public partial class custfrm : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        public custfrm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            savedata("insert into tbl_Customer(Cus_Name,Cus_Add,Cus_Email,Cus_Phone) values('" + txtname.Text + "','" + txtadd.Text + "','" + txtemail.Text + "','" + txtphone.Text + "')");

        }
        void savedata(string query)
        {
            da.InsertCommand = new SqlCommand(query,connectivity.conn);
            connectivity.openDb();
            da.InsertCommand.ExecuteNonQuery();
            connectivity.closeDb();

        }
    }
}
