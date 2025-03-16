namespace WindowsFormsApp1
{
    partial class Owners
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOwnerInfo = new System.Windows.Forms.Button();
            this.btnLocations = new System.Windows.Forms.Button();
            this.btnState = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 74);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F);
            this.label1.Location = new System.Drawing.Point(189, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Owners Information";
            // 
            // btnOwnerInfo
            // 
            this.btnOwnerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.btnOwnerInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOwnerInfo.FlatAppearance.BorderSize = 0;
            this.btnOwnerInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(249)))), ((int)(((byte)(243)))));
            this.btnOwnerInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(143)))));
            this.btnOwnerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOwnerInfo.ForeColor = System.Drawing.Color.White;
            this.btnOwnerInfo.Location = new System.Drawing.Point(53, 253);
            this.btnOwnerInfo.Name = "btnOwnerInfo";
            this.btnOwnerInfo.Size = new System.Drawing.Size(190, 64);
            this.btnOwnerInfo.TabIndex = 8;
            this.btnOwnerInfo.Text = "OwnerInfo";
            this.btnOwnerInfo.UseVisualStyleBackColor = false;
            this.btnOwnerInfo.Click += new System.EventHandler(this.btnOwnerInfo_Click);
            // 
            // btnLocations
            // 
            this.btnLocations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.btnLocations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocations.FlatAppearance.BorderSize = 0;
            this.btnLocations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(249)))), ((int)(((byte)(243)))));
            this.btnLocations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(143)))));
            this.btnLocations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocations.ForeColor = System.Drawing.Color.White;
            this.btnLocations.Location = new System.Drawing.Point(344, 253);
            this.btnLocations.Name = "btnLocations";
            this.btnLocations.Size = new System.Drawing.Size(190, 64);
            this.btnLocations.TabIndex = 9;
            this.btnLocations.Text = "Locations";
            this.btnLocations.UseVisualStyleBackColor = false;
            this.btnLocations.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // btnState
            // 
            this.btnState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.btnState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnState.FlatAppearance.BorderSize = 0;
            this.btnState.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(249)))), ((int)(((byte)(243)))));
            this.btnState.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(143)))));
            this.btnState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnState.ForeColor = System.Drawing.Color.White;
            this.btnState.Location = new System.Drawing.Point(642, 253);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(190, 64);
            this.btnState.TabIndex = 15;
            this.btnState.Text = "State";
            this.btnState.UseVisualStyleBackColor = false;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // Owners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnState);
            this.Controls.Add(this.btnLocations);
            this.Controls.Add(this.btnOwnerInfo);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Owners";
            this.Size = new System.Drawing.Size(880, 652);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOwnerInfo;
        private System.Windows.Forms.Button btnLocations;
        private System.Windows.Forms.Button btnState;
    }
}
