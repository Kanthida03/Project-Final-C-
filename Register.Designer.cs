namespace Project
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.tbcfpassword = new System.Windows.Forms.TextBox();
            this.btregister = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbwarning_name = new System.Windows.Forms.Label();
            this.lbwarning_password2 = new System.Windows.Forms.Label();
            this.cbshow_pass = new System.Windows.Forms.CheckBox();
            this.lbwarning_password3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("supermarket", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(280, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "สมัครสมาชิก";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อ - นามสกุล";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 42);
            this.label5.TabIndex = 4;
            this.label5.Text = "ชื่อผู้ใช้งาน";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 496);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 42);
            this.label6.TabIndex = 5;
            this.label6.Text = "รหัสผ่าน";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 603);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 42);
            this.label7.TabIndex = 6;
            this.label7.Text = "ยืนยันรหัสผ่าน";
            // 
            // tbname
            // 
            this.tbname.BackColor = System.Drawing.Color.OldLace;
            this.tbname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbname.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbname.Location = new System.Drawing.Point(239, 265);
            this.tbname.Multiline = true;
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(382, 45);
            this.tbname.TabIndex = 7;
            this.tbname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbfname_KeyPress);
            // 
            // tbusername
            // 
            this.tbusername.BackColor = System.Drawing.Color.OldLace;
            this.tbusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbusername.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusername.Location = new System.Drawing.Point(202, 378);
            this.tbusername.Multiline = true;
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(419, 45);
            this.tbusername.TabIndex = 10;
            // 
            // tbpassword
            // 
            this.tbpassword.BackColor = System.Drawing.Color.OldLace;
            this.tbpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbpassword.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpassword.Location = new System.Drawing.Point(187, 496);
            this.tbpassword.Multiline = true;
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '♡';
            this.tbpassword.Size = new System.Drawing.Size(434, 45);
            this.tbpassword.TabIndex = 16;
            this.tbpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbpassword_KeyPress);
            // 
            // tbcfpassword
            // 
            this.tbcfpassword.BackColor = System.Drawing.Color.OldLace;
            this.tbcfpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbcfpassword.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcfpassword.Location = new System.Drawing.Point(239, 603);
            this.tbcfpassword.Multiline = true;
            this.tbcfpassword.Name = "tbcfpassword";
            this.tbcfpassword.PasswordChar = '♡';
            this.tbcfpassword.Size = new System.Drawing.Size(385, 45);
            this.tbcfpassword.TabIndex = 17;
            this.tbcfpassword.TextChanged += new System.EventHandler(this.tbcfpassword_TextChanged);
            // 
            // btregister
            // 
            this.btregister.BackColor = System.Drawing.Color.Black;
            this.btregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btregister.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btregister.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btregister.Location = new System.Drawing.Point(485, 819);
            this.btregister.Name = "btregister";
            this.btregister.Size = new System.Drawing.Size(174, 73);
            this.btregister.TabIndex = 18;
            this.btregister.Text = "สมัครสมาชิก";
            this.btregister.UseVisualStyleBackColor = false;
            this.btregister.Click += new System.EventHandler(this.btregister_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(72, 819);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 73);
            this.button2.TabIndex = 19;
            this.button2.Text = "กลับหน้าหลัก";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btback_Click);
            // 
            // lbwarning_name
            // 
            this.lbwarning_name.AutoSize = true;
            this.lbwarning_name.BackColor = System.Drawing.Color.Transparent;
            this.lbwarning_name.Font = new System.Drawing.Font("supermarket", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbwarning_name.ForeColor = System.Drawing.Color.Red;
            this.lbwarning_name.Location = new System.Drawing.Point(469, 313);
            this.lbwarning_name.Name = "lbwarning_name";
            this.lbwarning_name.Size = new System.Drawing.Size(162, 35);
            this.lbwarning_name.TabIndex = 24;
            this.lbwarning_name.Text = "(ป้อนเฉพาะภาษาไทย)";
            this.lbwarning_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbwarning_password2
            // 
            this.lbwarning_password2.AutoSize = true;
            this.lbwarning_password2.BackColor = System.Drawing.Color.Transparent;
            this.lbwarning_password2.Font = new System.Drawing.Font("supermarket", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbwarning_password2.ForeColor = System.Drawing.Color.Red;
            this.lbwarning_password2.Location = new System.Drawing.Point(490, 651);
            this.lbwarning_password2.Name = "lbwarning_password2";
            this.lbwarning_password2.Size = new System.Drawing.Size(144, 35);
            this.lbwarning_password2.TabIndex = 26;
            this.lbwarning_password2.Text = "*รหัสผ่านไม่ตรงกัน";
            // 
            // cbshow_pass
            // 
            this.cbshow_pass.AutoSize = true;
            this.cbshow_pass.BackColor = System.Drawing.Color.Transparent;
            this.cbshow_pass.Font = new System.Drawing.Font("supermarket", 12F);
            this.cbshow_pass.Location = new System.Drawing.Point(487, 680);
            this.cbshow_pass.Name = "cbshow_pass";
            this.cbshow_pass.Size = new System.Drawing.Size(151, 46);
            this.cbshow_pass.TabIndex = 29;
            this.cbshow_pass.Text = "แสดงรหัสผ่าน";
            this.cbshow_pass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbshow_pass.UseVisualStyleBackColor = false;
            this.cbshow_pass.CheckedChanged += new System.EventHandler(this.cbshow_pass_CheckedChanged);
            // 
            // lbwarning_password3
            // 
            this.lbwarning_password3.AutoSize = true;
            this.lbwarning_password3.BackColor = System.Drawing.Color.Transparent;
            this.lbwarning_password3.Font = new System.Drawing.Font("supermarket", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbwarning_password3.ForeColor = System.Drawing.Color.Red;
            this.lbwarning_password3.Location = new System.Drawing.Point(436, 544);
            this.lbwarning_password3.Name = "lbwarning_password3";
            this.lbwarning_password3.Size = new System.Drawing.Size(195, 35);
            this.lbwarning_password3.TabIndex = 30;
            this.lbwarning_password3.Text = "*มีความยาว8-16 ตัวอักษร";
            this.lbwarning_password3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(308, 927);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 44;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 950);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbwarning_password2);
            this.Controls.Add(this.cbshow_pass);
            this.Controls.Add(this.lbwarning_name);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btregister);
            this.Controls.Add(this.tbcfpassword);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbwarning_password3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(750, 1006);
            this.MinimumSize = new System.Drawing.Size(750, 1006);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.TextBox tbcfpassword;
        private System.Windows.Forms.Button btregister;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbwarning_name;
        private System.Windows.Forms.Label lbwarning_password2;
        private System.Windows.Forms.CheckBox cbshow_pass;
        private System.Windows.Forms.Label lbwarning_password3;
        private System.Windows.Forms.Label label4;
    }
}