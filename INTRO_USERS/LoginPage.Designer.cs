namespace INTRO_USERS
{
    partial class LoginPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.bmClear = new System.Windows.Forms.Button();
            this.bMLogin = new System.Windows.Forms.Button();
            this.tbMPassword = new System.Windows.Forms.TextBox();
            this.tbMUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LoginAs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMember = new System.Windows.Forms.Panel();
            this.lMBack = new System.Windows.Forms.Label();
            this.panelLibrarian = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tbLUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLPassword = new System.Windows.Forms.TextBox();
            this.bLCLear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bLLogin = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.bMember = new System.Windows.Forms.Button();
            this.bLibrarian = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelAllLoginElements = new System.Windows.Forms.Panel();
            this.panelMember.SuspendLayout();
            this.panelLibrarian.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.panelAllLoginElements.SuspendLayout();
            this.SuspendLayout();
            // 
            // bmClear
            // 
            this.bmClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmClear.Location = new System.Drawing.Point(106, 181);
            this.bmClear.Name = "bmClear";
            this.bmClear.Size = new System.Drawing.Size(178, 29);
            this.bmClear.TabIndex = 15;
            this.bmClear.Text = "Clear";
            this.bmClear.UseVisualStyleBackColor = true;
            this.bmClear.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // bMLogin
            // 
            this.bMLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMLogin.Location = new System.Drawing.Point(106, 146);
            this.bMLogin.Name = "bMLogin";
            this.bMLogin.Size = new System.Drawing.Size(178, 29);
            this.bMLogin.TabIndex = 13;
            this.bMLogin.Text = "Login";
            this.bMLogin.UseVisualStyleBackColor = true;
            this.bMLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // tbMPassword
            // 
            this.tbMPassword.Location = new System.Drawing.Point(106, 120);
            this.tbMPassword.Name = "tbMPassword";
            this.tbMPassword.Size = new System.Drawing.Size(178, 20);
            this.tbMPassword.TabIndex = 12;
            this.tbMPassword.TextChanged += new System.EventHandler(this.tbMPassword_TextChanged);
            // 
            // tbMUserName
            // 
            this.tbMUserName.Location = new System.Drawing.Point(106, 94);
            this.tbMUserName.Name = "tbMUserName";
            this.tbMUserName.Size = new System.Drawing.Size(178, 20);
            this.tbMUserName.TabIndex = 11;
            this.tbMUserName.TextChanged += new System.EventHandler(this.tbMUserName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(845, 511);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(198, 121);
            this.listBox1.TabIndex = 17;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LoginAs
            // 
            this.LoginAs.AutoSize = true;
            this.LoginAs.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginAs.Location = new System.Drawing.Point(120, 14);
            this.LoginAs.Name = "LoginAs";
            this.LoginAs.Size = new System.Drawing.Size(215, 58);
            this.LoginAs.TabIndex = 19;
            this.LoginAs.Text = "Login As";
            this.LoginAs.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Member Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelMember
            // 
            this.panelMember.Controls.Add(this.lMBack);
            this.panelMember.Controls.Add(this.tbMUserName);
            this.panelMember.Controls.Add(this.label2);
            this.panelMember.Controls.Add(this.label3);
            this.panelMember.Controls.Add(this.tbMPassword);
            this.panelMember.Controls.Add(this.bmClear);
            this.panelMember.Controls.Add(this.label1);
            this.panelMember.Controls.Add(this.bMLogin);
            this.panelMember.Location = new System.Drawing.Point(378, 154);
            this.panelMember.Name = "panelMember";
            this.panelMember.Size = new System.Drawing.Size(332, 261);
            this.panelMember.TabIndex = 20;
            this.panelMember.Visible = false;
            this.panelMember.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMember_Paint);
            // 
            // lMBack
            // 
            this.lMBack.AutoSize = true;
            this.lMBack.Location = new System.Drawing.Point(174, 226);
            this.lMBack.Name = "lMBack";
            this.lMBack.Size = new System.Drawing.Size(32, 13);
            this.lMBack.TabIndex = 16;
            this.lMBack.Text = "Back";
            this.lMBack.Click += new System.EventHandler(this.lMBack_Click);
            // 
            // panelLibrarian
            // 
            this.panelLibrarian.Controls.Add(this.label7);
            this.panelLibrarian.Controls.Add(this.tbLUserName);
            this.panelLibrarian.Controls.Add(this.label4);
            this.panelLibrarian.Controls.Add(this.label5);
            this.panelLibrarian.Controls.Add(this.tbLPassword);
            this.panelLibrarian.Controls.Add(this.bLCLear);
            this.panelLibrarian.Controls.Add(this.label6);
            this.panelLibrarian.Controls.Add(this.bLLogin);
            this.panelLibrarian.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLibrarian.Location = new System.Drawing.Point(381, 154);
            this.panelLibrarian.Name = "panelLibrarian";
            this.panelLibrarian.Size = new System.Drawing.Size(332, 261);
            this.panelLibrarian.TabIndex = 21;
            this.panelLibrarian.Visible = false;
            this.panelLibrarian.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLibrarian_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Back";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tbLUserName
            // 
            this.tbLUserName.Location = new System.Drawing.Point(106, 94);
            this.tbLUserName.Name = "tbLUserName";
            this.tbLUserName.Size = new System.Drawing.Size(178, 21);
            this.tbLUserName.TabIndex = 11;
            this.tbLUserName.TextChanged += new System.EventHandler(this.tbLUserName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Username:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // tbLPassword
            // 
            this.tbLPassword.Location = new System.Drawing.Point(106, 120);
            this.tbLPassword.Name = "tbLPassword";
            this.tbLPassword.Size = new System.Drawing.Size(178, 21);
            this.tbLPassword.TabIndex = 12;
            this.tbLPassword.TextChanged += new System.EventHandler(this.tbLPassword_TextChanged);
            // 
            // bLCLear
            // 
            this.bLCLear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLCLear.Location = new System.Drawing.Point(106, 181);
            this.bLCLear.Name = "bLCLear";
            this.bLCLear.Size = new System.Drawing.Size(178, 29);
            this.bLCLear.TabIndex = 15;
            this.bLCLear.Text = "Clear";
            this.bLCLear.UseVisualStyleBackColor = true;
            this.bLCLear.Click += new System.EventHandler(this.bLCLear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 42);
            this.label6.TabIndex = 8;
            this.label6.Text = "Librarian Login";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // bLLogin
            // 
            this.bLLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLLogin.Location = new System.Drawing.Point(106, 146);
            this.bLLogin.Name = "bLLogin";
            this.bLLogin.Size = new System.Drawing.Size(178, 29);
            this.bLLogin.TabIndex = 13;
            this.bLLogin.Text = "Login";
            this.bLLogin.UseVisualStyleBackColor = true;
            this.bLLogin.Click += new System.EventHandler(this.bLLogin_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.bMember);
            this.panelLogin.Controls.Add(this.bLibrarian);
            this.panelLogin.Controls.Add(this.LoginAs);
            this.panelLogin.Location = new System.Drawing.Point(304, 144);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(446, 336);
            this.panelLogin.TabIndex = 22;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
            // 
            // bMember
            // 
            this.bMember.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bMember.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMember.Location = new System.Drawing.Point(257, 136);
            this.bMember.Name = "bMember";
            this.bMember.Size = new System.Drawing.Size(133, 114);
            this.bMember.TabIndex = 0;
            this.bMember.Text = "Member";
            this.bMember.UseVisualStyleBackColor = false;
            this.bMember.Click += new System.EventHandler(this.bMember_Click);
            // 
            // bLibrarian
            // 
            this.bLibrarian.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bLibrarian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLibrarian.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLibrarian.Location = new System.Drawing.Point(65, 136);
            this.bLibrarian.Name = "bLibrarian";
            this.bLibrarian.Size = new System.Drawing.Size(133, 114);
            this.bLibrarian.TabIndex = 0;
            this.bLibrarian.Text = "Librarian";
            this.bLibrarian.UseVisualStyleBackColor = false;
            this.bLibrarian.Click += new System.EventHandler(this.bLibrarian_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbExit);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 30);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pbExit
            // 
            this.pbExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbExit.BackgroundImage")));
            this.pbExit.Location = new System.Drawing.Point(1011, 5);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(30, 25);
            this.pbExit.TabIndex = 26;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panelAllLoginElements
            // 
            this.panelAllLoginElements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAllLoginElements.Controls.Add(this.panelLogin);
            this.panelAllLoginElements.Controls.Add(this.panelMember);
            this.panelAllLoginElements.Controls.Add(this.panelLibrarian);
            this.panelAllLoginElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAllLoginElements.Location = new System.Drawing.Point(0, 0);
            this.panelAllLoginElements.Name = "panelAllLoginElements";
            this.panelAllLoginElements.Size = new System.Drawing.Size(1054, 654);
            this.panelAllLoginElements.TabIndex = 26;
            this.panelAllLoginElements.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAllLoginElements_Paint);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1054, 654);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panelAllLoginElements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panelMember.ResumeLayout(false);
            this.panelMember.PerformLayout();
            this.panelLibrarian.ResumeLayout(false);
            this.panelLibrarian.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.panelAllLoginElements.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bmClear;
        private System.Windows.Forms.Button bMLogin;
        private System.Windows.Forms.TextBox tbMPassword;
        private System.Windows.Forms.TextBox tbMUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label LoginAs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMember;
        private System.Windows.Forms.Panel panelLibrarian;
        private System.Windows.Forms.TextBox tbLUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLPassword;
        private System.Windows.Forms.Button bLCLear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bLLogin;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button bMember;
        private System.Windows.Forms.Button bLibrarian;
        private System.Windows.Forms.Label lMBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.PictureBox pbExit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelAllLoginElements;
    }
}

