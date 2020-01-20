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
    public partial class Department : Form
    {
        public Department()
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
            cmd.CommandText = "Select * from department";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dataGridView1.DataSource = dtRecords;
        }


        private void labelAssetid_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxassettype_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelassettype_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxassetname_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelassetname_Click(object sender, EventArgs e)
        {

        }

        private void textBoxassetid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addasset_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
            string insertquery = "Insert into ims.department(dept_id,dept_name,sub_dept,dept_descrip) VALUES ('" + deptid.Text + "','" + deptname.Text + "','" + subdepart.Text + "','" + deptdes.Text + "')";

            con.Open();
            MySqlCommand comm1 = new MySqlCommand(insertquery, con);
            if (comm1.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Department Successfully Added");
                display_data();
            }
            else
            {
                MessageBox.Show("Department Not Inserted");
            }

            con.Close();
            deptid.Text = "";
            deptname.Text = "";
            subdepart.Text = "";
            deptdes.Text = "";
            
        }

        private void updateasset_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
            string insertquery = "delete from ims.department where dept_id ='" + deptid.Text + "'";

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
            deptid.Text = "";
            deptname.Text = "";
            subdepart.Text = "";
            deptdes.Text = "";
            
        }

        private void deleteasset_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database = ims");
            string insertquery = "update ims.department set dept_id='" + deptid.Text + "', dept_name='" + deptname.Text + "', sub_dept ='" + subdepart.Text + "' where dept_id ='" + deptid.Text + "'";
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
            con.Close();
            deptid.Text = "";
            deptname.Text = "";
            subdepart.Text = "";
            deptdes.Text = "";
        }

        private void Department_Load(object sender, EventArgs e)
        {

        }

       
    }
}
