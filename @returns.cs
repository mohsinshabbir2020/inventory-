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
    public partial class @return : Form
    {
        public @return()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
            con.Open();
            string insertquery = "select id,asset_name,asset_type,asset_description from ims.asset where asset_serial ='" + asetserial.Text + "'";
            MySqlCommand comm1 = new MySqlCommand(insertquery, con);
            MySqlDataReader da = comm1.ExecuteReader();
            while (da.Read())
            {
                return_text_id.Text = da.GetValue(0).ToString();
                return_text_name.Text = da.GetValue(1).ToString();
                return_text_type.Text = da.GetValue(2).ToString();
                return_text_description.Text = da.GetValue(3).ToString();
            }
            con.Close();
        }

        private void assetstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
