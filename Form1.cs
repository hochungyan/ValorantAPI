using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySqlConnector;

namespace valorant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //


            //
            string connetionString;
            MySqlConnection cnn;



            connetionString = @"Data Source=localhost;Initial Catalog=mydb;User ID=root;Password=root";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();
            //MessageBox.Show("Connection Open  !");

            string query = "select p.playername,p.age,p.avg_hs_player,p.avg_kd_player, t.teamname,c.countryname from player p join team t on p.team_idteam =t.idteam join country c on t.country_idcountry=c.idcountry where p.playername ='" + textBox1.Text+"'";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, cnn))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            //string query2 = "SELECT * FROM country";
            //using (MySqlDataAdapter adapter = new MySqlDataAdapter(query2, cnn))
            //{
            //    DataSet ds = new DataSet();
            //    adapter.Fill(ds);
            //    dataGridView2.DataSource = ds.Tables[0];
            //}






            //   cnn.Close();




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
            //string[] img = { "val.PNG" };
            //var image = imageList1.Images;
            
            
            //

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }



//}
//    }
//}
