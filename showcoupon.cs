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
    public partial class showcoupon : Form
    {
        public showcoupon()
        {
            InitializeComponent();
        }

        private MySqlConnection databaseConnection() //เชื่อมต่อฐานข้อมูล
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        public string copyphone_number;
        private void coupon_Load(object sender, EventArgs e)
        {
            lbphone_number.Text = copyphone_number; //รับค่าเบอร์โทรมาจากcollect_point
            btredeem_coupon.Visible = false; //ซ่อนแลกคูปอง

            get_lastpoint();
        }

        
        private void get_lastpoint()
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM history WHERE phone_number = '{lbphone_number.Text}' ";
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows) //สมาชิกเดิม
            {
                MySqlConnection conn2 = databaseConnection();
                conn2.Open();
                String sql = $"SELECT * FROM history WHERE phone_number = '{lbphone_number.Text}'";
                MySqlCommand command = new MySqlCommand(sql, conn2);
                List<int> p = new List<int>();
                List<int> cp = new List<int>();
                MySqlDataReader row2 = command.ExecuteReader(); //อ่านข้อมูลจำนวนstockของเมนู
                while (row2.Read())
                {
                    p.Add(row2.GetInt32("point"));
                    cp.Add(row2.GetInt32("coupon"));
                }
                conn2.Close();

                int sumpoint = p[p.Count - 1]; //จำนวนแต้ม
                int sumcoupon = cp[cp.Count - 1]; //จำนวนคูปอง
                lbpoint.Text = sumpoint.ToString();
                lbpoint.Visible = true; //แสดงค่าแต้ม
                lbcoupon.Text = sumcoupon.ToString();

                if (sumcoupon >= 1)
                {
                    btredeem_coupon.Visible = true;
                }
                else
                {
                    btselect_menu.Visible = true;
                }
            }
            else //สมาชิกใหม่
            {
                lbpoint.Text = 0.ToString();
                lbpoint.Visible = true; //แสดงค่าแต้ม
            }
            conn.Close();
        }

        //เลือกเมนู
        private void btselect_menu_Click(object sender, EventArgs e)
        {
            select_menu sl = new select_menu();
            sl.copyphone_number = lbphone_number.Text; //ส่งค่าlbเบอร์โทรไปหน้าselectmenu_redeem
            sl.ShowDialog();
            this.Close();
        }

        //แลกคูปอง
        private void btredom_coupon_Click(object sender, EventArgs e)
        {
            select_menuredeem smr = new select_menuredeem(); //ส่งค่าtbเบอร์โทร ไปหน้าselect_menuredeem
            smr.copyphone_number = lbphone_number.Text; //ส่งค่าlbเบอร์โทรไปหน้าselectmenu_redeem
            smr.ShowDialog();
            this.Close();
        }

        private void btback_Click(object sender, EventArgs e)
        {
            start st = new start();
            st.Show();
            this.Close();
        }
    }
}
