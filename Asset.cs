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
    public partial class Asset_id : Form
    {
        public Asset_id()
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
            cmd.CommandText = "Select * from asset";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dataGridView1.DataSource = dtRecords;
        }

        //method for db connection
        public static string dbconn()
        {

            string dbconect = "datasource=localhost; username=root; passowrd=; database=ims";
            return dbconect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // this.Hide();
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
            string insertquery = "Insert into ims.asset(id,date,asset_Name,asset_type,asset_serial,asset_description) VALUES('" + asetid.Text + "','"+dateTimePickerasset.Text+"','" + asetname.Text + "','" + asettype.Text + "','" + asetserial.Text + "', '"+ descript.Text + "')";
           
            con.Open();
            MySqlCommand comm1 = new MySqlCommand(insertquery, con);
                if (comm1.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Asset Successfully Added");
                display_data();
            }
            else
            {
                MessageBox.Show("Asset Not Inserted");
            }

            con.Close();
            asetid.Text = "";
            asetname.Text = "";
            asettype.Text = "";
            asetserial.Text ="";
            descript.Text = "";
        }

        private void labelAssetid_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void labelassettype_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void dateTimePickerasset_ValueChanged(object sender, EventArgs e)
        {

        }

      

        private void textBoxdescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
            string insertquery = "update ims.asset set asset_name='"+asetname.Text+"', asset_type='"+asettype.Text+"', asset_description ='"+descript.Text+"' where asset_serial ='" + asetserial.Text + "'";

            con.Open();
            MySqlCommand comm1 = new MySqlCommand(insertquery, con);
            if (comm1.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Asset Successfully Updated");
                display_data();
            }
            else
            {
                MessageBox.Show("Asset Not Updated");
            }
            asetid.Text = "";
            asetname.Text = "";
            asettype.Text = "";
            asetserial.Text ="";
            descript.Text = "";
        
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
            string insertquery = "delete from ims.asset where asset_serial ='" + asetserial.Text + "'";

            con.Open();
            MySqlCommand comm1 = new MySqlCommand(insertquery, con);
               if (comm1.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Asset Successfully Deleted");
                display_data();
            }
            else
            {
                MessageBox.Show("Asset Not Deleted");
            } 


            asetid.Text = "";
            asetname.Text = "";
            asettype.Text = "";
            asetserial.Text ="";
            descript.Text = "";
        


            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from asset where asset_serial ='" + asetserial.Text + "'";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dataGridView1.DataSource = dtRecords;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Asset_id_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void asettype_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
