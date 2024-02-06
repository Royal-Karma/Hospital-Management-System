namespace Hospital_Management_System
{
    partial class Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            pictureBox3 = new PictureBox();
            label1 = new Label();
            DoctorId = new Label();
            DoctorName = new Label();
            DoctorGender = new Label();
            Experience = new Label();
            Licensce = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            AddBtn = new Button();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            ResetBtn = new Button();
            HomeBtn = new Button();
            CrossBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-2, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(142, 125);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(146, 96);
            label1.Name = "label1";
            label1.Size = new Size(91, 29);
            label1.TabIndex = 5;
            label1.Text = "Doctor";
            label1.Click += label1_Click;
            // 
            // DoctorId
            // 
            DoctorId.AutoSize = true;
            DoctorId.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            DoctorId.Location = new Point(12, 188);
            DoctorId.Name = "DoctorId";
            DoctorId.Size = new Size(103, 25);
            DoctorId.TabIndex = 6;
            DoctorId.Text = "Doctor Id";
            // 
            // DoctorName
            // 
            DoctorName.AutoSize = true;
            DoctorName.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            DoctorName.Location = new Point(210, 188);
            DoctorName.Name = "DoctorName";
            DoctorName.Size = new Size(141, 25);
            DoctorName.TabIndex = 7;
            DoctorName.Text = "Doctor Name";
            // 
            // DoctorGender
            // 
            DoctorGender.AutoSize = true;
            DoctorGender.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            DoctorGender.Location = new Point(441, 188);
            DoctorGender.Name = "DoctorGender";
            DoctorGender.Size = new Size(155, 25);
            DoctorGender.TabIndex = 8;
            DoctorGender.Text = "Doctor Gender";
            // 
            // Experience
            // 
            Experience.AutoSize = true;
            Experience.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            Experience.Location = new Point(674, 188);
            Experience.Name = "Experience";
            Experience.Size = new Size(198, 25);
            Experience.TabIndex = 9;
            Experience.Text = "Years of experience";
            // 
            // Licensce
            // 
            Licensce.AutoSize = true;
            Licensce.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            Licensce.Location = new Point(968, 188);
            Licensce.Name = "Licensce";
            Licensce.Size = new Size(255, 25);
            Licensce.TabIndex = 10;
            Licensce.Text = "Medical licensce Number";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DeepSkyBlue;
            textBox1.Location = new Point(12, 228);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 27);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DeepSkyBlue;
            textBox2.Location = new Point(210, 228);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 27);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DeepSkyBlue;
            textBox3.Location = new Point(674, 228);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(198, 27);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DeepSkyBlue;
            textBox4.Location = new Point(968, 228);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(255, 27);
            textBox4.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.DeepSkyBlue;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(445, 228);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DeepSkyBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 281);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1334, 302);
            dataGridView1.TabIndex = 16;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.DeepSkyBlue;
            AddBtn.FlatStyle = FlatStyle.Popup;
            AddBtn.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            AddBtn.Location = new Point(12, 606);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(111, 60);
            AddBtn.TabIndex = 17;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.DeepSkyBlue;
            UpdateBtn.FlatStyle = FlatStyle.Popup;
            UpdateBtn.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            UpdateBtn.Location = new Point(168, 606);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(111, 60);
            UpdateBtn.TabIndex = 18;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.DeepSkyBlue;
            DeleteBtn.FlatStyle = FlatStyle.Popup;
            DeleteBtn.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            DeleteBtn.Location = new Point(327, 606);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(111, 60);
            DeleteBtn.TabIndex = 19;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.DeepSkyBlue;
            ResetBtn.FlatStyle = FlatStyle.Popup;
            ResetBtn.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            ResetBtn.Location = new Point(495, 606);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(111, 60);
            ResetBtn.TabIndex = 20;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // HomeBtn
            // 
            HomeBtn.BackColor = Color.DeepSkyBlue;
            HomeBtn.FlatStyle = FlatStyle.Popup;
            HomeBtn.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            HomeBtn.Location = new Point(643, 606);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(111, 60);
            HomeBtn.TabIndex = 21;
            HomeBtn.Text = "Home";
            HomeBtn.UseVisualStyleBackColor = false;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // CrossBtn
            // 
            CrossBtn.BackColor = Color.DeepSkyBlue;
            CrossBtn.FlatStyle = FlatStyle.Popup;
            CrossBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CrossBtn.Location = new Point(1316, 0);
            CrossBtn.Name = "CrossBtn";
            CrossBtn.Size = new Size(42, 40);
            CrossBtn.TabIndex = 22;
            CrossBtn.Text = "X";
            CrossBtn.UseVisualStyleBackColor = false;
            CrossBtn.Click += CrossBtn_Click;
            // 
            // Doctor
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1358, 678);
            Controls.Add(CrossBtn);
            Controls.Add(HomeBtn);
            Controls.Add(ResetBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Licensce);
            Controls.Add(Experience);
            Controls.Add(DoctorGender);
            Controls.Add(DoctorName);
            Controls.Add(DoctorId);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Doctor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doctor";
            Load += Doctor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private Label label1;
        private Label DoctorId;
        private Label DoctorName;
        private Label DoctorGender;
        private Label Experience;
        private Label Licensce;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button AddBtn;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button ResetBtn;
        private Button HomeBtn;
        private Button CrossBtn;
    }
}