namespace System_Weapon
{
    partial class Owner
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
            btnOwnerInfo = new Button();
            btnLocation = new Button();
            btnState = new Button();
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
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(189, 11);
            label1.Name = "label1";
            label1.Size = new Size(413, 34);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Owner Information";
            // 
            // btnOwnerInfo
            // 
            btnOwnerInfo.BackColor = Color.FromArgb(23, 23, 56);
            btnOwnerInfo.Cursor = Cursors.Hand;
            btnOwnerInfo.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 249, 243);
            btnOwnerInfo.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 60, 143);
            btnOwnerInfo.FlatStyle = FlatStyle.Flat;
            btnOwnerInfo.ForeColor = Color.White;
            btnOwnerInfo.Location = new Point(36, 252);
            btnOwnerInfo.Name = "btnOwnerInfo";
            btnOwnerInfo.Size = new Size(190, 64);
            btnOwnerInfo.TabIndex = 3;
            btnOwnerInfo.Text = "Owner Info";
            btnOwnerInfo.UseVisualStyleBackColor = false;
            btnOwnerInfo.Click += btnOwnerInfo_Click;
            // 
            // btnLocation
            // 
            btnLocation.BackColor = Color.FromArgb(23, 23, 56);
            btnLocation.Cursor = Cursors.Hand;
            btnLocation.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 249, 243);
            btnLocation.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 60, 143);
            btnLocation.FlatStyle = FlatStyle.Flat;
            btnLocation.ForeColor = Color.White;
            btnLocation.Location = new Point(306, 249);
            btnLocation.Name = "btnLocation";
            btnLocation.Size = new Size(190, 64);
            btnLocation.TabIndex = 4;
            btnLocation.Text = "Location";
            btnLocation.UseVisualStyleBackColor = false;
            btnLocation.Click += btnLocation_Click;
            // 
            // btnState
            // 
            btnState.BackColor = Color.FromArgb(23, 23, 56);
            btnState.Cursor = Cursors.Hand;
            btnState.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 249, 243);
            btnState.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 60, 143);
            btnState.FlatStyle = FlatStyle.Flat;
            btnState.ForeColor = Color.White;
            btnState.Location = new Point(594, 250);
            btnState.Name = "btnState";
            btnState.Size = new Size(190, 64);
            btnState.TabIndex = 5;
            btnState.Text = "State";
            btnState.UseVisualStyleBackColor = false;
            btnState.Click += btnState_Click;
            // 
            // Owner
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnState);
            Controls.Add(btnLocation);
            Controls.Add(btnOwnerInfo);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(23, 23, 56);
            Margin = new Padding(4);
            Name = "Owner";
            Size = new Size(880, 652);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnOwnerInfo;
        private Button btnLocation;
        private Button btnState;
    }
}
