namespace Weapon_System
{
    partial class Cat
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
            txtBoxCatName = new TextBox();
            txtBoxCatNum = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(126, 178, 221);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 284);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(970, 341);
            dataGridView1.TabIndex = 23;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(689, 215);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 47);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(484, 215);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 47);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(305, 215);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(113, 47);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(106, 215);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 47);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtBoxDes
            // 
            txtBoxDes.Location = new Point(690, 157);
            txtBoxDes.Name = "txtBoxDes";
            txtBoxDes.Size = new Size(264, 26);
            txtBoxDes.TabIndex = 18;
            // 
            // txtBoxCatName
            // 
            txtBoxCatName.Location = new Point(348, 157);
            txtBoxCatName.Name = "txtBoxCatName";
            txtBoxCatName.Size = new Size(249, 26);
            txtBoxCatName.TabIndex = 17;
            // 
            // txtBoxCatNum
            // 
            txtBoxCatNum.Location = new Point(51, 157);
            txtBoxCatNum.Name = "txtBoxCatNum";
            txtBoxCatNum.Size = new Size(216, 26);
            txtBoxCatNum.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(710, 94);
            label4.Name = "label4";
            label4.Size = new Size(117, 24);
            label4.TabIndex = 15;
            label4.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(366, 94);
            label3.Name = "label3";
            label3.Size = new Size(155, 24);
            label3.TabIndex = 14;
            label3.Text = "Category Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 94);
            label2.Name = "label2";
            label2.Size = new Size(173, 24);
            label2.TabIndex = 13;
            label2.Text = "Category Number:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, -71);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(230, 18);
            label1.TabIndex = 12;
            label1.Text = "Category or Type Of the Weapon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(147, 0);
            label5.Name = "label5";
            label5.Size = new Size(610, 45);
            label5.TabIndex = 24;
            label5.Text = "Categories or Type Of The Weapons";
            // 
            // Cat
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 123, 160);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtBoxDes);
            Controls.Add(txtBoxCatName);
            Controls.Add(txtBoxCatNum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Cat";
            Size = new Size(970, 626);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox txtBoxCatName;
        private TextBox txtBoxCatNum;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
    }
}
