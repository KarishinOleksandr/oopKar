using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CountNegatives(double[] numbers)
        {
            return numbers.Count(x => x < 0);
        }

        private double SumAfterMinModulus(double[] numbers)
        {
            double minModulus = numbers.Select(Math.Abs).Min();
            int minIndex = Array.IndexOf(numbers, minModulus);
            double sum = numbers.Skip(minIndex + 1).Sum();
            return sum;
        }

        private double[] ReplaceNegativesWithSquares(double[] numbers)
        {
            double[] squaredNumbers = numbers.Select(x => x < 0 ? x * x : x).ToArray();
            Array.Sort(squaredNumbers);
            return squaredNumbers;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Ваш масив: ";
            label2.Text = "Result: ";
            lblResult.Text = "";
            btnOk1.Text = "Сума мінусових";
            btnOk2.Text = "Сума після меншого";
            btnOk3.Text = "Заміна";
        }

        private void btnOk1_Click(object sender, EventArgs e)
        {
            if (txtArray.TextLength != 0)
            {
                string[] numbersStr = txtArray.Text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                double[] numbers = Array.ConvertAll(numbersStr, double.Parse);

                int negativeCount = CountNegatives(numbers);

                lblResult.Text = negativeCount.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input data!");
            }
        }

        private void btnOk2_Click(object sender, EventArgs e)
        {
            if (txtArray.TextLength != 0)
            {
                string[] numbersStr = txtArray.Text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                double[] numbers = Array.ConvertAll(numbersStr, double.Parse);

                double sumAfterMinModulus = SumAfterMinModulus(numbers);

                lblResult.Text = sumAfterMinModulus.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input data!");
            }
        }

        private void btnOk3_Click(object sender, EventArgs e)
        {
            if (txtArray.TextLength != 0)
            {
                string[] numbersStr = txtArray.Text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                double[] numbers = Array.ConvertAll(numbersStr, double.Parse);

                double[] squaredNumbers = ReplaceNegativesWithSquares(numbers);

                lblResult.Text = string.Join(", ", squaredNumbers);
            }
            else
            {
                MessageBox.Show("Invalid input data!");
            }
        }
    }
}
