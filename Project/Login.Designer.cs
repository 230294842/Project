namespace Project
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginButton = new FontAwesome.Sharp.IconButton();
            this.registerButton = new System.Windows.Forms.Label();
            this.passText = new System.Windows.Forms.TextBox();
            this.loginText = new System.Windows.Forms.TextBox();
            this.clearButton = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guestLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.guestLogin);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.registerButton);
            this.panel1.Controls.Add(this.passText);
            this.panel1.Controls.Add(this.loginText);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 506);
            this.panel1.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.IconChar = FontAwesome.Sharp.IconChar.Elevator;
            this.loginButton.IconColor = System.Drawing.Color.Black;
            this.loginButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.loginButton.Location = new System.Drawing.Point(233, 282);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(104, 50);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Login";
            this.loginButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.AutoSize = true;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(175, 440);
            this.registerButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(203, 24);
            this.registerButton.TabIndex = 8;
            this.registerButton.Text = "Click here to register";
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(204, 236);
            this.passText.Margin = new System.Windows.Forms.Padding(2);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(188, 20);
            this.passText.TabIndex = 7;
            this.passText.Text = "Enter your password here";
            this.passText.Click += new System.EventHandler(this.passText_Click);
            // 
            // loginText
            // 
            this.loginText.Location = new System.Drawing.Point(204, 188);
            this.loginText.Margin = new System.Windows.Forms.Padding(2);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(188, 20);
            this.loginText.TabIndex = 6;
            this.loginText.Text = "Enter your staff ID here";
            this.loginText.Click += new System.EventHandler(this.loginText_Click);
            // 
            // clearButton
            // 
            this.clearButton.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.clearButton.IconColor = System.Drawing.Color.Black;
            this.clearButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.clearButton.Location = new System.Drawing.Point(233, 345);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(104, 50);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(152, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Project.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guestLogin
            // 
            this.guestLogin.AutoSize = true;
            this.guestLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestLogin.Location = new System.Drawing.Point(151, 406);
            this.guestLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.guestLogin.Name = "guestLogin";
            this.guestLogin.Size = new System.Drawing.Size(263, 24);
            this.guestLogin.TabIndex = 10;
            this.guestLogin.Text = "Click here to login as guest";
            this.guestLogin.Click += new System.EventHandler(this.guestLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 506);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton clearButton;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.Label registerButton;
        private FontAwesome.Sharp.IconButton loginButton;
        private System.Windows.Forms.Label guestLogin;
    }
}