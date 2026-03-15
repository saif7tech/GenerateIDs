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
            lblDigitLength = new Label();
            lblMaxDigitValue = new Label();
            txbDigitLength = new TextBox();
            cbxMaxValue = new ComboBox();
            groupBox2 = new GroupBox();
            lblCountRows = new Label();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exportResultAsExcelToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            languageToolStripMenuItem = new ToolStripMenuItem();
            arabicToolStripMenuItem = new ToolStripMenuItem();
            englishToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerate.Font = new Font("Segoe UI", 12F);
            btnGenerate.Location = new Point(6, 22);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(95, 61);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "إنشاء هويات";
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
            groupBox1.Controls.Add(lblDigitLength);
            groupBox1.Controls.Add(lblMaxDigitValue);
            groupBox1.Controls.Add(btnGenerate);
            groupBox1.Controls.Add(txbDigitLength);
            groupBox1.Controls.Add(cbxMaxValue);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(673, 147);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "خيارات التسلسل الامتحاني";
            // 
            // lblOfficeName
            // 
            lblOfficeName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblOfficeName.AutoSize = true;
            lblOfficeName.Font = new Font("Segoe UI", 12F);
            lblOfficeName.Location = new Point(192, 62);
            lblOfficeName.Name = "lblOfficeName";
            lblOfficeName.RightToLeft = RightToLeft.Yes;
            lblOfficeName.Size = new Size(152, 21);
            lblOfficeName.TabIndex = 9;
            lblOfficeName.Text = "رمز أختصار المؤسسة :";
            // 
            // txbOfficeSyn
            // 
            txbOfficeSyn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txbOfficeSyn.Font = new Font("Segoe UI", 12F);
            txbOfficeSyn.Location = new Point(107, 59);
            txbOfficeSyn.Name = "txbOfficeSyn";
            txbOfficeSyn.Size = new Size(79, 29);
            txbOfficeSyn.TabIndex = 8;
            // 
            // lblYear
            // 
            lblYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 12F);
            lblYear.Location = new Point(192, 26);
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
            txbYearSyn.Location = new Point(107, 23);
            txbYearSyn.Name = "txbYearSyn";
            txbYearSyn.Size = new Size(79, 29);
            txbYearSyn.TabIndex = 6;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 12F);
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(383, 108);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 21);
            lblMessage.TabIndex = 5;
            // 
            // lblDigitLength
            // 
            lblDigitLength.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDigitLength.AutoSize = true;
            lblDigitLength.Font = new Font("Segoe UI", 12F);
            lblDigitLength.Location = new Point(493, 26);
            lblDigitLength.Name = "lblDigitLength";
            lblDigitLength.RightToLeft = RightToLeft.Yes;
            lblDigitLength.Size = new Size(94, 21);
            lblDigitLength.TabIndex = 3;
            lblDigitLength.Text = "عدد المراتب :";
            // 
            // lblMaxDigitValue
            // 
            lblMaxDigitValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMaxDigitValue.AutoSize = true;
            lblMaxDigitValue.Font = new Font("Segoe UI", 12F);
            lblMaxDigitValue.Location = new Point(493, 62);
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
            txbDigitLength.Location = new Point(408, 23);
            txbDigitLength.Name = "txbDigitLength";
            txbDigitLength.Size = new Size(79, 29);
            txbDigitLength.TabIndex = 1;
            // 
            // cbxMaxValue
            // 
            cbxMaxValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbxMaxValue.Font = new Font("Segoe UI", 12F);
            cbxMaxValue.FormattingEnabled = true;
            cbxMaxValue.Location = new Point(416, 59);
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
            lblCountRows.Location = new Point(521, 246);
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
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, languageToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(710, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportResultAsExcelToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exportResultAsExcelToolStripMenuItem
            // 
            exportResultAsExcelToolStripMenuItem.Name = "exportResultAsExcelToolStripMenuItem";
            exportResultAsExcelToolStripMenuItem.Size = new Size(213, 22);
            exportResultAsExcelToolStripMenuItem.Text = "تصدير النتائج الى ملف أكسل";
            exportResultAsExcelToolStripMenuItem.Click += exportResultAsExcelToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(213, 22);
            exitToolStripMenuItem.Text = "إنهاء";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arabicToolStripMenuItem, englishToolStripMenuItem });
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            languageToolStripMenuItem.Size = new Size(88, 20);
            languageToolStripMenuItem.Text = "English/عربي";
            // 
            // arabicToolStripMenuItem
            // 
            arabicToolStripMenuItem.Name = "arabicToolStripMenuItem";
            arabicToolStripMenuItem.Size = new Size(180, 22);
            arabicToolStripMenuItem.Text = "عربي";
            arabicToolStripMenuItem.Click += arabicToolStripMenuItem_Click;
            // 
            // englishToolStripMenuItem
            // 
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            englishToolStripMenuItem.Size = new Size(180, 22);
            englishToolStripMenuItem.Text = "English";
            englishToolStripMenuItem.Click += englishToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            Text = "تطبيق IMT الامتحاني";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        private GroupBox groupBox1;
        private Label lblMaxDigitValue;
        private TextBox txbDigitLength;
        private ComboBox cbxMaxValue;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label lblMessage;
        private Label lblDigitLength;
        private Label lblCountRows;
        private Label lblYear;
        private TextBox txbYearSyn;
        private Label lblOfficeName;
        private TextBox txbOfficeSyn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exportResultAsExcelToolStripMenuItem;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem arabicToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
