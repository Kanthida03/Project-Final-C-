using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class homestart : Form
    {
        public homestart()
        {
            InitializeComponent();
        }

        private void btstart_Click(object sender, EventArgs e)
        {
            this.Hide();
            select_type sl = new select_type();
            sl.Show();
        }
    }
}
