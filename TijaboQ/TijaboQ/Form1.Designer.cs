namespace TijaboQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBoxUse = new TextBox();
            txtBoxPass = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(246, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(231, 50);
            label1.TabIndex = 0;
            label1.Text = "Admin Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(86, 112);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(231, 50);
            label2.TabIndex = 1;
            label2.Text = "Admin Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(86, 202);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(231, 50);
            label3.TabIndex = 2;
            label3.Text = "Admin Login";
            // 
            // txtBoxUse
            // 
            txtBoxUse.Location = new Point(349, 133);
            txtBoxUse.Name = "txtBoxUse";
            txtBoxUse.Size = new Size(428, 38);
            txtBoxUse.TabIndex = 3;
            // 
            // txtBoxPass
            // 
            txtBoxPass.Location = new Point(352, 214);
            txtBoxPass.Name = "txtBoxPass";
            txtBoxPass.Size = new Size(428, 38);
            txtBoxPass.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(430, 300);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(166, 77);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 467);
            Controls.Add(btnSave);
            Controls.Add(txtBoxPass);
            Controls.Add(txtBoxUse);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxUse;
        private TextBox txtBoxPass;
        private Button btnSave;
    }
}
