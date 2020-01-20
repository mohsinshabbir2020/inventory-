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
    public partial class vendors : Form
    {
        public vendors()
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
            cmd.CommandText = "Select * from vendor";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dataGridView1.DataSource = dtRecords;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vendors_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
            string insertquery = "Insert into ims.vendor(V_CNIC,V_NAME,V_ADDRESS,V_CONT,V_NTN) VALUES ('" + textBoxvendorid.Text + "','" + textBoxvendorname.Text + "','" + textBoxadress.Text + "','" + textBoxcontactnumber.Text + "','" + textntnnum.Text +"')";

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
            textBoxvendorid.Text = "";
            textBoxvendorname.Text = "";
            textBoxadress.Text = "";
            textBoxcontactnumber.Text = "";
            textntnnum.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
            string insertquery = "delete from ims.vendor where V_CNIC ='" + textBoxvendorid.Text + "'";

            con.Open();
            MySqlCommand comm2 = new MySqlCommand(insertquery, con);
            if (comm2.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Vendor Successfully Deleted");
                display_data();
            }
            else
            {
                MessageBox.Show("Vendor Not Deleted");
            }

            con.Close();
            textBoxvendorid.Text = "";
            textBoxvendorname.Text = "";
            textBoxadress.Text = "";
            textBoxcontactnumber.Text = "";
            textntnnum.Text = "";
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
            string insertquery = "update ims.vendor set V_CNIC='" + textBoxvendorid.Text + "', V_ADDRESS='" + textBoxadress.Text + "', V_CONT ='" + textBoxcontactnumber.Text + "' where V_CNIC ='" + textBoxvendorid.Text + "'";
            //"Insert into ims.person(id,Name,address,mobile) VALUES('" + textBoxuserid.Text + "','" + textBoxvendorname.Text + "','" + textBoxadress.Text + "','" + textBoxcontactnumber.Text + "')";
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
            textBoxvendorid.Text = "";
            textBoxvendorname.Text = "";
            textBoxadress.Text = "";
            textBoxcontactnumber.Text = "";
            textntnnum.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from vendor where V_CNIC ='" + textBoxvendorid.Text + "'";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dataGridView1.DataSource = dtRecords;
        }
    }
}
