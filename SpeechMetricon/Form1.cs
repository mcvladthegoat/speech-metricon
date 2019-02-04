using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace SpeechMetricon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "In";
            dataGridView1.Columns[1].Name = "Out";
            dataGridView1.Columns[2].Name = "WER %";
            dataGridView1.Columns[3].Name = "WCR %";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            inStrings = new List<string>();
            outStrings = new List<string>();
            markedUpStrings = new List<string>();
        }

        List<string> inStrings, outStrings, markedUpStrings;
        double SERValue, WERValue, WCRValue;

        private void openLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openInStrings = new OpenFileDialog();
            openInStrings.Title = "Select a txt list with input strings";

            OpenFileDialog openOutStrings = new OpenFileDialog();
            openOutStrings.Title = "And select a txt list with output strings";
            if (openInStrings.ShowDialog() != DialogResult.OK || openOutStrings.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Select input and output files to proceed");
                return;
            }
            inStrings.Clear();
            outStrings.Clear();
            SERValue = 0; WERValue = 0; WCRValue = 0;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            var inFile = File.ReadAllLines(openInStrings.FileName);
            var outFile = File.ReadAllLines(openOutStrings.FileName);

            inStrings = new List<string>(inFile);
            outStrings = new List<string>(outFile);

            if (inStrings.Count != outStrings.Count)
            {
                MessageBox.Show("Both files should have same line count");
                return;
            }

            CalculateMetricsAndFill();


            //StreamReader reader = new StreamReader(openInStrings.FileName);
            //string line;
            //while ((line = reader.ReadLine()) != null)
            //{
            //    inStrings.Add(line);
            //}
        }

        public void CalculateMetricsAndFill()
        {     
            //Dispay results
            int index = 0;
            foreach (var line in inStrings)
            {
                string lineResultMarkup = "";
                double[] lineResultRates = new double[2];
                this.CalculateWR(line, outStrings[index], ref lineResultMarkup, ref lineResultRates);
                this.markedUpStrings.Add(lineResultMarkup);
                string[] row = new string[] { line, outStrings[index], lineResultRates[0].ToString("0.##"), lineResultRates[1].ToString("0.##") };
                dataGridView1.Rows.Add(row);
                System.Diagnostics.Debug.WriteLine(row);
                index++;
                if (lineResultRates[0] > 0)
                {
                    this.SERValue++;
                }
                this.WERValue += lineResultRates[0];
                this.WCRValue += lineResultRates[1];
            }
            this.wcrLabel.Text = (WCRValue / this.inStrings.Count()).ToString("0.##");
            this.werLabel.Text = (WERValue / this.inStrings.Count()).ToString("0.##");
            this.serLabel.Text = SERValue.ToString("0.##");
            this.totalLinesLabel.Text = this.inStrings.Count().ToString();
        }


        public void CalculateWR(String a, String b, ref string resultMarkup, ref double[] rates)
        {
            var punctuationIn = a.Where(Char.IsPunctuation).Distinct().ToArray();
            var punctuationOut = b.Where(Char.IsPunctuation).Distinct().ToArray();

            var r = a.ToLower().Split().Select(z => z.Trim(punctuationIn));
            var h = b.ToLower().Split().Select(z => z.Trim(punctuationOut));

            double deletion, substitution, insertion, correct;
            double[,] d = new double[r.Count() + 1, h.Count() + 1];


            for (int i = 0; i < r.Count() + 1; i++)
            {
                for (int j = 0; j < h.Count() + 1; j++)
                {
                    if (i == 0)
                    {
                        d[0, j] = j;
                    }
                    else if (j == 0)
                    {
                        d[i, 0] = i;
                    }
                }
            }

            for (int i = 1; i < r.Count()+1; i++)
            {
                for (int j = 1; j < h.Count()+1; j++)
                {
                    if (r.ElementAt(i - 1) == h.ElementAt(j - 1))
                    {
                        d[i, j] = d[i - 1, j - 1];
                    }
                    else
                    {
                        substitution = d[i - 1, j - 1] + 1;
                        insertion = d[i, j - 1] + 1;
                        deletion = d[i - 1, j] + 1;
                        d[i, j] = Math.Min(substitution, Math.Min(insertion, deletion));
                    }
                }
            }

            double wer = d[r.Count(), h.Count()] / r.Count()*100;
            Debug.Write("WER (%): ");
            Debug.WriteLine(wer);

            int x = r.Count(),
                y = h.Count();
            double wcr = 0;
            
            while (true)
            {
                if (x == 0 || y == 0)
                {
                    break;
                }
                if (r.ElementAt(x - 1) == h.ElementAt(y - 1))
                {
                    x--;
                    y--;
                    wcr++;
                    resultMarkup = h.ElementAt(y) + " " + resultMarkup;
                }
                else if (d[x, y] == d[x - 1, y - 1] + 1) //substitution
                {
                    x--;
                    y--;
                    resultMarkup = " _sub(" + r.ElementAt(x) + "," + h.ElementAt(y) + ") " + resultMarkup;
                }
                else if (d[x, y] == d[x - 1, y] + 1) //deletion
                {
                    x--;
                    resultMarkup = " _del(" + r.ElementAt(x) + ") " + resultMarkup;
                }
                else if (d[x, y] == d[x, y - 1] + 1) //insertion
                {
                    y--;
                    resultMarkup = " _ins(" + h.ElementAt(y) + ") " + resultMarkup;

                }
            }
            wcr =  (wcr / r.Count()) * 100;
            rates = new double[] { wer, wcr };
        }

        private void openRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void makeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            var csv = new StringBuilder();
            csv.AppendLine("Reference,Hypothesis,WER(%),WCR(%),|,SER(%),Average WER(%),Average WCR(%)");

            csv.AppendLine(string.Format("-,-,-,-, ,{0},{1},{2}", this.SERValue, this.WERValue, this.WCRValue));

            for (int i = 0; i < this.inStrings.Count; i++)
            {
                string buffer = string.Format("\"{0}\",\"{1}\",{2},{3}, ,,,", this.inStrings[i], this.outStrings[i], dataGridView1.Rows[i].Cells[2].Value, dataGridView1.Rows[i].Cells[3].Value);
                csv.AppendLine(buffer);
            }
            File.WriteAllText(saveFileDialog1.FileName, csv.ToString());

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            richTextBox1.Clear();
            var splitted = this.markedUpStrings[e.Row.Index].Split(' ');
            foreach(var k in splitted){
                if (k.Contains("_del")) //deletion
                {
                    string buffer = k.Substring(k.IndexOf('(') + 1, k.IndexOf(')') - k.IndexOf('(') - 1);
                    richTextBox1.SelectionBackColor = Color.Red;
                    richTextBox1.AppendText(buffer);
                }
                else if (k.Contains("_ins")) //insertion
                {
                    string buffer = k.Substring(k.IndexOf("(") + 1, k.IndexOf(")")- k.IndexOf('(') - 1);
                    richTextBox1.SelectionBackColor = Color.Aqua;
                    richTextBox1.AppendText(buffer);
                }
                else if (k.Contains("_sub")) //substitution
                {
                    string buffer = k.Substring(k.IndexOf("(") + 1, k.IndexOf(",") - k.IndexOf('(') - 1);
                    richTextBox1.SelectionBackColor = Color.Orange;
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Strikeout);
                    richTextBox1.AppendText(buffer);
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
                    buffer = k.Substring(k.IndexOf(","), k.Length-1 - k.IndexOf(","));
                    richTextBox1.AppendText(buffer);
                }
                else //correct word
                {
                    richTextBox1.SelectionBackColor = Color.White;
                    richTextBox1.AppendText(k);
                }
                richTextBox1.SelectionBackColor = Color.White;
                richTextBox1.AppendText(" ");
            }

            //richTextBox1.AppendText(this.markedUpStrings[e.Row.Index]);
        }

        private void makeReportRTFToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
