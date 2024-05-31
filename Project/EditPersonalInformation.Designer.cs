namespace Project
{
    partial class EditPersonalInformation
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.title = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.RichTextBox();
            this.email = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.ageMale = new System.Windows.Forms.RadioButton();
            this.ageFmale = new System.Windows.Forms.RadioButton();
            this.gender = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.age.Location = new System.Drawing.Point(236, 155);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(50, 24);
            this.age.TabIndex = 2;
            this.age.Text = "Age:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(292, 159);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(236, 103);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(240, 20);
            this.title.TabIndex = 4;
            this.title.Text = "Update Personal Information";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(201, 199);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(85, 24);
            this.address.TabIndex = 6;
            this.address.Text = "Address:";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(292, 199);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(207, 102);
            this.addressBox.TabIndex = 7;
            this.addressBox.Text = "Enter your address here.";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(146, 315);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(140, 24);
            this.email.TabIndex = 8;
            this.email.Text = "E-mail address:";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(292, 320);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(288, 20);
            this.emailInput.TabIndex = 9;
            this.emailInput.Text = "Example: user@lm.com";
            this.emailInput.Click += new System.EventHandler(this.emailInput_Click);
            // 
            // ageMale
            // 
            this.ageMale.AutoSize = true;
            this.ageMale.Location = new System.Drawing.Point(292, 399);
            this.ageMale.Name = "ageMale";
            this.ageMale.Size = new System.Drawing.Size(48, 17);
            this.ageMale.TabIndex = 10;
            this.ageMale.TabStop = true;
            this.ageMale.Text = "Male";
            this.ageMale.UseVisualStyleBackColor = true;
            // 
            // ageFmale
            // 
            this.ageFmale.AutoSize = true;
            this.ageFmale.Location = new System.Drawing.Point(346, 399);
            this.ageFmale.Name = "ageFmale";
            this.ageFmale.Size = new System.Drawing.Size(59, 17);
            this.ageFmale.TabIndex = 11;
            this.ageFmale.TabStop = true;
            this.ageFmale.Text = "Female";
            this.ageFmale.UseVisualStyleBackColor = true;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(207, 393);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(79, 24);
            this.gender.TabIndex = 12;
            this.gender.Text = "Gender:";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(144, 355);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(142, 24);
            this.phone.TabIndex = 13;
            this.phone.Text = "Phone number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 360);
            this.textBox1.MaxLength = 8;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(478, 437);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(131, 73);
            this.iconButton1.TabIndex = 15;
            this.iconButton1.Text = "Submit";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // EditPersonalInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 582);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.ageFmale);
            this.Controls.Add(this.ageMale);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.email);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.address);
            this.Controls.Add(this.title);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.age);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditPersonalInformation";
            this.Text = "EditPersonalInformation";
            this.Load += new System.EventHandler(this.EditPersonalInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.RichTextBox addressBox;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.RadioButton ageMale;
        private System.Windows.Forms.RadioButton ageFmale;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

