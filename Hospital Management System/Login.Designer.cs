
namespace Hospital_Management_System
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            admin = new RichTextBox();
            label3 = new Label();
            password = new RichTextBox();
            Loginbtn = new Button();
            Clearbtn = new Button();
            CrossBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 108);
            label1.Name = "label1";
            label1.Size = new Size(347, 29);
            label1.TabIndex = 0;
            label1.Text = "Hospital Management System";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hospital;
            pictureBox1.Location = new Point(189, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 305);
            label2.Name = "label2";
            label2.Size = new Size(87, 29);
            label2.TabIndex = 2;
            label2.Text = "Admin";
            // 
            // admin
            // 
            admin.BackColor = Color.DeepSkyBlue;
            admin.Location = new Point(176, 305);
            admin.Name = "admin";
            admin.Size = new Size(255, 29);
            admin.TabIndex = 3;
            admin.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 378);
            label3.Name = "label3";
            label3.Size = new Size(120, 29);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // password
            // 
            password.BackColor = Color.DeepSkyBlue;
            password.Location = new Point(176, 378);
            password.Name = "password";
            password.Size = new Size(255, 29);
            password.TabIndex = 5;
            password.Text = "";
            // 
            // Loginbtn
            // 
            Loginbtn.BackColor = Color.DeepSkyBlue;
            Loginbtn.FlatStyle = FlatStyle.Popup;
            Loginbtn.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            Loginbtn.Location = new Point(176, 442);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(111, 60);
            Loginbtn.TabIndex = 6;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = false;
            Loginbtn.Click += button1_Click;
            // 
            // Clearbtn
            // 
            Clearbtn.BackColor = Color.DeepSkyBlue;
            Clearbtn.FlatStyle = FlatStyle.Popup;
            Clearbtn.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            Clearbtn.Location = new Point(320, 442);
            Clearbtn.Name = "Clearbtn";
            Clearbtn.Size = new Size(111, 60);
            Clearbtn.TabIndex = 7;
            Clearbtn.Text = "Clear";
            Clearbtn.UseVisualStyleBackColor = false;
            Clearbtn.Click += Clearbtn_Click;
            // 
            // CrossBtn
            // 
            CrossBtn.BackColor = Color.DeepSkyBlue;
            CrossBtn.FlatStyle = FlatStyle.Popup;
            CrossBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CrossBtn.Location = new Point(467, 0);
            CrossBtn.Name = "CrossBtn";
            CrossBtn.Size = new Size(42, 40);
            CrossBtn.TabIndex = 8;
            CrossBtn.Text = "X";
            CrossBtn.UseVisualStyleBackColor = false;
            CrossBtn.Click += CrossBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(509, 639);
            Controls.Add(CrossBtn);
            Controls.Add(Clearbtn);
            Controls.Add(Loginbtn);
            Controls.Add(password);
            Controls.Add(label3);
            Controls.Add(admin);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private RichTextBox admin;
        private Label label3;
        private RichTextBox password;
        private Button Loginbtn;
        private Button Clearbtn;
        private Button CrossBtn;
    }
}
