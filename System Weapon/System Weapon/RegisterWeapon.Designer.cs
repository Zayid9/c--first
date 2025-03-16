namespace System_Weapon
{
    partial class RegisterWeapon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            btnLocation = new Button();
            btnOwnerInfo = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 23, 56);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 74);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(189, 11);
            label1.Name = "label1";
            label1.Size = new Size(387, 34);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Register Weapon";
            // 
            // btnLocation
            // 
            btnLocation.BackColor = Color.FromArgb(23, 23, 56);
            btnLocation.Cursor = Cursors.Hand;
            btnLocation.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 249, 243);
            btnLocation.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 60, 143);
            btnLocation.FlatStyle = FlatStyle.Flat;
            btnLocation.ForeColor = Color.White;
            btnLocation.Location = new Point(542, 255);
            btnLocation.Name = "btnLocation";
            btnLocation.Size = new Size(190, 64);
            btnLocation.TabIndex = 8;
            btnLocation.Text = "Weapons";
            btnLocation.UseVisualStyleBackColor = false;
            btnLocation.Click += btnLocation_Click;
            // 
            // btnOwnerInfo
            // 
            btnOwnerInfo.BackColor = Color.FromArgb(23, 23, 56);
            btnOwnerInfo.Cursor = Cursors.Hand;
            btnOwnerInfo.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 249, 243);
            btnOwnerInfo.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 60, 143);
            btnOwnerInfo.FlatStyle = FlatStyle.Flat;
            btnOwnerInfo.ForeColor = Color.White;
            btnOwnerInfo.Location = new Point(117, 255);
            btnOwnerInfo.Name = "btnOwnerInfo";
            btnOwnerInfo.Size = new Size(190, 64);
            btnOwnerInfo.TabIndex = 7;
            btnOwnerInfo.Text = "Categories";
            btnOwnerInfo.UseVisualStyleBackColor = false;
            btnOwnerInfo.Click += btnOwnerInfo_Click;
            // 
            // RegisterWeapon
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(btnLocation);
            Controls.Add(btnOwnerInfo);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(23, 23, 56);
            Margin = new Padding(4);
            Name = "RegisterWeapon";
            Size = new Size(880, 652);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnLocation;
        private Button btnOwnerInfo;
    }
}
