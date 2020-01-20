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
    public partial class purchaseorder : Form
    {
        public purchaseorder()
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
            cmd.CommandText = "Select * from po";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dataGridView1.DataSource = dtRecords;
        }

        private void addpo_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
            string insertquery = "Insert into ims.po(PO_num,PO_DATE,PO_DES,PO_APPROVED) VALUES ('" + ponum.Text + "','" + podate.Text + "','" + podes.Text + "','" + poapprove.Text + "')";

            con.Open();
            MySqlCommand comm1 = new MySqlCommand(insertquery, con);
            if (comm1.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Vendor Successfully Added");
                display_data();
            }
            else
            {
                MessageBox.Show("Vendor Not Inserted");
            }

            con.Close();
            ponum.Text = "";
            podate.Text = "";
            podes.Text = "";
            poapprove.Text = "";
            
        }

        private void deletepo_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
            string insertquery = "delete from ims.po where PO_num ='" + ponum.Text + "'";

            con.Open();
            MySqlCommand comm2 = new MySqlCommand(insertquery, con);
            if (comm2.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("PO Successfully Deleted");
                display_data();
            }
            else
            {
                MessageBox.Show("PO Not Deleted");
            }

            con.Close();
            ponum.Text = "";
            podate.Text = "";
            podes.Text = "";
            poapprove.Text = "";
        }

        private void purchaseorder_Load(object sender, EventArgs e)
        {

        }

        private void updatepo_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
            string insertquery = "update ims.po set PO_DES='" + podes.Text + "', PO_APPROVED='" + poapprove.Text + "' where 	PO_num ='" + ponum.Text + "'";

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
            ponum.Text = "";
            podate.Text = "";
            podes.Text = "";
            poapprove.Text = "";
        }

        private void searchpo_Click(object sender, EventArgs e)
        {
             MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from po where PO_num ='" + ponum.Text + "'";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dataGridView1.DataSource = dtRecords;
        
        }
    }
}
