namespace System_Weapon
{
    partial class Reports
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
            label1 = new Label();
            panel1 = new Panel();
            btnIndividual = new Button();
            btnAll = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(285, 19);
            label1.Name = "label1";
            label1.Size = new Size(264, 34);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Reports";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 23, 56);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 70);
            panel1.TabIndex = 56;
            // 
            // btnIndividual
            // 
            btnIndividual.BackColor = Color.FromArgb(23, 23, 56);
            btnIndividual.Cursor = Cursors.Hand;
            btnIndividual.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 249, 243);
            btnIndividual.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 60, 143);
            btnIndividual.FlatStyle = FlatStyle.Flat;
            btnIndividual.ForeColor = Color.White;
            btnIndividual.Location = new Point(93, 212);
            btnIndividual.Name = "btnIndividual";
            btnIndividual.Size = new Size(186, 75);
            btnIndividual.TabIndex = 57;
            btnIndividual.Text = "Individual";
            btnIndividual.UseVisualStyleBackColor = false;
            btnIndividual.Click += btnSave_Click;
            // 
            // btnAll
            // 
            btnAll.BackColor = Color.FromArgb(23, 23, 56);
            btnAll.Cursor = Cursors.Hand;
            btnAll.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 249, 243);
            btnAll.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 60, 143);
            btnAll.FlatStyle = FlatStyle.Flat;
            btnAll.ForeColor = Color.White;
            btnAll.Location = new Point(482, 212);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(186, 75);
            btnAll.TabIndex = 58;
            btnAll.Text = "All";
            btnAll.UseVisualStyleBackColor = false;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAll);
            Controls.Add(btnIndividual);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(23, 23, 56);
            Margin = new Padding(4);
            Name = "Reports";
            Size = new Size(880, 652);
            Load += Reports_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Button btnIndividual;
        private Button btnAll;
    }
}
