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
    public partial class select_menuredeem : Form
    {
        public select_menuredeem()
        {
            InitializeComponent();
        }

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        public string copyphone_number;
        //แสดงเมนูกาแฟเป็นอันแรก ในหน้าเลือกเมนู
        private void select_menuredeem_Load(object sender, EventArgs e)
        {
            lbphone_number.Text = copyphone_number; //รับค่าเบอร์โทรมาจากshowcoupon
            
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Visible = false;

            showStockcoffee(); //โชว์ตารางเมนูกาแฟ

            //ซ่อนคอลัมน์
            datamenu.Columns[0].Visible = false;
            datamenu.Columns[3].Visible = false;
            datamenu.Columns[4].Visible = false;

            //ปรับขนาดคอลัมน์
            datamenu.Columns[1].Width = 250; //เมนู
            datamenu.Columns[2].Width = 180; //ราคา

            // แก้ไขชื่อหัวตาราง
            datamenu.Columns[1].HeaderText = "    เมนู";
            datamenu.Columns[2].HeaderText = "     ราคา";
        }

        //โค้ดแสดงตารางเมนูกาแฟ
        private void showStockcoffee()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stock WHERE type = '{btcoffee.Text}'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            datamenu.DataSource = ds.Tables[0].DefaultView;
        }

        //คลิกปุ่มประเภทเครื่องดื่ม > เปลี่ยนสี
        private void btsetting(object sender, EventArgs e)
        {
            foreach (Control c in btpanel_type.Controls)
            {
                c.BackColor = Color.BurlyWood; //สีเดิม
            }
            Control click = (Control)sender;
            click.BackColor = Color.SaddleBrown; //สีเมื่อคลิก
        }

        //คลิกปุ่มกาแฟ > แสดงเมนู
        private void btcoffee_Click(object sender, EventArgs e)
        {
            btsetting(btcoffee, null); //เปลี่ยนสีbt

            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stock WHERE type = '{btcoffee.Text}'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            datamenu.DataSource = ds.Tables[0].DefaultView;
        }

        //คลิกปุ่มชา > แสดงเมนู
        private void bttea_Click(object sender, EventArgs e)
        {
            btsetting(bttea, null); //เปลี่ยนสีbt

            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stock WHERE type = '{bttea.Text}'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            datamenu.DataSource = ds.Tables[0].DefaultView;
        }

        //คลิกปุ่มนม โกโก้ และคาราเมล > แสดงเมนู
        private void btmilk_Click(object sender, EventArgs e)
        {
            btsetting(btmilk, null); //เปลี่ยนสีbt

            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stock WHERE type = '{btmilk.Text}'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            datamenu.DataSource = ds.Tables[0].DefaultView;
        }

        //คลิกปุ่มน้ำผลไม้ > แสดงเมนู
        private void btjuice_Click(object sender, EventArgs e)
        {
            btsetting(btjuice, null); //เปลี่ยนสีbt

            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stock WHERE type = '{btjuice.Text}'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            datamenu.DataSource = ds.Tables[0].DefaultView;
        }

        //คลิกเลือกเมนูในตาราง
        private void datamenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            datamenu.CurrentRow.Selected = true; //เลือกเมนู > นำค่าจากrowที่เลือกมาเก็บไว้ใน FormattedValue ค่า string
            data_stock = true; //ทำการเลือกเมนู > ข้อมูลในสต็อค
            lbmenu.Text = datamenu.Rows[e.RowIndex].Cells["menu"].FormattedValue.ToString();
            lbprice.Text = datamenu.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
           
        }

        //คลิกปุ่มระดับความหวาน > เปลี่ยนสี
        private void btsetting2(object sender, EventArgs e)
        {
            foreach (Control c in btpanel_sweetness.Controls)
            {
                c.BackColor = Color.BurlyWood; //สีเดิม
            }
            Control click = (Control)sender;
            click.BackColor = Color.SaddleBrown; //สีเมื่อคลิก
        }

        //ปุ่มเลือกระดับความหวาน
        private void btno_sugar_Click(object sender, EventArgs e)
        {
            btsetting2(btno_sugar, null); //เปลี่ยนสีbt
            lbsweetness.Text = "ไม่หวาน";
        }
        private void btless_sugar_Click(object sender, EventArgs e)
        {
            btsetting2(btless_sugar, null); //เปลี่ยนสีbt
            lbsweetness.Text = "หวานน้อย";
        }
        private void btfull_sugar_Click(object sender, EventArgs e)
        {
            btsetting2(btfull_sugar, null); //เปลี่ยนสีbt
            lbsweetness.Text = "หวานปกติ";
        }
        private void btmore_sugar_Click(object sender, EventArgs e)
        {
            btsetting2(btmore_sugar, null); //เปลี่ยนสีbt
            lbsweetness.Text = "หวานมาก";
        }

        Boolean data_stock;
        int amount_menu;
        int sumpoint, sumcoupon, redeempoint, redeemcoupon;
        private void btselect_menu_redeem_Click(object sender, EventArgs e)
        {
            if (data_stock == true) //ถ้าเลือกเมนู
            {
                MySqlConnection conn = databaseConnection();
                conn.Open();

                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT *FROM stock WHERE menu='{lbmenu.Text}'";

                MySqlDataReader row = cmd.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        amount_menu = int.Parse(row.GetString(3)); //จำนวนในstock
                    }
                }
                conn.Close();

                //เตือนเมื่อเครื่องดื่มหมด
                if (amount_menu == 0) //ถ้าจำนวนstock menu = 0
                {
                    MessageBox.Show(lbmenu.Text + " หมด กรุณาเลือกเมนูใหม่ 🔁", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }

            //เตือนเมื่อยังไม่เลือกเครื่องดื่ม
            if (lbmenu.Text == "")
            {
                MessageBox.Show("กรุณาเลือกเมนูเครื่องดื่ม 😊", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (lbsweetness.Text == "")
            {
                MessageBox.Show("กรุณาเลือกระดับความหวาน 😊", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (lbmenu.Text == "" && lbsweetness.Text == "")
            {
                MessageBox.Show("กรุณาเลือกเมนูเครื่องดื่มและระดับความหวาน 😊", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (lbmenu.Text != "" && lbsweetness.Text != "")
            {
                int seletedRow = datamenu.CurrentCell.RowIndex;
                int selectedid = Convert.ToInt32(datamenu.Rows[seletedRow].Cells["id"].Value);
                int amountstock = Convert.ToInt32(datamenu.Rows[seletedRow].Cells["amount"].Value);

                //เลือกข้อมูลจำนวนแต้ม คูปอง จากเบอร์โทร
                MySqlConnection conn = databaseConnection();
                conn.Open();

                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM history WHERE phone_number = '{lbphone_number.Text}'";
                //cmd.CommandText = $"SELECT MAX(point) FROM history WHERE phone_number = '{lbphone_number.Text}' ";
                List<int> p = new List<int>();
                List<int> cp = new List<int>();
                MySqlDataReader row = cmd.ExecuteReader();
                if (row.HasRows) 
                {
                    while (row.Read()) //อ่านค่าแถวนั้น
                    {
                        p.Add(row.GetInt32("point"));
                        cp.Add(row.GetInt32("coupon"));
                        //sumpoint = row.GetInt32("MAX(point)");
                    }
                    sumpoint = p[p.Count - 1];
                    sumcoupon = cp[cp.Count - 1];
                    redeempoint = sumpoint - 10;
                    redeemcoupon = sumcoupon - 1;

                    //ประวัติการซื้อ
                    MySqlConnection conn2 = databaseConnection();
                    conn2.Open();
                    String sql2 = "INSERT INTO history (menu,phone_number,point,coupon,status,amount_sale,date) VALUES('" + lbmenu.Text + "', '" + lbphone_number.Text + "', '" + (redeempoint) + "', '" + (redeemcoupon) + "', 'แลกแต้ม','" + 1.ToString() + "', '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "')";
                    MySqlCommand cmd2 = new MySqlCommand(sql2, conn2);
                    int rows = cmd2.ExecuteNonQuery();
                    conn2.Close();
                    if (rows > 0)
                    {
                        //ลบจำนวนstock
                        MySqlConnection conn3 = databaseConnection();
                        conn3.Open();
                        string sql3 = "UPDATE stock SET amount = '" + (amountstock - 1) + "' WHERE id = '" + selectedid + "'";
                        MySqlCommand command2 = new MySqlCommand(sql3, conn3);
                        command2.ExecuteNonQuery();
                        conn3.Close();

                        MessageBox.Show("  ♡ ขอบคุณที่ใช้บริการ ♡");
                        start st = new start();
                        st.Show();
                        this.Close();
                    }
                }
                conn.Close();
            }
        }

        //ยกเลิกแลกเครื่องดื่ม
        private void btcancle_redeem_Click(object sender, EventArgs e)
        {
            start st = new start();
            st.Show();
            this.Hide();
        }
    }
}
