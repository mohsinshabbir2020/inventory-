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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
           string insertquery = ("SELECT COUNT(*) FROM login WHERE user='" + textBoxadminname.Text + "' AND password='" + textBoxadminpass.Text + "'");
          // string insertquery = ("SELECT * FROM login WHERE user='" + textBoxadminname.Text + "' AND password='" + textBoxadminpass.Text + "'");
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
          MySqlDataAdapter comm1 = new MySqlDataAdapter(insertquery, con);
            DataTable dt = new DataTable(); //this is creating a virtual table  
           comm1.Fill(dt);
           con.Open();
           
           
            if (dt.Rows[0][0].ToString() == "1")
           {
               MessageBox.Show("Welcome  " + textBoxadminname.Text);
                this.Hide();
               
                main m = new main();
                m.Show();
            }

          //  else if (dt.Rows[1][1].ToString() == "1")
          //  {
          //      MessageBox.Show("This is Restricted User"); 


         //   }
           else
               MessageBox.Show("Invalid username or password"); 
            
            
            /* labelname.Text = textBoxadminname.Text;
            labeladminpassqord.Text = textBoxadminpass.Text;
            string dbconn1 = users.dbconn();
            MySqlConnection con = new MySqlConnection(dbconn1);
           
            con.Open();
           
           if (con.State == ConnectionState.Open)
            {
                MessageBox.Show("Welcome to IMS");
            }
            else
            {
                MessageBox.Show("Not Connected");
            }*/
         //   this.Hide();
         
          //  main m = new main();
           // m.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBoxadminname.Clear();
            textBoxadminpass.Clear();
        }

        private void textBoxadminpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void labeladminpassqord_Click(object sender, EventArgs e)
        {

        }

        private void textBoxadminname_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelname_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
