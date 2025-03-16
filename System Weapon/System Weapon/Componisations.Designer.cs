namespace System_Weapon
{
    partial class Componisations
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
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnSave = new Button();
            txtBoxDes = new TextBox();
            txtBoxTakeOver = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBoxCompID = new TextBox();
            panel1 = new Panel();
            label5 = new Label();
            label7 = new Label();
            txtBoxComPrice = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtBoxWeaponPrice = new TextBox();
            label9 = new Label();
            comboBoxOwnerNameFK = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 390);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(877, 262);
            dataGridView1.TabIndex = 45;
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
            btnDelete.Location = new Point(598, 314);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 58);
            btnDelete.TabIndex = 44;
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
            btnUpdate.Location = new Point(426, 314);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 58);
            btnUpdate.TabIndex = 43;
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
            btnClear.Location = new Point(254, 314);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 58);
            btnClear.TabIndex = 42;
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
            btnSave.Location = new Point(84, 314);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 58);
            btnSave.TabIndex = 41;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtBoxDes
            // 
            txtBoxDes.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxDes.ForeColor = Color.FromArgb(23, 23, 56);
            txtBoxDes.Location = new Point(567, 198);
            txtBoxDes.Name = "txtBoxDes";
            txtBoxDes.Size = new Size(244, 28);
            txtBoxDes.TabIndex = 39;
            // 
            // txtBoxTakeOver
            // 
            txtBoxTakeOver.Enabled = false;
            txtBoxTakeOver.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxTakeOver.ForeColor = Color.FromArgb(23, 23, 56);
            txtBoxTakeOver.Location = new Point(128, 198);
            txtBoxTakeOver.Name = "txtBoxTakeOver";
            txtBoxTakeOver.Size = new Size(190, 28);
            txtBoxTakeOver.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(437, 94);
            label6.Name = "label6";
            label6.Size = new Size(112, 22);
            label6.TabIndex = 36;
            label6.Text = "OwnerName:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(451, 198);
            label4.Name = "label4";
            label4.Size = new Size(103, 22);
            label4.TabIndex = 35;
            label4.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 204);
            label3.Name = "label3";
            label3.Size = new Size(91, 22);
            label3.TabIndex = 34;
            label3.Text = "TakeOver:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 96);
            label2.Name = "label2";
            label2.Size = new Size(81, 22);
            label2.TabIndex = 33;
            label2.Text = "CompID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(228, 9);
            label1.Name = "label1";
            label1.Size = new Size(365, 34);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Componisations";
            // 
            // txtBoxCompID
            // 
            txtBoxCompID.Enabled = false;
            txtBoxCompID.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxCompID.ForeColor = Color.FromArgb(23, 23, 56);
            txtBoxCompID.Location = new Point(128, 94);
            txtBoxCompID.Name = "txtBoxCompID";
            txtBoxCompID.Size = new Size(190, 28);
            txtBoxCompID.TabIndex = 37;
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
            panel1.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 262);
            label5.Name = "label5";
            label5.Size = new Size(52, 22);
            label5.TabIndex = 47;
            label5.Text = "Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(457, 151);
            label7.Name = "label7";
            label7.Size = new Size(89, 22);
            label7.TabIndex = 46;
            label7.Text = "ComPrice:";
            // 
            // txtBoxComPrice
            // 
            txtBoxComPrice.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxComPrice.ForeColor = Color.FromArgb(23, 23, 56);
            txtBoxComPrice.Location = new Point(567, 149);
            txtBoxComPrice.Name = "txtBoxComPrice";
            txtBoxComPrice.Size = new Size(244, 28);
            txtBoxComPrice.TabIndex = 48;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(97, 254);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(391, 32);
            dateTimePicker1.TabIndex = 52;
            // 
            // txtBoxWeaponPrice
            // 
            txtBoxWeaponPrice.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxWeaponPrice.ForeColor = Color.FromArgb(23, 23, 56);
            txtBoxWeaponPrice.Location = new Point(128, 145);
            txtBoxWeaponPrice.Name = "txtBoxWeaponPrice";
            txtBoxWeaponPrice.Size = new Size(190, 28);
            txtBoxWeaponPrice.TabIndex = 54;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(13, 151);
            label9.Name = "label9";
            label9.Size = new Size(117, 22);
            label9.TabIndex = 53;
            label9.Text = "WeaponPrice:";
            // 
            // comboBoxOwnerNameFK
            // 
            comboBoxOwnerNameFK.FormattingEnabled = true;
            comboBoxOwnerNameFK.Location = new Point(567, 93);
            comboBoxOwnerNameFK.Name = "comboBoxOwnerNameFK";
            comboBoxOwnerNameFK.Size = new Size(244, 32);
            comboBoxOwnerNameFK.TabIndex = 55;
            // 
            // Componisations
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBoxOwnerNameFK);
            Controls.Add(txtBoxWeaponPrice);
            Controls.Add(label9);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(txtBoxComPrice);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtBoxDes);
            Controls.Add(txtBoxTakeOver);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBoxCompID);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(23, 23, 56);
            Margin = new Padding(4);
            Name = "Componisations";
            Size = new Size(880, 652);
            Load += Componisations_Load;
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
        private TextBox txtBoxDes;
        private TextBox txtBoxTakeOver;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBoxCompID;
        private Panel panel1;
        private Label label5;
        private Label label7;
        private TextBox txtBoxComPrice;
        private DateTimePicker dateTimePicker1;
        private TextBox txtBoxWeaponPrice;
        private Label label9;
        private ComboBox comboBoxOwnerNameFK;
    }
}
