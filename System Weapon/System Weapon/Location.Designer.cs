namespace System_Weapon
{
    partial class Location
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
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnSave = new Button();
            txtBoxVillage = new TextBox();
            txtBoxDistrict = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBoxLocationID = new TextBox();
            panel1 = new Panel();
            btnLogout = new Button();
            txtBoxDesc = new TextBox();
            label5 = new Label();
            txtBoxCity = new TextBox();
            label4 = new Label();
            label7 = new Label();
            ComboBoxOwnerIDFK = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 366);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(696, 335);
            dataGridView1.TabIndex = 31;
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
            btnDelete.Location = new Point(536, 274);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 58);
            btnDelete.TabIndex = 30;
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
            btnUpdate.Location = new Point(364, 274);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 58);
            btnUpdate.TabIndex = 29;
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
            btnClear.Location = new Point(192, 274);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 58);
            btnClear.TabIndex = 28;
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
            btnSave.Location = new Point(22, 274);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 58);
            btnSave.TabIndex = 27;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtBoxVillage
            // 
            txtBoxVillage.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxVillage.ForeColor = Color.FromArgb(23, 23, 56);
            txtBoxVillage.Location = new Point(111, 199);
            txtBoxVillage.Name = "txtBoxVillage";
            txtBoxVillage.Size = new Size(227, 28);
            txtBoxVillage.TabIndex = 26;
            // 
            // txtBoxDistrict
            // 
            txtBoxDistrict.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxDistrict.ForeColor = Color.FromArgb(23, 23, 56);
            txtBoxDistrict.Location = new Point(111, 152);
            txtBoxDistrict.Name = "txtBoxDistrict";
            txtBoxDistrict.Size = new Size(227, 28);
            txtBoxDistrict.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 205);
            label6.Name = "label6";
            label6.Size = new Size(67, 22);
            label6.TabIndex = 21;
            label6.Text = "Village:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 158);
            label3.Name = "label3";
            label3.Size = new Size(70, 22);
            label3.TabIndex = 18;
            label3.Text = "District:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 103);
            label2.Name = "label2";
            label2.Size = new Size(107, 22);
            label2.TabIndex = 17;
            label2.Text = "Location ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 9);
            label1.Name = "label1";
            label1.Size = new Size(364, 34);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Owner Location";
            // 
            // txtBoxLocationID
            // 
            txtBoxLocationID.Enabled = false;
            txtBoxLocationID.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxLocationID.ForeColor = Color.FromArgb(23, 23, 56);
            txtBoxLocationID.Location = new Point(132, 101);
            txtBoxLocationID.Name = "txtBoxLocationID";
            txtBoxLocationID.Size = new Size(190, 28);
            txtBoxLocationID.TabIndex = 22;
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
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
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
            // txtBoxDesc
            // 
            txtBoxDesc.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxDesc.ForeColor = Color.FromArgb(23, 23, 56);
            txtBoxDesc.Location = new Point(444, 158);
            txtBoxDesc.Name = "txtBoxDesc";
            txtBoxDesc.Size = new Size(227, 28);
            txtBoxDesc.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(342, 164);
            label5.Name = "label5";
            label5.Size = new Size(103, 22);
            label5.TabIndex = 32;
            label5.Text = "Description:";
            // 
            // txtBoxCity
            // 
            txtBoxCity.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxCity.ForeColor = Color.FromArgb(23, 23, 56);
            txtBoxCity.Location = new Point(405, 103);
            txtBoxCity.Name = "txtBoxCity";
            txtBoxCity.Size = new Size(266, 28);
            txtBoxCity.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(353, 109);
            label4.Name = "label4";
            label4.Size = new Size(46, 22);
            label4.TabIndex = 34;
            label4.Text = "City:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(342, 209);
            label7.Name = "label7";
            label7.Size = new Size(86, 22);
            label7.TabIndex = 36;
            label7.Text = "OwnerID:";
            // 
            // ComboBoxOwnerIDFK
            // 
            ComboBoxOwnerIDFK.FormattingEnabled = true;
            ComboBoxOwnerIDFK.Location = new Point(434, 199);
            ComboBoxOwnerIDFK.Name = "ComboBoxOwnerIDFK";
            ComboBoxOwnerIDFK.Size = new Size(250, 32);
            ComboBoxOwnerIDFK.TabIndex = 37;
            ComboBoxOwnerIDFK.SelectedIndexChanged += ComboBoxOwnerIDFK_SelectedIndexChanged;
            // 
            // Location
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 700);
            Controls.Add(ComboBoxOwnerIDFK);
            Controls.Add(label7);
            Controls.Add(txtBoxCity);
            Controls.Add(label4);
            Controls.Add(txtBoxDesc);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtBoxVillage);
            Controls.Add(txtBoxDistrict);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBoxLocationID);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(23, 23, 56);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Location";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Location";
            Load += Location_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnSave;
        private TextBox txtBoxVillage;
        private TextBox txtBoxDistrict;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBoxLocationID;
        private Panel panel1;
        private Button btnLogout;
        private TextBox txtBoxDesc;
        private Label label5;
        private TextBox txtBoxCity;
        private Label label4;
        private Label label7;
        private ComboBox ComboBoxOwnerIDFK;
    }
}