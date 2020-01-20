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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string dbconn1 = users.dbconn();
            MySqlConnection con = new MySqlConnection(dbconn1);
            con.Open();
            Asset_id a = new Asset_id();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dbconn1 = users.dbconn();
            MySqlConnection con = new MySqlConnection(dbconn1);
            con.Open();
            Department d = new Department();
            d.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string dbconn1 = users.dbconn();
            MySqlConnection con = new MySqlConnection(dbconn1);
            con.Open();
            purchaseorder p = new purchaseorder();
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string dbconn1 = users.dbconn();
            MySqlConnection con = new MySqlConnection(dbconn1);
            con.Open();
            Payment py = new Payment();
            py.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string dbconn1 = users.dbconn();
            MySqlConnection con = new MySqlConnection(dbconn1);
            con.Open();
            @return ret = new @return();
            ret.Show();
            }

        private void button8_Click(object sender, EventArgs e)
        {
            string dbconn1 = users.dbconn();
            MySqlConnection con = new MySqlConnection(dbconn1);
            con.Open();
            Report rep = new Report();
            rep.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dbconn1 = users.dbconn();
            MySqlConnection con = new MySqlConnection(dbconn1);
            con.Open();
            users ua = new users();
            ua.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dbconn1 = users.dbconn();
            MySqlConnection con = new MySqlConnection(dbconn1);
            con.Open();
            vendors ven = new vendors();
            ven.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
