namespace INTRO_USERS
{
    partial class Members
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Members));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginID = new System.Windows.Forms.Label();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.panelAllLoginElements = new System.Windows.Forms.Panel();
            this.panelResults = new System.Windows.Forms.Panel();
            this.lvToys = new System.Windows.Forms.ListView();
            this.toyImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toyDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toyType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.originalCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toyReplCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toyLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelSearch = new System.Windows.Forms.Panel();
            this.bSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbToyCategory = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRating = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbToySearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSortBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.panelAllLoginElements.SuspendLayout();
            this.panelResults.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loginID);
            this.panel1.Controls.Add(this.pbExit);
            this.panel1.Location = new System.Drawing.Point(-1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 30);
            this.panel1.TabIndex = 28;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // loginID
            // 
            this.loginID.AutoSize = true;
            this.loginID.Location = new System.Drawing.Point(22, 5);
            this.loginID.Name = "loginID";
            this.loginID.Size = new System.Drawing.Size(35, 13);
            this.loginID.TabIndex = 31;
            this.loginID.Text = "label7";
            // 
            // pbExit
            // 
            this.pbExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbExit.BackgroundImage")));
            this.pbExit.Location = new System.Drawing.Point(1011, 5);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(30, 25);
            this.pbExit.TabIndex = 30;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // panelAllLoginElements
            // 
            this.panelAllLoginElements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAllLoginElements.Controls.Add(this.panelResults);
            this.panelAllLoginElements.Controls.Add(this.panelSearch);
            this.panelAllLoginElements.Controls.Add(this.panelNavigation);
            this.panelAllLoginElements.Controls.Add(this.panel1);
            this.panelAllLoginElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAllLoginElements.Location = new System.Drawing.Point(0, 0);
            this.panelAllLoginElements.Name = "panelAllLoginElements";
            this.panelAllLoginElements.Size = new System.Drawing.Size(1054, 654);
            this.panelAllLoginElements.TabIndex = 29;
            // 
            // panelResults
            // 
            this.panelResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResults.Controls.Add(this.lvToys);
            this.panelResults.Location = new System.Drawing.Point(213, 111);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(828, 473);
            this.panelResults.TabIndex = 31;
            // 
            // lvToys
            // 
            this.lvToys.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.toyImage,
            this.toyName,
            this.toyDescription,
            this.toyType,
            this.originalCost,
            this.toyReplCost,
            this.toyLocation});
            this.lvToys.GridLines = true;
            this.lvToys.Location = new System.Drawing.Point(-1, -1);
            this.lvToys.Name = "lvToys";
            this.lvToys.Size = new System.Drawing.Size(828, 472);
            this.lvToys.TabIndex = 0;
            this.lvToys.UseCompatibleStateImageBehavior = false;
            this.lvToys.View = System.Windows.Forms.View.Details;
            this.lvToys.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // toyImage
            // 
            this.toyImage.Text = "Image";
            this.toyImage.Width = 70;
            // 
            // toyName
            // 
            this.toyName.Text = "Name";
            // 
            // toyDescription
            // 
            this.toyDescription.Text = "Description";
            // 
            // toyType
            // 
            this.toyType.Text = "Type";
            // 
            // originalCost
            // 
            this.originalCost.Text = "Cost";
            // 
            // toyReplCost
            // 
            this.toyReplCost.Text = "Replacement Cost";
            // 
            // toyLocation
            // 
            this.toyLocation.Text = "Location";
            // 
            // panelSearch
            // 
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.bSearch);
            this.panelSearch.Controls.Add(this.label2);
            this.panelSearch.Controls.Add(this.cbToyCategory);
            this.panelSearch.Controls.Add(this.checkBox1);
            this.panelSearch.Controls.Add(this.label5);
            this.panelSearch.Controls.Add(this.cbRating);
            this.panelSearch.Controls.Add(this.label4);
            this.panelSearch.Controls.Add(this.tbToySearch);
            this.panelSearch.Controls.Add(this.label3);
            this.panelSearch.Controls.Add(this.cbSortBy);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Location = new System.Drawing.Point(212, 39);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(829, 66);
            this.panelSearch.TabIndex = 30;
            this.panelSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSearch_Paint);
            // 
            // bSearch
            // 
            this.bSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bSearch.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearch.Location = new System.Drawing.Point(708, 38);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 23);
            this.bSearch.TabIndex = 15;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = false;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Toy Category";
            // 
            // cbToyCategory
            // 
            this.cbToyCategory.FormattingEnabled = true;
            this.cbToyCategory.Location = new System.Drawing.Point(499, 6);
            this.cbToyCategory.Name = "cbToyCategory";
            this.cbToyCategory.Size = new System.Drawing.Size(121, 21);
            this.cbToyCategory.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(686, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 36);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Show unavailable\r\n          toys";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(174, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rating:";
            // 
            // cbRating
            // 
            this.cbRating.FormattingEnabled = true;
            this.cbRating.Location = new System.Drawing.Point(226, 33);
            this.cbRating.Name = "cbRating";
            this.cbRating.Size = new System.Drawing.Size(121, 21);
            this.cbRating.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name or type:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbToySearch
            // 
            this.tbToySearch.Location = new System.Drawing.Point(226, 6);
            this.tbToySearch.Name = "tbToySearch";
            this.tbToySearch.Size = new System.Drawing.Size(121, 20);
            this.tbToySearch.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(445, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sort by:";
            // 
            // cbSortBy
            // 
            this.cbSortBy.FormattingEnabled = true;
            this.cbSortBy.Location = new System.Drawing.Point(499, 35);
            this.cbSortBy.Name = "cbSortBy";
            this.cbSortBy.Size = new System.Drawing.Size(121, 21);
            this.cbSortBy.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filer Box:";
            // 
            // panelNavigation
            // 
            this.panelNavigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavigation.Controls.Add(this.button4);
            this.panelNavigation.Controls.Add(this.button3);
            this.panelNavigation.Controls.Add(this.button2);
            this.panelNavigation.Controls.Add(this.button1);
            this.panelNavigation.Location = new System.Drawing.Point(3, 39);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(203, 610);
            this.panelNavigation.TabIndex = 29;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(4, 464);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 137);
            this.button4.TabIndex = 3;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(4, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 137);
            this.button3.TabIndex = 2;
            this.button3.Text = "Membership Info";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(4, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 137);
            this.button2.TabIndex = 1;
            this.button2.Text = "Borrowed Toys";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(4, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 137);
            this.button1.TabIndex = 0;
            this.button1.Text = "Toy Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(839, 502);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(198, 121);
            this.listBox1.TabIndex = 27;
            this.listBox1.Visible = false;
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1054, 654);
            this.Controls.Add(this.panelAllLoginElements);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Members";
            this.Text = "Members";
            this.Load += new System.EventHandler(this.Members_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.panelAllLoginElements.ResumeLayout(false);
            this.panelResults.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Panel panelAllLoginElements;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSortBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbRating;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbToySearch;
        private System.Windows.Forms.ListView lvToys;
        private System.Windows.Forms.ColumnHeader toyImage;
        private System.Windows.Forms.ColumnHeader toyDescription;
        private System.Windows.Forms.ColumnHeader toyType;
        private System.Windows.Forms.ColumnHeader originalCost;
        private System.Windows.Forms.ColumnHeader toyReplCost;
        private System.Windows.Forms.ColumnHeader toyLocation;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbToyCategory;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Label loginID;
        private System.Windows.Forms.ColumnHeader toyName;
    }
}