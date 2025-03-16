namespace Weapon_System
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBoxOwnerID = new TextBox();
            txtBoxName = new TextBox();
            txtBoxTell = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtBoxLocationID = new TextBox();
            ComboboxSex = new ComboBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            dataView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 10);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(411, 45);
            label1.TabIndex = 0;
            label1.Text = "Owner Of The Weapons";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 111);
            label2.Name = "label2";
            label2.Size = new Size(102, 24);
            label2.TabIndex = 1;
            label2.Text = "Owner ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 237);
            label3.Name = "label3";
            label3.Size = new Size(111, 24);
            label3.TabIndex = 2;
            label3.Text = "Telephone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 179);
            label4.Name = "label4";
            label4.Size = new Size(69, 24);
            label4.TabIndex = 3;
            label4.Text = "Name:";
            // 
            // txtBoxOwnerID
            // 
            txtBoxOwnerID.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxOwnerID.Location = new Point(159, 107);
            txtBoxOwnerID.Name = "txtBoxOwnerID";
            txtBoxOwnerID.Size = new Size(249, 28);
            txtBoxOwnerID.TabIndex = 4;
            // 
            // txtBoxName
            // 
            txtBoxName.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxName.Location = new Point(159, 179);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(249, 28);
            txtBoxName.TabIndex = 5;
            // 
            // txtBoxTell
            // 
            txtBoxTell.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxTell.Location = new Point(159, 237);
            txtBoxTell.Name = "txtBoxTell";
            txtBoxTell.Size = new Size(249, 28);
            txtBoxTell.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(455, 112);
            label5.Name = "label5";
            label5.Size = new Size(49, 24);
            label5.TabIndex = 7;
            label5.Text = "Sex:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(455, 180);
            label6.Name = "label6";
            label6.Size = new Size(119, 24);
            label6.TabIndex = 8;
            label6.Text = "Location ID:";
            // 
            // txtBoxLocationID
            // 
            txtBoxLocationID.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxLocationID.Location = new Point(580, 176);
            txtBoxLocationID.Name = "txtBoxLocationID";
            txtBoxLocationID.Size = new Size(367, 28);
            txtBoxLocationID.TabIndex = 10;
            // 
            // ComboboxSex
            // 
            ComboboxSex.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComboboxSex.FormattingEnabled = true;
            ComboboxSex.Items.AddRange(new object[] { "Male", "Female" });
            ComboboxSex.Location = new Point(580, 108);
            ComboboxSex.Name = "ComboboxSex";
            ComboboxSex.Size = new Size(151, 29);
            ComboboxSex.TabIndex = 11;
            ComboboxSex.SelectedIndexChanged += ComboboxSex_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(141, 288);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 52);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(671, 288);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 52);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(494, 288);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 52);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(314, 288);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(113, 52);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dataView
            // 
            dataView.BackgroundColor = Color.FromArgb(126, 178, 221);
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.Location = new Point(0, 369);
            dataView.Name = "dataView";
            dataView.RowHeadersWidth = 51;
            dataView.Size = new Size(970, 326);
            dataView.TabIndex = 16;
            // 
            // Owner
            // 
            AutoScaleDimensions = new SizeF(20F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 123, 160);
            Controls.Add(dataView);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(ComboboxSex);
            Controls.Add(txtBoxLocationID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtBoxTell);
            Controls.Add(txtBoxName);
            Controls.Add(txtBoxOwnerID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(8, 7, 8, 7);
            Name = "Owner";
            Size = new Size(970, 695);
            ((System.ComponentModel.ISupportInitialize)dataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBoxOwnerID;
        private TextBox txtBoxName;
        private TextBox txtBoxTell;
        private Label label5;
        private Label label6;
        private TextBox txtBoxLocationID;
        private ComboBox ComboboxSex;
        private Button btnSave;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private DataGridView dataView;
    }
}
