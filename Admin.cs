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
    public partial class Admin : Form
    {
        private MySqlConnection databaseConnection() //เชื่อมต่อฐานข้อมูล
        {
            string connectionString = "datasource=127.0.0.1; port = 3306; username = root; password =; database = project;charset = utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        public Admin()
        {
            InitializeComponent();
        }

        private void cbshow_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshow_pass.Checked) //แสดงรหัสผ่าน
            {
                tbpassword.UseSystemPasswordChar = true; 
            }
            else
            {
                tbpassword.UseSystemPasswordChar = false;
            }
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            if(tbusername.Text == "" || tbpassword.Text == "")
            {
                MessageBox.Show("กรุณาป้อนข้อมูลให้ครบถ้วน", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MySqlConnection conn = databaseConnection();
                conn.Open();

                MySqlCommand cmd;
                cmd = conn.CreateCommand();

                cmd.CommandText = $"SELECT * FROM admin WHERE username = '{tbusername.Text}' AND password = '{tbpassword.Text}'";

                MySqlDataReader row = cmd.ExecuteReader();
                if (row.HasRows) //ถ้ามีusername และpassword 
                {
                    homepage hp = new homepage();
                    hp.copyusername = tbusername.Text;
                    hp.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();
            }
        }

        private void btregister_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            this.Hide();
        }

        private void btreset_password_Click(object sender, EventArgs e)
        {
            reset_password repass = new reset_password();
            repass.Show();
            this.Hide();
        }
    }
}
