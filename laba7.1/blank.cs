using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.IO;
using System.Text.RegularExpressions;

namespace laba7._1
{
    public partial class blank : Form
    {
        public string DocName = "";
        private string BufferText = "";
        public bool IsSaved = false;



        public blank()
        {
            InitializeComponent();
            sbTime.Text = Convert.ToString(System.DateTime.Now.ToLongTimeString());
            sbTime.ToolTipText = Convert.ToString(System.DateTime.Today.ToLongDateString());
            HighlightSyntax();


        }

        private void blank_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            sbAmount.Text = "Аmount of symbols" + richTextBox1.Text.Length.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Cut()
        {
            this.BufferText = richTextBox1.SelectedText;
            richTextBox1.SelectedText = "";
        }
        public void Copy()
        {
            this.BufferText = richTextBox1.SelectedText;
        }
        public void Paste()
        {
            richTextBox1.SelectedText = this.BufferText;
        }
        public void SelectAll()
        {
            richTextBox1.SelectAll();
        }
        public void Delete()
        {
            richTextBox1.SelectedText = "";
            this.BufferText = "";
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Select();
        }

        public void Open(string OpenFileName)
        {
            if (OpenFileName == "")
            {
                return;
            }
            else
            {
                StreamReader sr = new StreamReader(OpenFileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                DocName = OpenFileName;
            }
        }

        public void Save(string SaveFileName)
        {
            if (SaveFileName == "")
            {
                return;
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(SaveFileName))
                {
                    sw.WriteLine(richTextBox1.Text);
                }
                DocName = SaveFileName;
            }
        }


        private void blank_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (IsSaved == false)
            {
                if (MessageBox.Show("Ви не зберегли файл: " + this.DocName + "?",
                    "Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Save(this.DocName);
                }
            }
            else
            {
                e.Cancel = true;
            }
        }


        public void AlignTextLeft()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }
        public void AlignTextCenter()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        public void AlignTextRight()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void HighlightSyntax()
        {

            int currentPosition = richTextBox1.SelectionStart;

            string text = richTextBox1.Text;

            richTextBox1.SelectAll();
            richTextBox1.SelectionColor = Color.Black;
            string regex = @"\b(auto|break|case|char|const|continue|default|do|double|else|enum|extern|float|for|goto|if|int|long|register|return|short|signed|sizeof|static|struct|switch|typedef|union|unsigned|void|volatile|while)\b";
            MatchCollection matches = Regex.Matches(text, regex);
            foreach (Match match in matches)
            {
                richTextBox1.Select(match.Index, match.Length);
                richTextBox1.SelectionColor = Color.Blue;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            }

            richTextBox1.SelectionStart = currentPosition;
            richTextBox1.SelectionLength = 0;

        }

        public void SaveAsRTF(string SaveFileName)
        {
            if (SaveFileName == "")
            {
                return;
            }
            else
            {
                richTextBox1.SaveFile(SaveFileName, RichTextBoxStreamType.RichText);
                DocName = SaveFileName;
                IsSaved = true;
            }
        }

    }
}
