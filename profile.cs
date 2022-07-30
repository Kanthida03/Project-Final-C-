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
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
        }

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1; port = 3306; username = root; password =; database = project;charset = utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        public string copyusername;
        private void editprofile_Load(object sender, EventArgs e)
        {
            lbusername.Text = copyusername;
            lbwarning_name.Visible = true; //ชื่อ-สกุล
        
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM admin WHERE username=\"{lbusername.Text}\"";
            MySqlDataReader row = cmd.ExecuteReader();
            if (row.HasRows)
            {
                while (row.Read())
                {
                    tbname.Text = row.GetString(1);
                    tbpassword.Text = row.GetString(3);
                }
            }
        }

        private void tbname_KeyPress(object sender, KeyPressEventArgs e) //เช็คอักษรไทย
        {
            if ((int)e.KeyChar >= 161 || (int)e.KeyChar == 8 || (int)e.KeyChar == 13 || (int)e.KeyChar == 46 || (int)e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true; //ถ้าเป็นตัวเลขหรืออังกฤษ
                MessageBox.Show("กรุณาป้อนเฉพาะตัวอักษรภาษาไทย", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            int countCharacter = this.tbpassword.TextLength; //นับตัวอักษรหัสผ่าน
            if (countCharacter < 7 || countCharacter >= 16)
            {
                lbwarning_password3.Visible = true;
            }
            else
            {
                lbwarning_password3.Visible = false;
            }
        }

        //แสดงรหัสผ่าน
        private void cbshow_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshow_pass.Checked) //เมื่อกดแสดงรหัสผ่าน
            {
                tbpassword.UseSystemPasswordChar = true;
            }
            else
            {
                tbpassword.UseSystemPasswordChar = false;
            }
        }

        //แก้ไขข้อมูล
        private void btedit_Click(object sender, EventArgs e)
        {
            if (tbname.Text == "" || tbpassword.Text == "")
            {
                MessageBox.Show("กรุณาป้อนข้อมูลให้ครบถ้วน", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MySqlConnection conn2 = databaseConnection();
                string sql = "UPDATE admin SET fname ='" + tbname.Text + "', password ='" + tbpassword.Text + "'  WHERE username = '" + lbusername.Text + "'";
                MySqlCommand cmd2 = new MySqlCommand(sql, conn2);
                conn2.Open();
                cmd2.ExecuteNonQuery();
                conn2.Close();

                MessageBox.Show("แก้ไขข้อมูลส่วนตัวเรียบร้อย", "แจ้งเตือน");
            }
        }

        private void btback_Click(object sender, EventArgs e)
        {
            homepage hp = new homepage();
            hp.copyusername = lbusername.Text;
            hp.ShowDialog();
            this.Hide();
        }
    }
}
