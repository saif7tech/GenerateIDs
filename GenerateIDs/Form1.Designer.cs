namespace GenerateIDs
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
            btnGenerate = new Button();
            groupBox1 = new GroupBox();
            lblOfficeName = new Label();
            txbOfficeSyn = new TextBox();
            lblYear = new Label();
            txbYearSyn = new TextBox();
            lblMessage = new Label();
            btnExport = new Button();
            lblStudentsCount = new Label();
            lblMaxDigitValue = new Label();
            txbDigitLength = new TextBox();
            cbxMaxValue = new ComboBox();
            groupBox2 = new GroupBox();
            lblCountRows = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerate.Font = new Font("Segoe UI", 12F);
            btnGenerate.Location = new Point(37, 13);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(117, 38);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "إنشاء";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lblOfficeName);
            groupBox1.Controls.Add(txbOfficeSyn);
            groupBox1.Controls.Add(lblYear);
            groupBox1.Controls.Add(txbYearSyn);
            groupBox1.Controls.Add(lblMessage);
            groupBox1.Controls.Add(btnExport);
            groupBox1.Controls.Add(lblStudentsCount);
            groupBox1.Controls.Add(lblMaxDigitValue);
            groupBox1.Controls.Add(btnGenerate);
            groupBox1.Controls.Add(txbDigitLength);
            groupBox1.Controls.Add(cbxMaxValue);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(673, 162);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "خيارات التسلسل الامتحاني";
            // 
            // lblOfficeName
            // 
            lblOfficeName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblOfficeName.AutoSize = true;
            lblOfficeName.Font = new Font("Segoe UI", 12F);
            lblOfficeName.Location = new Point(321, 89);
            lblOfficeName.Name = "lblOfficeName";
            lblOfficeName.RightToLeft = RightToLeft.Yes;
            lblOfficeName.Size = new Size(128, 21);
            lblOfficeName.TabIndex = 9;
            lblOfficeName.Text = "رمز أختصار للسنة :";
            // 
            // txbOfficeSyn
            // 
            txbOfficeSyn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txbOfficeSyn.Font = new Font("Segoe UI", 12F);
            txbOfficeSyn.Location = new Point(236, 85);
            txbOfficeSyn.Name = "txbOfficeSyn";
            txbOfficeSyn.Size = new Size(79, 29);
            txbOfficeSyn.TabIndex = 8;
            // 
            // lblYear
            // 
            lblYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 12F);
            lblYear.Location = new Point(539, 89);
            lblYear.Name = "lblYear";
            lblYear.RightToLeft = RightToLeft.Yes;
            lblYear.Size = new Size(128, 21);
            lblYear.TabIndex = 7;
            lblYear.Text = "رمز أختصار للسنة :";
            // 
            // txbYearSyn
            // 
            txbYearSyn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txbYearSyn.Font = new Font("Segoe UI", 12F);
            txbYearSyn.Location = new Point(454, 85);
            txbYearSyn.Name = "txbYearSyn";
            txbYearSyn.Size = new Size(79, 29);
            txbYearSyn.TabIndex = 6;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 12F);
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(416, 124);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 21);
            lblMessage.TabIndex = 5;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExport.Font = new Font("Segoe UI", 12F);
            btnExport.Location = new Point(6, 57);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(168, 53);
            btnExport.TabIndex = 4;
            btnExport.Text = "تصدير النتائج الى ملف أكسل";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // lblStudentsCount
            // 
            lblStudentsCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStudentsCount.AutoSize = true;
            lblStudentsCount.Font = new Font("Segoe UI", 12F);
            lblStudentsCount.Location = new Point(575, 44);
            lblStudentsCount.Name = "lblStudentsCount";
            lblStudentsCount.RightToLeft = RightToLeft.Yes;
            lblStudentsCount.Size = new Size(94, 21);
            lblStudentsCount.TabIndex = 3;
            lblStudentsCount.Text = "عدد المراتب :";
            // 
            // lblMaxDigitValue
            // 
            lblMaxDigitValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMaxDigitValue.AutoSize = true;
            lblMaxDigitValue.Font = new Font("Segoe UI", 12F);
            lblMaxDigitValue.Location = new Point(321, 44);
            lblMaxDigitValue.Name = "lblMaxDigitValue";
            lblMaxDigitValue.RightToLeft = RightToLeft.Yes;
            lblMaxDigitValue.Size = new Size(153, 21);
            lblMaxDigitValue.TabIndex = 2;
            lblMaxDigitValue.Text = "القيمة القصوى للخانة :";
            // 
            // txbDigitLength
            // 
            txbDigitLength.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txbDigitLength.Font = new Font("Segoe UI", 12F);
            txbDigitLength.Location = new Point(490, 40);
            txbDigitLength.Name = "txbDigitLength";
            txbDigitLength.Size = new Size(79, 29);
            txbDigitLength.TabIndex = 1;
            // 
            // cbxMaxValue
            // 
            cbxMaxValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbxMaxValue.Font = new Font("Segoe UI", 12F);
            cbxMaxValue.FormattingEnabled = true;
            cbxMaxValue.Location = new Point(259, 40);
            cbxMaxValue.Name = "cbxMaxValue";
            cbxMaxValue.Size = new Size(56, 29);
            cbxMaxValue.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(lblCountRows);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(0, 180);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.Yes;
            groupBox2.Size = new Size(710, 270);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "التسلسل الامتحاني للطلبة";
            // 
            // lblCountRows
            // 
            lblCountRows.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblCountRows.AutoSize = true;
            lblCountRows.Location = new Point(587, 246);
            lblCountRows.Name = "lblCountRows";
            lblCountRows.Size = new Size(0, 15);
            lblCountRows.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(704, 216);
            dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            Text = "تطبيق IMT الامتحاني";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerate;
        private GroupBox groupBox1;
        private Label lblMaxDigitValue;
        private TextBox txbDigitLength;
        private ComboBox cbxMaxValue;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button btnExport;
        private Label lblMessage;
        private Label lblStudentsCount;
        private Label lblCountRows;
        private Label lblYear;
        private TextBox txbYearSyn;
        private Label lblOfficeName;
        private TextBox txbOfficeSyn;
    }
}
