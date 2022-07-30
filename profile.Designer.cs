namespace Project
{
    partial class profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profile));
            this.cbshow_pass = new System.Windows.Forms.CheckBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbwarning_password3 = new System.Windows.Forms.Label();
            this.btback = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.lbusername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbwarning_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbshow_pass
            // 
            this.cbshow_pass.AutoSize = true;
            this.cbshow_pass.BackColor = System.Drawing.Color.Transparent;
            this.cbshow_pass.Font = new System.Drawing.Font("supermarket", 12F);
            this.cbshow_pass.Location = new System.Drawing.Point(484, 614);
            this.cbshow_pass.Name = "cbshow_pass";
            this.cbshow_pass.Size = new System.Drawing.Size(151, 46);
            this.cbshow_pass.TabIndex = 47;
            this.cbshow_pass.Text = "แสดงรหัสผ่าน";
            this.cbshow_pass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbshow_pass.UseVisualStyleBackColor = false;
            this.cbshow_pass.CheckedChanged += new System.EventHandler(this.cbshow_pass_CheckedChanged);
            // 
            // tbpassword
            // 
            this.tbpassword.BackColor = System.Drawing.Color.OldLace;
            this.tbpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbpassword.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpassword.Location = new System.Drawing.Point(187, 541);
            this.tbpassword.Multiline = true;
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '♡';
            this.tbpassword.Size = new System.Drawing.Size(435, 45);
            this.tbpassword.TabIndex = 40;
            this.tbpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbpassword_KeyPress);
            // 
            // tbname
            // 
            this.tbname.BackColor = System.Drawing.Color.OldLace;
            this.tbname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbname.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbname.Location = new System.Drawing.Point(235, 410);
            this.tbname.Multiline = true;
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(387, 45);
            this.tbname.TabIndex = 37;
            this.tbname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbname_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 541);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 42);
            this.label6.TabIndex = 35;
            this.label6.Text = "รหัสผ่าน";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("supermarket", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(422, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 56);
            this.label1.TabIndex = 31;
            this.label1.Text = "ข้อมูลส่วนตัว";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbwarning_password3
            // 
            this.lbwarning_password3.AutoSize = true;
            this.lbwarning_password3.BackColor = System.Drawing.Color.Transparent;
            this.lbwarning_password3.Font = new System.Drawing.Font("supermarket", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbwarning_password3.ForeColor = System.Drawing.Color.Red;
            this.lbwarning_password3.Location = new System.Drawing.Point(437, 589);
            this.lbwarning_password3.Name = "lbwarning_password3";
            this.lbwarning_password3.Size = new System.Drawing.Size(195, 35);
            this.lbwarning_password3.TabIndex = 48;
            this.lbwarning_password3.Text = "*มีความยาว8-16 ตัวอักษร";
            this.lbwarning_password3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btback
            // 
            this.btback.BackColor = System.Drawing.Color.Black;
            this.btback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btback.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btback.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btback.Location = new System.Drawing.Point(70, 829);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(174, 73);
            this.btback.TabIndex = 50;
            this.btback.Text = "กลับ";
            this.btback.UseVisualStyleBackColor = false;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // btedit
            // 
            this.btedit.BackColor = System.Drawing.Color.Black;
            this.btedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btedit.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btedit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btedit.Location = new System.Drawing.Point(481, 829);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(174, 73);
            this.btedit.TabIndex = 49;
            this.btedit.Text = "แก้ไขข้อมูล";
            this.btedit.UseVisualStyleBackColor = false;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // lbusername
            // 
            this.lbusername.BackColor = System.Drawing.Color.Transparent;
            this.lbusername.Font = new System.Drawing.Font("supermarket", 14F, System.Drawing.FontStyle.Bold);
            this.lbusername.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbusername.Location = new System.Drawing.Point(147, 262);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(310, 45);
            this.lbusername.TabIndex = 51;
            this.lbusername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(299, 929);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 42);
            this.label2.TabIndex = 53;
            this.label2.Text = "ชื่อ - นามสกุล";
            // 
            // lbwarning_name
            // 
            this.lbwarning_name.AutoSize = true;
            this.lbwarning_name.BackColor = System.Drawing.Color.Transparent;
            this.lbwarning_name.Font = new System.Drawing.Font("supermarket", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbwarning_name.ForeColor = System.Drawing.Color.Red;
            this.lbwarning_name.Location = new System.Drawing.Point(473, 458);
            this.lbwarning_name.Name = "lbwarning_name";
            this.lbwarning_name.Size = new System.Drawing.Size(162, 35);
            this.lbwarning_name.TabIndex = 54;
            this.lbwarning_name.Text = "(ป้อนเฉพาะภาษาไทย)";
            this.lbwarning_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // editprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 950);
            this.Controls.Add(this.lbwarning_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbusername);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbwarning_password3);
            this.Controls.Add(this.cbshow_pass);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(750, 1006);
            this.MinimumSize = new System.Drawing.Size(750, 1006);
            this.Name = "editprofile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editprofile";
            this.Load += new System.EventHandler(this.editprofile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbshow_pass;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbwarning_password3;
        private System.Windows.Forms.Button btback;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbwarning_name;
    }
}