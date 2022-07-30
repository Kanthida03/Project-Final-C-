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
    public partial class reset_password : Form
    {
        public reset_password()
        {
            InitializeComponent();
        }

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1; port = 3306; username = root; password =; database = project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        private void reset_password_Load(object sender, EventArgs e)
        {
            
            lbwarning_cfpass.Visible = false; //รหัสผ่านไม่ตรงกัน
            label2.Visible = false; //รหัสผ่านใหม่
            tbnewpass.Visible = false; 
            lbwarning_newpass.Visible = false; //มีความยาว8-16
            label3.Visible = false; //ยืนยันรหัสผ่านใหม่
            tbcfnewpass.Visible = false;
            cbshow_pass.Visible = false; //โชว์รหัสผ่าน
            btcf_password.Visible = false; //ยืนยันการเปลี่ยนรหัสผ่าน
        }

        private void btserch_admin_Click(object sender, EventArgs e)
        {
            if (tbusername.Text != "")
            {
                MySqlConnection conn = databaseConnection();
                conn.Open();

                MySqlCommand cmd;
                cmd = conn.CreateCommand();

                cmd.CommandText = $"SELECT * FROM admin WHERE username=\"{tbusername.Text}\"";

                MySqlDataReader row = cmd.ExecuteReader();
                if (row.HasRows) //ถ้ามีusername
                {
                    MessageBox.Show("มีข้อมูลพนักงาน", "แจ้งเตือน");
                    while (row.Read())
                    {
                        lbname.Text = row.GetString(1);
                    }

                    label2.Visible = true; //รหัสผ่านใหม่
                    tbnewpass.Visible = true;
                    lbwarning_newpass.Visible = true;
                    label3.Visible = true; //ยืนยันรหัสผ่าน
                    tbcfnewpass.Visible = true;
                    cbshow_pass.Visible = true; //แสดงรหัสผ่าน
                    btcf_password.Visible = true; //ยืนยันการเปลี่ยนรหัสผ่าน
                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูลพนักงาน", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("กรุณาป้อนข้อมูลผู้ใช้งาน", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbnewpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            int countCharacter = this.tbnewpass.TextLength; //นับตัวอักษรหัสผ่าน
            if (countCharacter < 7 || countCharacter >= 16)
            {
                lbwarning_newpass.Visible = true;
            }
            else
            {
                lbwarning_newpass.Visible = false;
            }
        }

        //รหัสผ่านไม่ตรงกัน
        private void tbcfnewpass_TextChanged(object sender, EventArgs e)
        {
            if (tbcfnewpass.Text != tbnewpass.Text) 
            {
                lbwarning_cfpass.Visible = true;
            }
            else
            {
                lbwarning_cfpass.Visible = false;
            }
        }

        //แสดงรหัสผ่าน
        private void cbshow_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshow_pass.Checked) 
            {
                tbnewpass.UseSystemPasswordChar = true;
            }
            else
            {
                tbnewpass.UseSystemPasswordChar = false;
            }
        }

        private void btcf_password_Click(object sender, EventArgs e)
        {
            if (tbnewpass.Text == tbcfnewpass.Text)
            {
                MySqlConnection conn = databaseConnection();
                string sql = "UPDATE admin SET password ='" + tbcfnewpass.Text + "' WHERE username = '" + tbusername.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("เปลี่ยนรหัสผ่านเรียบร้อย", "แจ้งเตือน");
                Admin am = new Admin();
                am.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("รหัสผ่านไม่ตรงกัน", "แจ้งเตือน");
            }
        }

        private void btback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin am = new Admin();
            am.Show();
        }
    }
}
