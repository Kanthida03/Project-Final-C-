namespace Project
{
    partial class history
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(history));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btsearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bthistory = new System.Windows.Forms.Button();
            this.btmanage = new System.Windows.Forms.Button();
            this.btlogout = new System.Windows.Forms.Button();
            this.lbname = new System.Windows.Forms.Label();
            this.btprofile = new System.Windows.Forms.Button();
            this.lbusername = new System.Windows.Forms.Label();
            this.datahistory = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbsumprice = new System.Windows.Forms.Label();
            this.lbamount = new System.Windows.Forms.Label();
            this.panel_sum = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btreload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datahistory)).BeginInit();
            this.panel_sum.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("supermarket", 10F);
            this.dateTimePicker1.Font = new System.Drawing.Font("supermarket", 12F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(277, 261);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(167, 49);
            this.dateTimePicker1.TabIndex = 20;
            this.dateTimePicker1.Value = new System.DateTime(2022, 7, 1, 0, 0, 0, 0);
            // 
            // btsearch
            // 
            this.btsearch.BackColor = System.Drawing.Color.Gold;
            this.btsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsearch.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold);
            this.btsearch.Location = new System.Drawing.Point(672, 255);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(125, 61);
            this.btsearch.TabIndex = 38;
            this.btsearch.Text = "🔎ค้นหา";
            this.btsearch.UseVisualStyleBackColor = false;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 42);
            this.label1.TabIndex = 39;
            this.label1.Text = "จาก";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 42);
            this.label2.TabIndex = 40;
            this.label2.Text = "ถึง";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("supermarket", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(431, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 49);
            this.label5.TabIndex = 90;
            this.label5.Text = "📃ประวัติการขายเครื่องดื่ม";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(284, 43);
            this.label7.TabIndex = 91;
            this.label7.Text = "ยอดเครื่องดื่ม                 แก้ว";
            // 
            // bthistory
            // 
            this.bthistory.BackColor = System.Drawing.Color.Transparent;
            this.bthistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bthistory.BackgroundImage")));
            this.bthistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bthistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bthistory.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold);
            this.bthistory.ForeColor = System.Drawing.Color.Gold;
            this.bthistory.Location = new System.Drawing.Point(39, 346);
            this.bthistory.Name = "bthistory";
            this.bthistory.Size = new System.Drawing.Size(166, 76);
            this.bthistory.TabIndex = 95;
            this.bthistory.Text = "ประวัติการขาย";
            this.bthistory.UseVisualStyleBackColor = false;
            // 
            // btmanage
            // 
            this.btmanage.BackColor = System.Drawing.Color.Transparent;
            this.btmanage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmanage.BackgroundImage")));
            this.btmanage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btmanage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmanage.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold);
            this.btmanage.ForeColor = System.Drawing.Color.SeaShell;
            this.btmanage.Location = new System.Drawing.Point(39, 248);
            this.btmanage.Name = "btmanage";
            this.btmanage.Size = new System.Drawing.Size(166, 74);
            this.btmanage.TabIndex = 94;
            this.btmanage.Text = "ข้อมูลเครื่องดื่ม";
            this.btmanage.UseVisualStyleBackColor = false;
            this.btmanage.Click += new System.EventHandler(this.btmanage_Click);
            // 
            // btlogout
            // 
            this.btlogout.BackColor = System.Drawing.Color.Transparent;
            this.btlogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btlogout.BackgroundImage")));
            this.btlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlogout.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold);
            this.btlogout.ForeColor = System.Drawing.Color.SeaShell;
            this.btlogout.Location = new System.Drawing.Point(39, 828);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(166, 76);
            this.btlogout.TabIndex = 93;
            this.btlogout.Text = "ออกจากระบบ";
            this.btlogout.UseVisualStyleBackColor = false;
            this.btlogout.Click += new System.EventHandler(this.btlogout_Click);
            // 
            // lbname
            // 
            this.lbname.Font = new System.Drawing.Font("supermarket", 14F);
            this.lbname.Location = new System.Drawing.Point(134, 43);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(281, 41);
            this.lbname.TabIndex = 97;
            // 
            // btprofile
            // 
            this.btprofile.BackColor = System.Drawing.Color.SeaShell;
            this.btprofile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btprofile.BackgroundImage")));
            this.btprofile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btprofile.Font = new System.Drawing.Font("supermarket", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btprofile.ForeColor = System.Drawing.Color.SeaShell;
            this.btprofile.Location = new System.Drawing.Point(27, 12);
            this.btprofile.Name = "btprofile";
            this.btprofile.Size = new System.Drawing.Size(101, 103);
            this.btprofile.TabIndex = 96;
            this.btprofile.UseVisualStyleBackColor = false;
            this.btprofile.Click += new System.EventHandler(this.btprofile_Click);
            // 
            // lbusername
            // 
            this.lbusername.Font = new System.Drawing.Font("supermarket", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusername.ForeColor = System.Drawing.Color.SeaShell;
            this.lbusername.Location = new System.Drawing.Point(579, 53);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(198, 40);
            this.lbusername.TabIndex = 99;
            // 
            // datahistory
            // 
            this.datahistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.datahistory.BackgroundColor = System.Drawing.Color.SeaShell;
            this.datahistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datahistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datahistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datahistory.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datahistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.datahistory.EnableHeadersVisualStyles = false;
            this.datahistory.GridColor = System.Drawing.Color.Black;
            this.datahistory.Location = new System.Drawing.Point(275, 346);
            this.datahistory.Name = "datahistory";
            this.datahistory.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("supermarket", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datahistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datahistory.RowHeadersVisible = false;
            this.datahistory.RowHeadersWidth = 40;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("supermarket", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.datahistory.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datahistory.RowTemplate.Height = 28;
            this.datahistory.Size = new System.Drawing.Size(556, 418);
            this.datahistory.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(447, 930);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 43);
            this.label3.TabIndex = 41;
            this.label3.Text = "ยอดเงินรวม                   บาท";
            // 
            // lbsumprice
            // 
            this.lbsumprice.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsumprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbsumprice.Location = new System.Drawing.Point(168, 59);
            this.lbsumprice.Name = "lbsumprice";
            this.lbsumprice.Size = new System.Drawing.Size(58, 43);
            this.lbsumprice.TabIndex = 42;
            // 
            // lbamount
            // 
            this.lbamount.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbamount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbamount.Location = new System.Drawing.Point(168, 3);
            this.lbamount.Name = "lbamount";
            this.lbamount.Size = new System.Drawing.Size(58, 43);
            this.lbamount.TabIndex = 102;
            // 
            // panel_sum
            // 
            this.panel_sum.Controls.Add(this.lbamount);
            this.panel_sum.Controls.Add(this.lbsumprice);
            this.panel_sum.Controls.Add(this.label3);
            this.panel_sum.Controls.Add(this.label7);
            this.panel_sum.Location = new System.Drawing.Point(399, 808);
            this.panel_sum.Name = "panel_sum";
            this.panel_sum.Size = new System.Drawing.Size(328, 119);
            this.panel_sum.TabIndex = 103;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("supermarket", 10F);
            this.dateTimePicker2.Font = new System.Drawing.Font("supermarket", 12F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(499, 261);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(157, 49);
            this.dateTimePicker2.TabIndex = 104;
            this.dateTimePicker2.Value = new System.DateTime(2022, 7, 1, 0, 0, 0, 0);
            // 
            // btreload
            // 
            this.btreload.BackColor = System.Drawing.Color.Gold;
            this.btreload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btreload.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold);
            this.btreload.Location = new System.Drawing.Point(803, 255);
            this.btreload.Name = "btreload";
            this.btreload.Size = new System.Drawing.Size(54, 61);
            this.btreload.TabIndex = 105;
            this.btreload.Text = "🔁";
            this.btreload.UseVisualStyleBackColor = false;
            this.btreload.Click += new System.EventHandler(this.btreload_Click);
            // 
            // history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 950);
            this.Controls.Add(this.btreload);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.panel_sum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datahistory);
            this.Controls.Add(this.lbusername);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.btprofile);
            this.Controls.Add(this.bthistory);
            this.Controls.Add(this.btmanage);
            this.Controls.Add(this.btlogout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.dateTimePicker1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(900, 1006);
            this.MinimumSize = new System.Drawing.Size(900, 1006);
            this.Name = "history";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "history";
            this.Load += new System.EventHandler(this.history_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datahistory)).EndInit();
            this.panel_sum.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bthistory;
        private System.Windows.Forms.Button btmanage;
        private System.Windows.Forms.Button btlogout;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Button btprofile;
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.DataGridView datahistory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbsumprice;
        private System.Windows.Forms.Label lbamount;
        private System.Windows.Forms.Panel panel_sum;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btreload;
    }
}