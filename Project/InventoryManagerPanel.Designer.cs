namespace Project
{
    partial class InventoryManagerPanel
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
            this.menu = new System.Windows.Forms.Panel();
            this.logoutButton = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.purchaseButton = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.Label();
            this.generateReportBtn = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuButton = new FontAwesome.Sharp.IconButton();
            this.title = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editPersonalInfoButton = new System.Windows.Forms.Button();
            this.showPersonalInfoButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.loginTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.staffPic = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.title.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menu.Controls.Add(this.logoutButton);
            this.menu.Controls.Add(this.iconButton3);
            this.menu.Controls.Add(this.iconButton4);
            this.menu.Controls.Add(this.purchaseButton);
            this.menu.Controls.Add(this.iconButton2);
            this.menu.Controls.Add(this.iconButton1);
            this.menu.Controls.Add(this.label2);
            this.menu.Controls.Add(this.dateTime);
            this.menu.Controls.Add(this.generateReportBtn);
            this.menu.Controls.Add(this.panel2);
            this.menu.Controls.Add(this.menuButton);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Margin = new System.Windows.Forms.Padding(2);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(172, 658);
            this.menu.TabIndex = 0;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.logoutButton.IconChar = FontAwesome.Sharp.IconChar.Wheelchair;
            this.logoutButton.IconColor = System.Drawing.Color.Black;
            this.logoutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(7, 543);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(100, 49);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutButton.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(7, 426);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(159, 51);
            this.iconButton3.TabIndex = 5;
            this.iconButton3.Text = "Generate receipt";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(7, 369);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(159, 51);
            this.iconButton4.TabIndex = 6;
            this.iconButton4.Text = "Update product";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // purchaseButton
            // 
            this.purchaseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.purchaseButton.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.purchaseButton.IconColor = System.Drawing.Color.Black;
            this.purchaseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.purchaseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.purchaseButton.Location = new System.Drawing.Point(7, 312);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(159, 51);
            this.purchaseButton.TabIndex = 5;
            this.purchaseButton.Text = "Add product";
            this.purchaseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.purchaseButton.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Microscope;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(7, 255);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(159, 51);
            this.iconButton2.TabIndex = 6;
            this.iconButton2.Text = "Orders";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(7, 198);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(159, 51);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Inventory status";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 610);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current time:";
            // 
            // dateTime
            // 
            this.dateTime.AutoSize = true;
            this.dateTime.Location = new System.Drawing.Point(12, 632);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(35, 13);
            this.dateTime.TabIndex = 0;
            this.dateTime.Text = "label2";
            // 
            // generateReportBtn
            // 
            this.generateReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.generateReportBtn.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.generateReportBtn.IconColor = System.Drawing.Color.Black;
            this.generateReportBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.generateReportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generateReportBtn.Location = new System.Drawing.Point(7, 141);
            this.generateReportBtn.Name = "generateReportBtn";
            this.generateReportBtn.Size = new System.Drawing.Size(159, 51);
            this.generateReportBtn.TabIndex = 2;
            this.generateReportBtn.Text = "Generate report";
            this.generateReportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.generateReportBtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 81);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuButton.IconChar = FontAwesome.Sharp.IconChar.House;
            this.menuButton.IconColor = System.Drawing.Color.Black;
            this.menuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButton.Location = new System.Drawing.Point(7, 84);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(159, 51);
            this.menuButton.TabIndex = 3;
            this.menuButton.Text = "Menu";
            this.menuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menuButton.UseVisualStyleBackColor = false;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Gray;
            this.title.Controls.Add(this.label1);
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Location = new System.Drawing.Point(172, 0);
            this.title.Margin = new System.Windows.Forms.Padding(2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1065, 65);
            this.title.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Legend Motor Limited - Genesis system";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.editPersonalInfoButton);
            this.panel1.Controls.Add(this.showPersonalInfoButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.loginTime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.position);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.staffPic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(172, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 593);
            this.panel1.TabIndex = 2;
            // 
            // editPersonalInfoButton
            // 
            this.editPersonalInfoButton.Location = new System.Drawing.Point(270, 211);
            this.editPersonalInfoButton.Name = "editPersonalInfoButton";
            this.editPersonalInfoButton.Size = new System.Drawing.Size(196, 43);
            this.editPersonalInfoButton.TabIndex = 6;
            this.editPersonalInfoButton.Text = "Edit personal information";
            this.editPersonalInfoButton.UseVisualStyleBackColor = true;
            this.editPersonalInfoButton.Click += new System.EventHandler(this.editPersonalInfoButton_Click);
            // 
            // showPersonalInfoButton
            // 
            this.showPersonalInfoButton.Location = new System.Drawing.Point(68, 211);
            this.showPersonalInfoButton.Name = "showPersonalInfoButton";
            this.showPersonalInfoButton.Size = new System.Drawing.Size(196, 43);
            this.showPersonalInfoButton.TabIndex = 5;
            this.showPersonalInfoButton.Text = "Show personal information";
            this.showPersonalInfoButton.UseVisualStyleBackColor = true;
            this.showPersonalInfoButton.Click += new System.EventHandler(this.showPersonalInfoButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(64, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(307, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Branch: IVE - Shatin warehouse";
            // 
            // loginTime
            // 
            this.loginTime.AutoSize = true;
            this.loginTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.loginTime.Location = new System.Drawing.Point(170, 161);
            this.loginTime.Name = "loginTime";
            this.loginTime.Size = new System.Drawing.Size(288, 24);
            this.loginTime.TabIndex = 4;
            this.loginTime.Text = "{ignore me, it\'s date and time}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(64, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Login time: ";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.Location = new System.Drawing.Point(64, 133);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(269, 24);
            this.position.TabIndex = 2;
            this.position.Text = "Position: Inventory manager";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Welcome! Nicola Wong";
            // 
            // staffPic
            // 
            this.staffPic.BackgroundImage = global::Project.Properties.Resources._360_F_428116625_7bpn1ZTdPnM2iYZgWUsqGIE5pvhUpGYn;
            this.staffPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.staffPic.Enabled = false;
            this.staffPic.Location = new System.Drawing.Point(758, 26);
            this.staffPic.Name = "staffPic";
            this.staffPic.Size = new System.Drawing.Size(270, 265);
            this.staffPic.TabIndex = 0;
            this.staffPic.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Generate report";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // InventoryManagerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.menu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "InventoryManagerPanel";
            this.Text = " Profile [Inventory manager]";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton generateReportBtn;
        private FontAwesome.Sharp.IconButton menuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Button staffPic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label loginTime;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton purchaseButton;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton logoutButton;
        private System.Windows.Forms.Button showPersonalInfoButton;
        private System.Windows.Forms.Button editPersonalInfoButton;
        private System.Windows.Forms.Button button1;
    }
}

