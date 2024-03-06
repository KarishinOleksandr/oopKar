using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static laba3.Form1;

namespace laba3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public abstract class Pair
        {
            public abstract Pair Add(Pair other);
            public abstract Pair Subtract(Pair other);
            public abstract Pair Multiply(Pair other);
            public abstract Pair Divide(Pair other);

            public abstract override string ToString();
        }

        public class Complex : Pair
        {
            public double Real { get; set; }
            public double Imaginary { get; set; }

            public Complex(double real, double imaginary)
            {
                Real = real;
                Imaginary = imaginary;
            }

            public override Pair Add(Pair other)
            {
                if (other is Complex)
                {
                    var complex = (Complex)other;
                    return new Complex(Real + complex.Real, Imaginary + complex.Imaginary);
                }

                throw new ArgumentException("Invalid type for addition.");
            }

            public override Pair Subtract(Pair other)
            {
                if (other is Complex)
                {
                    var complex = (Complex)other;
                    return new Complex(Real - complex.Real, Imaginary - complex.Imaginary);
                }

                throw new ArgumentException("Invalid type for subtraction.");
            }

            public override Pair Multiply(Pair other)
            {
                if (other is Complex)
                {
                    var complex = (Complex)other;
                    return new Complex(
                        Real * complex.Real - Imaginary * complex.Imaginary,
                        Real * complex.Imaginary + Imaginary * complex.Real
                    );
                }

                throw new ArgumentException("Invalid type for multiplication.");
            }

            public override Pair Divide(Pair other)
            {
                if (other is Complex)
                {
                    var complex = (Complex)other;
                    double denominator = complex.Real * complex.Real + complex.Imaginary * complex.Imaginary;

                    if (denominator != 0)
                    {
                        double realPart = (Real * complex.Real + Imaginary * complex.Imaginary) / denominator;
                        double imaginaryPart = (Imaginary * complex.Real - Real * complex.Imaginary) / denominator;

                        return new Complex(realPart, imaginaryPart);
                    }

                    throw new DivideByZeroException("Division by zero is not allowed.");
                }

                throw new ArgumentException("Invalid type for division.");
            }

            public override string ToString()
            {
                return $"{Real} + {Imaginary}i";
            }
        }

        public class Rational : Pair
        {
            public int Numerator { get; set; }
            public int Denominator { get; set; }

            public Rational(int numerator, int denominator)
            {
                if (denominator == 0)
                {
                    MessageBox.Show("Domminator cannot be 0!!!");
                }

                int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
                Numerator = numerator / gcd;
                Denominator = denominator / gcd;
            }

            private int GCD(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }

            public override Pair Add(Pair other)
            {
                if (other is Rational)
                {
                    var rational = (Rational)other;
                    int commonDenominator = LCM(Denominator, rational.Denominator);
                    int sumNumerator = Numerator * (commonDenominator / Denominator) +
                                       rational.Numerator * (commonDenominator / rational.Denominator);

                    return new Rational(sumNumerator, commonDenominator);
                }

                throw new ArgumentException("Invalid type for addition.");
            }

            public override Pair Subtract(Pair other)
            {
                if (other is Rational)
                {
                    var rational = (Rational)other;
                    int commonDenominator = LCM(Denominator, rational.Denominator);
                    int diffNumerator = Numerator * (commonDenominator / Denominator) -
                                        rational.Numerator * (commonDenominator / rational.Denominator);

                    return new Rational(diffNumerator, commonDenominator);
                }

                throw new ArgumentException("Invalid type for subtraction.");
            }

            public override Pair Multiply(Pair other)
            {
                if (other is Rational)
                {
                    var rational = (Rational)other;
                    return new Rational(Numerator * rational.Numerator, Denominator * rational.Denominator);
                }

                throw new ArgumentException("Invalid type for multiplication.");
            }

            public override Pair Divide(Pair other)
            {
                if (other is Rational)
                {
                    var rational = (Rational)other;
                    if (rational.Numerator != 0)
                    {
                        return new Rational(Numerator * rational.Denominator, Denominator * rational.Numerator);
                    }

                    throw new DivideByZeroException("Division by zero is not allowed.");
                }

                throw new ArgumentException("Invalid type for division.");
            }

            private int LCM(int a, int b)
            {
                return Math.Abs(a * b) / GCD(a, b);
            }

            public override string ToString()
            {
                return $"{Numerator}/{Denominator}";
            }
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "real1";
            label2.Text = "real2";
            label3.Text = "Result: ";
            lblResult.Text = "";
            label4.Text = "imaginary1";
            label5.Text = "imaginary2";
            btnplus.Text = "+";
            btnminus.Text = "-";
            btnmulty.Text = "*";
            btndivide.Text = "/";
            label11.Text = "Numerator1";
            label10.Text = "Numerator2";
            label9.Text = "Result: ";
            lblResult2.Text = "";
            label7.Text = "Dominator1";
            label6.Text = "Dominator2";
            btnplus2.Text = "+";
            btnminus2.Text = "-";
            btnmulty2.Text = "*";
            btndivide2.Text = "/";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txt1.Text, out double real1) && double.TryParse(txt3.Text, out double imaginary1) &&
        double.TryParse(txt2.Text, out double real2) && double.TryParse(txt4.Text, out double imaginary2))
            {
                Pair pair1 = new Complex(real1, imaginary1);
                Pair pair2 = new Complex(real2, imaginary2);
                Pair resultAdd = pair1.Add(pair2);
                lblResult.Text = resultAdd.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input data!");
            }
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txt1.Text, out double real1) && double.TryParse(txt3.Text, out double imaginary1) &&
        double.TryParse(txt2.Text, out double real2) && double.TryParse(txt4.Text, out double imaginary2))
            {
                Pair pair1 = new Complex(real1, imaginary1);
                Pair pair2 = new Complex(real2, imaginary2);
                Pair resultSub = pair1.Subtract(pair2);
                lblResult.Text = resultSub.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input data!");
            }
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txt1.Text, out double real1) && double.TryParse(txt3.Text, out double imaginary1) &&
        double.TryParse(txt2.Text, out double real2) && double.TryParse(txt4.Text, out double imaginary2))
            {
                Pair pair1 = new Complex(real1, imaginary1);
                Pair pair2 = new Complex(real2, imaginary2);
                Pair resultDivide = pair1.Divide(pair2);
                lblResult.Text = resultDivide.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input data!");
            }
        }

        private void btnmulty_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txt1.Text, out double real1) && double.TryParse(txt3.Text, out double imaginary1) &&
        double.TryParse(txt2.Text, out double real2) && double.TryParse(txt4.Text, out double imaginary2))
            {
                Pair pair1 = new Complex(real1, imaginary1);
                Pair pair2 = new Complex(real2, imaginary2);
                Pair resultMult = pair1.Multiply(pair2);
                lblResult.Text = resultMult.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input data!");
            }
        }

        private void btnplus2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt1R.Text, out int real1) && int.TryParse(txt3R.Text, out int imaginary1) &&
        int.TryParse(txt2R.Text, out int real2) && int.TryParse(txt4R.Text, out int imaginary2))
            {
                Pair pair1 = new Rational(real1, imaginary1);
                Pair pair2 = new Rational(real2, imaginary2);
                Pair resultAdd = pair1.Add(pair2);
                lblResult2.Text = resultAdd.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input data!");
            }
        }

        private void btnminus2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt1R.Text, out int real1) && int.TryParse(txt3R.Text, out int imaginary1) &&
        int.TryParse(txt2R.Text, out int real2) && int.TryParse(txt4R.Text, out int imaginary2))
            {
                Pair pair1 = new Rational(real1, imaginary1);
                Pair pair2 = new Rational(real2, imaginary2);
                Pair resultAdd = pair1.Subtract(pair2);
                lblResult2.Text = resultAdd.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input data!");
            }
        }

        private void btndivide2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt1R.Text, out int real1) && int.TryParse(txt3R.Text, out int imaginary1) &&
        int.TryParse(txt2R.Text, out int real2) && int.TryParse(txt4R.Text, out int imaginary2))
            {
                Pair pair1 = new Rational(real1, imaginary1);
                Pair pair2 = new Rational(real2, imaginary2);
                Pair resultAdd = pair1.Divide(pair2);
                lblResult2.Text = resultAdd.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input data!");
            }
        }

        private void btnmulty2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt1R.Text, out int real1) && int.TryParse(txt3R.Text, out int imaginary1) &&
        int.TryParse(txt2R.Text, out int real2) && int.TryParse(txt4R.Text, out int imaginary2))
            {
                Pair pair1 = new Rational(real1, imaginary1);
                Pair pair2 = new Rational(real2, imaginary2);
                Pair resultAdd = pair1.Multiply(pair2);
                lblResult2.Text = resultAdd.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input data!");
            }
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                { return; }
                if (e.KeyChar == '+' || e.KeyChar == '-')
                { return; }
                if (e.KeyChar == ',')
                { return; }
                if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
                { return; }
                e.Handled = true;
            }
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                { return; }
                if (e.KeyChar == '+' || e.KeyChar == '-')
                { return; }
                if (e.KeyChar == ',')
                { return; }
                if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
                { return; }
                e.Handled = true;
            }
        }

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                { return; }
                if (e.KeyChar == '+' || e.KeyChar == '-')
                { return; }
                if (e.KeyChar == ',')
                { return; }
                if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
                { return; }
                e.Handled = true;
            }
        }

        private void txt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                { return; }
                if (e.KeyChar == '+' || e.KeyChar == '-')
                { return; }
                if (e.KeyChar == ',')
                { return; }
                if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
                { return; }
                e.Handled = true;
            }
        }

        private void txt1R_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                { return; }
                if (e.KeyChar == '+' || e.KeyChar == '-')
                { return; }
                if (e.KeyChar == ',')
                { return; }
                if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
                { return; }
                e.Handled = true;
            }
        }

        private void txt2R_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                { return; }
                if (e.KeyChar == '+' || e.KeyChar == '-')
                { return; }
                if (e.KeyChar == ',')
                { return; }
                if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
                { return; }
                e.Handled = true;
            }
        }

        private void txt3R_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                { return; }
                if (e.KeyChar == '+' || e.KeyChar == '-')
                { return; }
                if (e.KeyChar == ',')
                { return; }
                if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
                { return; }
                e.Handled = true;
            }
        }

        private void txt4R_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                { return; }
                if (e.KeyChar == '+' || e.KeyChar == '-')
                { return; }
                if (e.KeyChar == ',')
                { return; }
                if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
                { return; }
                e.Handled = true;
            }
        }
    }
}