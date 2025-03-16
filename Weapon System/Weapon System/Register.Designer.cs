namespace Weapon_System
{
    partial class Register
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBoxWeaponID = new TextBox();
            txtBoxCategoryID = new TextBox();
            txtBoxManufacturerNo = new TextBox();
            txtBoxMadeIN = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtBoxDes = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(223, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(420, 45);
            label1.TabIndex = 0;
            label1.Text = "Add Or Register Weapon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 88);
            label2.Name = "label2";
            label2.Size = new Size(117, 24);
            label2.TabIndex = 1;
            label2.Text = "Weapon ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 155);
            label3.Name = "label3";
            label3.Size = new Size(124, 24);
            label3.TabIndex = 2;
            label3.Text = "Category ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(517, 84);
            label4.Name = "label4";
            label4.Size = new Size(210, 24);
            label4.TabIndex = 3;
            label4.Text = "Manufacturer Number:";
            // 
            // txtBoxWeaponID
            // 
            txtBoxWeaponID.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxWeaponID.Location = new Point(201, 84);
            txtBoxWeaponID.Name = "txtBoxWeaponID";
            txtBoxWeaponID.Size = new Size(300, 28);
            txtBoxWeaponID.TabIndex = 5;
            // 
            // txtBoxCategoryID
            // 
            txtBoxCategoryID.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxCategoryID.Location = new Point(201, 155);
            txtBoxCategoryID.Name = "txtBoxCategoryID";
            txtBoxCategoryID.Size = new Size(300, 28);
            txtBoxCategoryID.TabIndex = 6;
            // 
            // txtBoxManufacturerNo
            // 
            txtBoxManufacturerNo.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxManufacturerNo.Location = new Point(733, 84);
            txtBoxManufacturerNo.Name = "txtBoxManufacturerNo";
            txtBoxManufacturerNo.Size = new Size(167, 28);
            txtBoxManufacturerNo.TabIndex = 7;
            // 
            // txtBoxMadeIN
            // 
            txtBoxMadeIN.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxMadeIN.Location = new Point(201, 208);
            txtBoxMadeIN.Name = "txtBoxMadeIN";
            txtBoxMadeIN.Size = new Size(300, 28);
            txtBoxMadeIN.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 208);
            label5.Name = "label5";
            label5.Size = new Size(89, 24);
            label5.TabIndex = 4;
            label5.Text = "Made In:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(526, 155);
            label6.Name = "label6";
            label6.Size = new Size(117, 24);
            label6.TabIndex = 9;
            label6.Text = "Description:";
            // 
            // txtBoxDes
            // 
            txtBoxDes.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxDes.Location = new Point(653, 151);
            txtBoxDes.Name = "txtBoxDes";
            txtBoxDes.Size = new Size(247, 28);
            txtBoxDes.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(130, 265);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 52);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(297, 265);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(113, 52);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(482, 265);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 52);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(644, 265);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 52);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(126, 178, 221);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 348);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(969, 347);
            dataGridView1.TabIndex = 15;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 123, 160);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtBoxDes);
            Controls.Add(label6);
            Controls.Add(txtBoxMadeIN);
            Controls.Add(txtBoxManufacturerNo);
            Controls.Add(txtBoxCategoryID);
            Controls.Add(txtBoxWeaponID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Register";
            Size = new Size(970, 695);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBoxWeaponID;
        private TextBox txtBoxCategoryID;
        private TextBox txtBoxManufacturerNo;
        private TextBox txtBoxMadeIN;
        private Label label5;
        private Label label6;
        private TextBox txtBoxDes;
        private Button btnSave;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridView1;
    }
}
