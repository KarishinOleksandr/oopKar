﻿using System;
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
            label17.Text = "a1";
            label18.Text = "an";
            label19.Text = "b1";
            label20.Text = "bn";
            lblResult6.Text = "";
            btnOK6.Text = "Generate";
            label21.Text = "Input text: ";
            label24.Text = "Result: ";
            lblResult7.Text = " ";
            btnOK7.Text = "Generate";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           if(txtX.TextLength != 0)
            {
                double x = Convert.ToDouble(txtX.Text);
                double result = (Math.Log(Math.Abs(Math.Cos(x))) / Math.Log(1 + Math.Pow(x, 2)));
                lblResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Input data!");
            }

        }

        private void textX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            if (e.KeyChar == '+' || e.KeyChar == '-')
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
            e.Handled = true; ;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOk2_Click(object sender, EventArgs e)
        {
            if (txtA.TextLength != 0 || txtB.TextLength !=0 || txty.TextLength != 0)
            {
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);
                double y = Convert.ToDouble(txty.Text);
                double result2 = (((a * b) / 2) * (Math.Sin(y * Math.PI / 180)));
                lblResult2.Text = result2.ToString();
            }
            else
            {
                MessageBox.Show("Input data!");
            }
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
            if (e.KeyChar == '+' || e.KeyChar == '-')
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
            e.Handled = true;
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            if (e.KeyChar == '+' || e.KeyChar == '-')
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
            e.Handled = true;
        }

        private void txty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            if (e.KeyChar == '+' || e.KeyChar == '-')
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
            e.Handled = true;
        }

        private void btnOK3_Click(object sender, EventArgs e)
        {
            if (txtaa.TextLength !=0 || txtbb.TextLength !=0 || txtcc.TextLength !=0 || txtdd.TextLength != 0)
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
            else
            {
                MessageBox.Show("Input data!");
            }
            
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void txtaa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            if (e.KeyChar == '+' || e.KeyChar == '-')
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
            e.Handled = true;
        }

        private void txtbb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            if (e.KeyChar == '+' || e.KeyChar == '-')
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
            e.Handled = true;
        }

        private void txtcc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            if (e.KeyChar == '+' || e.KeyChar == '-')
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
            e.Handled = true;
        }

        private void txtdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            if (e.KeyChar == '+' || e.KeyChar == '-')
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
            e.Handled = true;
        }

        private void btnOK4_Click(object sender, EventArgs e)
        {
            if(txtfirst.TextLength != 0 || txtsecond.TextLength !=0 || txtthird.TextLength != 0)
            {
                double first = Convert.ToDouble(txtfirst.Text);
                double second = Convert.ToDouble(txtsecond.Text);
                double third = Convert.ToDouble(txtthird.Text);
                bool Positive = (first + second > 0) || (first + third > 0) || (second + third > 0);
                if (Positive)
                {
                    lblResult4.Text = "Sum of one is positive";
                }
            }
            else
            {
                MessageBox.Show("Input data!");
            }
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

        private void btnOK6_Click(object sender, EventArgs e)
        {

            if(txta6_1.TextLength != 0 ||  txta6_2.TextLength != 0 || txtb6_1.TextLength !=0 || txtb6_2.TextLength != 0)
            {
                int a1 = int.Parse(txta6_1.Text);
                int an = int.Parse(txta6_2.Text);
                int b1 = int.Parse(txtb6_1.Text);
                int bn = int.Parse(txtb6_2.Text);

                int[] sequenceA = GenerateSequence(a1, an);
                int[] sequenceB = GenerateSequence(b1, bn);

                TransformSequence(sequenceA, sequenceB);
                for (int i = 0; i < sequenceB.Length; i++)
                {
                    lblResult6.Text = ($"b{i + 1} = {sequenceB[i]}");
                }

                int[] GenerateSequence(int start, int end)
                {
                    int[] sequence = new int[Math.Abs(end - start) + 1];
                    for (int i = 0; i < sequence.Length; i++)
                    {
                        sequence[i] = start + i;
                    }
                    return sequence;
                }
                void TransformSequence(int[] a, int[] b)
                {
                    for (int i = 0; i < a.Length && i < b.Length; i++)
                    {
                        if (a[i] <= 0)
                        {
                            b[i] *= 10;
                        }
                        else
                        {
                            b[i] = 0;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Input data!");
            }
            
        }

        private void txta6_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            if (e.KeyChar == '+' || e.KeyChar == '-')
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
            e.Handled = true;
        }

        private void txta6_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            if (e.KeyChar == '+' || e.KeyChar == '-')
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
            e.Handled = true;
        }

        private void txtb6_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            if (e.KeyChar == '+' || e.KeyChar == '-')
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
            e.Handled = true;
        }

        private void txtb6_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            if (e.KeyChar == '+' || e.KeyChar == '-')
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
            e.Handled = true;
        }

        private void btnOK7_Click(object sender, EventArgs e)
        {
            if (txt7.TextLength != 0)
            {
                string input_txt = txt7.Text;

                int count_abc = CountABCGroups(input_txt);

                string result = Convert.ToString(count_abc);

                lblResult7.Text = result;

                int CountABCGroups(string input)
                {
                    int count = 0;

                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == 'a')
                        {
                            count++;

                        }
                        else if (input[i] == 'b')
                        {
                            count++;
                        }
                        else if (input[i] == 'c')
                        {
                            count++;
                        }

                    }

                    return count;
                }
            }
            else
            {
                MessageBox.Show("Input data!");
            }
        }
    }
}
