namespace CalculationStudentMark
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
            StudentName = new Label();
            Physics = new Label();
            Chemistry = new Label();
            Math = new Label();
            TxtBoxStudentName = new TextBox();
            textBoxPhysics = new TextBox();
            textBoxChemistry = new TextBox();
            textBoxMath = new TextBox();
            Calculate = new Button();
            lblAverage = new Label();
            grade = new Label();
            ClearButton = new Button();
            everage = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(254, 29);
            label1.Name = "label1";
            label1.Size = new Size(386, 54);
            label1.TabIndex = 0;
            label1.Text = "Student Calculations";
            // 
            // StudentName
            // 
            StudentName.AutoSize = true;
            StudentName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            StudentName.Location = new Point(51, 109);
            StudentName.Name = "StudentName";
            StudentName.Size = new Size(194, 38);
            StudentName.TabIndex = 1;
            StudentName.Text = "Student Name";
            // 
            // Physics
            // 
            Physics.AutoSize = true;
            Physics.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Physics.Location = new Point(51, 182);
            Physics.Name = "Physics";
            Physics.Size = new Size(107, 38);
            Physics.TabIndex = 2;
            Physics.Text = "Physics";
            // 
            // Chemistry
            // 
            Chemistry.AutoSize = true;
            Chemistry.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Chemistry.Location = new Point(51, 271);
            Chemistry.Name = "Chemistry";
            Chemistry.Size = new Size(141, 38);
            Chemistry.TabIndex = 3;
            Chemistry.Text = "Chemistry";
            // 
            // Math
            // 
            Math.AutoSize = true;
            Math.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Math.Location = new Point(51, 362);
            Math.Name = "Math";
            Math.Size = new Size(81, 38);
            Math.TabIndex = 4;
            Math.Text = "Math";
            // 
            // TxtBoxStudentName
            // 
            TxtBoxStudentName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBoxStudentName.Location = new Point(271, 113);
            TxtBoxStudentName.Name = "TxtBoxStudentName";
            TxtBoxStudentName.Size = new Size(434, 34);
            TxtBoxStudentName.TabIndex = 5;
            TxtBoxStudentName.TextChanged += TxtBoxStudentName_TextChanged;
            // 
            // textBoxPhysics
            // 
            textBoxPhysics.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhysics.Location = new Point(271, 186);
            textBoxPhysics.Name = "textBoxPhysics";
            textBoxPhysics.Size = new Size(434, 34);
            textBoxPhysics.TabIndex = 6;
            // 
            // textBoxChemistry
            // 
            textBoxChemistry.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxChemistry.Location = new Point(271, 275);
            textBoxChemistry.Name = "textBoxChemistry";
            textBoxChemistry.Size = new Size(434, 34);
            textBoxChemistry.TabIndex = 7;
            // 
            // textBoxMath
            // 
            textBoxMath.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMath.Location = new Point(271, 366);
            textBoxMath.Name = "textBoxMath";
            textBoxMath.Size = new Size(434, 34);
            textBoxMath.TabIndex = 8;
            // 
            // Calculate
            // 
            Calculate.Location = new Point(411, 429);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(133, 29);
            Calculate.TabIndex = 9;
            Calculate.Text = "Calculate";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblAverage.Location = new Point(711, 109);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(130, 23);
            lblAverage.TabIndex = 10;
            lblAverage.Text = "The Average is: ";
            lblAverage.Click += lblAverage_Click;
            // 
            // grade
            // 
            grade.AutoSize = true;
            grade.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            grade.Location = new Point(711, 182);
            grade.Name = "grade";
            grade.Size = new Size(112, 23);
            grade.TabIndex = 11;
            grade.Text = "The grade is: ";
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(678, 429);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(133, 29);
            ClearButton.TabIndex = 12;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // everage
            // 
            everage.AutoSize = true;
            everage.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            everage.Location = new Point(847, 109);
            everage.Name = "everage";
            everage.Size = new Size(0, 23);
            everage.TabIndex = 13;
            everage.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(829, 182);
            label2.Name = "label2";
            label2.Size = new Size(0, 23);
            label2.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(835, 182);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 482);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(everage);
            Controls.Add(ClearButton);
            Controls.Add(grade);
            Controls.Add(lblAverage);
            Controls.Add(Calculate);
            Controls.Add(textBoxMath);
            Controls.Add(textBoxChemistry);
            Controls.Add(textBoxPhysics);
            Controls.Add(TxtBoxStudentName);
            Controls.Add(Math);
            Controls.Add(Chemistry);
            Controls.Add(Physics);
            Controls.Add(StudentName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label StudentName;
        private Label Physics;
        private Label Chemistry;
        private Label Math;
        private TextBox TxtBoxStudentName;
        private TextBox textBoxPhysics;
        private TextBox textBoxChemistry;
        private TextBox textBoxMath;
        private Button Calculate;
        private Label lblAverage;
        private Label grade;
        private Button ClearButton;
        private Label everage;
        private Label label2;
        private Label label3;
    }
}