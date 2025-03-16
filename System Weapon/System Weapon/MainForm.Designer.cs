namespace System_Weapon
{
    partial class MainForm
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            btnReports = new Button();
            btnLogout = new Button();
            btnComponisations = new Button();
            btnRegisterWeapon = new Button();
            btnOwner = new Button();
            btnHome = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            componisations1 = new Componisations();
            registerWeapon1 = new RegisterWeapon();
            owner1 = new Owner();
            reports1 = new Reports();
            dashboard1 = new Dashboard();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 23, 56);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1173, 43);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 5);
            label2.Name = "label2";
            label2.Size = new Size(276, 24);
            label2.TabIndex = 1;
            label2.Text = "Weapon Management System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Location = new Point(1144, 8);
            label1.Name = "label1";
            label1.Size = new Size(22, 24);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 23, 56);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnReports);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnComponisations);
            panel2.Controls.Add(btnRegisterWeapon);
            panel2.Controls.Add(btnOwner);
            panel2.Controls.Add(btnHome);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(293, 652);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(99, 611);
            label4.Name = "label4";
            label4.Size = new Size(85, 28);
            label4.TabIndex = 8;
            label4.Text = "LogOut";
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(23, 23, 56);
            btnReports.Cursor = Cursors.Hand;
            btnReports.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 249, 243);
            btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 60, 143);
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(15, 472);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(267, 55);
            btnReports.TabIndex = 7;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(23, 23, 56);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 249, 243);
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 60, 143);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = Properties.Resources.icons8_logout_rounded_up_filled_32px;
            btnLogout.Location = new Point(47, 603);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(47, 43);
            btnLogout.TabIndex = 6;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnComponisations
            // 
            btnComponisations.BackColor = Color.FromArgb(23, 23, 56);
            btnComponisations.Cursor = Cursors.Hand;
            btnComponisations.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 249, 243);
            btnComponisations.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 60, 143);
            btnComponisations.FlatStyle = FlatStyle.Flat;
            btnComponisations.ForeColor = Color.White;
            btnComponisations.Location = new Point(15, 396);
            btnComponisations.Name = "btnComponisations";
            btnComponisations.Size = new Size(267, 55);
            btnComponisations.TabIndex = 5;
            btnComponisations.Text = "Componisations";
            btnComponisations.UseVisualStyleBackColor = false;
            btnComponisations.Click += btnComponisations_Click;
            // 
            // btnRegisterWeapon
            // 
            btnRegisterWeapon.BackColor = Color.FromArgb(23, 23, 56);
            btnRegisterWeapon.Cursor = Cursors.Hand;
            btnRegisterWeapon.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 249, 243);
            btnRegisterWeapon.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 60, 143);
            btnRegisterWeapon.FlatStyle = FlatStyle.Flat;
            btnRegisterWeapon.ForeColor = Color.White;
            btnRegisterWeapon.Location = new Point(15, 322);
            btnRegisterWeapon.Name = "btnRegisterWeapon";
            btnRegisterWeapon.Size = new Size(267, 55);
            btnRegisterWeapon.TabIndex = 4;
            btnRegisterWeapon.Text = "Register Weapon";
            btnRegisterWeapon.UseVisualStyleBackColor = false;
            btnRegisterWeapon.Click += btnRegisterWeapon_Click;
            // 
            // btnOwner
            // 
            btnOwner.BackColor = Color.FromArgb(23, 23, 56);
            btnOwner.Cursor = Cursors.Hand;
            btnOwner.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 249, 243);
            btnOwner.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 60, 143);
            btnOwner.FlatStyle = FlatStyle.Flat;
            btnOwner.ForeColor = Color.White;
            btnOwner.Location = new Point(15, 243);
            btnOwner.Name = "btnOwner";
            btnOwner.Size = new Size(267, 55);
            btnOwner.TabIndex = 3;
            btnOwner.Text = "Owner";
            btnOwner.UseVisualStyleBackColor = false;
            btnOwner.Click += btnOwner_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(23, 23, 56);
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 249, 243);
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 60, 143);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(15, 166);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(267, 55);
            btnHome.TabIndex = 2;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 112);
            label3.Name = "label3";
            label3.Size = new Size(118, 18);
            label3.TabIndex = 1;
            label3.Text = "Welcome, Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.Wea;
            pictureBox1.Location = new Point(67, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dashboard1);
            panel3.Controls.Add(reports1);
            panel3.Controls.Add(componisations1);
            panel3.Controls.Add(registerWeapon1);
            panel3.Controls.Add(owner1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(293, 43);
            panel3.Name = "panel3";
            panel3.Size = new Size(880, 652);
            panel3.TabIndex = 2;
            // 
            // componisations1
            // 
            componisations1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            componisations1.ForeColor = Color.FromArgb(23, 23, 56);
            componisations1.Location = new Point(0, 0);
            componisations1.Margin = new Padding(4);
            componisations1.Name = "componisations1";
            componisations1.Size = new Size(1100, 815);
            componisations1.TabIndex = 2;
            // 
            // registerWeapon1
            // 
            registerWeapon1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerWeapon1.ForeColor = Color.FromArgb(23, 23, 56);
            registerWeapon1.Location = new Point(2, -2);
            registerWeapon1.Margin = new Padding(4);
            registerWeapon1.Name = "registerWeapon1";
            registerWeapon1.Size = new Size(1100, 815);
            registerWeapon1.TabIndex = 1;
            // 
            // owner1
            // 
            owner1.BackColor = Color.White;
            owner1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            owner1.ForeColor = Color.FromArgb(23, 23, 56);
            owner1.Location = new Point(0, 1);
            owner1.Margin = new Padding(4);
            owner1.Name = "owner1";
            owner1.Size = new Size(1100, 815);
            owner1.TabIndex = 0;
            // 
            // reports1
            // 
            reports1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reports1.ForeColor = Color.FromArgb(23, 23, 56);
            reports1.Location = new Point(-2, -1);
            reports1.Margin = new Padding(4);
            reports1.Name = "reports1";
            reports1.Size = new Size(1100, 815);
            reports1.TabIndex = 3;
            // 
            // dashboard1
            // 
            dashboard1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard1.Location = new Point(-3, 0);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(1100, 815);
            dashboard1.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 695);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(23, 23, 56);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label3;
        private Button btnHome;
        private Button btnReports;
        private Button btnLogout;
        private Button btnComponisations;
        private Button btnRegisterWeapon;
        private Button btnOwner;
        private Label label4;
        private Panel panel3;
        private Owner owner1;
        private Componisations componisations1;
        private RegisterWeapon registerWeapon1;
        private Dashboard dashboard1;
        private Reports reports1;
    }
}