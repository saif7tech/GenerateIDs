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
                lblMessage.Text = "«·—Ã«¡ ≈œŒ«· ﬁÌ„… —ﬁ„Ì…";
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

            dataGridView1.Columns["No"].HeaderText = "«·—ﬁ„";
            dataGridView1.Columns["StudentID"].HeaderText = "ÂÊÌ… «·ÿ«·»";
            lblCountRows.Text = "⁄œœ «·ÂÊÌ«  " + dtStudents.Rows.Count;
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

        private void btnExport_Click(object sender, EventArgs e)
        {
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

                MessageBox.Show(" „  ’œÌ— «·»Ì«‰«  »‰Ã«Õ");
            }
        }
    }
}
