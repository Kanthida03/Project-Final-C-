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
    public partial class pay : Form
    {
        public pay()
        {
            InitializeComponent();
        }

        private MySqlConnection databaseConnection() //เชื่อมต่อฐานข้อมูล
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        public string copytbmenu, copytbprice, copysweetness, copyphone_number; //รับค่าจากหน้าselect_menu
        private void pay_Load(object sender, EventArgs e)
        {
            lbmenu.Text = copytbmenu;
            lbprice.Text = copytbprice;
            lbsweetness.Text = copysweetness;
            lbphone_number.Text = copyphone_number;
            btconfermpay.Visible = false; //ยืนยันการชำระเงิน

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Visible = false; //วันที่
        }

        private void btsetting(object sender, EventArgs e) //btเปลี่ยนสีเมื่อคลิกจำนวนเงิน
        {
            foreach (Control c in btmoney_setting.Controls)
            {
                c.BackColor = Color.White; //สีเดิม
            }
            Control click = (Control)sender;
            click.BackColor = Color.Gold; //สีเมื่อคลิก
        }

       
        int sum = 0; //รวมเงินที่จ่าย
        private void bt1bath_Click(object sender, EventArgs e)
        {
            btsetting(bt1bath, null); //เปลี่ยนสีbt
            sum = sum + 1; //sum รวมเงินที่จ่าย
            lbpay_money.Text = sum.ToString(); //เก็บsumค่าstring ในtbรวมเงินที่จ่าย 
            change_value(); //เงินทอน
        }

        private void bt5bath_Click(object sender, EventArgs e)
        {
            btsetting(bt5bath, null); //เปลี่ยนสีbt
            sum = sum + 5;
            lbpay_money.Text = sum.ToString();
            change_value();
        }

        private void bt10bath_Click(object sender, EventArgs e)
        {
            btsetting(bt10bath, null); //เปลี่ยนสีbt
            sum = sum + 10;
            lbpay_money.Text = sum.ToString();
            change_value();
        }

        private void bt20bath_Click(object sender, EventArgs e)
        {
            btsetting(bt20bath, null); //เปลี่ยนสีbt
            sum = sum + 20;
            lbpay_money.Text = sum.ToString();
            change_value();
        }

        private void bt50bath_Click(object sender, EventArgs e)
        {
            btsetting(bt50bath, null); //เปลี่ยนสีbt
            sum = sum + 50;
            lbpay_money.Text = sum.ToString();
            change_value();
        }

        private void bt100bath_Click(object sender, EventArgs e)
        {
            btsetting(bt100bath, null); //เปลี่ยนสีbt
            sum = sum + 100;
            lbpay_money.Text = sum.ToString();
            change_value();
        }

        //แสดงค่าเงินทอน
        int price; //ราคาเครื่องดื่ม
        int sum_money; //เงินที่จ่าย
        int change = 0; //เงินทอน
        private void change_value()
        {
            price = int.Parse(lbprice.Text); //ค่าเครื่องดื่ม > int เพื่อคำนวณ
            sum_money = int.Parse(lbpay_money.Text); //เงินที่จ่าย > int เพื่อคำนวณ
            change = sum_money - price; //เงินทอน
            if (sum_money >= price) //ถ้าเงินที่จ่าย > ค่าเครื่องดื่ม แสดงเงินทอน
            {
                lbchange.Text = change.ToString(); //เก็บเงินทอนstring ในtbเงินทอน
                lbchange.Visible = true; //แสดงจำนวนเงินทอน
                btconfermpay.Visible = true; //แสดงปุ่มยืนยันชำระเงิน
            }
            else
            {
                lbchange.Visible = false;
                btconfermpay.Visible = false;
            }
        }

        //ลบจำนวนstockของเมนู
        int amount_menu;
        private void delete_stock()
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();

            String sql = $"SELECT * FROM stock WHERE menu = '{lbmenu.Text}'"; //เลือกข้อมูลจากชื่อเมนู
            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader readdata = command.ExecuteReader(); //อ่านข้อมูลจำนวนstockของเมนู
            while (readdata.Read())
            {
                amount_menu = readdata.GetInt32("amount");
            }
            conn.Close();

            conn.Open();
            sql = "UPDATE stock SET amount = '" + (amount_menu - 1) + "' WHERE menu = '" + lbmenu.Text + "'";
            MySqlCommand command1 = new MySqlCommand(sql, conn);
            command1.ExecuteReader();
            conn.Close();

            MessageBox.Show("  ♡ ขอบคุณที่ใช้บริการ ♡");
            start st = new start();
            st.Show();
            this.Hide();
        }
      
        private void btconfermpay_Click(object sender, EventArgs e)
        {
            if (lbphone_number.Text != "") //สมาชิก
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
                    String sql = $"SELECT point FROM history WHERE phone_number = '{lbphone_number.Text}'";
                    MySqlCommand command = new MySqlCommand(sql, conn2);
                    List<int> p = new List<int>();
                    MySqlDataReader row2 = command.ExecuteReader(); //อ่านข้อมูลจำนวนstockของเมนู
                    while (row2.Read())
                    {
                        p.Add(row2.GetInt32("point")); 
                    }
                    int newpoint = p[p.Count - 1] + 1;
                    float ncp = newpoint / 10;
                    int newcoupon = Convert.ToInt32(ncp); //จำนวนคูปอง
                    conn2.Close();

                    conn2.Open();
                    //เพิ่มประวัติการซื้อ
                    String sql2 = "INSERT INTO history (menu,price,phone_number,point,coupon,status,amount_sale,date) VALUES('" + lbmenu.Text + "','" + lbprice.Text + "','" + lbphone_number.Text + "','" + (newpoint) + "','" + (newcoupon) + "', 'ชำระเงิน', '" + 1.ToString() + "', '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "')";
                    cmd = new MySqlCommand(sql2, conn2);
                    cmd.ExecuteReader();
                    conn2.Close();

                    //ลบจำนวนstockของเมนู
                    delete_stock();
                }
                else //สมาชิกใหม่
                {
                    //เพิ่มประวัติการซื้อ
                    MySqlConnection conn3 = databaseConnection();
                    string sql = "INSERT INTO history (menu,price,phone_number,point,coupon,status,amount_sale,date) VALUES('" + lbmenu.Text + "','" + lbprice.Text + "','" + lbphone_number.Text + "','" + 1.ToString() + "','" + 0.ToString() + "', 'ชำระเงิน','" + 1.ToString() + "', '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "')";
                    conn3.Open();
                    cmd = new MySqlCommand(sql, conn3);
                    cmd.ExecuteReader();
                    conn3.Close();

                    //ลบจำนวนstockของเมนู
                    delete_stock();
                }
            }
            else if (lbphone_number.Text == "") //ไม่ได้สมัครสมาชิก
            {
                MySqlConnection conn = databaseConnection();
                String sql = "INSERT INTO history (menu,price,status,amount_sale,date) VALUES('" + lbmenu.Text + "','" + lbprice.Text + "', 'ชำระเงิน', '" + 1.ToString() + "', '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                conn.Close();

                if (rows > 0)
                {
                    delete_stock();

                }
            }
        }

        private void btcancle_Click(object sender, EventArgs e)
        {
            select_menu sl = new select_menu();
            sl.Show();
            this.Close();
        }
    }
}
