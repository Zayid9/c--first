namespace MethodPractice
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
            label4 = new Label();
            txtBoxNumber1 = new TextBox();
            txtBoxNumber2 = new TextBox();
            txtBoxResult = new TextBox();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(393, 20);
            label1.Name = "label1";
            label1.Size = new Size(260, 32);
            label1.TabIndex = 0;
            label1.Text = "Arithematic Operations";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(150, 150);
            label2.Name = "label2";
            label2.Size = new Size(122, 32);
            label2.TabIndex = 1;
            label2.Text = "Number 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(150, 220);
            label3.Name = "label3";
            label3.Size = new Size(122, 32);
            label3.TabIndex = 2;
            label3.Text = "Number 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(150, 296);
            label4.Name = "label4";
            label4.Size = new Size(78, 32);
            label4.TabIndex = 3;
            label4.Text = "Result";
            // 
            // txtBoxNumber1
            // 
            txtBoxNumber1.Location = new Point(319, 156);
            txtBoxNumber1.Name = "txtBoxNumber1";
            txtBoxNumber1.Size = new Size(212, 27);
            txtBoxNumber1.TabIndex = 4;
            // 
            // txtBoxNumber2
            // 
            txtBoxNumber2.Location = new Point(319, 220);
            txtBoxNumber2.Name = "txtBoxNumber2";
            txtBoxNumber2.Size = new Size(212, 27);
            txtBoxNumber2.TabIndex = 5;
            // 
            // txtBoxResult
            // 
            txtBoxResult.Location = new Point(319, 301);
            txtBoxResult.Name = "txtBoxResult";
            txtBoxResult.ReadOnly = true;
            txtBoxResult.Size = new Size(212, 27);
            txtBoxResult.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(224, 386);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 42);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(399, 386);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(106, 42);
            btnSubtract.TabIndex = 8;
            btnSubtract.Text = "Subtract";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(547, 386);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(106, 42);
            btnMultiply.TabIndex = 9;
            btnMultiply.Text = "Multiply";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(718, 386);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(106, 42);
            btnDivide.TabIndex = 10;
            btnDivide.Text = "Divide";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(695, 194);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(106, 42);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 508);
            Controls.Add(btnExit);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(txtBoxResult);
            Controls.Add(txtBoxNumber2);
            Controls.Add(txtBoxNumber1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBoxNumber1;
        private TextBox txtBoxNumber2;
        private TextBox txtBoxResult;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnExit;
    }
}