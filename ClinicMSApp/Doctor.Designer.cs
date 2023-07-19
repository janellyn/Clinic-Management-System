namespace ClinicMSApp
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DltBtn = new Button();
            EdtBtn = new Button();
            AddBtn = new Button();
            label3 = new Label();
            DExpTb = new TextBox();
            label2 = new Label();
            DSpecCb = new ComboBox();
            DPhoneTb = new TextBox();
            label16 = new Label();
            DAddTb = new TextBox();
            label9 = new Label();
            DOB = new DateTimePicker();
            DGenCb = new ComboBox();
            DNameTb = new TextBox();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label15 = new Label();
            pictureBox12 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox10 = new PictureBox();
            label14 = new Label();
            label13 = new Label();
            pictureBox1 = new PictureBox();
            DPassTb = new TextBox();
            label4 = new Label();
            DoctorDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DoctorDGV).BeginInit();
            SuspendLayout();
            // 
            // DltBtn
            // 
            DltBtn.BackColor = Color.LightSkyBlue;
            DltBtn.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DltBtn.ForeColor = SystemColors.Window;
            DltBtn.Location = new Point(1304, 218);
            DltBtn.Name = "DltBtn";
            DltBtn.Size = new Size(117, 41);
            DltBtn.TabIndex = 48;
            DltBtn.Text = "Delete";
            DltBtn.UseVisualStyleBackColor = false;
            DltBtn.Click += DltBtn_Click;
            // 
            // EdtBtn
            // 
            EdtBtn.BackColor = Color.LightSkyBlue;
            EdtBtn.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EdtBtn.ForeColor = SystemColors.Window;
            EdtBtn.Location = new Point(1148, 217);
            EdtBtn.Name = "EdtBtn";
            EdtBtn.Size = new Size(117, 41);
            EdtBtn.TabIndex = 47;
            EdtBtn.Text = "Edit";
            EdtBtn.UseVisualStyleBackColor = false;
            EdtBtn.Click += EdtBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.LightSkyBlue;
            AddBtn.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.ForeColor = SystemColors.Window;
            AddBtn.Location = new Point(990, 217);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(117, 41);
            AddBtn.TabIndex = 46;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(548, 181);
            label3.Name = "label3";
            label3.Size = new Size(65, 26);
            label3.TabIndex = 45;
            label3.Text = "DOB";
            // 
            // DExpTb
            // 
            DExpTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DExpTb.Location = new Point(1224, 131);
            DExpTb.Multiline = true;
            DExpTb.Name = "DExpTb";
            DExpTb.Size = new Size(215, 58);
            DExpTb.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(1224, 95);
            label2.Name = "label2";
            label2.Size = new Size(135, 26);
            label2.TabIndex = 42;
            label2.Text = "Experience";
            // 
            // DSpecCb
            // 
            DSpecCb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DSpecCb.FormattingEnabled = true;
            DSpecCb.Items.AddRange(new object[] { "Generalist", "Gynecology", "Urology", "Surgery", "Dermatology" });
            DSpecCb.Location = new Point(743, 131);
            DSpecCb.Name = "DSpecCb";
            DSpecCb.Size = new Size(203, 36);
            DSpecCb.TabIndex = 41;
            DSpecCb.Text = "Specialisation";
            // 
            // DPhoneTb
            // 
            DPhoneTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DPhoneTb.Location = new Point(319, 219);
            DPhoneTb.Name = "DPhoneTb";
            DPhoneTb.Size = new Size(201, 34);
            DPhoneTb.TabIndex = 40;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.DeepSkyBlue;
            label16.Location = new Point(319, 181);
            label16.Name = "label16";
            label16.Size = new Size(81, 26);
            label16.TabIndex = 39;
            label16.Text = "Phone";
            // 
            // DAddTb
            // 
            DAddTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DAddTb.Location = new Point(990, 131);
            DAddTb.Multiline = true;
            DAddTb.Name = "DAddTb";
            DAddTb.Size = new Size(201, 58);
            DAddTb.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.DeepSkyBlue;
            label9.Location = new Point(990, 95);
            label9.Name = "label9";
            label9.Size = new Size(102, 26);
            label9.TabIndex = 37;
            label9.Text = "Address";
            // 
            // DOB
            // 
            DOB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DOB.Location = new Point(548, 219);
            DOB.Name = "DOB";
            DOB.Size = new Size(209, 34);
            DOB.TabIndex = 36;
            // 
            // DGenCb
            // 
            DGenCb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DGenCb.FormattingEnabled = true;
            DGenCb.Items.AddRange(new object[] { "Male ", "Female" });
            DGenCb.Location = new Point(565, 131);
            DGenCb.Name = "DGenCb";
            DGenCb.Size = new Size(137, 36);
            DGenCb.TabIndex = 35;
            DGenCb.Text = "Gender";
            // 
            // DNameTb
            // 
            DNameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DNameTb.Location = new Point(319, 133);
            DNameTb.Name = "DNameTb";
            DNameTb.Size = new Size(201, 34);
            DNameTb.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.DeepSkyBlue;
            label8.Location = new Point(319, 95);
            label8.Name = "label8";
            label8.Size = new Size(158, 26);
            label8.TabIndex = 33;
            label8.Text = "Doctor Name";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1412, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 32;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(773, 29);
            label1.Name = "label1";
            label1.Size = new Size(233, 28);
            label1.TabIndex = 31;
            label1.Text = "Clinics Codespace";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(label15);
            panel1.Controls.Add(pictureBox12);
            panel1.Controls.Add(pictureBox11);
            panel1.Controls.Add(pictureBox10);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 678);
            panel1.TabIndex = 30;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(101, 618);
            label15.Name = "label15";
            label15.Size = new Size(88, 23);
            label15.TabIndex = 16;
            label15.Text = "Log Out";
            label15.Click += label15_Click;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(48, 608);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(43, 43);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 15;
            pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(25, 223);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(66, 66);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 14;
            pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(25, 131);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(66, 66);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 13;
            pictureBox10.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(101, 243);
            label14.Name = "label14";
            label14.Size = new Size(130, 23);
            label14.TabIndex = 10;
            label14.Text = "Receptionist";
            label14.Click += label14_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(101, 147);
            label13.Name = "label13";
            label13.Size = new Size(117, 23);
            label13.TabIndex = 9;
            label13.Text = "Laboratory";
            label13.Click += label13_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(89, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // DPassTb
            // 
            DPassTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DPassTb.Location = new Point(784, 219);
            DPassTb.Name = "DPassTb";
            DPassTb.Size = new Size(162, 34);
            DPassTb.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(784, 181);
            label4.Name = "label4";
            label4.Size = new Size(118, 26);
            label4.TabIndex = 49;
            label4.Text = "Password";
            // 
            // DoctorDGV
            // 
            DoctorDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.NullValue = null;
            DoctorDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            DoctorDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DoctorDGV.BackgroundColor = Color.White;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DoctorDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DoctorDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DoctorDGV.DefaultCellStyle = dataGridViewCellStyle6;
            DoctorDGV.Location = new Point(316, 283);
            DoctorDGV.Name = "DoctorDGV";
            DoctorDGV.RowHeadersWidth = 51;
            DoctorDGV.RowTemplate.Height = 29;
            DoctorDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DoctorDGV.Size = new Size(1123, 368);
            DoctorDGV.TabIndex = 51;
            DoctorDGV.CellContentClick += DoctorDGV_CellContentClick_1;
            // 
            // Doctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1455, 678);
            Controls.Add(DoctorDGV);
            Controls.Add(DPassTb);
            Controls.Add(label4);
            Controls.Add(DltBtn);
            Controls.Add(EdtBtn);
            Controls.Add(AddBtn);
            Controls.Add(label3);
            Controls.Add(DExpTb);
            Controls.Add(label2);
            Controls.Add(DSpecCb);
            Controls.Add(DPhoneTb);
            Controls.Add(label16);
            Controls.Add(DAddTb);
            Controls.Add(label9);
            Controls.Add(DOB);
            Controls.Add(DGenCb);
            Controls.Add(DNameTb);
            Controls.Add(label8);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Doctor";
            Text = "Doctor";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DoctorDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DltBtn;
        private Button EdtBtn;
        private Button AddBtn;
        private Label label3;
        private TextBox DExpTb;
        private Label label2;
        private ComboBox DSpecCb;
        private TextBox DPhoneTb;
        private Label label16;
        private TextBox DAddTb;
        private Label label9;
        private DateTimePicker DOB;
        private ComboBox DGenCb;
        private TextBox DNameTb;
        private Label label8;
        private PictureBox pictureBox3;
        private Label label1;
        private Panel panel1;
        private Label label15;
        private PictureBox pictureBox12;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private Label label14;
        private Label label13;
        private PictureBox pictureBox1;
        private TextBox DPassTb;
        private Label label4;
        private DataGridView DoctorDGV;
    }
}