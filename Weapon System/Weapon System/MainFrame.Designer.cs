namespace Weapon_System
{
    partial class MainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            panel1 = new Panel();
            btnComponisation = new Button();
            btnLogOut = new Button();
            btnRegisterWeapon = new Button();
            btnCat = new Button();
            btnLocation = new Button();
            btnState = new Button();
            btnOwner = new Button();
            btnDashboard = new Button();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            panel6 = new Panel();
            dashboard1 = new Dashboard();
            owner1 = new Owner();
            state1 = new State();
            location1 = new Location();
            cat1 = new Cat();
            register1 = new Register();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 123, 160);
            panel1.Controls.Add(btnComponisation);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(btnRegisterWeapon);
            panel1.Controls.Add(btnCat);
            panel1.Controls.Add(btnLocation);
            panel1.Controls.Add(btnState);
            panel1.Controls.Add(btnOwner);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 770);
            panel1.TabIndex = 0;
            // 
            // btnComponisation
            // 
            btnComponisation.Dock = DockStyle.Top;
            btnComponisation.FlatAppearance.BorderSize = 0;
            btnComponisation.FlatStyle = FlatStyle.Flat;
            btnComponisation.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComponisation.Location = new Point(42, 547);
            btnComponisation.Name = "btnComponisation";
            btnComponisation.Size = new Size(257, 77);
            btnComponisation.TabIndex = 10;
            btnComponisation.Text = "Componisation";
            btnComponisation.UseVisualStyleBackColor = true;
            btnComponisation.Click += btnComponisation_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Dock = DockStyle.Bottom;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.Location = new Point(42, 657);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(257, 113);
            btnLogOut.TabIndex = 9;
            btnLogOut.Text = "LogOut";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnRegisterWeapon
            // 
            btnRegisterWeapon.Dock = DockStyle.Top;
            btnRegisterWeapon.FlatAppearance.BorderSize = 0;
            btnRegisterWeapon.FlatStyle = FlatStyle.Flat;
            btnRegisterWeapon.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegisterWeapon.Location = new Point(42, 475);
            btnRegisterWeapon.Name = "btnRegisterWeapon";
            btnRegisterWeapon.Size = new Size(257, 72);
            btnRegisterWeapon.TabIndex = 8;
            btnRegisterWeapon.Text = "Registartion Weapon";
            btnRegisterWeapon.UseVisualStyleBackColor = true;
            btnRegisterWeapon.Click += btnRegisterWeapon_Click;
            // 
            // btnCat
            // 
            btnCat.Dock = DockStyle.Top;
            btnCat.FlatAppearance.BorderSize = 0;
            btnCat.FlatStyle = FlatStyle.Flat;
            btnCat.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCat.Location = new Point(42, 414);
            btnCat.Name = "btnCat";
            btnCat.Size = new Size(257, 61);
            btnCat.TabIndex = 7;
            btnCat.Text = "Categories";
            btnCat.UseVisualStyleBackColor = true;
            btnCat.Click += btnCat_Click;
            // 
            // btnLocation
            // 
            btnLocation.Dock = DockStyle.Top;
            btnLocation.FlatAppearance.BorderSize = 0;
            btnLocation.FlatStyle = FlatStyle.Flat;
            btnLocation.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLocation.Location = new Point(42, 340);
            btnLocation.Name = "btnLocation";
            btnLocation.Size = new Size(257, 74);
            btnLocation.TabIndex = 6;
            btnLocation.Text = "Location";
            btnLocation.UseVisualStyleBackColor = true;
            btnLocation.Click += btnLocation_Click;
            // 
            // btnState
            // 
            btnState.Dock = DockStyle.Top;
            btnState.FlatAppearance.BorderSize = 0;
            btnState.FlatStyle = FlatStyle.Flat;
            btnState.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnState.Location = new Point(42, 265);
            btnState.Name = "btnState";
            btnState.Size = new Size(257, 75);
            btnState.TabIndex = 5;
            btnState.Text = "State";
            btnState.UseVisualStyleBackColor = true;
            btnState.Click += btnState_Click;
            // 
            // btnOwner
            // 
            btnOwner.Dock = DockStyle.Top;
            btnOwner.FlatAppearance.BorderSize = 0;
            btnOwner.FlatStyle = FlatStyle.Flat;
            btnOwner.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOwner.Location = new Point(42, 201);
            btnOwner.Name = "btnOwner";
            btnOwner.Size = new Size(257, 64);
            btnOwner.TabIndex = 4;
            btnOwner.Text = "Owner";
            btnOwner.UseVisualStyleBackColor = true;
            btnOwner.Click += btnOwner_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(42, 125);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(257, 76);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(299, 125);
            panel4.Name = "panel4";
            panel4.Size = new Size(43, 645);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Left;
            panel3.Enabled = false;
            panel3.Location = new Point(0, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(42, 645);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(342, 125);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, 97);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 2;
            label2.Text = "Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 57);
            label1.Name = "label1";
            label1.Size = new Size(153, 28);
            label1.TabIndex = 1;
            label1.Text = "National Army";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(33, 123, 160);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(342, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(970, 85);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(dashboard1);
            panel6.Controls.Add(owner1);
            panel6.Controls.Add(state1);
            panel6.Controls.Add(location1);
            panel6.Controls.Add(cat1);
            panel6.Controls.Add(register1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(342, 85);
            panel6.Name = "panel6";
            panel6.Size = new Size(970, 685);
            panel6.TabIndex = 2;
            // 
            // dashboard1
            // 
            dashboard1.Location = new Point(-2, -3);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(970, 695);
            dashboard1.TabIndex = 5;
            // 
            // owner1
            // 
            owner1.BackColor = Color.FromArgb(33, 123, 160);
            owner1.Font = new Font("Tahoma", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            owner1.Location = new Point(0, -3);
            owner1.Margin = new Padding(8, 7, 8, 7);
            owner1.Name = "owner1";
            owner1.Size = new Size(1212, 869);
            owner1.TabIndex = 4;
            // 
            // state1
            // 
            state1.BackColor = Color.FromArgb(33, 123, 160);
            state1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            state1.Location = new Point(-3, -3);
            state1.Margin = new Padding(5, 4, 5, 4);
            state1.Name = "state1";
            state1.Size = new Size(1212, 869);
            state1.TabIndex = 3;
            // 
            // location1
            // 
            location1.BackColor = Color.FromArgb(33, 123, 160);
            location1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            location1.Location = new Point(0, -1);
            location1.Margin = new Padding(4);
            location1.Name = "location1";
            location1.Size = new Size(1212, 869);
            location1.TabIndex = 2;
            // 
            // cat1
            // 
            cat1.BackColor = Color.FromArgb(33, 123, 160);
            cat1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cat1.Location = new Point(-1, -1);
            cat1.Name = "cat1";
            cat1.Size = new Size(1212, 782);
            cat1.TabIndex = 1;
            // 
            // register1
            // 
            register1.BackColor = Color.FromArgb(33, 123, 160);
            register1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register1.Location = new Point(-1, 0);
            register1.Margin = new Padding(4);
            register1.Name = "register1";
            register1.Size = new Size(1212, 869);
            register1.TabIndex = 0;
            // 
            // MainFrame
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 770);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "MainFrame";
            Text = "MainFrame";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label2;
        private Button btnRegisterWeapon;
        private Button btnCat;
        private Button btnLocation;
        private Button btnState;
        private Button btnOwner;
        private Button btnDashboard;
        private Panel panel4;
        private Button btnLogOut;
        private Panel panel5;
        private Button btnComponisation;
        private Panel panel6;
        private Owner owner1;
        private State state1;
        private Location location1;
        private Cat cat1;
        private Register register1;
        private Dashboard dashboard1;
    }
}