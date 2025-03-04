namespace Araç
{
    partial class Loginpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginpage));
            label1 = new Label();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            checkBox1 = new CheckBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 14.25F);
            label1.Location = new Point(12, 235);
            label1.Name = "label1";
            label1.Size = new Size(169, 23);
            label1.TabIndex = 0;
            label1.Text = "TC Kimlik Numarası:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Corbel", 14.25F);
            textBox1.Location = new Point(187, 263);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 31);
            textBox1.TabIndex = 1;
            textBox1.UseSystemPasswordChar = true;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Corbel", 14.25F);
            maskedTextBox1.Location = new Point(187, 224);
            maskedTextBox1.Margin = new Padding(3, 4, 3, 4);
            maskedTextBox1.Mask = "99999999999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(214, 31);
            maskedTextBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 14.25F);
            label2.Location = new Point(131, 266);
            label2.Name = "label2";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 3;
            label2.Text = "Şifre:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(913, 201);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Location = new Point(0, 511);
            panel2.Name = "panel2";
            panel2.Size = new Size(913, 30);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(287, 329);
            button1.Name = "button1";
            button1.Size = new Size(114, 45);
            button1.TabIndex = 0;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            checkBox1.Location = new Point(407, 267);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(160, 27);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Şifremi Unuttum";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("ROG Fonts", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 70);
            label3.Name = "label3";
            label3.Size = new Size(569, 38);
            label3.TabIndex = 7;
            label3.Text = "Online Ders Giris Paneli";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(643, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Loginpage
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 540);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Corbel", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Loginpage";
            Text = "Kullanıcı Giriş Paneli";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private CheckBox checkBox1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}