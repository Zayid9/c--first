namespace Weapon_System
{
    partial class State
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
            txtBoxStateNumber = new TextBox();
            txtBoxName = new TextBox();
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
            label1.Font = new Font("Tahoma", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 0);
            label1.Name = "label1";
            label1.Size = new Size(444, 53);
            label1.TabIndex = 0;
            label1.Text = "State Of The Weapon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 126);
            label2.Name = "label2";
            label2.Size = new Size(140, 24);
            label2.TabIndex = 1;
            label2.Text = "State Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 174);
            label3.Name = "label3";
            label3.Size = new Size(122, 24);
            label3.TabIndex = 2;
            label3.Text = "State Name:";
            // 
            // txtBoxStateNumber
            // 
            txtBoxStateNumber.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxStateNumber.Location = new Point(233, 126);
            txtBoxStateNumber.Name = "txtBoxStateNumber";
            txtBoxStateNumber.Size = new Size(373, 29);
            txtBoxStateNumber.TabIndex = 3;
            // 
            // txtBoxName
            // 
            txtBoxName.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxName.Location = new Point(233, 174);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(373, 29);
            txtBoxName.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(119, 256);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 52);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(286, 256);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(113, 52);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(466, 256);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 52);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(644, 256);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 52);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(126, 178, 221);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 338);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(967, 357);
            dataGridView1.TabIndex = 12;
            // 
            // State
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 123, 160);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtBoxName);
            Controls.Add(txtBoxStateNumber);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "State";
            Size = new Size(970, 695);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxStateNumber;
        private TextBox txtBoxName;
        private Button btnSave;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridView1;
    }
}
