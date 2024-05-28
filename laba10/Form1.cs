using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba10
{
    public partial class Form1 : Form
    {
        private Thread thread1;
        private Thread thread2;
        private Thread thread3;

        public Form1()
        {
            InitializeComponent();
            thread1 = new Thread(new ThreadStart(DrawRectangles));
            thread2 = new Thread(new ThreadStart(DrawEllipses));
            thread3 = new Thread(new ThreadStart(GenerateRandomNumbers));
        }

        private void DrawRectangles()
        {
            try
            {
                Random rnd = new Random();
                Graphics g = panel1.CreateGraphics();
                while (true)
                {
                    Thread.Sleep(40);
                    g.DrawRectangle(Pens.Pink, rnd.Next(panel1.Width), rnd.Next(panel1.Height), 50, 30);
                }
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DrawEllipses()
        {
            try
            {
                Random rnd = new Random();
                Graphics g = panel2.CreateGraphics();
                while (true)
                {
                    Thread.Sleep(40);
                    g.DrawEllipse(Pens.Blue, rnd.Next(panel2.Width), rnd.Next(panel2.Height), 50, 30);
                }
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GenerateRandomNumbers()
        {
            try
            {
                Random rnd = new Random();
                while (true)
                {
                    Thread.Sleep(100);
                    this.Invoke((MethodInvoker)delegate
                    {
                        richTextBox1.AppendText(rnd.Next().ToString() + Environment.NewLine);
                    });
                }
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            thread1.Start();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            thread1.Abort();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            thread2.Start();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            thread2.Abort();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            thread3.Start();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            thread3.Abort();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn1.Text = "start";
            btn2.Text = "stop";
            btn3.Text = "start";
            btn4.Text = "stop";
            btn5.Text = "start";
            btn6.Text = "stop";
            btn7.Text = "total start";
            btn8.Text = "total stop";
        }
          

        private void btn7_Click(object sender, EventArgs e)
        {
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            thread1.Abort();
            thread2.Abort();
            thread3.Abort();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (thread1 != null && thread1.IsAlive) thread1.Abort();
            if (thread2 != null && thread2.IsAlive) thread2.Abort();
            if (thread3 != null && thread3.IsAlive) thread3.Abort();
        }
    }
}
