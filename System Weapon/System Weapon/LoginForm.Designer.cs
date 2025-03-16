namespace System_Weapon
{
    partial class LoginForm
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            txtBoxUsername = new TextBox();
            txtBoxPassword = new TextBox();
            label4 = new Label();
            btnLogin = new Button();
            Admin_ShowPass = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 23, 56);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 43);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(23, 23, 56);
            label1.Cursor = Cursors.Hand;
            label1.ForeColor = Color.White;
            label1.Location = new Point(393, 9);
            label1.Name = "label1";
            label1.Size = new Size(22, 24);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Admin;
            pictureBox1.Location = new Point(140, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(129, 188);
            label2.Name = "label2";
            label2.Size = new Size(182, 28);
            label2.TabIndex = 2;
            label2.Text = "Welcome, Admin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 273);
            label3.Name = "label3";
            label3.Size = new Size(94, 22);
            label3.TabIndex = 3;
            label3.Text = "Username:";
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.Location = new Point(22, 298);
            txtBoxUsername.Multiline = true;
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new Size(373, 36);
            txtBoxUsername.TabIndex = 4;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(22, 378);
            txtBoxPassword.Multiline = true;
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.Size = new Size(373, 36);
            txtBoxPassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 353);
            label4.Name = "label4";
            label4.Size = new Size(90, 22);
            label4.TabIndex = 5;
            label4.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(23, 23, 56);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 249, 243);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 60, 143);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(22, 466);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(375, 49);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Admin_ShowPass
            // 
            Admin_ShowPass.AutoSize = true;
            Admin_ShowPass.Location = new Point(225, 420);
            Admin_ShowPass.Name = "Admin_ShowPass";
            Admin_ShowPass.Size = new Size(170, 28);
            Admin_ShowPass.TabIndex = 8;
            Admin_ShowPass.Text = "Show Password";
            Admin_ShowPass.UseVisualStyleBackColor = true;
            Admin_ShowPass.CheckedChanged += Admin_ShowPass_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 646);
            Controls.Add(Admin_ShowPass);
            Controls.Add(btnLogin);
            Controls.Add(txtBoxPassword);
            Controls.Add(label4);
            Controls.Add(txtBoxUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(23, 23, 56);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxUsername;
        private TextBox txtBoxPassword;
        private Label label4;
        private Button btnLogin;
        private CheckBox Admin_ShowPass;
    }
}