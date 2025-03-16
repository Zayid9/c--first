namespace System_Weapon
{
    partial class Weapons
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
            txtBoxWeaponName = new TextBox();
            label4 = new Label();
            btnLogout = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnSave = new Button();
            txtBoxManuNo = new TextBox();
            label6 = new Label();
            label2 = new Label();
            txtBoxWeaponID = new TextBox();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label9 = new Label();
            comboBoxCatIDFK = new ComboBox();
            txtBoxDes = new TextBox();
            label8 = new Label();
            txtBoxMadeIn = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBoxWeaponName
            // 
            txtBoxWeaponName.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxWeaponName.ForeColor = Color.FromArgb(23, 23, 56);
            txtBoxWeaponName.Location = new Point(472, 84);
            txtBoxWeaponName.Name = "txtBoxWeaponName";
            txtBoxWeaponName.Size = new Size(177, 28);
            txtBoxWeaponName.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(341, 90);
            label4.Name = "label4";
            label4.Size = new Size(125, 22);
            label4.TabIndex = 52;
            label4.Text = "WeaponName:";
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
            btnLogout.TabIndex = 32;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(161, 9);
            label1.Name = "label1";
            label1.Size = new Size(284, 34);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Weapons";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 379);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(696, 322);
            dataGridView1.TabIndex = 49;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(23, 23, 56);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 249, 243);
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 60, 143);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(532, 304);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 58);
            btnDelete.TabIndex = 48;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(23, 23, 56);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 249, 243);
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 60, 143);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(360, 304);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 58);
            btnUpdate.TabIndex = 47;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(23, 23, 56);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 249, 243);
            btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 60, 143);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(188, 304);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 58);
            btnClear.TabIndex = 46;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(23, 23, 56);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 249, 243);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 60, 143);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(18, 304);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 58);
            btnSave.TabIndex = 45;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtBoxManuNo
            // 
            txtBoxManuNo.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxManuNo.ForeColor = Color.FromArgb(23, 23, 56);
            txtBoxManuNo.Location = new Point(149, 129);
            txtBoxManuNo.Name = "txtBoxManuNo";
            txtBoxManuNo.Size = new Size(178, 28);
            txtBoxManuNo.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(1, 135);
            label6.Name = "label6";
            label6.Size = new Size(147, 22);
            label6.TabIndex = 41;
            label6.Text = "Manufacturer No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 88);
            label2.Name = "label2";
            label2.Size = new Size(99, 22);
            label2.TabIndex = 39;
            label2.Text = "WeaponID:";
            // 
            // txtBoxWeaponID
            // 
            txtBoxWeaponID.Enabled = false;
            txtBoxWeaponID.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxWeaponID.ForeColor = Color.FromArgb(23, 23, 56);
            txtBoxWeaponID.Location = new Point(123, 86);
            txtBoxWeaponID.Name = "txtBoxWeaponID";
            txtBoxWeaponID.Size = new Size(178, 28);
            txtBoxWeaponID.TabIndex = 42;
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
            panel1.TabIndex = 38;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(149, 217);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(328, 32);
            dateTimePicker1.TabIndex = 66;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 225);
            label5.Name = "label5";
            label5.Size = new Size(140, 22);
            label5.TabIndex = 67;
            label5.Text = "Production Year:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(0, 171);
            label9.Name = "label9";
            label9.Size = new Size(105, 22);
            label9.TabIndex = 70;
            label9.Text = "CategoryID:";
            // 
            // comboBoxCatIDFK
            // 
            comboBoxCatIDFK.FormattingEnabled = true;
            comboBoxCatIDFK.Location = new Point(123, 165);
            comboBoxCatIDFK.Name = "comboBoxCatIDFK";
            comboBoxCatIDFK.Size = new Size(178, 32);
            comboBoxCatIDFK.TabIndex = 71;
            // 
            // txtBoxDes
            // 
            txtBoxDes.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxDes.ForeColor = Color.FromArgb(23, 23, 56);
            txtBoxDes.Location = new Point(468, 171);
            txtBoxDes.Name = "txtBoxDes";
            txtBoxDes.Size = new Size(181, 28);
            txtBoxDes.TabIndex = 73;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(358, 176);
            label8.Name = "label8";
            label8.Size = new Size(103, 22);
            label8.TabIndex = 72;
            label8.Text = "Description:";
            // 
            // txtBoxMadeIn
            // 
            txtBoxMadeIn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxMadeIn.ForeColor = Color.FromArgb(23, 23, 56);
            txtBoxMadeIn.Location = new Point(468, 129);
            txtBoxMadeIn.Name = "txtBoxMadeIn";
            txtBoxMadeIn.Size = new Size(178, 28);
            txtBoxMadeIn.TabIndex = 75;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(372, 131);
            label3.Name = "label3";
            label3.Size = new Size(78, 22);
            label3.TabIndex = 74;
            label3.Text = "Made in:";
            // 
            // Weapons
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(696, 700);
            Controls.Add(txtBoxMadeIn);
            Controls.Add(label3);
            Controls.Add(txtBoxDes);
            Controls.Add(label8);
            Controls.Add(comboBoxCatIDFK);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtBoxWeaponName);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtBoxManuNo);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(txtBoxWeaponID);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(23, 23, 56);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Weapons";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Weapons";
            Load += Weapons_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBoxWeaponName;
        private Label label4;
        private Button btnLogout;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnSave;
        private TextBox txtBoxManuNo;
        private Label label6;
        private Label label2;
        private TextBox txtBoxWeaponID;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label9;
        private ComboBox comboBoxCatIDFK;
        private TextBox txtBoxDes;
        private Label label8;
        private TextBox txtBoxMadeIn;
        private Label label3;
    }
}