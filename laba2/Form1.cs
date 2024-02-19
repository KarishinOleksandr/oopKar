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
        }

        public void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                double degree = Convert.ToDouble(txtdegree.Text);
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
            private double degree;
            private double[] coef;

            public Polynomial(double degree, double[] coef)
            {
                this.degree = degree;
                this.coef = coef;
            }

            public double Evaluate(double x)
            {
                double result = 0;

                for (int i = 0; i <= degree && i < coef.Length; i++)
                {
                    result += coef[i] * Math.Pow(x, i);
                }

                return result;
            }
        }
    }
}
