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
    public partial class users : Form
    {
        public users()
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
            cmd.CommandText = "Select * from person";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dataGridView1.DataSource = dtRecords;
        }

        private void user_Load(object sender, EventArgs e)
        {

        }

        private void textBoxvendorid_TextChanged(object sender, EventArgs e)
        {

        }
        public static string dbconn()
        {

            string dbconect = "datasource=localhost; username=root; passowrd=; database=ims";
            return dbconect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
            string insertquery = "Insert into ims.person(id,Name,address,mobile) VALUES('" + textBoxuserid.Text + "','" + textBoxvendorname.Text + "','" + textBoxadress.Text + "','" + textBoxcontactnumber.Text + "')";
            //  string insertquery = ("Insert into umt.info() VALUES(" +textBoxpname.Text + "," + textBoxaddress+")");
            con.Open();
            MySqlCommand comm = new MySqlCommand(insertquery, con);
            if (comm.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data Successfully Inserted");
                display_data();
            }
            else
            {
                MessageBox.Show("Data Not Inserted");
            }
            //labelname.Text = "";
            textBoxuserid.Text = "";
            textBoxvendorname.Text = "";
            textBoxcontactnumber.Text = "";
            textBoxadress.Text = "";
            con.Close();
        }

        private void remove_user(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
            string insertquery = "delete from ims.person where Id ='" + textBoxuserid.Text + "'";

            con.Open();
            MySqlCommand comm2 = new MySqlCommand(insertquery, con);
            if (comm2.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("User Successfully Deleted");
                display_data();
            }
            else
            {
                MessageBox.Show("User Not Deleted");
            }

            textBoxuserid.Text = "";
            textBoxvendorname.Text="";
            textBoxadress.Text= "";
            textBoxcontactnumber.Text = "";
          



            con.Close();
       
        }

        private void Update_user(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
            string insertquery = "update ims.person set id='" + textBoxuserid.Text + "', address='" + textBoxadress.Text + "', mobile ='" + textBoxcontactnumber.Text + "' where Name ='" + textBoxvendorname.Text + "'";
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
              textBoxuserid.Text = "";
              textBoxvendorname.Text = "";
               textBoxcontactnumber.Text = "";
               textBoxadress.Text = "";
              

            con.Close();
        }

        private void search_user(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from person where Name ='" + textBoxvendorname.Text + "'";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dataGridView1.DataSource = dtRecords;
        }
    }
}
