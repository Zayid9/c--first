namespace System_Weapon
{
    partial class Category
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
            btnLogout = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnSave = new Button();
            label2 = new Label();
            txtBoxCategoryID = new TextBox();
            panel1 = new Panel();
            txtBoxCategoryName = new TextBox();
            label3 = new Label();
            label8 = new Label();
            txtBoxDesc = new TextBox();
            label5 = new Label();
            comboBoxOwnerID = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            btnLogout.Location = new Point(634, 7);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(41, 43);
            btnLogout.TabIndex = 32;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 9);
            label1.Name = "label1";
            label1.Size = new Size(484, 34);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Category Of The Weapon";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 353);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(678, 297);
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
            btnDelete.Location = new Point(527, 280);
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
            btnUpdate.Location = new Point(355, 280);
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
            btnClear.Location = new Point(183, 280);
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
            btnSave.Location = new Point(13, 280);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 58);
            btnSave.TabIndex = 45;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 86);
            label2.Name = "label2";
            label2.Size = new Size(111, 22);
            label2.TabIndex = 39;
            label2.Text = "Category ID:";
            // 
            // txtBoxCategoryID
            // 
            txtBoxCategoryID.Enabled = false;
            txtBoxCategoryID.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxCategoryID.ForeColor = Color.FromArgb(23, 23, 56);
            txtBoxCategoryID.Location = new Point(118, 84);
            txtBoxCategoryID.Name = "txtBoxCategoryID";
            txtBoxCategoryID.Size = new Size(190, 28);
            txtBoxCategoryID.TabIndex = 42;
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
            panel1.Size = new Size(678, 70);
            panel1.TabIndex = 38;
            // 
            // txtBoxCategoryName
            // 
            txtBoxCategoryName.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxCategoryName.ForeColor = Color.FromArgb(23, 23, 56);
            txtBoxCategoryName.Location = new Point(139, 128);
            txtBoxCategoryName.Name = "txtBoxCategoryName";
            txtBoxCategoryName.Size = new Size(267, 28);
            txtBoxCategoryName.TabIndex = 57;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 134);
            label3.Name = "label3";
            label3.Size = new Size(137, 22);
            label3.TabIndex = 56;
            label3.Text = "Category Name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(13, 176);
            label8.Name = "label8";
            label8.Size = new Size(86, 22);
            label8.TabIndex = 58;
            label8.Text = "OwnerID:";
            // 
            // txtBoxDesc
            // 
            txtBoxDesc.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxDesc.ForeColor = Color.FromArgb(23, 23, 56);
            txtBoxDesc.Location = new Point(108, 217);
            txtBoxDesc.Name = "txtBoxDesc";
            txtBoxDesc.Size = new Size(446, 32);
            txtBoxDesc.TabIndex = 61;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 223);
            label5.Name = "label5";
            label5.Size = new Size(103, 22);
            label5.TabIndex = 60;
            label5.Text = "Description:";
            // 
            // comboBoxOwnerID
            // 
            comboBoxOwnerID.FormattingEnabled = true;
            comboBoxOwnerID.Location = new Point(110, 173);
            comboBoxOwnerID.Name = "comboBoxOwnerID";
            comboBoxOwnerID.Size = new Size(300, 32);
            comboBoxOwnerID.TabIndex = 62;
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 653);
            Controls.Add(comboBoxOwnerID);
            Controls.Add(txtBoxDesc);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(txtBoxCategoryName);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(txtBoxCategoryID);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(23, 23, 56);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Category";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category";
            Load += Category_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboBoxOwnerIDFK;
        private TextBox txtBoxCity;
        private Label label4;
        private Button btnLogout;
        private Label label1;
        private Label label7;
        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnSave;
        private TextBox txtBoxVillage;
        private TextBox txtBoxDistrict;
        private Label label6;
        private Label label2;
        private TextBox txtBoxCategoryID;
        private Panel panel1;
        private TextBox txtBoxCategoryName;
        private Label label3;
        private Label label8;
        private TextBox txtBoxDesc;
        private Label label5;
        private ComboBox comboBoxOwnerID;
    }
}