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
    public partial class collectpoint : Form
    {
        public collectpoint()
        {
            InitializeComponent();
        }

        private MySqlConnection databaseConnection() //เชื่อมต่อฐานข้อมูล
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }


        Control activecontrol;
        private void bt1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            activecontrol.Focus();
            SendKeys.Send(btn.Text); //ส่งค่าtext
        }

        private void tbphone_number_Enter(object sender, EventArgs e)
        {
            activecontrol = (Control)sender; //textตัวเลข ที่ถูกส่งมา
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            tbphone_number.Text = ""; //เบอร์โทรค่าว่าง
        }

        private void btskip_Click(object sender, EventArgs e) //ข้ามการสะสมแต้ม
        {
            select_menu sm = new select_menu();
            sm.Show();
            this.Hide();
        }

        private void btok_Click(object sender, EventArgs e) //สมาชิก
        {
            int countCharacter = this.tbphone_number.TextLength; //นับตัวอักษรเบอร์โทรที่ป้อน
            if (countCharacter != 10)
            {
                MessageBox.Show("กรุณาป้อนข้อมูลให้ครบ 10 ตัว", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (countCharacter == 10) //ถ้าเบอร์โทรครบ 10 จำนวน
            {
                showcoupon scp = new showcoupon();
                scp.copyphone_number = tbphone_number.Text;
                scp.ShowDialog();
                this.Close();
            }
        }
    }
}

