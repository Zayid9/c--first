namespace Login_Admin
{
    partial class Dashboard
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
            Menues = new GroupBox();
            btnDashboard = new Button();
            btnAddWeapon = new Button();
            btnComponisations = new Button();
            btnReports = new Button();
            btnLogout = new Button();
            Menues.SuspendLayout();
            SuspendLayout();
            // 
            // Menues
            // 
            Menues.BackColor = Color.FromArgb(128, 255, 255);
            Menues.Controls.Add(btnLogout);
            Menues.Controls.Add(btnReports);
            Menues.Controls.Add(btnComponisations);
            Menues.Controls.Add(btnAddWeapon);
            Menues.Controls.Add(btnDashboard);
            Menues.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Menues.ForeColor = Color.FromArgb(192, 0, 192);
            Menues.Location = new Point(21, 69);
            Menues.Name = "Menues";
            Menues.Size = new Size(275, 485);
            Menues.TabIndex = 0;
            Menues.TabStop = false;
            Menues.Text = "Menues";
            // 
            // btnDashboard
            // 
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Location = new Point(22, 49);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(183, 50);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnAddWeapon
            // 
            btnAddWeapon.FlatStyle = FlatStyle.Flat;
            btnAddWeapon.Location = new Point(22, 134);
            btnAddWeapon.Name = "btnAddWeapon";
            btnAddWeapon.Size = new Size(183, 50);
            btnAddWeapon.TabIndex = 1;
            btnAddWeapon.Text = "Add Weapon";
            btnAddWeapon.UseVisualStyleBackColor = true;
            btnAddWeapon.Click += btnAddWeapon_Click;
            // 
            // btnComponisations
            // 
            btnComponisations.FlatStyle = FlatStyle.Flat;
            btnComponisations.Location = new Point(22, 215);
            btnComponisations.Name = "btnComponisations";
            btnComponisations.Size = new Size(183, 50);
            btnComponisations.TabIndex = 2;
            btnComponisations.Text = "Componisation";
            btnComponisations.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Location = new Point(22, 306);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(183, 50);
            btnReports.TabIndex = 3;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(22, 392);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(183, 50);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(881, 658);
            Controls.Add(Menues);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            Menues.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Menues;
        private Button btnLogout;
        private Button btnReports;
        private Button btnComponisations;
        private Button btnAddWeapon;
        private Button btnDashboard;
    }
}