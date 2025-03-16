namespace System_Weapon
{
    partial class OwnerInfo
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
            btnLogout = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBoxOwnerID = new TextBox();
            txtBoxOwnerName = new TextBox();
            txtBoxTell = new TextBox();
            comboBoxSex = new ComboBox();
            btnSave = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            txtBoxNationality = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 23, 56);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(696, 70);
            panel1.TabIndex = 0;
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
            btnLogout.Location = new Point(637, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(47, 43);
            btnLogout.TabIndex = 16;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 9);
            label1.Name = "label1";
            label1.Size = new Size(406, 34);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Owner Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 104);
            label2.Name = "label2";
            label2.Size = new Size(92, 22);
            label2.TabIndex = 1;
            label2.Text = "Owner ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 153);
            label3.Name = "label3";
            label3.Size = new Size(118, 22);
            label3.TabIndex = 2;
            label3.Text = "Owner Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(364, 159);
            label4.Name = "label4";
            label4.Size = new Size(98, 22);
            label4.TabIndex = 3;
            label4.Text = "Telephone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(364, 104);
            label5.Name = "label5";
            label5.Size = new Size(44, 22);
            label5.TabIndex = 4;
            label5.Text = "Sex:";
            // 
            // txtBoxOwnerID
            // 
            txtBoxOwnerID.Enabled = false;
            txtBoxOwnerID.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxOwnerID.ForeColor = Color.FromArgb(23, 23, 56);
            txtBoxOwnerID.Location = new Point(132, 102);
            txtBoxOwnerID.Name = "txtBoxOwnerID";
            txtBoxOwnerID.Size = new Size(190, 28);
            txtBoxOwnerID.TabIndex = 6;
            // 
            // txtBoxOwnerName
            // 
            txtBoxOwnerName.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxOwnerName.ForeColor = Color.FromArgb(23, 23, 56);
            txtBoxOwnerName.Location = new Point(148, 153);
            txtBoxOwnerName.Name = "txtBoxOwnerName";
            txtBoxOwnerName.Size = new Size(190, 28);
            txtBoxOwnerName.TabIndex = 7;
            // 
            // txtBoxTell
            // 
            txtBoxTell.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxTell.ForeColor = Color.FromArgb(23, 23, 56);
            txtBoxTell.Location = new Point(468, 159);
            txtBoxTell.Name = "txtBoxTell";
            txtBoxTell.Size = new Size(200, 28);
            txtBoxTell.TabIndex = 8;
            // 
            // comboBoxSex
            // 
            comboBoxSex.ForeColor = Color.FromArgb(23, 23, 56);
            comboBoxSex.FormattingEnabled = true;
            comboBoxSex.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxSex.Location = new Point(431, 104);
            comboBoxSex.Name = "comboBoxSex";
            comboBoxSex.Size = new Size(151, 32);
            comboBoxSex.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(23, 23, 56);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 249, 243);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 60, 143);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(22, 285);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 58);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(23, 23, 56);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 249, 243);
            btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 60, 143);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(192, 285);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 58);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(23, 23, 56);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 249, 243);
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 60, 143);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(364, 285);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 58);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(23, 23, 56);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 249, 243);
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 60, 143);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(536, 285);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 58);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 359);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(696, 343);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtBoxNationality
            // 
            txtBoxNationality.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNationality.ForeColor = Color.FromArgb(23, 23, 56);
            txtBoxNationality.Location = new Point(148, 202);
            txtBoxNationality.Name = "txtBoxNationality";
            txtBoxNationality.Size = new Size(190, 28);
            txtBoxNationality.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(34, 202);
            label6.Name = "label6";
            label6.Size = new Size(99, 22);
            label6.TabIndex = 16;
            label6.Text = "Nationality:";
            // 
            // OwnerInfo
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 700);
            Controls.Add(txtBoxNationality);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(comboBoxSex);
            Controls.Add(txtBoxTell);
            Controls.Add(txtBoxOwnerName);
            Controls.Add(txtBoxOwnerID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(23, 23, 56);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "OwnerInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OwnerInfo";
            Load += OwnerInfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBoxOwnerID;
        private TextBox txtBoxOwnerName;
        private TextBox txtBoxTell;
        private ComboBox comboBoxSex;
        private Button btnSave;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private Button btnLogout;
        private TextBox txtBoxNationality;
        private Label label6;
    }
}