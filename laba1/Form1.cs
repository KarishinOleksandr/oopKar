using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "x = ";
            label2.Text = "Result: ";
            lblResult.Text = " ";
            btnOk.Text = "Generate";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textX.Text);
            double result = (Math.Log(Math.Abs(Math.Cos(x))) / Math.Log(1 + Math.Pow(x, 2)));
            lblResult.Text = result.ToString();

        }

        private void textX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {                     return;             }
            e.Handled = true;
        }
    }
}
