using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace inventory_system
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            display_data();
        }
        private void display_data()
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from invoices";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            GridViewpo.DataSource = dtRecords;
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void addinvoice_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
            string insertquery = "Insert into ims.invoices(INV_NUM,INV_DATE,INV_DESCRIP,INV_SER) VALUES ('" + invnumtxt.Text + "','" + invdatetxt.Text + "','" + invdestxt.Text + "','" + invsertxt.Text + "')";

            con.Open();
            MySqlCommand comm1 = new MySqlCommand(insertquery, con);
            if (comm1.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Payment Successfully Added");
                display_data();
            }
            else
            {
                MessageBox.Show("Payment Not Inserted");
            }

            con.Close();
           invnumtxt.Text = "";
            invdatetxt.Text = "";
            invdestxt.Text = "";
            invsertxt.Text = "";
        }

        private void deleteinvoice_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
            string insertquery = "delete from ims.invoices where INV_NUM ='" + invnumtxt.Text + "'";

            con.Open();
            MySqlCommand comm2 = new MySqlCommand(insertquery, con);
            if (comm2.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Department Successfully Deleted");
                display_data();
            }
            else
            {
                MessageBox.Show("Department Not Deleted");
            }

            con.Close();
            invnumtxt.Text = "";
            invdatetxt.Text = "";
            invdestxt.Text = "";
            invsertxt.Text = "";
        }

        private void updateinvoice_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
            string insertquery = "update ims.invoices set INV_DESCRIP='" + invdestxt.Text + "', INV_SER='" + invsertxt.Text + "' where 	INV_NUM ='" + invnumtxt.Text + "'";
            
             con.Open();
            MySqlCommand comm1 = new MySqlCommand(insertquery, con);
            if (comm1.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("User Successfully Updated");
                display_data();
            }
            else
            {
                MessageBox.Show("User Not Updated");
            }
            con.Close();
            invnumtxt.Text = "";
            invdatetxt.Text = "";
            invdestxt.Text = "";
            invsertxt.Text = "";
        }

        private void searchinvoice_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from invoices where INV_NUM ='" + invnumtxt.Text + "'";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            GridViewpo.DataSource = dtRecords;
        }
    }
}
