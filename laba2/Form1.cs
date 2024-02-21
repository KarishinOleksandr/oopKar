using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Ступінь многочлена";
            label2.Text = "Коефіціент многочленів(чeрез кому)";
            label3.Text = "x = ";
            label4.Text = "Result";
            lblResult.Text = "";
            btnOK.Text = "Generate";
            label5.Text = "Ступінь многочлена";
            label6.Text = "Коефіціент многочленів(чeрез кому)";
            label7.Text = "x = ";
            label8.Text = "Result";
            lblResult2.Text = "";
            btnOk2.Text = "Generate";
            label9.Text = "Ступінь многочлена";
            label10.Text = "Коефіціент многочленів(чeрез кому)";
            label13.Text = "Ступінь многочлена";
            label14.Text = "Коефіціент многочленів(чeрез кому)";
            label15.Text = "x = ";
            label16.Text = "Result";
            lblResult3.Text = "";
            btnOk3.Text = "Generate";
            label11.Text = "Ступінь многочлена";
            label12.Text = "Коефіціент многочленів(чeрез кому)";
            label19.Text = "Ступінь многочлена";
            label20.Text = "Коефіціент многочленів(чeрез кому)";
            label21.Text = "x = ";
            label22.Text = "Result";
            lblResult4.Text = "";
            btnOk4.Text = "Generate";
            label17.Text = "Ступінь многочлена";
            label18.Text = "Коефіціент многочленів(чeрез кому)";
            label25.Text = "Ступінь многочлена";
            label26.Text = "Коефіціент многочленів(чeрез кому)";
            label27.Text = "x = ";
            label28.Text = "Result";
            lblResult5.Text = "";
            btnOk5.Text = "Generate";
            label23.Text = "Ступінь многочлена";
            label24.Text = "Коефіціент многочленів(чeрез кому)";
        }

        public void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int degree = int.Parse(txtdegree.Text);
                string[] coefString = txtcoef.Text.Split(',');
                double[] coef = new double[coefString.Length];

                for (int i = 0; i < coefString.Length; i++)
                {
                    coef[i] = Convert.ToDouble(coefString[i]);
                }

                double x = Convert.ToDouble(txtX.Text);

                Polynomial polynomial = new Polynomial(degree, coef);
                double result = polynomial.Evaluate(x);

                lblResult.Text = result.ToString();

            } 
            catch (Exception ex) 
            {
                lblResult.Text = "Помилка: " + ex.Message;
            }
          
        }

        public class Polynomial
        {
            private int degree;
            private double[] coef;

            public Polynomial(int degree, double[] coef)
            {
                this.degree = degree;
                this.coef = coef;
            }

            public double Evaluate(double x)
            {
                double result = 0;

                for (int i = 0; i <= degree && i < coef.Length; i++)
                {
                    result += coef[i] * Math.Pow(x,degree - i);
                }

                return result;
            }

            public Polynomial Add(Polynomial other)
            {
                if (this.IsZero() || other.IsZero())
                {
                    return new Polynomial(0, new double[] { 0 });
                }

                int resultDegree = Math.Max(this.degree, other.degree);
                double[] resultCoefficients = new double[resultDegree + 1];

                for (int i = 0; i <= this.degree; i++)
                {
                    resultCoefficients[i] += this.coef[i];
                }

                for (int i = 0; i <= other.degree; i++)
                {
                    resultCoefficients[i] += other.coef[i];
                }

                return new Polynomial(resultDegree, resultCoefficients);
            }


            public Polynomial Subtract(Polynomial other)
            {
                int resultDegree = Math.Max(this.degree, other.degree);
                double[] resultCoefficients = new double[resultDegree + 1];

                for (int i = 0; i <= this.degree; i++)
                {
                    resultCoefficients[i] += this.coef[i];
                }

                for (int i = 0; i <= other.degree; i++)
                {
                    resultCoefficients[i] -= other.coef[i];
                }

                return new Polynomial(resultDegree, resultCoefficients);
            }

            public Polynomial Multiply(Polynomial other)
            {
                if (this.IsZero() || other.IsZero())
                {
                    return new Polynomial(0, new double[] { 0 });
                }

                int resultDegree = this.degree + other.degree;
                double[] resultCoefficients = new double[resultDegree + 1];

                for (int i = 0; i <= this.degree; i++)
                {
                    for (int j = 0; j <= other.degree; j++)
                    {
                        if (i < this.coef.Length && j < other.coef.Length)
                        {
                            resultCoefficients[i + j] += this.coef[i] * other.coef[j];
                        }
                    }
                }

                return new Polynomial(resultDegree, resultCoefficients);
            }

            private bool IsZero()
            {
                foreach (var coef in coef)
                {
                    if (coef != 0)
                        return false;
                }

                return true;
            }

            public string Print()
            {
                StringBuilder sb = new StringBuilder();

                for (int i = degree; i >= 0; i--)
                {
                    if (coef[i] != 0)
                    {
                        if (coef[i] > 0 && i != degree)
                            sb.Append(" + ");
                        else if (coef[i] < 0)
                            sb.Append(" - ");

                        if (Math.Abs(coef[i]) != 1 || i == 0)
                            sb.Append(Math.Abs(coef[i]));

                        if (i > 0)
                            sb.Append("x^" + i);
                    }
                }

                return sb.ToString();
            }

        }

        private void btnOk2_Click(object sender, EventArgs e)
        {
            try
            {
                int degree2 = int.Parse(txtdegree2.Text);
                string[] coefString2 = txtcoef2.Text.Split(',');
                double[] coef2 = new double[coefString2.Length];

                for (int i = 0; i < coefString2.Length; i++)
                {
                    coef2[i] = Convert.ToDouble(coefString2[i]);
                }

                double x2 = Convert.ToDouble(txtX2.Text);
                int degree22 = int.Parse(txtdegree22.Text);
                string[] coefString22 = txtcoef22.Text.Split(',');
                double[] coef22 = new double[coefString22.Length];

                for (int i = 0; i < coefString22.Length; i++)
                {
                    coef22[i] = Convert.ToDouble(coefString22[i]);
                }


                Polynomial polynomial2 = new Polynomial(degree2, coef2);
                Polynomial poly2 = new Polynomial(degree22, coef22);
                double result = polynomial2.Multiply(poly2).Evaluate(x2);

                lblResult2.Text = result.ToString();

            }
            catch (Exception ex)
            {
                lblResult2.Text = "Помилка: " + ex.Message;
            }
        }

        private void btnOk3_Click(object sender, EventArgs e)
        {
            try
            {
                int degree3 = int.Parse(txtdegree3.Text);
                string[] coefString3 = txtcoef3.Text.Split(',');
                double[] coef3 = new double[coefString3.Length];

                for (int i = 0; i < coefString3.Length && i < coef3.Length; i++)
                {
                    coef3[i] = Convert.ToDouble(coefString3[i]);
                }


                double x3 = Convert.ToDouble(txtX3.Text);
                int degree33 = int.Parse(txtdegree33.Text);
                string[] coefString33 = txtcoef33.Text.Split(',');
                double[] coef33 = new double[coefString33.Length];

                for (int i = 0; i < coefString33.Length && i < coef33.Length; i++)
                {
                    coef33[i] = Convert.ToDouble(coefString33[i]);
                }



                Polynomial polynomial3 = new Polynomial(degree3, coef3);
                Polynomial poly3 = new Polynomial(degree33, coef33);
                double result = polynomial3.Add(poly3).Evaluate(x3);

                lblResult3.Text = result.ToString();

            }
            catch (Exception ex)
            {
                lblResult3.Text = "Помилка: " + ex.Message;
            }
        }

        private void btnOk4_Click(object sender, EventArgs e)
        {
            try
            {
                int degree3 = int.Parse(txtdegree4.Text);
                string[] coefString3 = txtcoef4.Text.Split(',');
                double[] coef3 = new double[coefString3.Length];

                for (int i = 0; i < coefString3.Length && i < coef3.Length; i++)
                {
                    coef3[i] = Convert.ToDouble(coefString3[i]);
                }


                double x3 = Convert.ToDouble(txtX4.Text);
                int degree33 = int.Parse(txtdegree44.Text);
                string[] coefString33 = txtcoef44.Text.Split(',');
                double[] coef33 = new double[coefString33.Length];

                for (int i = 0; i < coefString33.Length && i < coef33.Length; i++)
                {
                    coef33[i] = Convert.ToDouble(coefString33[i]);
                }



                Polynomial polynomial3 = new Polynomial(degree3, coef3);
                Polynomial poly3 = new Polynomial(degree33, coef33);
                double result = polynomial3.Subtract(poly3).Evaluate(x3);

                lblResult4.Text = result.ToString();

            }
            catch (Exception ex)
            {
                lblResult4.Text = "Помилка: " + ex.Message;
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void btnOk5_Click(object sender, EventArgs e)
        {
            try
            {
                int degree3 = int.Parse(txtdegree5.Text);
                string[] coefString3 = txtcoef5.Text.Split(',');
                double[] coef3 = new double[coefString3.Length];

                for (int i = 0; i < coefString3.Length && i < coef3.Length; i++)
                {
                    if (double.TryParse(coefString3[i], out coef3[i]) == false)
                    {
                        lblResult5.Text = "Помилка: Некоректне числове значення.";
                        return;
                    }
                }

                double x3;
                if (!double.TryParse(txtX5.Text, out x3))
                {
                    lblResult5.Text = "Помилка: Некоректне значення 'x'.";
                    return;
                }

                int degree33 = int.Parse(txtdegree55.Text);
                string[] coefString33 = txtcoef55.Text.Split(',');
                double[] coef33 = new double[coefString33.Length];

                for (int i = 0; i < coefString33.Length && i < coef33.Length; i++)
                {
                    if (double.TryParse(coefString33[i], out coef33[i]) == false)
                    {
                        lblResult5.Text = "Помилка: Некоректне числове значення.";
                        return;
                    }
                }

                Polynomial polynomial3 = new Polynomial(degree3, coef3);
                Polynomial poly3 = new Polynomial(degree33, coef33);
                string result = polynomial3.Print();

                lblResult5.Text = result;

            }
            catch (Exception ex)
            {
                lblResult5.Text = "Помилка: " + ex.Message;
            }
        }

        private void txtdegree_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcoef_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtX_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtdegree2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcoef2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtX2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtdegree22_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcoef22_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtdegree3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcoef3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtX3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtdegree33_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcoef33_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtdegree4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcoef4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtX4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtdegree44_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcoef44_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtdegree5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcoef5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtX5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtdegree55_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcoef55_KeyPress(object sender, KeyPressEventArgs e)
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
