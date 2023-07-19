namespace ClinicMSApp
{
    partial class Receptionist
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receptionist));
            ReceptionistDGV = new DataGridView();
            RPhoneTb = new TextBox();
            label16 = new Label();
            RNameTb = new TextBox();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label15 = new Label();
            pictureBox12 = new PictureBox();
            pictureBox11 = new PictureBox();
            label14 = new Label();
            pictureBox1 = new PictureBox();
            RPasswordTb = new TextBox();
            label4 = new Label();
            RAddressTb = new TextBox();
            label9 = new Label();
            DltBtn = new Button();
            EdBtn = new Button();
            AddBtn = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)ReceptionistDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ReceptionistDGV
            // 
            ReceptionistDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.NullValue = null;
            ReceptionistDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ReceptionistDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ReceptionistDGV.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ReceptionistDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ReceptionistDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ReceptionistDGV.DefaultCellStyle = dataGridViewCellStyle3;
            ReceptionistDGV.Location = new Point(312, 303);
            ReceptionistDGV.Name = "ReceptionistDGV";
            ReceptionistDGV.RowHeadersWidth = 51;
            ReceptionistDGV.RowTemplate.Height = 29;
            ReceptionistDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ReceptionistDGV.Size = new Size(1123, 368);
            ReceptionistDGV.TabIndex = 44;
            ReceptionistDGV.CellContentClick += ReceptionistDGV_CellContentClick;
            // 
            // RPhoneTb
            // 
            RPhoneTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RPhoneTb.Location = new Point(583, 163);
            RPhoneTb.Name = "RPhoneTb";
            RPhoneTb.Size = new Size(201, 34);
            RPhoneTb.TabIndex = 40;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.DeepSkyBlue;
            label16.Location = new Point(583, 125);
            label16.Name = "label16";
            label16.Size = new Size(81, 26);
            label16.TabIndex = 39;
            label16.Text = "Phone";
            // 
            // RNameTb
            // 
            RNameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RNameTb.Location = new Point(315, 163);
            RNameTb.Name = "RNameTb";
            RNameTb.Size = new Size(201, 34);
            RNameTb.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.DeepSkyBlue;
            label8.Location = new Point(315, 125);
            label8.Name = "label8";
            label8.Size = new Size(76, 26);
            label8.TabIndex = 33;
            label8.Text = "Name";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1404, 12);
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
            label1.Location = new Point(775, 29);
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
            panel1.Controls.Add(label14);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 683);
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
            pictureBox11.Location = new Point(37, 161);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(66, 66);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 14;
            pictureBox11.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(113, 181);
            label14.Name = "label14";
            label14.Size = new Size(76, 23);
            label14.TabIndex = 10;
            label14.Text = "Homes";
            label14.Click += label14_Click;
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
            // RPasswordTb
            // 
            RPasswordTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RPasswordTb.Location = new Point(856, 163);
            RPasswordTb.Name = "RPasswordTb";
            RPasswordTb.Size = new Size(162, 34);
            RPasswordTb.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(856, 125);
            label4.Name = "label4";
            label4.Size = new Size(118, 26);
            label4.TabIndex = 51;
            label4.Text = "Password";
            // 
            // RAddressTb
            // 
            RAddressTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RAddressTb.Location = new Point(1082, 161);
            RAddressTb.Multiline = true;
            RAddressTb.Name = "RAddressTb";
            RAddressTb.Size = new Size(322, 36);
            RAddressTb.TabIndex = 54;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.DeepSkyBlue;
            label9.Location = new Point(1082, 125);
            label9.Name = "label9";
            label9.Size = new Size(102, 26);
            label9.TabIndex = 53;
            label9.Text = "Address";
            // 
            // DltBtn
            // 
            DltBtn.BackColor = Color.LightSkyBlue;
            DltBtn.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DltBtn.ForeColor = SystemColors.Window;
            DltBtn.Location = new Point(990, 233);
            DltBtn.Name = "DltBtn";
            DltBtn.Size = new Size(117, 41);
            DltBtn.TabIndex = 57;
            DltBtn.Text = "Delete";
            DltBtn.UseVisualStyleBackColor = false;
            DltBtn.Click += DltBtn_Click;
            // 
            // EdBtn
            // 
            EdBtn.BackColor = Color.LightSkyBlue;
            EdBtn.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EdBtn.ForeColor = SystemColors.Window;
            EdBtn.Location = new Point(834, 232);
            EdBtn.Name = "EdBtn";
            EdBtn.Size = new Size(117, 41);
            EdBtn.TabIndex = 56;
            EdBtn.Text = "Edit";
            EdBtn.UseVisualStyleBackColor = false;
            EdBtn.Click += EdBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.LightSkyBlue;
            AddBtn.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.ForeColor = SystemColors.Window;
            AddBtn.Location = new Point(676, 232);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(117, 41);
            AddBtn.TabIndex = 55;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(814, 76);
            label2.Name = "label2";
            label2.Size = new Size(151, 26);
            label2.TabIndex = 58;
            label2.Text = "Receptionist";
            // 
            // Receptionist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1445, 683);
            Controls.Add(label2);
            Controls.Add(DltBtn);
            Controls.Add(EdBtn);
            Controls.Add(AddBtn);
            Controls.Add(RAddressTb);
            Controls.Add(label9);
            Controls.Add(RPasswordTb);
            Controls.Add(label4);
            Controls.Add(ReceptionistDGV);
            Controls.Add(RPhoneTb);
            Controls.Add(label16);
            Controls.Add(RNameTb);
            Controls.Add(label8);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Receptionist";
            Text = "Receptionist";
            ((System.ComponentModel.ISupportInitialize)ReceptionistDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView ReceptionistDGV;
        private TextBox RPhoneTb;
        private Label label16;
        private TextBox RNameTb;
        private Label label8;
        private PictureBox pictureBox3;
        private Label label1;
        private Panel panel1;
        private Label label15;
        private PictureBox pictureBox12;
        private PictureBox pictureBox11;
        private Label label14;
        private PictureBox pictureBox1;
        private TextBox RPasswordTb;
        private Label label4;
        private TextBox RAddressTb;
        private Label label9;
        private Button DltBtn;
        private Button EdBtn;
        private Button AddBtn;
        private Label label2;
    }
}