using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CoffeeShop
{
    public partial class America_Hot_Product : Form
    {
        public America_Hot_Product()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int ID = int.Parse(textBox1.Text);
            //string NAME = string.Format(textBox2.Text);
            

            string sql = " SELECT * FROM sales";
            sql = " INSERT INTO sales (ProductName,Price) VALUES('America-Hot','20')";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=123456789;database=coffee_project");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
