namespace Project
{
    partial class manage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manage));
            this.btdelete = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datamenu = new System.Windows.Forms.DataGridView();
            this.btjuice = new System.Windows.Forms.Button();
            this.btcoffee = new System.Windows.Forms.Button();
            this.btmilk = new System.Windows.Forms.Button();
            this.bttea = new System.Windows.Forms.Button();
            this.tbmenu = new System.Windows.Forms.TextBox();
            this.tbamount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbprice = new System.Windows.Forms.TextBox();
            this.btpanel_manage = new System.Windows.Forms.Panel();
            this.btadd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btsearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbusername = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btprofile = new System.Windows.Forms.Button();
            this.cbx_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bthistory = new System.Windows.Forms.Button();
            this.btmanage = new System.Windows.Forms.Button();
            this.btlogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datamenu)).BeginInit();
            this.btpanel_manage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btdelete
            // 
            this.btdelete.BackColor = System.Drawing.Color.BurlyWood;
            this.btdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdelete.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold);
            this.btdelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btdelete.Location = new System.Drawing.Point(373, 17);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(142, 54);
            this.btdelete.TabIndex = 10;
            this.btdelete.Text = "ลบเมนู";
            this.btdelete.UseVisualStyleBackColor = false;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            this.btdelete.MouseLeave += new System.EventHandler(this.btdelete_MouseLeave);
            this.btdelete.MouseHover += new System.EventHandler(this.btdelete_MouseHover);
            // 
            // btedit
            // 
            this.btedit.BackColor = System.Drawing.Color.BurlyWood;
            this.btedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btedit.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold);
            this.btedit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btedit.Location = new System.Drawing.Point(200, 17);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(142, 54);
            this.btedit.TabIndex = 9;
            this.btedit.Text = "แก้ไขเมนู";
            this.btedit.UseVisualStyleBackColor = false;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            this.btedit.MouseLeave += new System.EventHandler(this.btedit_MouseLeave);
            this.btedit.MouseHover += new System.EventHandler(this.btedit_MouseHover);
            // 
            // tbsearch
            // 
            this.tbsearch.BackColor = System.Drawing.Color.Gold;
            this.tbsearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbsearch.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsearch.ForeColor = System.Drawing.Color.Black;
            this.tbsearch.Location = new System.Drawing.Point(306, 289);
            this.tbsearch.Multiline = true;
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(399, 42);
            this.tbsearch.TabIndex = 15;
            this.tbsearch.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("supermarket", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 49);
            this.label3.TabIndex = 17;
            this.label3.Text = "🥤ประเภทเครื่องดื่ม";
            // 
            // datamenu
            // 
            this.datamenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.datamenu.BackgroundColor = System.Drawing.Color.SeaShell;
            this.datamenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datamenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datamenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.datamenu.ColumnHeadersHeight = 40;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datamenu.DefaultCellStyle = dataGridViewCellStyle30;
            this.datamenu.EnableHeadersVisualStyles = false;
            this.datamenu.GridColor = System.Drawing.Color.Black;
            this.datamenu.Location = new System.Drawing.Point(258, 355);
            this.datamenu.Name = "datamenu";
            this.datamenu.ReadOnly = true;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("supermarket", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datamenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.datamenu.RowHeadersVisible = false;
            this.datamenu.RowHeadersWidth = 40;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("supermarket", 12F);
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.datamenu.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.datamenu.RowTemplate.Height = 28;
            this.datamenu.Size = new System.Drawing.Size(602, 308);
            this.datamenu.TabIndex = 18;
            this.datamenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datamenu_CellClick);
            // 
            // btjuice
            // 
            this.btjuice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btjuice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btjuice.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold);
            this.btjuice.ForeColor = System.Drawing.Color.White;
            this.btjuice.Location = new System.Drawing.Point(731, 200);
            this.btjuice.Name = "btjuice";
            this.btjuice.Size = new System.Drawing.Size(121, 63);
            this.btjuice.TabIndex = 22;
            this.btjuice.Text = "น้ำผลไม้ ";
            this.btjuice.UseVisualStyleBackColor = false;
            this.btjuice.Click += new System.EventHandler(this.btjuice_Click);
            // 
            // btcoffee
            // 
            this.btcoffee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btcoffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcoffee.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold);
            this.btcoffee.ForeColor = System.Drawing.Color.White;
            this.btcoffee.Location = new System.Drawing.Point(258, 200);
            this.btcoffee.Name = "btcoffee";
            this.btcoffee.Size = new System.Drawing.Size(101, 63);
            this.btcoffee.TabIndex = 23;
            this.btcoffee.Text = "กาแฟ";
            this.btcoffee.UseVisualStyleBackColor = false;
            this.btcoffee.Click += new System.EventHandler(this.btcoffee_Click);
            // 
            // btmilk
            // 
            this.btmilk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btmilk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmilk.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold);
            this.btmilk.ForeColor = System.Drawing.Color.White;
            this.btmilk.Location = new System.Drawing.Point(482, 200);
            this.btmilk.Name = "btmilk";
            this.btmilk.Size = new System.Drawing.Size(226, 63);
            this.btmilk.TabIndex = 21;
            this.btmilk.Text = "นม โกโก้ และคาราเมล";
            this.btmilk.UseVisualStyleBackColor = false;
            this.btmilk.Click += new System.EventHandler(this.btmilk_Click);
            // 
            // bttea
            // 
            this.bttea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bttea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttea.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold);
            this.bttea.ForeColor = System.Drawing.Color.White;
            this.bttea.Location = new System.Drawing.Point(379, 200);
            this.bttea.Name = "bttea";
            this.bttea.Size = new System.Drawing.Size(78, 63);
            this.bttea.TabIndex = 20;
            this.bttea.Text = "ชา";
            this.bttea.UseVisualStyleBackColor = false;
            this.bttea.Click += new System.EventHandler(this.bttea_Click);
            // 
            // tbmenu
            // 
            this.tbmenu.BackColor = System.Drawing.Color.Gold;
            this.tbmenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbmenu.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmenu.ForeColor = System.Drawing.Color.Black;
            this.tbmenu.Location = new System.Drawing.Point(340, 681);
            this.tbmenu.Multiline = true;
            this.tbmenu.Name = "tbmenu";
            this.tbmenu.Size = new System.Drawing.Size(302, 46);
            this.tbmenu.TabIndex = 24;
            // 
            // tbamount
            // 
            this.tbamount.BackColor = System.Drawing.Color.Gold;
            this.tbamount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbamount.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbamount.ForeColor = System.Drawing.Color.Black;
            this.tbamount.Location = new System.Drawing.Point(731, 755);
            this.tbamount.Multiline = true;
            this.tbamount.Name = "tbamount";
            this.tbamount.Size = new System.Drawing.Size(60, 46);
            this.tbamount.TabIndex = 25;
            this.tbamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbprice_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 683);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 42);
            this.label5.TabIndex = 27;
            this.label5.Text = "ชื่อเมนู :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(649, 759);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 42);
            this.label6.TabIndex = 28;
            this.label6.Text = "จำนวน :            แก้ว";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(666, 685);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 42);
            this.label7.TabIndex = 31;
            this.label7.Text = "ราคา :            ฿  ";
            // 
            // tbprice
            // 
            this.tbprice.BackColor = System.Drawing.Color.Gold;
            this.tbprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbprice.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbprice.ForeColor = System.Drawing.Color.Black;
            this.tbprice.Location = new System.Drawing.Point(731, 683);
            this.tbprice.Multiline = true;
            this.tbprice.Name = "tbprice";
            this.tbprice.Size = new System.Drawing.Size(60, 46);
            this.tbprice.TabIndex = 30;
            this.tbprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbprice_KeyPress);
            // 
            // btpanel_manage
            // 
            this.btpanel_manage.Controls.Add(this.btdelete);
            this.btpanel_manage.Controls.Add(this.btedit);
            this.btpanel_manage.Controls.Add(this.btadd);
            this.btpanel_manage.Location = new System.Drawing.Point(285, 828);
            this.btpanel_manage.Name = "btpanel_manage";
            this.btpanel_manage.Size = new System.Drawing.Size(543, 76);
            this.btpanel_manage.TabIndex = 32;
            // 
            // btadd
            // 
            this.btadd.BackColor = System.Drawing.Color.BurlyWood;
            this.btadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btadd.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold);
            this.btadd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btadd.Location = new System.Drawing.Point(23, 17);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(142, 54);
            this.btadd.TabIndex = 7;
            this.btadd.Text = "เพิ่มเมนู";
            this.btadd.UseVisualStyleBackColor = false;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            this.btadd.MouseLeave += new System.EventHandler(this.btadd_MouseLeave);
            this.btadd.MouseHover += new System.EventHandler(this.btadd_MouseHover);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(243, 753);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 42);
            this.label8.TabIndex = 34;
            this.label8.Text = "ประเภท :";
            // 
            // btsearch
            // 
            this.btsearch.BackColor = System.Drawing.Color.Gold;
            this.btsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsearch.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold);
            this.btsearch.Location = new System.Drawing.Point(727, 281);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(125, 58);
            this.btsearch.TabIndex = 37;
            this.btsearch.Text = "🔎ค้นหา";
            this.btsearch.UseVisualStyleBackColor = false;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 42);
            this.label4.TabIndex = 38;
            this.label4.Text = "เมนู";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbusername
            // 
            this.lbusername.Font = new System.Drawing.Font("supermarket", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusername.ForeColor = System.Drawing.Color.SeaShell;
            this.lbusername.Location = new System.Drawing.Point(507, 47);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(198, 40);
            this.lbusername.TabIndex = 40;
            // 
            // lbname
            // 
            this.lbname.Font = new System.Drawing.Font("supermarket", 14F);
            this.lbname.Location = new System.Drawing.Point(129, 47);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(276, 41);
            this.lbname.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(296, 924);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 43;
            // 
            // btprofile
            // 
            this.btprofile.BackColor = System.Drawing.Color.SeaShell;
            this.btprofile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btprofile.BackgroundImage")));
            this.btprofile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btprofile.Font = new System.Drawing.Font("supermarket", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btprofile.ForeColor = System.Drawing.Color.SeaShell;
            this.btprofile.Location = new System.Drawing.Point(22, 16);
            this.btprofile.Name = "btprofile";
            this.btprofile.Size = new System.Drawing.Size(101, 103);
            this.btprofile.TabIndex = 39;
            this.btprofile.UseVisualStyleBackColor = false;
            this.btprofile.Click += new System.EventHandler(this.btprofile_Click);
            // 
            // cbx_type
            // 
            this.cbx_type.BackColor = System.Drawing.Color.Gold;
            this.cbx_type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_type.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_type.FormattingEnabled = true;
            this.cbx_type.Items.AddRange(new object[] {
            "กาแฟ",
            "ชา",
            "นม โกโก้ และคาราเมล",
            "น้ำผลไม้"});
            this.cbx_type.Location = new System.Drawing.Point(340, 754);
            this.cbx_type.Name = "cbx_type";
            this.cbx_type.Size = new System.Drawing.Size(302, 50);
            this.cbx_type.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(481, 924);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 45;
            // 
            // bthistory
            // 
            this.bthistory.BackColor = System.Drawing.Color.Transparent;
            this.bthistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bthistory.BackgroundImage")));
            this.bthistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bthistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bthistory.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold);
            this.bthistory.ForeColor = System.Drawing.Color.SeaShell;
            this.bthistory.Location = new System.Drawing.Point(36, 373);
            this.bthistory.Name = "bthistory";
            this.bthistory.Size = new System.Drawing.Size(166, 76);
            this.bthistory.TabIndex = 51;
            this.bthistory.Text = "ประวัติการขาย";
            this.bthistory.UseVisualStyleBackColor = false;
            this.bthistory.Click += new System.EventHandler(this.bthistory_Click);
            // 
            // btmanage
            // 
            this.btmanage.BackColor = System.Drawing.Color.Transparent;
            this.btmanage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmanage.BackgroundImage")));
            this.btmanage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btmanage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmanage.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold);
            this.btmanage.ForeColor = System.Drawing.Color.Gold;
            this.btmanage.Location = new System.Drawing.Point(36, 275);
            this.btmanage.Name = "btmanage";
            this.btmanage.Size = new System.Drawing.Size(166, 74);
            this.btmanage.TabIndex = 50;
            this.btmanage.Text = "ข้อมูลเครื่องดื่ม";
            this.btmanage.UseVisualStyleBackColor = false;
            // 
            // btlogout
            // 
            this.btlogout.BackColor = System.Drawing.Color.Transparent;
            this.btlogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btlogout.BackgroundImage")));
            this.btlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlogout.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold);
            this.btlogout.ForeColor = System.Drawing.Color.SeaShell;
            this.btlogout.Location = new System.Drawing.Point(36, 823);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(166, 76);
            this.btlogout.TabIndex = 49;
            this.btlogout.Text = "ออกจากระบบ";
            this.btlogout.UseVisualStyleBackColor = false;
            this.btlogout.Click += new System.EventHandler(this.btlogout_Click);
            // 
            // manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 950);
            this.Controls.Add(this.bthistory);
            this.Controls.Add(this.btmanage);
            this.Controls.Add(this.btlogout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.btjuice);
            this.Controls.Add(this.lbusername);
            this.Controls.Add(this.btmilk);
            this.Controls.Add(this.btcoffee);
            this.Controls.Add(this.bttea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btpanel_manage);
            this.Controls.Add(this.tbprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbamount);
            this.Controls.Add(this.tbmenu);
            this.Controls.Add(this.datamenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btprofile);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(900, 1006);
            this.MinimumSize = new System.Drawing.Size(900, 1006);
            this.Name = "manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "manage";
            this.Load += new System.EventHandler(this.manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datamenu)).EndInit();
            this.btpanel_manage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView datamenu;
        private System.Windows.Forms.Button btjuice;
        private System.Windows.Forms.Button btcoffee;
        private System.Windows.Forms.Button btmilk;
        private System.Windows.Forms.Button bttea;
        private System.Windows.Forms.TextBox tbmenu;
        private System.Windows.Forms.TextBox tbamount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbprice;
        private System.Windows.Forms.Panel btpanel_manage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btprofile;
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bthistory;
        private System.Windows.Forms.Button btmanage;
        private System.Windows.Forms.Button btlogout;
    }
}