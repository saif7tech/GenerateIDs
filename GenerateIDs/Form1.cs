using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace GenerateIDs
{
    public partial class Form1 : Form
    {
        DataTable dtStudents = new DataTable();
        int counter = 0;
        
        bool isArabic;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9; i++)
            {
                cbxMaxValue.Items.Add(i.ToString());
            }

            isArabic = true;

            cbxMaxValue.SelectedIndex = 0;

            dtStudents.Columns.Add("No", typeof(int));
            dtStudents.Columns.Add("StudentID", typeof(string));

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            lblCountRows.Text = string.Empty;
            // ≈⁄«œ…  ÂÌ∆… «·»Ì«‰« 
            counter = 0;
            
            dtStudents.Clear();

            dataGridView1.DataSource = null;

            int DigitLength;
            int maxValue = Convert.ToInt32(cbxMaxValue.SelectedItem);

            if (!int.TryParse(txbDigitLength.Text, out DigitLength))
            {
                informMessage(2);
                //lblMessage.Text = "«·—Ã«¡ ≈œŒ«· ﬁÌ„… —ﬁ„Ì…";
                return;
            }

            if (DigitLength <= 0)
            {
                lblMessage.Text = "«·—Ã«¡ ≈œŒ«· ﬁÌ„… —ﬁ„Ì… √ﬂ»— „‰ «·’›—";
                return;
            }

            dataGridView1.SuspendLayout();

            //  Ê·Ìœ «·ÂÊÌ« 
            GenerateID("", DigitLength, maxValue);

            dataGridView1.ResumeLayout();

            // ≈⁄«œ… —»ÿ «·»Ì«‰« 
            dataGridView1.DataSource = dtStudents;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            TableLanguage();
       

        }

        private void GenerateID(string currentID, int digitLength, int maxValue)
        {

            // ‘—ÿ «· Êﬁ›
            if (currentID.Length == digitLength)
            {
                //  Ã«Â· «·ÂÊÌ… «· Ì ﬂ·Â« √’›«—
                if (currentID.All(c => c == '0'))
                    return;

                counter++;

                string formattedID = FormatStudentID(currentID);

                dtStudents.Rows.Add(counter, txbOfficeSyn.Text + txbYearSyn.Text + formattedID);
                return;
            }

            //  Ê·Ìœ «·—ﬁ„ «· «·Ì
            for (int i = 0; i <= maxValue; i++)
            {
                GenerateID(currentID + i.ToString(), digitLength, maxValue);
            }
        }

        private string FormatStudentID(string id)
        {
            List<string> parts = new List<string>();

            for (int i = 0; i < id.Length; i += 2)
            {
                parts.Add(id.Substring(i, Math.Min(2, id.Length - i)));
            }

            return string.Join("-", parts);
        }


        private void arabicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isArabic = true;

            this.RightToLeft = RightToLeft.Yes;
            this.Text = " ÿ»Ìﬁ IMT «·«„ Õ«‰Ì";

            groupBox1.Text = "ŒÌ«—«  «· ”·”· «·«„ Õ«‰Ì";
            groupBox1.RightToLeft = RightToLeft.Yes;

            groupBox2.Text = "«· ”·”· «·«„ Õ«‰Ì ··ÿ·»…";
            groupBox2.RightToLeft = RightToLeft.Yes;

            fileToolStripMenuItem.Text = "„·›";
            exportResultAsExcelToolStripMenuItem.Text = " ’œÌ— «·‰ «∆Ã «·Ï „·› √ﬂ”·";
            exitToolStripMenuItem.Text = "≈‰Â«¡";
            lblDigitLength.Text = "⁄œœ «·„—« » :";


            lblMaxDigitValue.Text = "«·ﬁÌ„… «·ﬁ’ÊÏ ··Œ«‰… :";
            lblYear.Text = "—„“ √Œ ’«— ··”‰… :";
            lblOfficeName.Text = "—„“ √Œ ’«— «·„ƒ””… :";
            btnGenerate.Text = "≈‰‘«¡ ÂÊÌ« ";

            lblCountRows.RightToLeft = RightToLeft.Yes;
            TableLanguage();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isArabic = false;
            this.RightToLeft = RightToLeft.Yes;
            this.Text = "IMT Examination Application";

            groupBox1.Text = "Exam Sequence Options";
            groupBox1.RightToLeft = RightToLeft.Yes;

            groupBox2.Text = "Students Exam Sequence";
            groupBox2.RightToLeft = RightToLeft.Yes;

            fileToolStripMenuItem.Text = "File";
            exportResultAsExcelToolStripMenuItem.Text = "Export Results to Excel";

            lblDigitLength.Text = "Number of Digit:";
            lblMaxDigitValue.Text = "Maximum Digit Value:";
            lblYear.Text = "Year Abbreviation:";
            lblOfficeName.Text = "Office Abbreviation:";
            btnGenerate.Text = "Generate IDs";
            exitToolStripMenuItem.Text = "Exit";
            lblCountRows.RightToLeft = RightToLeft.No;
            TableLanguage();
        }

        private void exportResultAsExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtStudents.Rows.Count == 0)
            {
                informMessage(0);
                // lblMessage.Text = "·«Ì„ﬂ‰ «‰‘«¡ ÃœÊ· √ﬂ”· »”»» ⁄œ„ ÊÃÊœ ‰ «∆Ã";
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel File|*.xlsx";
            sfd.Title = "Save Excel File";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(dtStudents, "Students");

                    wb.SaveAs(sfd.FileName);
                }


                //MessageBox.Show(" „  ’œÌ— «·»Ì«‰«  »‰Ã«Õ");
            }
        }

        private void TableLanguage()
        {
            dataGridView1.Columns[0].Width = 70;
            if (isArabic)
            {
                dataGridView1.RightToLeft = RightToLeft.No;
                dataGridView1.Columns[0].HeaderText = "«·—ﬁ„";
                
                dataGridView1.Columns[1].HeaderText = "ÂÊÌ… «·ÿ«·»";
                lblCountRows.Text = "⁄œœ «·«”ÿ— ( " + dtStudents.Rows.Count + " )";
            }
            else
            {
                dataGridView1.RightToLeft = RightToLeft.No;
                dataGridView1.Columns[0].HeaderText = "No";
                dataGridView1.Columns[1].HeaderText = "Student ID";
                lblCountRows.Text = "Number of Rows ( " + dtStudents.Rows.Count + " ) ";
            }


        }
        private void informMessage(int ErrorType)
        {

            switch (ErrorType)
            {
                case 0:
                    if (isArabic)
                    {
                        MessageBox.Show("·«Ì„ﬂ‰ «‰‘«¡ ÃœÊ· √ﬂ”· »”»» ⁄œ„ ÊÃÊœ ‰ «∆Ã", "›‘· «· ’œÌ—", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        MessageBox.Show("Excel file cannot be created because there are no results.", "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    break;
                case 1:
                    if (isArabic)
                    {
                        MessageBox.Show(" „  ’œÌ— «·»Ì«‰«  »‰Ã«Õ.",
                                             " „  «·⁄„·Ì… »‰Ã«Õ",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data exported successfully.",
                                             "Success",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
                    }
                    break;

                case 2:
                    if (isArabic)
                    {
                        MessageBox.Show("«·ﬁÌ„… «·„œŒ·… €Ì— ’ÕÌÕ…. Ì—ÃÏ ≈œŒ«· ⁄œœ ’ÕÌÕ ›Ì Õﬁ· ⁄œœ «·Œ«‰« .",
                                        "Œÿ√ ›Ì «·≈œŒ«·", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid integer in the 'Number of Digits' field.",
                                             "Input Error",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Exclamation);
                    }



                    break;


            }


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
