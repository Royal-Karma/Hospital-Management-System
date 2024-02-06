namespace Hospital_Management_System
{
    partial class Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            pictureBox5 = new PictureBox();
            label1 = new Label();
            DoctorId = new Label();
            textBox1 = new TextBox();
            DoctorName = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
            label7 = new Label();
            textBox6 = new TextBox();
            AddBtn = new Button();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            ResetBtn = new Button();
            HomeBtn = new Button();
            dataGridView2 = new DataGridView();
            CrossBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(-2, -1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(142, 125);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(146, 95);
            label1.Name = "label1";
            label1.Size = new Size(91, 29);
            label1.TabIndex = 7;
            label1.Text = "Patient";
            // 
            // DoctorId
            // 
            DoctorId.AutoSize = true;
            DoctorId.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            DoctorId.Location = new Point(12, 212);
            DoctorId.Name = "DoctorId";
            DoctorId.Size = new Size(106, 25);
            DoctorId.TabIndex = 8;
            DoctorId.Text = "Patient Id";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DeepSkyBlue;
            textBox1.Location = new Point(188, 210);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 27);
            textBox1.TabIndex = 12;
            // 
            // DoctorName
            // 
            DoctorName.AutoSize = true;
            DoctorName.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            DoctorName.Location = new Point(12, 260);
            DoctorName.Name = "DoctorName";
            DoctorName.Size = new Size(144, 25);
            DoctorName.TabIndex = 13;
            DoctorName.Text = "Patient Name";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DeepSkyBlue;
            textBox2.Location = new Point(188, 258);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 27);
            textBox2.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 309);
            label2.Name = "label2";
            label2.Size = new Size(164, 25);
            label2.TabIndex = 15;
            label2.Text = "Patient Address";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DeepSkyBlue;
            textBox3.Location = new Point(188, 307);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(218, 27);
            textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DeepSkyBlue;
            textBox4.Location = new Point(188, 360);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(218, 27);
            textBox4.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 362);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 18;
            label3.Text = "Patient Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            label4.Location = new Point(655, 212);
            label4.Name = "label4";
            label4.Size = new Size(150, 25);
            label4.TabIndex = 19;
            label4.Text = "Patient Phone";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.DeepSkyBlue;
            textBox5.Location = new Point(826, 213);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(218, 27);
            textBox5.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            label5.Location = new Point(655, 260);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 21;
            label5.Text = "Gender";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.DeepSkyBlue;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(826, 261);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 28);
            comboBox1.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            label6.Location = new Point(655, 309);
            label6.Name = "label6";
            label6.Size = new Size(132, 25);
            label6.TabIndex = 23;
            label6.Text = "BloodGroup";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.DeepSkyBlue;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "A+", "B+", "O+", "A-", "B-", "O-", "AB+", "AB-" });
            comboBox2.Location = new Point(826, 306);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(218, 28);
            comboBox2.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            label7.Location = new Point(655, 359);
            label7.Name = "label7";
            label7.Size = new Size(147, 25);
            label7.TabIndex = 25;
            label7.Text = "Major Disease";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.DeepSkyBlue;
            textBox6.Location = new Point(826, 357);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(218, 27);
            textBox6.TabIndex = 26;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.DeepSkyBlue;
            AddBtn.FlatStyle = FlatStyle.Popup;
            AddBtn.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            AddBtn.Location = new Point(1284, 177);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(111, 60);
            AddBtn.TabIndex = 27;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.DeepSkyBlue;
            UpdateBtn.FlatStyle = FlatStyle.Popup;
            UpdateBtn.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            UpdateBtn.Location = new Point(1284, 258);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(111, 60);
            UpdateBtn.TabIndex = 28;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.DeepSkyBlue;
            DeleteBtn.FlatStyle = FlatStyle.Popup;
            DeleteBtn.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            DeleteBtn.Location = new Point(1284, 337);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(111, 60);
            DeleteBtn.TabIndex = 29;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.DeepSkyBlue;
            ResetBtn.FlatStyle = FlatStyle.Popup;
            ResetBtn.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            ResetBtn.Location = new Point(1284, 413);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(111, 60);
            ResetBtn.TabIndex = 30;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // HomeBtn
            // 
            HomeBtn.BackColor = Color.DeepSkyBlue;
            HomeBtn.FlatStyle = FlatStyle.Popup;
            HomeBtn.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            HomeBtn.Location = new Point(1284, 489);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(111, 60);
            HomeBtn.TabIndex = 31;
            HomeBtn.Text = "Home";
            HomeBtn.UseVisualStyleBackColor = false;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.DeepSkyBlue;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 413);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1218, 282);
            dataGridView2.TabIndex = 32;
            dataGridView2.DoubleClick += dataGridView2_DoubleClick;
            // 
            // CrossBtn
            // 
            CrossBtn.BackColor = Color.DeepSkyBlue;
            CrossBtn.FlatStyle = FlatStyle.Popup;
            CrossBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CrossBtn.Location = new Point(1366, -1);
            CrossBtn.Name = "CrossBtn";
            CrossBtn.Size = new Size(42, 40);
            CrossBtn.TabIndex = 33;
            CrossBtn.Text = "X";
            CrossBtn.UseVisualStyleBackColor = false;
            CrossBtn.Click += CrossBtn_Click;
            // 
            // Patient
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1407, 713);
            Controls.Add(CrossBtn);
            Controls.Add(dataGridView2);
            Controls.Add(HomeBtn);
            Controls.Add(ResetBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(DoctorName);
            Controls.Add(textBox1);
            Controls.Add(DoctorId);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Patient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient";
            Load += Patient_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox5;
        private Label label1;
        private Label DoctorId;
        private TextBox textBox1;
        private Label DoctorName;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private ComboBox comboBox2;
        private Label label7;
        private TextBox textBox6;
        private Button AddBtn;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button ResetBtn;
        private Button HomeBtn;
        private DataGridView dataGridView2;
        private Button CrossBtn;
    }
}