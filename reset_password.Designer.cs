namespace Project
{
    partial class reset_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reset_password));
            this.tbcfnewpass = new System.Windows.Forms.TextBox();
            this.tbnewpass = new System.Windows.Forms.TextBox();
            this.btcf_password = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbwarning_newpass = new System.Windows.Forms.Label();
            this.lbwarning_cfpass = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.btserch_admin = new System.Windows.Forms.Button();
            this.btback = new System.Windows.Forms.Button();
            this.cbshow_pass = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbcfnewpass
            // 
            this.tbcfnewpass.BackColor = System.Drawing.Color.OldLace;
            this.tbcfnewpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbcfnewpass.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcfnewpass.ForeColor = System.Drawing.Color.Black;
            this.tbcfnewpass.Location = new System.Drawing.Point(273, 592);
            this.tbcfnewpass.Multiline = true;
            this.tbcfnewpass.Name = "tbcfnewpass";
            this.tbcfnewpass.PasswordChar = '♡';
            this.tbcfnewpass.Size = new System.Drawing.Size(334, 51);
            this.tbcfnewpass.TabIndex = 50;
            this.tbcfnewpass.TextChanged += new System.EventHandler(this.tbcfnewpass_TextChanged);
            // 
            // tbnewpass
            // 
            this.tbnewpass.BackColor = System.Drawing.Color.OldLace;
            this.tbnewpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbnewpass.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnewpass.ForeColor = System.Drawing.Color.Black;
            this.tbnewpass.Location = new System.Drawing.Point(240, 497);
            this.tbnewpass.Multiline = true;
            this.tbnewpass.Name = "tbnewpass";
            this.tbnewpass.PasswordChar = '♡';
            this.tbnewpass.Size = new System.Drawing.Size(359, 51);
            this.tbnewpass.TabIndex = 51;
            this.tbnewpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbnewpass_KeyPress);
            // 
            // btcf_password
            // 
            this.btcf_password.BackColor = System.Drawing.Color.Black;
            this.btcf_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcf_password.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold);
            this.btcf_password.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btcf_password.Location = new System.Drawing.Point(495, 821);
            this.btcf_password.Name = "btcf_password";
            this.btcf_password.Size = new System.Drawing.Size(159, 64);
            this.btcf_password.TabIndex = 54;
            this.btcf_password.Text = "ยืนยัน";
            this.btcf_password.UseVisualStyleBackColor = false;
            this.btcf_password.Click += new System.EventHandler(this.btcf_password_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("supermarket", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(385, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 73);
            this.label1.TabIndex = 58;
            this.label1.Text = "ตั้งค่ารหัสผ่านใหม่";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbname
            // 
            this.lbname.BackColor = System.Drawing.Color.Transparent;
            this.lbname.Font = new System.Drawing.Font("supermarket", 12F);
            this.lbname.Location = new System.Drawing.Point(222, 269);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(302, 54);
            this.lbname.TabIndex = 59;
            this.lbname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(119, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 53);
            this.label2.TabIndex = 63;
            this.label2.Text = "รหัสผ่านใหม่";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(119, 587);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 53);
            this.label3.TabIndex = 64;
            this.label3.Text = "ยืนยันรหัสผ่าน";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbwarning_newpass
            // 
            this.lbwarning_newpass.AutoSize = true;
            this.lbwarning_newpass.BackColor = System.Drawing.Color.Transparent;
            this.lbwarning_newpass.Font = new System.Drawing.Font("supermarket", 9F);
            this.lbwarning_newpass.ForeColor = System.Drawing.Color.Red;
            this.lbwarning_newpass.Location = new System.Drawing.Point(428, 551);
            this.lbwarning_newpass.Name = "lbwarning_newpass";
            this.lbwarning_newpass.Size = new System.Drawing.Size(171, 31);
            this.lbwarning_newpass.TabIndex = 65;
            this.lbwarning_newpass.Text = "*มีความยาว8-16 ตัวอักษร";
            this.lbwarning_newpass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbwarning_cfpass
            // 
            this.lbwarning_cfpass.AutoSize = true;
            this.lbwarning_cfpass.BackColor = System.Drawing.Color.Transparent;
            this.lbwarning_cfpass.Font = new System.Drawing.Font("supermarket", 9F);
            this.lbwarning_cfpass.ForeColor = System.Drawing.Color.Red;
            this.lbwarning_cfpass.Location = new System.Drawing.Point(478, 646);
            this.lbwarning_cfpass.Name = "lbwarning_cfpass";
            this.lbwarning_cfpass.Size = new System.Drawing.Size(125, 31);
            this.lbwarning_cfpass.TabIndex = 66;
            this.lbwarning_cfpass.Text = "*รหัสผ่านไม่ตรงกัน";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(119, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 53);
            this.label4.TabIndex = 68;
            this.label4.Text = "ชื่อผู้ใช้งาน";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbusername
            // 
            this.tbusername.BackColor = System.Drawing.Color.OldLace;
            this.tbusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbusername.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusername.ForeColor = System.Drawing.Color.Black;
            this.tbusername.Location = new System.Drawing.Point(126, 410);
            this.tbusername.Multiline = true;
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(338, 51);
            this.tbusername.TabIndex = 67;
            // 
            // btserch_admin
            // 
            this.btserch_admin.BackColor = System.Drawing.Color.Black;
            this.btserch_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btserch_admin.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btserch_admin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btserch_admin.Location = new System.Drawing.Point(479, 410);
            this.btserch_admin.Name = "btserch_admin";
            this.btserch_admin.Size = new System.Drawing.Size(128, 53);
            this.btserch_admin.TabIndex = 69;
            this.btserch_admin.Text = "🔎ค้นหา";
            this.btserch_admin.UseVisualStyleBackColor = false;
            this.btserch_admin.Click += new System.EventHandler(this.btserch_admin_Click);
            // 
            // btback
            // 
            this.btback.BackColor = System.Drawing.Color.Black;
            this.btback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btback.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold);
            this.btback.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btback.Location = new System.Drawing.Point(57, 821);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(159, 64);
            this.btback.TabIndex = 70;
            this.btback.Text = "กลับ";
            this.btback.UseVisualStyleBackColor = false;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // cbshow_pass
            // 
            this.cbshow_pass.AutoSize = true;
            this.cbshow_pass.BackColor = System.Drawing.Color.Transparent;
            this.cbshow_pass.Font = new System.Drawing.Font("supermarket", 10F);
            this.cbshow_pass.Location = new System.Drawing.Point(479, 669);
            this.cbshow_pass.Name = "cbshow_pass";
            this.cbshow_pass.Size = new System.Drawing.Size(134, 39);
            this.cbshow_pass.TabIndex = 71;
            this.cbshow_pass.Text = "แสดงรหัสผ่าน";
            this.cbshow_pass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbshow_pass.UseVisualStyleBackColor = false;
            this.cbshow_pass.CheckedChanged += new System.EventHandler(this.cbshow_pass_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(315, 929);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 72;
            // 
            // reset_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 950);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbshow_pass);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.btserch_admin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.lbwarning_cfpass);
            this.Controls.Add(this.lbwarning_newpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btcf_password);
            this.Controls.Add(this.tbnewpass);
            this.Controls.Add(this.tbcfnewpass);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(750, 1006);
            this.MinimumSize = new System.Drawing.Size(750, 1006);
            this.Name = "reset_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reset_password";
            this.Load += new System.EventHandler(this.reset_password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbcfnewpass;
        private System.Windows.Forms.TextBox tbnewpass;
        private System.Windows.Forms.Button btcf_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbwarning_newpass;
        private System.Windows.Forms.Label lbwarning_cfpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.Button btserch_admin;
        private System.Windows.Forms.Button btback;
        private System.Windows.Forms.CheckBox cbshow_pass;
        private System.Windows.Forms.Label label5;
    }
}