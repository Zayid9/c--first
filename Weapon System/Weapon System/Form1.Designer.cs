namespace Weapon_System
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBoxUsername = new TextBox();
            txtBoxPassword = new TextBox();
            btnLogin = new Button();
            chkBoxShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(275, 9);
            label1.Name = "label1";
            label1.Size = new Size(239, 48);
            label1.TabIndex = 0;
            label1.Text = "Admin Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 98);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 1;
            label2.Text = "Username: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(105, 156);
            label3.Name = "label3";
            label3.Size = new Size(122, 28);
            label3.TabIndex = 2;
            label3.Text = "Password: ";
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.Location = new Point(239, 102);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new Size(404, 27);
            txtBoxUsername.TabIndex = 3;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(239, 156);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(404, 27);
            txtBoxPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(380, 240);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(134, 71);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkBoxShowPassword
            // 
            chkBoxShowPassword.AutoSize = true;
            chkBoxShowPassword.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkBoxShowPassword.Location = new Point(473, 189);
            chkBoxShowPassword.Name = "chkBoxShowPassword";
            chkBoxShowPassword.Size = new Size(170, 28);
            chkBoxShowPassword.TabIndex = 6;
            chkBoxShowPassword.Text = "Show Password";
            chkBoxShowPassword.UseVisualStyleBackColor = true;
            //chkBoxShowPassword.CheckedChanged += chkBoxShowPassword_CheckedChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 123, 160);
            ClientSize = new Size(836, 369);
            Controls.Add(chkBoxShowPassword);
            Controls.Add(btnLogin);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxUsername;
        private TextBox txtBoxPassword;
        private Button btnLogin;
        private CheckBox chkBoxShowPassword;
    }
}
