namespace ClinicMSApp
{
    partial class Prescriptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prescriptions));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            PrintBtn = new Button();
            AddBtn = new Button();
            Medicine = new TextBox();
            label2 = new Label();
            DocId = new ComboBox();
            DocName = new TextBox();
            label16 = new Label();
            Test = new TextBox();
            label9 = new Label();
            PatId = new ComboBox();
            PatName = new TextBox();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label15 = new Label();
            pictureBox12 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox8 = new PictureBox();
            label13 = new Label();
            label11 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            TestId = new ComboBox();
            Cost = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Prescr = new RichTextBox();
            LabTestDGV = new DataGridView();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            pictureBox11 = new PictureBox();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LabTestDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            SuspendLayout();
            // 
            // PrintBtn
            // 
            PrintBtn.BackColor = Color.LightSkyBlue;
            PrintBtn.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PrintBtn.ForeColor = SystemColors.Window;
            PrintBtn.Location = new Point(505, 361);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(117, 41);
            PrintBtn.TabIndex = 48;
            PrintBtn.Text = "Print";
            PrintBtn.UseVisualStyleBackColor = false;
            PrintBtn.Click += PrintBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.LightSkyBlue;
            AddBtn.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.ForeColor = SystemColors.Window;
            AddBtn.Location = new Point(348, 361);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(117, 41);
            AddBtn.TabIndex = 46;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // Medicine
            // 
            Medicine.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Medicine.Location = new Point(723, 207);
            Medicine.Multiline = true;
            Medicine.Name = "Medicine";
            Medicine.Size = new Size(185, 195);
            Medicine.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(723, 171);
            label2.Name = "label2";
            label2.Size = new Size(124, 26);
            label2.TabIndex = 42;
            label2.Text = "Medicines";
            // 
            // DocId
            // 
            DocId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DocId.FormattingEnabled = true;
            DocId.Location = new Point(303, 118);
            DocId.Name = "DocId";
            DocId.Size = new Size(137, 36);
            DocId.TabIndex = 41;
            DocId.Text = "Doctor Id";
            DocId.SelectionChangeCommitted += DocId_SelectionChangeCommitted;
            // 
            // DocName
            // 
            DocName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DocName.Location = new Point(468, 118);
            DocName.Name = "DocName";
            DocName.Size = new Size(215, 34);
            DocName.TabIndex = 40;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.DeepSkyBlue;
            label16.Location = new Point(468, 80);
            label16.Name = "label16";
            label16.Size = new Size(158, 26);
            label16.TabIndex = 39;
            label16.Text = "Doctor Name";
            // 
            // Test
            // 
            Test.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Test.Location = new Point(468, 207);
            Test.Multiline = true;
            Test.Name = "Test";
            Test.Size = new Size(215, 38);
            Test.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.DeepSkyBlue;
            label9.Location = new Point(468, 171);
            label9.Name = "label9";
            label9.Size = new Size(59, 26);
            label9.TabIndex = 37;
            label9.Text = "Test";
            // 
            // PatId
            // 
            PatId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PatId.FormattingEnabled = true;
            PatId.Location = new Point(303, 301);
            PatId.Name = "PatId";
            PatId.Size = new Size(137, 36);
            PatId.TabIndex = 35;
            PatId.Text = "Patient Id";
            PatId.SelectionChangeCommitted += PatId_SelectionChangeCommitted;
            // 
            // PatName
            // 
            PatName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PatName.Location = new Point(468, 301);
            PatName.Name = "PatName";
            PatName.Size = new Size(215, 34);
            PatName.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.DeepSkyBlue;
            label8.Location = new Point(468, 263);
            label8.Name = "label8";
            label8.Size = new Size(162, 26);
            label8.TabIndex = 33;
            label8.Text = "Patient Name";
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
            label1.Location = new Point(736, 38);
            label1.Name = "label1";
            label1.Size = new Size(233, 28);
            label1.TabIndex = 31;
            label1.Text = "Clinics Codespace";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(pictureBox11);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(pictureBox12);
            panel1.Controls.Add(pictureBox10);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
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
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(25, 314);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(66, 66);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 13;
            pictureBox10.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(25, 223);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(66, 66);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 11;
            pictureBox8.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(101, 330);
            label13.Name = "label13";
            label13.Size = new Size(117, 23);
            label13.TabIndex = 9;
            label13.Text = "Laboratory";
            label13.Click += label13_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(101, 237);
            label11.Name = "label11";
            label11.Size = new Size(90, 23);
            label11.TabIndex = 7;
            label11.Text = "Patients";
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(45, 237);
            label10.Name = "label10";
            label10.Size = new Size(0, 26);
            label10.TabIndex = 3;
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
            // TestId
            // 
            TestId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TestId.FormattingEnabled = true;
            TestId.Location = new Point(303, 209);
            TestId.Name = "TestId";
            TestId.Size = new Size(137, 36);
            TestId.TabIndex = 49;
            TestId.Text = "Test Id";
            TestId.SelectionChangeCommitted += TestId_SelectionChangeCommitted;
            // 
            // Cost
            // 
            Cost.Enabled = false;
            Cost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Cost.Location = new Point(723, 116);
            Cost.Multiline = true;
            Cost.Name = "Cost";
            Cost.Size = new Size(137, 36);
            Cost.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(723, 80);
            label3.Name = "label3";
            label3.Size = new Size(63, 26);
            label3.TabIndex = 50;
            label3.Text = "Cost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(930, 80);
            label4.Name = "label4";
            label4.Size = new Size(147, 26);
            label4.TabIndex = 52;
            label4.Text = "Prescription";
            // 
            // Prescr
            // 
            Prescr.Location = new Point(930, 118);
            Prescr.Name = "Prescr";
            Prescr.Size = new Size(491, 284);
            Prescr.TabIndex = 53;
            Prescr.Text = "";
            // 
            // LabTestDGV
            // 
            LabTestDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.NullValue = null;
            LabTestDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            LabTestDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LabTestDGV.BackgroundColor = Color.White;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            LabTestDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            LabTestDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            LabTestDGV.DefaultCellStyle = dataGridViewCellStyle6;
            LabTestDGV.Location = new Point(292, 428);
            LabTestDGV.Name = "LabTestDGV";
            LabTestDGV.RowHeadersWidth = 51;
            LabTestDGV.RowTemplate.Height = 29;
            LabTestDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LabTestDGV.Size = new Size(1129, 243);
            LabTestDGV.TabIndex = 54;
            LabTestDGV.CellContentClick += LabTestDGV_CellContentClick;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(25, 131);
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
            label14.Location = new Point(101, 151);
            label14.Name = "label14";
            label14.Size = new Size(76, 23);
            label14.TabIndex = 17;
            label14.Text = "Homes";
            label14.Click += label14_Click;
            // 
            // Prescriptions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1446, 683);
            Controls.Add(LabTestDGV);
            Controls.Add(Prescr);
            Controls.Add(label4);
            Controls.Add(Cost);
            Controls.Add(label3);
            Controls.Add(TestId);
            Controls.Add(PrintBtn);
            Controls.Add(AddBtn);
            Controls.Add(Medicine);
            Controls.Add(label2);
            Controls.Add(DocId);
            Controls.Add(DocName);
            Controls.Add(label16);
            Controls.Add(Test);
            Controls.Add(label9);
            Controls.Add(PatId);
            Controls.Add(PatName);
            Controls.Add(label8);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Prescriptions";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Prescriptions";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)LabTestDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PrintBtn;
        private Button AddBtn;
        private TextBox Medicine;
        private Label label2;
        private ComboBox DocId;
        private TextBox DocName;
        private Label label16;
        private TextBox Test;
        private Label label9;
        private ComboBox PatId;
        private TextBox PatName;
        private Label label8;
        private PictureBox pictureBox3;
        private Label label1;
        private Panel panel1;
        private Label label15;
        private PictureBox pictureBox12;
        private PictureBox pictureBox10;
        private PictureBox pictureBox8;
        private Label label13;
        private Label label11;
        private Label label10;
        private PictureBox pictureBox1;
        private ComboBox TestId;
        private TextBox Cost;
        private Label label3;
        private Label label4;
        private RichTextBox Prescr;
        private DataGridView LabTestDGV;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PictureBox pictureBox11;
        private Label label14;
    }
}