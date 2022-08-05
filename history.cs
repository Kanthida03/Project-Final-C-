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
    public partial class history : Form
    {
        public history()
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
        private void history_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = new DateTime(2022, 6, 25);
            dateTimePicker2.Value = DateTime.Now;


            lbusername.Text = copyusername;

            //แสดงชื่อจริง นามสกุล
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM admin WHERE username = '{lbusername.Text}'"; 
            MySqlDataReader row = cmd.ExecuteReader();
            if (row.HasRows)
            {
                while (row.Read())
                {
                    lbname.Text = row.GetString(1);
                }
            }
            conn.Close();

            showHistory(); //โชว์ประวัติการขายทั้งหมด 
          
            //ปรับขนาดคอลัมน์
            datahistory.Columns[0].Width = 30; //ไอดี
            datahistory.Columns[1].Width = 130; //เมนู
            datahistory.Columns[2].Width = 40; //ราคา
            datahistory.Columns[3].Width = 120; //เบอร์โทร
            datahistory.Columns[4].Width = 50; //แต้ม
            datahistory.Columns[5].Width = 80; //คูปอง
            datahistory.Columns[6].Width = 70; //สถานะ
        }

        private void showHistory()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM history";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            datahistory.DataSource = ds.Tables[0].DefaultView;

            int amount_history = 0;
            int sum_price = 0;
            conn.Open();
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                amount_history = amount_history + int.Parse(read.GetString(7)); //รวมจำนวนเครื่องดื่มที่ขาย
                sum_price = sum_price + int.Parse(read.GetString(2)); //รวมจำนวนเงินที่ขาย
            }
            lbamount.Text = amount_history.ToString();
            lbsumprice.Text = sum_price.ToString();
            conn.Close();
        }

        private void btreload_Click(object sender, EventArgs e)
        {
            showHistory();
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text != "" || dateTimePicker2.Text != "")
            {
                MySqlConnection conn = databaseConnection();
                DataSet ds = new DataSet();
                conn.Open();

                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM history WHERE date between @date1 and @date2"; 
             
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.SelectCommand.Parameters.AddWithValue("@date1", dateTimePicker1.Value.ToString("dd/MM/yyyy"));
                adapter.SelectCommand.Parameters.AddWithValue("@date2", dateTimePicker2.Value.ToString("dd/MM/yyyy"));

                adapter.Fill(ds);

                conn.Close();

                datahistory.DataSource = ds.Tables[0].DefaultView;

                int amount_history = 0;
                int sum_price = 0;
                conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read()) 
                {
                    amount_history = amount_history + int.Parse(read.GetString(7)); //รวมจำนวนเครื่องดื่มที่ขาย
                    sum_price = sum_price + int.Parse(read.GetString(2)); //รวมจำนวนเงินที่ขาย
                }
                lbamount.Text = amount_history.ToString(); 
                lbsumprice.Text = sum_price.ToString();
                conn.Close();
            }
        }
        private void btprofile_Click(object sender, EventArgs e)
        {
            profile edit = new profile();
            edit.copyusername = lbusername.Text;
            edit.ShowDialog();
            this.Hide();
        }

        private void btmanage_Click(object sender, EventArgs e)
        {
            manage mn = new manage();
            mn.copyusername = lbusername.Text;
            mn.ShowDialog();
            this.Hide();
        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            Admin am = new Admin();
            am.Show();
            this.Close();
        }
    }
}
