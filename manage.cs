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
    public partial class manage : Form
    {
        public manage()
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
        //แสดงเมนูกาแฟเป็นอันแรก ในหน้าเลือกเมนู
        private void manage_Load(object sender, EventArgs e)
        {
            lbusername.Text = copyusername;

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

            showStock(); //โชว์ตารางเมนูทั้งหมด


            //ปรับขนาดคอลัมน์
            datamenu.Columns[0].Width = 40; //ไอดี
            datamenu.Columns[1].Width = 145; //เมนู
            datamenu.Columns[2].Width = 80; //ราคา
            datamenu.Columns[3].Width = 80; //จำนวน
            datamenu.Columns[4].Width = 120; //ประเภท

            datamenu.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datamenu.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datamenu.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datamenu.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //แก้ไขชื่อหัวตาราง
            datamenu.Columns[0].HeaderText = " ID";
            datamenu.Columns[1].HeaderText = "    เมนู";
            datamenu.Columns[2].HeaderText = "   ราคา";
            datamenu.Columns[3].HeaderText = " จำนวน";
            datamenu.Columns[4].HeaderText = "     ประเภท";
        }

        //โค้ดแสดงตารางเมนู
        private void showStock()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stock"; 

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            datamenu.DataSource = ds.Tables[0].DefaultView;
        }

        //คลิกปุ่มกาแฟ > แสดงเมนู
        private void btcoffee_Click(object sender, EventArgs e)
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

        //คลิกปุ่มชา > แสดงเมนู
        private void bttea_Click(object sender, EventArgs e)
        {
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

        //ค้นหาเมนู
        private void btsearch_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stock WHERE menu like '%" + tbsearch.Text + "%'"; 
            
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            
            conn.Close();
            datamenu.DataSource = ds.Tables[0].DefaultView;
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            if (tbsearch.Text == "")
            {
                showStock();
            }
        }

        //คลิกเลือกเมนูในตาราง
        private void datamenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            datamenu.CurrentRow.Selected = true; //เลือกเมนู > นำค่าจากrowที่เลือกมาเก็บไว้ใน FormattedValue ค่า string
            tbmenu.Text = datamenu.Rows[e.RowIndex].Cells["menu"].FormattedValue.ToString();
            tbprice.Text = datamenu.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
            cbx_type.Text = datamenu.Rows[e.RowIndex].Cells["type"].FormattedValue.ToString();
            tbamount.Text = datamenu.Rows[e.RowIndex].Cells["amount"].FormattedValue.ToString();
        }

        //คลิกปุ่มการทำงาน > เปลี่ยนสี
        private void btsetting(object sender, EventArgs e)
        {
            foreach (Control c in btpanel_manage.Controls)
            {
                c.BackColor = Color.BurlyWood; //สีเดิม
            }
            Control click = (Control)sender;
            click.BackColor = Color.SaddleBrown; //สีเมื่อคลิก
        }

        private void tbprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("ป้อนข้อมูลเป็นตัวเลขเท่านั้น");
            }
        }

        //โชว์เมนูจากประเภทในโปรแกรมการทำงาน
        private void showstock2()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stock WHERE type = '{cbx_type.Text}'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            datamenu.DataSource = ds.Tables[0].DefaultView;
        }


        //เพิ่มเมนู
        private void btadd_Click(object sender, EventArgs e)
        {
            if (tbmenu.Text == "" || tbprice.Text == "" || cbx_type.Text == "" || tbamount.Text == "")
            {
                MessageBox.Show("กรุณาป้อนข้อมูลเครื่องดื่มให้ครบ");
            }
            else
            {
                MySqlConnection conn = databaseConnection();
                conn.Open();
                MySqlCommand cmd;
                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM stock WHERE menu = '{tbmenu.Text}'"; //เลือกข้อมูลจากชื่อเมนู
                MySqlDataReader row = cmd.ExecuteReader();
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        MessageBox.Show("เมนูเครื่องดื่มซ้ำ");
                    }
                }
                else
                {
                    MySqlConnection conn2 = databaseConnection();
                    String sql = "INSERT INTO stock (menu, type, price, amount) VALUES('" + tbmenu.Text + "' , '" + cbx_type.Text + "', '" + tbprice.Text + "', '" + tbamount.Text + "')";
                    MySqlCommand cmd2 = new MySqlCommand(sql, conn2);

                    conn2.Open();

                    int rows = cmd2.ExecuteNonQuery();

                    conn2.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show("เพิ่มเมนูเครื่องดื่มเรียบร้อย");
                        showstock2(); //โชว์เมนูที่เพิ่ม
                    }
                } 
            }
        }

        //แก้ไขเครื่องดื่ม
        private void btedit_Click(object sender, EventArgs e)
        {
            int seletedRow = datamenu.CurrentCell.RowIndex;
            int editId = Convert.ToInt32(datamenu.Rows[seletedRow].Cells["id"].Value);

            MySqlConnection conn = databaseConnection();

            String sql = "UPDATE stock SET menu = '" + tbmenu.Text + "',type = '" + cbx_type.Text + "',price = '" + tbprice.Text + "',amount = '" + tbamount.Text + "' WHERE id = '" + editId + "'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            if (rows > 0)
            {
                MessageBox.Show("อัพเดตข้อมูลเมนูสำเร็จ");
                showstock2(); //โชว์เมนูที่แก้ไข
            }
        }


        //ลบข้อมูลเครื่องดื่ม
        private void btdelete_Click(object sender, EventArgs e)
        {
            int seletedRow = datamenu.CurrentCell.RowIndex;
            int deleted = Convert.ToInt32(datamenu.Rows[seletedRow].Cells["id"].Value);

            MySqlConnection conn = databaseConnection();
            String sql = "DELETE FROM stock WHERE id = '" + deleted + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            if (rows > 0)
            {
                MessageBox.Show("ลบเมนูสำเร็จ");
                showstock2(); //โชว์เมนูที่ลบ
                this.tbmenu.Clear();
                this.tbprice.Clear();
                this.tbamount.Clear();
            }
        }

        private void btadd_MouseHover(object sender, EventArgs e)
        {
            btsetting(btadd, null);
        }

        private void btadd_MouseLeave(object sender, EventArgs e)
        {
            btsetting(btadd, null);
        }

        private void btedit_MouseHover(object sender, EventArgs e)
        {
            btsetting(btedit, null);
        }

        private void btedit_MouseLeave(object sender, EventArgs e)
        {
            btsetting(btedit, null);
        }

        private void btdelete_MouseHover(object sender, EventArgs e)
        {
            btsetting(btdelete, null);
        }

        private void btdelete_MouseLeave(object sender, EventArgs e)
        {
            btsetting(btdelete, null);
        }

        private void btprofile_Click(object sender, EventArgs e)
        {
            profile edit = new profile();
            edit.copyusername = lbusername.Text;
            edit.ShowDialog();
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
