namespace Hospital_Management_System
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            DocBtn = new Button();
            PatientBtn = new Button();
            LogoutBtn = new Button();
            CrossBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(148, 95);
            label1.Name = "label1";
            label1.Size = new Size(81, 29);
            label1.TabIndex = 1;
            label1.Text = "Home";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(476, 61);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(142, 125);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(476, 448);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(142, 125);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(476, 238);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(142, 125);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // DocBtn
            // 
            DocBtn.BackColor = Color.DeepSkyBlue;
            DocBtn.FlatStyle = FlatStyle.Popup;
            DocBtn.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            DocBtn.Location = new Point(654, 79);
            DocBtn.Name = "DocBtn";
            DocBtn.Size = new Size(157, 60);
            DocBtn.TabIndex = 7;
            DocBtn.Text = "Doctor";
            DocBtn.UseVisualStyleBackColor = false;
            DocBtn.Click += DocBtn_Click;
            // 
            // PatientBtn
            // 
            PatientBtn.BackColor = Color.DeepSkyBlue;
            PatientBtn.FlatStyle = FlatStyle.Popup;
            PatientBtn.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            PatientBtn.Location = new Point(654, 274);
            PatientBtn.Name = "PatientBtn";
            PatientBtn.Size = new Size(157, 60);
            PatientBtn.TabIndex = 8;
            PatientBtn.Text = "Patient";
            PatientBtn.UseVisualStyleBackColor = false;
            PatientBtn.Click += PatientBtn_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.DeepSkyBlue;
            LogoutBtn.FlatStyle = FlatStyle.Popup;
            LogoutBtn.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            LogoutBtn.Location = new Point(654, 484);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(157, 60);
            LogoutBtn.TabIndex = 10;
            LogoutBtn.Text = "Log out";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // CrossBtn
            // 
            CrossBtn.BackColor = Color.DeepSkyBlue;
            CrossBtn.FlatStyle = FlatStyle.Popup;
            CrossBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CrossBtn.Location = new Point(1337, -1);
            CrossBtn.Name = "CrossBtn";
            CrossBtn.Size = new Size(42, 40);
            CrossBtn.TabIndex = 11;
            CrossBtn.Text = "X";
            CrossBtn.UseVisualStyleBackColor = false;
            CrossBtn.Click += CrossBtn_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1376, 725);
            Controls.Add(CrossBtn);
            Controls.Add(LogoutBtn);
            Controls.Add(PatientBtn);
            Controls.Add(DocBtn);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button DocBtn;
        private Button PatientBtn;
        private Button LogoutBtn;
        private Button CrossBtn;
    }
}