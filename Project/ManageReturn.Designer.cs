namespace Project
{
    partial class ManageReturn
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.age = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.orderID = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(269, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(233, 235);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(111, 24);
            this.age.TabIndex = 2;
            this.age.Text = "Return item:";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(298, 105);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(126, 20);
            this.title.TabIndex = 4;
            this.title.Text = "Manage return";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(234, 197);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(110, 24);
            this.email.TabIndex = 8;
            this.email.Text = "Waybill info:";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(350, 202);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(199, 20);
            this.emailInput.TabIndex = 9;
            this.emailInput.Text = "Enter the tracking number here.";
            this.emailInput.Click += new System.EventHandler(this.emailInput_Click);
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(258, 153);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(86, 24);
            this.phone.TabIndex = 13;
            this.phone.Text = "Order ID:";
            // 
            // orderID
            // 
            this.orderID.Location = new System.Drawing.Point(350, 158);
            this.orderID.MaxLength = 8;
            this.orderID.Name = "orderID";
            this.orderID.Size = new System.Drawing.Size(100, 20);
            this.orderID.TabIndex = 14;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(562, 364);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(131, 73);
            this.iconButton1.TabIndex = 15;
            this.iconButton1.Text = "Submit";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Engine parts",
            "Titanium exhaust"});
            this.listBox1.Location = new System.Drawing.Point(350, 237);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 56);
            this.listBox1.TabIndex = 16;
            // 
            // ManageReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 462);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.orderID);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.email);
            this.Controls.Add(this.title);
            this.Controls.Add(this.age);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageReturn";
            this.Text = "ManageReturn";
            this.Load += new System.EventHandler(this.ManageReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox orderID;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

