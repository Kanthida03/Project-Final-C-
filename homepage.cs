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

namespace Project
{
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private MySqlConnection databaseConnection() //เชื่อมต่อฐานข้อมูล
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }


        public string copyusername;
        private void homepage_Load(object sender, EventArgs e)
        {
            lbusername.Text = copyusername;
            lbusername.Visible = false;

            //แสดงชื่อจริง นามสกุล
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM admin WHERE username = '{lbusername.Text}'"; //เลือกข้อมูลจากชื่อเมนู
            MySqlDataReader row = cmd.ExecuteReader();
            if (row.HasRows)
            {
                while (row.Read())
                {
                    lbname.Text = row.GetString(1);  
                }
            }
            conn.Close();

        }

        private void btprofile_Click(object sender, EventArgs e)
        {
            profile edit = new profile();
            edit.copyusername = lbusername.Text;
            edit.ShowDialog();
            this.Hide();
        }

        private void btmanage_Click(object sender, EventArgs e)
        {
            manage mn = new manage();
            mn.copyusername = lbusername.Text;
            mn.ShowDialog();
            this.Hide();
        }

        private void bthistory_Click(object sender, EventArgs e)
        {
            history his = new history();
            his.copyusername = lbusername.Text;
            his.ShowDialog();
            this.Hide();
        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
