namespace System_Weapon
{
    partial class IndividualReport
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
            panel1 = new Panel();
            btnLogout = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnRefresh = new Button();
            btnSearch = new Button();
            comboBoxDisplays = new ComboBox();
            comboBoxIDName = new ComboBox();
            dataGridView1 = new DataGridView();
            btnPrint = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 76;
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
            btnLogout.Click += btnLogout_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(129, 12);
            label1.Name = "label1";
            label1.Size = new Size(379, 34);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Individual Report";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(comboBoxDisplays);
            groupBox1.Controls.Add(comboBoxIDName);
            groupBox1.Location = new Point(107, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(566, 86);
            groupBox1.TabIndex = 77;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Engine";
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(468, 35);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(92, 33);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(325, 35);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(137, 33);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // comboBoxDisplays
            // 
            comboBoxDisplays.FormattingEnabled = true;
            comboBoxDisplays.Location = new Point(151, 35);
            comboBoxDisplays.Name = "comboBoxDisplays";
            comboBoxDisplays.Size = new Size(168, 32);
            comboBoxDisplays.TabIndex = 1;
            // 
            // comboBoxIDName
            // 
            comboBoxIDName.FormattingEnabled = true;
            comboBoxIDName.Items.AddRange(new object[] { "ID", "Name" });
            comboBoxIDName.Location = new Point(19, 35);
            comboBoxIDName.Name = "comboBoxIDName";
            comboBoxIDName.Size = new Size(113, 32);
            comboBoxIDName.TabIndex = 0;
            comboBoxIDName.SelectedIndexChanged += comboBoxIDName_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 211);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(612, 383);
            dataGridView1.TabIndex = 78;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(407, 614);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(147, 50);
            btnPrint.TabIndex = 4;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // IndividualReport
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 700);
            Controls.Add(btnPrint);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(23, 23, 56);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "IndividualReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IndividualReport";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogout;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox comboBoxIDName;
        private ComboBox comboBoxDisplays;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Button btnRefresh;
        private Button btnPrint;
    }
}