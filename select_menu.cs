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
    public partial class select_menu : Form
    {

        public select_menu()
        {
            InitializeComponent();
        }

        private MySqlConnection databaseConnection() //เชื่อมต่อฐานข้อมูล
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public string copyphone_number; //รับค่าเบอร์โทรมาจากหน้าcollect point
        //แสดงเมนูกาแฟเป็นอันแรก ในหน้าเลือกเมนู
        private void select_menu_Load(object sender, EventArgs e)
        {
            lbphone_number.Text = copyphone_number;

            showStockcoffee(); //โชว์ตารางเมนูกาแฟ

            //ซ่อนคอลัมน์
            datamenu.Columns[0].Visible = false; //id
            datamenu.Columns[3].Visible = false; //amount
            datamenu.Columns[4].Visible = false; //type

            //ปรับขนาดคอลัมน์
            datamenu.Columns[1].Width = 250; //เมนู
            datamenu.Columns[2].Width = 180; //ราคา

            //ปรับให้คอลัมน์ราคาอยู่ตรงกลาง
            datamenu.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //แก้ไขชื่อหัวตาราง
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
            foreach(Control c in btpanel_type.Controls)
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
            tbmenu.Text = datamenu.Rows[e.RowIndex].Cells["menu"].FormattedValue.ToString();
            tbprice.Text = datamenu.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
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
            tbsweetness.Text = "ไม่หวาน";
        }
        private void btless_sugar_Click(object sender, EventArgs e)
        {
            btsetting2(btless_sugar, null); //เปลี่ยนสีbt
            tbsweetness.Text = "หวานน้อย";
        }
        private void btfull_sugar_Click(object sender, EventArgs e)
        {
            btsetting2(btfull_sugar, null); //เปลี่ยนสีbt
            tbsweetness.Text = "หวานปกติ";
        }
        private void btmore_sugar_Click(object sender, EventArgs e)
        {
            btsetting2(btmore_sugar, null); //เปลี่ยนสีbt
            tbsweetness.Text = "หวานมาก";
        }

        Boolean data_stock; //ค่าtrue false
        int amount_menu;
        private void btselect_menu_Click(object sender, EventArgs e)
        {
            if (data_stock == true) //ถ้าเลือกเมนูในตาราง
            {
                MySqlConnection conn = databaseConnection();
                conn.Open();

                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM stock WHERE menu = '{tbmenu.Text}'";

                MySqlDataReader row = cmd.ExecuteReader();

                if (row.HasRows) //ถ้ามีข้อมูลในrowที่select
                {
                    while (row.Read()) //อ่านค่าจำนวนในstock menu
                    {
                        amount_menu = int.Parse(row.GetString(3)); 
                    }
                }
                conn.Close();

                //เตือนเมื่อเครื่องดื่มหมด
                if (amount_menu == 0) //ถ้าจำนวนstock menu = 0
                {
                    MessageBox.Show(tbmenu.Text + " หมด กรุณาเลือกเมนูใหม่ 🔁", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            
            //เตือนเมื่อยังไม่เลือกเครื่องดื่ม
            if (tbmenu.Text == "")
            {
                MessageBox.Show("กรุณาเลือกเมนูเครื่องดื่ม", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (tbsweetness.Text == "")
            {
                MessageBox.Show("กรุณาเลือกระดับความหวาน", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (tbmenu.Text == "" && tbsweetness.Text == "")
            {
                MessageBox.Show("กรุณาเลือกเมนูเครื่องดื่มและระดับความหวาน", "เตือน", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (tbmenu.Text != "" && tbsweetness.Text != "")
            {
                pay p = new pay(); //ส่งค่าtextbox ไปหน้าpay
                p.copytbmenu = tbmenu.Text;
                p.copytbprice = tbprice.Text;
                p.copysweetness = tbsweetness.Text;
                p.copyphone_number = lbphone_number.Text;
                p.ShowDialog();
                this.Close();
            }
        }

        private void btcancle_Click(object sender, EventArgs e)
        {
            start st = new start();
            st.Show();
            this.Close();
        }
    }
}
