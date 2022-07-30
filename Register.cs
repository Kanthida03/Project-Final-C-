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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1; port = 3306; username = root; password =; database = project;charset = utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            lbwarning_password2.Visible = false; //รหัสไม่ตรง
        }

        private void tbfname_KeyPress(object sender, KeyPressEventArgs e) //เช็คอักษรไทย
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

        //ยืนยันรหัสผ่าน
        private void tbcfpassword_TextChanged(object sender, EventArgs e) 
        {
            if (tbcfpassword.Text != tbpassword.Text) //ถ้ารหัสผ่านไม่ตรงกัน
            {
                lbwarning_password2.Visible = true;
            }
            else
            {
                lbwarning_password2.Visible = false;
            }
        }

        //เมื่อคลิกปุ่มสมัคร
        private void btregister_Click(object sender, EventArgs e)
        {
            if (tbname.Text == "" || tbusername.Text == "" || tbpassword.Text == "" || tbcfpassword.Text == "")
            {
                MessageBox.Show("กรุณาป้อนข้อมูลให้ครบถ้วน", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (lbwarning_password2.Visible == true)
            {
                MessageBox.Show("กรุณาป้อนข้อมูลให้ถูกต้อง", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MySqlConnection conn = databaseConnection();
                conn.Open();

                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM admin WHERE username = '{tbusername.Text}'";
                
                MySqlDataReader row = cmd.ExecuteReader();
                if (row.HasRows) //ถ้ามีค่าจากcolumeที่เลือก > username ซ้ำ
                {
                    conn.Close();
                    MessageBox.Show("ชื่อผู้ใช้งานซ้ำ กรุณาเปลี่ยนใหม่", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                }
                else //ถ้าusername ไม่ซ้ำ
                {
                    MySqlConnection conn3 = databaseConnection();
                    string sql = "INSERT INTO admin (fname, lname, username, password) VALUES('" + tbname.Text + "', '" + tbusername.Text + "', '" + tbcfpassword.Text + "')";
                    MySqlCommand cmd3 = new MySqlCommand(sql, conn3);
                    conn3.Open();
                    int rows = cmd3.ExecuteNonQuery();
                    conn3.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "แจ้งเตือน");
                        Admin admin = new Admin();
                        admin.Show();
                        this.Hide();
                    }
                }
            }
        } 

        private void btback_Click(object sender, EventArgs e)
        {
            Admin am = new Admin();
            am.Show();
            this.Hide();
        }
    }
}
