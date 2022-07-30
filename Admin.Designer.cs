namespace Project
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btlogin = new System.Windows.Forms.Button();
            this.btregister = new System.Windows.Forms.Button();
            this.cbshow_pass = new System.Windows.Forms.CheckBox();
            this.btreset_password = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("supermarket", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(110, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "ผู้ใช้งาน :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("supermarket", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(110, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 53);
            this.label2.TabIndex = 3;
            this.label2.Text = "รหัสผ่าน :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btlogin
            // 
            this.btlogin.BackColor = System.Drawing.Color.Black;
            this.btlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btlogin.Font = new System.Drawing.Font("supermarket", 14F, System.Drawing.FontStyle.Bold);
            this.btlogin.ForeColor = System.Drawing.Color.White;
            this.btlogin.Location = new System.Drawing.Point(229, 690);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(261, 60);
            this.btlogin.TabIndex = 5;
            this.btlogin.Text = "เข้าสู่ระบบ";
            this.btlogin.UseVisualStyleBackColor = false;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // btregister
            // 
            this.btregister.BackColor = System.Drawing.Color.Black;
            this.btregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btregister.Font = new System.Drawing.Font("supermarket", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btregister.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btregister.Location = new System.Drawing.Point(181, 785);
            this.btregister.Name = "btregister";
            this.btregister.Size = new System.Drawing.Size(166, 53);
            this.btregister.TabIndex = 6;
            this.btregister.Text = "สมัครสมาชิก";
            this.btregister.UseVisualStyleBackColor = false;
            this.btregister.Click += new System.EventHandler(this.btregister_Click);
            // 
            // cbshow_pass
            // 
            this.cbshow_pass.AutoSize = true;
            this.cbshow_pass.BackColor = System.Drawing.Color.SeaShell;
            this.cbshow_pass.Font = new System.Drawing.Font("supermarket", 12F);
            this.cbshow_pass.Location = new System.Drawing.Point(474, 579);
            this.cbshow_pass.Name = "cbshow_pass";
            this.cbshow_pass.Size = new System.Drawing.Size(151, 46);
            this.cbshow_pass.TabIndex = 8;
            this.cbshow_pass.Text = "แสดงรหัสผ่าน";
            this.cbshow_pass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbshow_pass.UseVisualStyleBackColor = false;
            this.cbshow_pass.CheckedChanged += new System.EventHandler(this.cbshow_pass_CheckedChanged);
            // 
            // btreset_password
            // 
            this.btreset_password.BackColor = System.Drawing.Color.Black;
            this.btreset_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btreset_password.Font = new System.Drawing.Font("supermarket", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btreset_password.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btreset_password.Location = new System.Drawing.Point(381, 785);
            this.btreset_password.Name = "btreset_password";
            this.btreset_password.Size = new System.Drawing.Size(166, 53);
            this.btreset_password.TabIndex = 9;
            this.btreset_password.Text = "ลืมรหัสผ่าน ?";
            this.btreset_password.UseVisualStyleBackColor = false;
            this.btreset_password.Click += new System.EventHandler(this.btreset_password_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SeaShell;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("supermarket", 14F);
            this.label4.Location = new System.Drawing.Point(349, 775);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 67);
            this.label4.TabIndex = 10;
            this.label4.Text = "|";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbusername
            // 
            this.tbusername.BackColor = System.Drawing.Color.Gold;
            this.tbusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbusername.Font = new System.Drawing.Font("supermarket", 14F);
            this.tbusername.Location = new System.Drawing.Point(229, 433);
            this.tbusername.Multiline = true;
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(383, 53);
            this.tbusername.TabIndex = 11;
            // 
            // tbpassword
            // 
            this.tbpassword.BackColor = System.Drawing.Color.Gold;
            this.tbpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbpassword.Font = new System.Drawing.Font("supermarket", 14F);
            this.tbpassword.Location = new System.Drawing.Point(242, 520);
            this.tbpassword.Multiline = true;
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '♡';
            this.tbpassword.Size = new System.Drawing.Size(370, 53);
            this.tbpassword.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SeaShell;
            this.label3.ForeColor = System.Drawing.Color.SeaShell;
            this.label3.Location = new System.Drawing.Point(283, 934);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "kataibin";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("supermarket", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(300, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 53);
            this.label5.TabIndex = 14;
            this.label5.Text = "พนักงาน ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 950);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.btreset_password);
            this.Controls.Add(this.cbshow_pass);
            this.Controls.Add(this.btregister);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(750, 1006);
            this.MinimumSize = new System.Drawing.Size(750, 1006);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button btregister;
        private System.Windows.Forms.CheckBox cbshow_pass;
        private System.Windows.Forms.Button btreset_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

