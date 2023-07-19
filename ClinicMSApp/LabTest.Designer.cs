namespace ClinicMSApp
{
    partial class LabTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabTest));
            panel1 = new Panel();
            label15 = new Label();
            pictureBox12 = new PictureBox();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            TestCost = new TextBox();
            label16 = new Label();
            TestName = new TextBox();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            DeleteBtn = new Button();
            EditBtn = new Button();
            AddBtn = new Button();
            LabTestDGV = new DataGridView();
            pictureBox11 = new PictureBox();
            label14 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LabTestDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(pictureBox11);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(pictureBox12);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 646);
            panel1.TabIndex = 31;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(103, 571);
            label15.Name = "label15";
            label15.Size = new Size(88, 23);
            label15.TabIndex = 16;
            label15.Text = "Log Out";
            label15.Click += label15_Click;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(50, 561);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(43, 43);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 15;
            pictureBox12.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(45, 165);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(503, 43);
            label1.Name = "label1";
            label1.Size = new Size(146, 28);
            label1.TabIndex = 32;
            label1.Text = "Laboratory";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(527, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(89, 81);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // TestCost
            // 
            TestCost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TestCost.Location = new Point(611, 230);
            TestCost.Name = "TestCost";
            TestCost.Size = new Size(201, 34);
            TestCost.TabIndex = 44;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.DeepSkyBlue;
            label16.Location = new Point(611, 192);
            label16.Name = "label16";
            label16.Size = new Size(63, 26);
            label16.TabIndex = 43;
            label16.Text = "Cost";
            // 
            // TestName
            // 
            TestName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TestName.Location = new Point(319, 230);
            TestName.Name = "TestName";
            TestName.Size = new Size(201, 34);
            TestName.TabIndex = 42;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.DeepSkyBlue;
            label8.Location = new Point(319, 192);
            label8.Name = "label8";
            label8.Size = new Size(130, 26);
            label8.TabIndex = 41;
            label8.Text = "Test Name";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(841, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 45;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.LightSkyBlue;
            DeleteBtn.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBtn.ForeColor = SystemColors.Window;
            DeleteBtn.Location = new Point(659, 293);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(117, 41);
            DeleteBtn.TabIndex = 51;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.LightSkyBlue;
            EditBtn.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditBtn.ForeColor = SystemColors.Window;
            EditBtn.Location = new Point(503, 292);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(117, 41);
            EditBtn.TabIndex = 50;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.LightSkyBlue;
            AddBtn.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.ForeColor = SystemColors.Window;
            AddBtn.Location = new Point(345, 292);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(117, 41);
            AddBtn.TabIndex = 49;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // LabTestDGV
            // 
            LabTestDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.NullValue = null;
            LabTestDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            LabTestDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LabTestDGV.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            LabTestDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            LabTestDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            LabTestDGV.DefaultCellStyle = dataGridViewCellStyle3;
            LabTestDGV.Location = new Point(273, 358);
            LabTestDGV.Name = "LabTestDGV";
            LabTestDGV.RowHeadersWidth = 51;
            LabTestDGV.RowTemplate.Height = 29;
            LabTestDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LabTestDGV.Size = new Size(599, 276);
            LabTestDGV.TabIndex = 53;
            LabTestDGV.CellContentClick += LabTestDGV_CellContentClick;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(45, 136);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(66, 66);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 20;
            pictureBox11.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(121, 156);
            label14.Name = "label14";
            label14.Size = new Size(76, 23);
            label14.TabIndex = 19;
            label14.Text = "Homes";
            label14.Click += label14_Click;
            // 
            // LabTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 646);
            Controls.Add(LabTestDGV);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(pictureBox3);
            Controls.Add(TestCost);
            Controls.Add(label16);
            Controls.Add(TestName);
            Controls.Add(label8);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LabTest";
            Text = "LabTest";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)LabTestDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label15;
        private PictureBox pictureBox12;
        private Label label10;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox TestCost;
        private Label label16;
        private TextBox TestName;
        private Label label8;
        private PictureBox pictureBox3;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button AddBtn;
        private DataGridView LabTestDGV;
        private PictureBox pictureBox11;
        private Label label14;
    }
}