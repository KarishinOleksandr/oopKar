using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Введыть ваш масив";
            label2.Text = "Result";
            lblResult.Text = "";
            lblResult2.Text = "";
        }

        private void btnOK1_Click(object sender, EventArgs e)
        {
            if (txt1.TextLength != 0)
            {
                string[] stringArray = txt1.Text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                stringArray = stringArray.Select(s => s.Trim()).ToArray(); // Очищення від зайвих пробілів

                Dictionary<string, int> stringCount = new Dictionary<string, int>();

                foreach (string str in stringArray)
                {
                    if (stringCount.ContainsKey(str))
                    {
                        stringCount[str]++;
                    }
                    else
                    {
                        stringCount[str] = 1;
                    }
                }

                int n = (int)numericUpDown.Value;
                int countWithNStartingChars = stringArray.Count(s => s.Length >= n && s.Substring(0, n).All(c => c == s[0]));

                lblResult.Text = "Кількість однакових рядків: " + stringCount.Count;
                lblResult2.Text = $"Кількість рядків, що починаються з {n} однакових символів: {countWithNStartingChars}";
            }
            else
            {
                MessageBox.Show("Invalid input data!");
            }
        }

    }
}
