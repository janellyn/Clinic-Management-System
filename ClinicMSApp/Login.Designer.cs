namespace ClinicMSApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            RoleCb = new ComboBox();
            UserName = new TextBox();
            Password = new TextBox();
            LoginBtn = new Button();
            ResetLbl = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 106);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(369, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 41);
            label1.Name = "label1";
            label1.Size = new Size(345, 28);
            label1.TabIndex = 1;
            label1.Text = "Clinic Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(155, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(93, 252);
            label2.Name = "label2";
            label2.Size = new Size(128, 26);
            label2.TabIndex = 2;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(93, 331);
            label3.Name = "label3";
            label3.Size = new Size(118, 26);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // RoleCb
            // 
            RoleCb.FormattingEnabled = true;
            RoleCb.Items.AddRange(new object[] { "Doctor", "Receptionist" });
            RoleCb.Location = new Point(93, 202);
            RoleCb.Name = "RoleCb";
            RoleCb.Size = new Size(194, 31);
            RoleCb.TabIndex = 4;
            // 
            // UserName
            // 
            UserName.Location = new Point(93, 281);
            UserName.Name = "UserName";
            UserName.Size = new Size(194, 30);
            UserName.TabIndex = 5;
            // 
            // Password
            // 
            Password.Location = new Point(93, 360);
            Password.Name = "Password";
            Password.Size = new Size(194, 30);
            Password.TabIndex = 6;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.LightSkyBlue;
            LoginBtn.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.ForeColor = SystemColors.Window;
            LoginBtn.Location = new Point(128, 428);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(117, 41);
            LoginBtn.TabIndex = 7;
            LoginBtn.Text = "Log In";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // ResetLbl
            // 
            ResetLbl.AutoSize = true;
            ResetLbl.Font = new Font("Bookman Old Style", 13.2000008F, FontStyle.Underline, GraphicsUnit.Point);
            ResetLbl.ForeColor = Color.DeepSkyBlue;
            ResetLbl.Location = new Point(150, 481);
            ResetLbl.Name = "ResetLbl";
            ResetLbl.Size = new Size(74, 26);
            ResetLbl.TabIndex = 8;
            ResetLbl.Text = "Reset";
            ResetLbl.Click += ResetLbl_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(405, 531);
            Controls.Add(ResetLbl);
            Controls.Add(LoginBtn);
            Controls.Add(Password);
            Controls.Add(UserName);
            Controls.Add(RoleCb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private ComboBox RoleCb;
        private TextBox UserName;
        private TextBox Password;
        private Button LoginBtn;
        private PictureBox pictureBox2;
        private Label ResetLbl;
    }
}