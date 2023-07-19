namespace ClinicMSApp
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label15 = new Label();
            pictureBox12 = new PictureBox();
            pictureBox1 = new PictureBox();
            PatName = new TextBox();
            label8 = new Label();
            PatGen = new ComboBox();
            PatDOB = new DateTimePicker();
            PatAdd = new TextBox();
            label9 = new Label();
            PatHIV = new ComboBox();
            PatPhone = new TextBox();
            label16 = new Label();
            PatAll = new TextBox();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label3 = new Label();
            AddBtn = new Button();
            EdtBtn = new Button();
            DltBtn = new Button();
            PatientDGV = new DataGridView();
            pictureBox11 = new PictureBox();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PatientDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1398, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(760, 29);
            label1.Name = "label1";
            label1.Size = new Size(233, 28);
            label1.TabIndex = 10;
            label1.Text = "Clinics Codespace";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(pictureBox11);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(pictureBox12);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 683);
            panel1.TabIndex = 9;
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
            // PatName
            // 
            PatName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PatName.Location = new Point(306, 133);
            PatName.Name = "PatName";
            PatName.Size = new Size(201, 34);
            PatName.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.DeepSkyBlue;
            label8.Location = new Point(306, 95);
            label8.Name = "label8";
            label8.Size = new Size(162, 26);
            label8.TabIndex = 14;
            label8.Text = "Patient Name";
            // 
            // PatGen
            // 
            PatGen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PatGen.FormattingEnabled = true;
            PatGen.Items.AddRange(new object[] { "Male ", "Female" });
            PatGen.Location = new Point(543, 131);
            PatGen.Name = "PatGen";
            PatGen.Size = new Size(137, 36);
            PatGen.TabIndex = 16;
            PatGen.Text = "Gender";
            // 
            // PatDOB
            // 
            PatDOB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PatDOB.Location = new Point(600, 217);
            PatDOB.Name = "PatDOB";
            PatDOB.Size = new Size(195, 34);
            PatDOB.TabIndex = 17;
            // 
            // PatAdd
            // 
            PatAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PatAdd.Location = new Point(907, 131);
            PatAdd.Multiline = true;
            PatAdd.Name = "PatAdd";
            PatAdd.Size = new Size(227, 58);
            PatAdd.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.DeepSkyBlue;
            label9.Location = new Point(907, 95);
            label9.Name = "label9";
            label9.Size = new Size(102, 26);
            label9.TabIndex = 18;
            label9.Text = "Address";
            // 
            // PatHIV
            // 
            PatHIV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PatHIV.FormattingEnabled = true;
            PatHIV.Items.AddRange(new object[] { "Positive", "Negative" });
            PatHIV.Location = new Point(711, 130);
            PatHIV.Name = "PatHIV";
            PatHIV.Size = new Size(137, 36);
            PatHIV.TabIndex = 22;
            PatHIV.Text = "HIV";
            // 
            // PatPhone
            // 
            PatPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PatPhone.Location = new Point(306, 219);
            PatPhone.Name = "PatPhone";
            PatPhone.Size = new Size(201, 34);
            PatPhone.TabIndex = 21;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.DeepSkyBlue;
            label16.Location = new Point(306, 181);
            label16.Name = "label16";
            label16.Size = new Size(81, 26);
            label16.TabIndex = 20;
            label16.Text = "Phone";
            // 
            // PatAll
            // 
            PatAll.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PatAll.Location = new Point(1179, 131);
            PatAll.Multiline = true;
            PatAll.Name = "PatAll";
            PatAll.Size = new Size(215, 58);
            PatAll.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(1179, 95);
            label2.Name = "label2";
            label2.Size = new Size(107, 26);
            label2.TabIndex = 23;
            label2.Text = "Allergies";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(599, 181);
            label3.Name = "label3";
            label3.Size = new Size(65, 26);
            label3.TabIndex = 26;
            label3.Text = "DOB";
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.LightSkyBlue;
            AddBtn.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.ForeColor = SystemColors.Window;
            AddBtn.Location = new Point(936, 217);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(117, 41);
            AddBtn.TabIndex = 27;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // EdtBtn
            // 
            EdtBtn.BackColor = Color.LightSkyBlue;
            EdtBtn.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EdtBtn.ForeColor = SystemColors.Window;
            EdtBtn.Location = new Point(1094, 217);
            EdtBtn.Name = "EdtBtn";
            EdtBtn.Size = new Size(117, 41);
            EdtBtn.TabIndex = 28;
            EdtBtn.Text = "Edit";
            EdtBtn.UseVisualStyleBackColor = false;
            EdtBtn.Click += EdtBtn_Click;
            // 
            // DltBtn
            // 
            DltBtn.BackColor = Color.LightSkyBlue;
            DltBtn.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DltBtn.ForeColor = SystemColors.Window;
            DltBtn.Location = new Point(1250, 218);
            DltBtn.Name = "DltBtn";
            DltBtn.Size = new Size(117, 41);
            DltBtn.TabIndex = 29;
            DltBtn.Text = "Delete";
            DltBtn.UseVisualStyleBackColor = false;
            DltBtn.Click += DltBtn_Click;
            // 
            // PatientDGV
            // 
            PatientDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.NullValue = null;
            PatientDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            PatientDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PatientDGV.BackgroundColor = Color.White;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            PatientDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            PatientDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            PatientDGV.DefaultCellStyle = dataGridViewCellStyle6;
            PatientDGV.Location = new Point(306, 283);
            PatientDGV.Name = "PatientDGV";
            PatientDGV.RowHeadersWidth = 51;
            PatientDGV.RowTemplate.Height = 29;
            PatientDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PatientDGV.Size = new Size(1123, 368);
            PatientDGV.TabIndex = 52;
            PatientDGV.CellContentClick += PatientDGV_CellContentClick;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(38, 141);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(66, 66);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 18;
            pictureBox11.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(114, 161);
            label14.Name = "label14";
            label14.Size = new Size(76, 23);
            label14.TabIndex = 17;
            label14.Text = "Homes";
            label14.Click += label14_Click;
            // 
            // Patient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1441, 683);
            Controls.Add(PatientDGV);
            Controls.Add(DltBtn);
            Controls.Add(EdtBtn);
            Controls.Add(AddBtn);
            Controls.Add(label3);
            Controls.Add(PatAll);
            Controls.Add(label2);
            Controls.Add(PatHIV);
            Controls.Add(PatPhone);
            Controls.Add(label16);
            Controls.Add(PatAdd);
            Controls.Add(label9);
            Controls.Add(PatDOB);
            Controls.Add(PatGen);
            Controls.Add(PatName);
            Controls.Add(label8);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Patient";
            Text = "Patient";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PatientDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox3;
        private Label label1;
        private Panel panel1;
        private Label label15;
        private PictureBox pictureBox12;
        private PictureBox pictureBox1;
        private TextBox PatName;
        private Label label8;
        private ComboBox PatGen;
        private DateTimePicker PatDOB;
        private TextBox PatAdd;
        private Label label9;
        private ComboBox PatHIV;
        private TextBox PatPhone;
        private Label label16;
        private TextBox PatAll;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label3;
        private Button AddBtn;
        private Button EdtBtn;
        private Button DltBtn;
        private DataGridView PatientDGV;
        private PictureBox pictureBox11;
        private Label label14;
    }
}