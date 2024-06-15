using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Laba12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
        }

        private Word.Application wordApp;
        private Word.Document doc;

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (doc != null)
            {
                doc.Close(false);
                doc = null;
            }
            if (wordApp != null)
            {
                wordApp.Quit();
                wordApp = null;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string adress = textBox2.Text;
            string phone = textBox4.Text;
            string post = textBox3.Text;
            string data = textBox6.Text;
            string mane2 = textBox5.Text;
            string orgname = textBox8.Text;
            string orgaddress = textBox7.Text;

            string templatePath = @"D:\dr.docx";

            UpdateDocument(templatePath, name, adress, phone, post, data, mane2, orgname, orgaddress);
        }

        private void UpdateDocument(string templatePath, string name, string adress, string phone, string post, string data, string mane2, string orgname, string orgaddress)
        {
            wordApp = new Word.Application();
            doc = null;

            try
            {
                doc = wordApp.Documents.Open(templatePath);

                ReplaceText("{Name}", name, doc);
                ReplaceText("{Adress}", adress, doc);
                ReplaceText("{Phone}", phone, doc);
                ReplaceText("{Post}", post, doc);
                ReplaceText("{Data}", data, doc);
                ReplaceText("{Mane2}", mane2, doc);
                ReplaceText("{Orgname}", orgname, doc);
                ReplaceText("{Orgaddres}", orgaddress, doc);

                doc.Save();
                MessageBox.Show("Діловий лист оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            finally
            {
                if (doc != null)
                {
                    doc.Close(false);
                }
                if (wordApp != null)
                {
                    wordApp.Quit();
                }
            }
        }

        private void ReplaceText(string placeholder, string newValue, Word.Document doc)
        {
            foreach (Word.Range range in doc.StoryRanges)
            {
                Word.Find find = range.Find;
                find.Text = placeholder;
                find.Replacement.Text = newValue;
                find.Execute(Replace: Word.WdReplace.wdReplaceAll);
            }
        }
    }
}
