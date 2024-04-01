using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "Reeal A:";
            label4.Text = "Imaginary A:";
            label5.Text = "Real B:";
            label6.Text = "Imaginary B:";
            label7.Text = "Result:";
            button1.Text = "Calculate";
            lblResult.Text = "";
            lblResult2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ComplexNumber A = ParseComplexNumber(txtA.Text, txtA1.Text);
                ComplexNumber B = ParseComplexNumber(txtB.Text, txtB1.Text);

                var result = ComplexNumberOperations.Distribute(A, B);

                lblResult.Text = $"{result.Item1}";
                lblResult2.Text =  $"{result.Item2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format. Please enter valid real and imaginary parts.");
            }
        }
        private ComplexNumber ParseComplexNumber(string realPart, string imaginaryPart)
        {
            double real = double.Parse(realPart);
            double imaginary = double.Parse(imaginaryPart);
            return new ComplexNumber(real, imaginary);
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            if (e.KeyChar == '+' || e.KeyChar == '-')
            { return; }
            if (e.KeyChar == ',')
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
            if (e.KeyChar == (char)Keys.Space)
            { return; }
            e.Handled = true;
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            if (e.KeyChar == '+' || e.KeyChar == '-')
            { return; }
            if (e.KeyChar == ',')
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
            if (e.KeyChar == (char)Keys.Space)
            { return; }
            e.Handled = true;
        }

        private void txtA1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            if (e.KeyChar == '+' || e.KeyChar == '-')
            { return; }
            if (e.KeyChar == ',')
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
            if (e.KeyChar == (char)Keys.Space)
            { return; }
            e.Handled = true;
        }

        private void txtB1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            { return; }
            if (e.KeyChar == '+' || e.KeyChar == '-')
            { return; }
            if (e.KeyChar == ',')
            { return; }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            { return; }
            if (e.KeyChar == (char)Keys.Space)
            { return; }
            e.Handled = true;
        }
    }

    public struct ComplexNumber
    {
        public double RealPart { get; }
        public double ImaginaryPart { get; }

        public ComplexNumber(double realPart, double imaginaryPart)
        {
            RealPart = realPart;
            ImaginaryPart = imaginaryPart;
        }

        public override string ToString()
        {
            return $"{RealPart} + {ImaginaryPart}i";
        }
    }

    public static class ComplexNumberOperations
    {
        public static Tuple<ComplexNumber, ComplexNumber> Distribute(ComplexNumber A, ComplexNumber B)
        {
            double averageRealPart = (A.RealPart + B.RealPart) / 2;
            double averageImaginaryPart = (A.ImaginaryPart + B.ImaginaryPart) / 2;

            ComplexNumber C = new ComplexNumber(averageRealPart, averageImaginaryPart);
            ComplexNumber D = new ComplexNumber(averageRealPart, -averageImaginaryPart);

            return Tuple.Create(C, D);
        }
    }
}

