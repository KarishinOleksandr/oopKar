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
            label3.Text = "a = ";
            label4.Text = "b = ";
            label5.Text = "γ = ";
            label6.Text = "Result: ";
            lblResult2.Text = " ";
            btnOk2.Text = "Generate";
            label7.Text = "a = ";
            label8.Text = "b = ";
            label9.Text = "c = ";
            label10.Text = "d = ";
            label11.Text = "Result: ";
            lblResult3.Text = "";
            btnOK3.Text = "Generate";
            label12.Text = "a = ";
            label13.Text = "b = ";
            label14.Text = "c = ";
            label15.Text = "Result: ";
            lblResult4.Text = "";
            btnOK4.Text = "Generate";
            lblResult5.Text = "";
            label16.Text = "Result: ";
            btnOK5.Text = "Generate";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtX.Text);
            double result = (Math.Log(Math.Abs(Math.Cos(x))) / Math.Log(1 + Math.Pow(x, 2)));
            lblResult.Text = result.ToString();

        }

        private void textX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            e.Handled = true;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOk2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double y = Convert.ToDouble(txty.Text);
            double result2 = (((a * b) / 2) * (Math.Sin(y * Math.PI / 180)));
            lblResult2.Text = result2.ToString();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
                e.Handled = true;
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
            e.Handled = true;
        }

        private void txty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
            e.Handled = true;
        }

        private void btnOK3_Click(object sender, EventArgs e)
        {
            double aa = Convert.ToDouble(txtaa.Text);
            double bb = Convert.ToDouble(txtbb.Text);
            double c = Convert.ToDouble(txtcc.Text);
            double d = Convert.ToDouble(txtdd.Text);
            double check1 = (aa / c);
            double check2 = (bb / d);
            double check3 = (aa / d);
            double check4 = (bb / c);
            if (check1 == check2)
            { lblResult3.Text = "true"; }
            else if (check3 == check4)
            { lblResult3.Text = "true"; }
            else { lblResult3.Text = "false"; }
            
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void txtaa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
            e.Handled = true;
        }

        private void txtbb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
            e.Handled = true;
        }

        private void txtcc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
            e.Handled = true;
        }

        private void txtdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
            e.Handled = true;
        }

        private void btnOK4_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(txtfirst.Text);
            double second = Convert.ToDouble(txtsecond.Text);
            double third = Convert.ToDouble(txtthird.Text);
            bool Positive = (first + second > 0) ||(first + third > 0) || (second + third > 0);
            if (Positive)
            {
                lblResult4.Text = "Sum of one is positive";
            }
            else 
            { lblResult4.Text = "Sum of any is negative"; }
        }

        private void txtfirst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            if (e.KeyChar == '+' || e.KeyChar == '-')
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
            e.Handled = true;
        }

        private void txtsecond_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            if (e.KeyChar == '+' || e.KeyChar == '-')
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
            e.Handled = true;
        }

        private void txtthird_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            if (e.KeyChar == '+' || e.KeyChar == '-')
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
            e.Handled = true;
        }

        private void btnOK5_Click(object sender, EventArgs e)
        {
            for (int age = 100; age <= 150; age++)
            {
                for (int day = 1; day <= 31; day++)
                {
                    if (IsCorrectAge(age, day))
                    {
                        string age2 = Convert.ToString(age);
                        lblResult5.Text = age2;
                        return;
                    }
                }
            }
            int CalculateSumOfSquares(int number)
            {
                int sum = 0;
                while (number > 0)
                {
                    int digit = number % 10;
                    sum += digit * digit;
                    number /= 10;
                }
                return sum;
            }
            bool IsCorrectAge(int age, int day)
            {
                int sumOfSquares = CalculateSumOfSquares(age);
                int result = sumOfSquares + day;
                return result == age;

            }
            
        }
    }
}
