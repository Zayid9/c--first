namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnCompenisation = new System.Windows.Forms.Button();
            this.btnRegisterWeapon = new System.Windows.Forms.Button();
            this.btnOwner = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.owners1 = new WindowsFormsApp1.Owners();
            this.registerWeapon1 = new WindowsFormsApp1.RegisterWeapon();
            this.compenisations1 = new WindowsFormsApp1.Compenisations();
            this.reports1 = new WindowsFormsApp1.Reports();
            this.users1 = new WindowsFormsApp1.Users();
            this.dashboard1 = new WindowsFormsApp1.Dashboard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 43);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weapon Management Systen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1139, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.btnUsers);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.btnReports);
            this.panel2.Controls.Add(this.btnCompenisation);
            this.panel2.Controls.Add(this.btnRegisterWeapon);
            this.panel2.Controls.Add(this.btnOwner);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 652);
            this.panel2.TabIndex = 1;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatAppearance.BorderSize = 2;
            this.btnUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(249)))), ((int)(((byte)(243)))));
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(143)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Location = new System.Drawing.Point(12, 535);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(267, 55);
            this.btnUsers.TabIndex = 9;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.label4.Location = new System.Drawing.Point(99, 611);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "LogOut";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 2;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(249)))), ((int)(((byte)(243)))));
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(143)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Image = global::WindowsFormsApp1.Properties.Resources.icons8_logout_rounded_up_filled_32px;
            this.btnLogOut.Location = new System.Drawing.Point(47, 603);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(47, 43);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderSize = 2;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(249)))), ((int)(((byte)(243)))));
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(143)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Location = new System.Drawing.Point(15, 468);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(267, 55);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnCompenisation
            // 
            this.btnCompenisation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.btnCompenisation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompenisation.FlatAppearance.BorderSize = 2;
            this.btnCompenisation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(249)))), ((int)(((byte)(243)))));
            this.btnCompenisation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(143)))));
            this.btnCompenisation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompenisation.Location = new System.Drawing.Point(15, 393);
            this.btnCompenisation.Name = "btnCompenisation";
            this.btnCompenisation.Size = new System.Drawing.Size(267, 55);
            this.btnCompenisation.TabIndex = 5;
            this.btnCompenisation.Text = "Compenisation";
            this.btnCompenisation.UseVisualStyleBackColor = false;
            this.btnCompenisation.Click += new System.EventHandler(this.btnCompenisation_Click);
            // 
            // btnRegisterWeapon
            // 
            this.btnRegisterWeapon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.btnRegisterWeapon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterWeapon.FlatAppearance.BorderSize = 2;
            this.btnRegisterWeapon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(249)))), ((int)(((byte)(243)))));
            this.btnRegisterWeapon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(143)))));
            this.btnRegisterWeapon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterWeapon.Location = new System.Drawing.Point(15, 319);
            this.btnRegisterWeapon.Name = "btnRegisterWeapon";
            this.btnRegisterWeapon.Size = new System.Drawing.Size(267, 55);
            this.btnRegisterWeapon.TabIndex = 4;
            this.btnRegisterWeapon.Text = "Register Weapon";
            this.btnRegisterWeapon.UseVisualStyleBackColor = false;
            this.btnRegisterWeapon.Click += new System.EventHandler(this.btnRegisterWeapon_Click);
            // 
            // btnOwner
            // 
            this.btnOwner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.btnOwner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOwner.FlatAppearance.BorderSize = 2;
            this.btnOwner.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(249)))), ((int)(((byte)(243)))));
            this.btnOwner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(143)))));
            this.btnOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOwner.Location = new System.Drawing.Point(15, 243);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.Size = new System.Drawing.Size(267, 55);
            this.btnOwner.TabIndex = 3;
            this.btnOwner.Text = "Owner";
            this.btnOwner.UseVisualStyleBackColor = false;
            this.btnOwner.Click += new System.EventHandler(this.btnOwner_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 2;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(249)))), ((int)(((byte)(243)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(143)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(15, 166);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(267, 55);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.Location = new System.Drawing.Point(66, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Welcome, Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Wea1;
            this.pictureBox1.Location = new System.Drawing.Point(67, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashboard1);
            this.panel3.Controls.Add(this.users1);
            this.panel3.Controls.Add(this.owners1);
            this.panel3.Controls.Add(this.registerWeapon1);
            this.panel3.Controls.Add(this.compenisations1);
            this.panel3.Controls.Add(this.reports1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(293, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(880, 652);
            this.panel3.TabIndex = 2;
            // 
            // owners1
            // 
            this.owners1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.owners1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.owners1.Location = new System.Drawing.Point(0, 0);
            this.owners1.Margin = new System.Windows.Forms.Padding(4);
            this.owners1.Name = "owners1";
            this.owners1.Size = new System.Drawing.Size(880, 652);
            this.owners1.TabIndex = 3;
            // 
            // registerWeapon1
            // 
            this.registerWeapon1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerWeapon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.registerWeapon1.Location = new System.Drawing.Point(0, 0);
            this.registerWeapon1.Margin = new System.Windows.Forms.Padding(4);
            this.registerWeapon1.Name = "registerWeapon1";
            this.registerWeapon1.Size = new System.Drawing.Size(880, 652);
            this.registerWeapon1.TabIndex = 2;
            // 
            // compenisations1
            // 
            this.compenisations1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compenisations1.Location = new System.Drawing.Point(0, 0);
            this.compenisations1.Margin = new System.Windows.Forms.Padding(4);
            this.compenisations1.Name = "compenisations1";
            this.compenisations1.Size = new System.Drawing.Size(880, 652);
            this.compenisations1.TabIndex = 1;
            // 
            // reports1
            // 
            this.reports1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reports1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.reports1.Location = new System.Drawing.Point(0, 0);
            this.reports1.Margin = new System.Windows.Forms.Padding(4);
            this.reports1.Name = "reports1";
            this.reports1.Size = new System.Drawing.Size(880, 652);
            this.reports1.TabIndex = 0;
            // 
            // users1
            // 
            this.users1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.users1.Location = new System.Drawing.Point(0, 0);
            this.users1.Margin = new System.Windows.Forms.Padding(4);
            this.users1.Name = "users1";
            this.users1.Size = new System.Drawing.Size(880, 652);
            this.users1.TabIndex = 4;
            // 
            // dashboard1
            // 
            this.dashboard1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Margin = new System.Windows.Forms.Padding(4);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(880, 652);
            this.dashboard1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 695);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCompenisation;
        private System.Windows.Forms.Button btnRegisterWeapon;
        private System.Windows.Forms.Button btnOwner;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private Owners owners1;
        private RegisterWeapon registerWeapon1;
        private Compenisations compenisations1;
        private Reports reports1;
        private System.Windows.Forms.Button btnUsers;
        private Dashboard dashboard1;
        private Users users1;
    }
}