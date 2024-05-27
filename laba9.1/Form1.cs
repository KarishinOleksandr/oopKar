using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba9._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Введыть коефіціент";
            btn1.Text = "Validate";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a;
            TextBox textBoxA = (TextBox)this.Controls["txtA"];
            PictureBox pictureBox = (PictureBox)this.Controls["pictureBox2"];

            if (float.TryParse(textBoxA.Text, out a))
            {
                Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.White);
                    DrawAxes(g, pictureBox.Width, pictureBox.Height);
                    PlotParametric(g, a, pictureBox.Width, pictureBox.Height);
                }
                pictureBox.Image = bmp;
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть правильний коефіцієнт.", "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawAxes(Graphics g, int width, int height)
        {
            Pen axisPen = new Pen(Color.Black, 2);
            g.DrawLine(axisPen, width / 2, 0, width / 2, height); 
            g.DrawLine(axisPen, 0, height / 2, width, height / 2); 

            Font font = new Font("Arial", 10);
            g.DrawString("Y", font, Brushes.Black, width / 2 + 5, 5);
            g.DrawString("X", font, Brushes.Black, width - 15, height / 2 + 5);
        }

        private void PlotParametric(Graphics g, float a, int width, int height)
        {
            Pen pen = new Pen(Color.Blue, 2);
            float tStep = 0.01f;

            for (float t = -10; t <= 10; t += tStep)
            {
                float x = 3 * a * t / 1 + t * t * t;
                float y = 3 * a * t * t / 1 + t * t * t;

                float xScaled = width / 2 + x * 20;
                float yScaled = height / 2 - y * 20;

                g.DrawRectangle(pen, xScaled, yScaled, 1, 1);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

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
    }
}
