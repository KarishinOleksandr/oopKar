using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba11
{
    public partial class Form1 : Form
    {

        private static string dataFilePath = "contacts.csv";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Save data";
            label1.Text = "Input name";
            label2.Text = "Input number";
            label3.Text = "Input email";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string phone = phoneTextBox.Text;
            string email = emailTextBox.Text;

            if (IsValidPhoneNumber(phone) && IsValidEmail(email))
            {
                SaveUserData(name, phone, email);
                MessageBox.Show("Success!!");
            }
            else
            {
                MessageBox.Show("Invalid phone number or email!");
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^\(?\d{3}\)?-? *\d{3}-? *-?\d{4}$";
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, pattern);
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern);
        }


        private static void SaveUserData(string name, string phone, string email)
        {
            using (StreamWriter writer = new StreamWriter(dataFilePath, true))
            {
                writer.WriteLine($"Name: {name}");
                writer.WriteLine($"Number: {phone}");
                writer.WriteLine($"Email: {email}");
                writer.WriteLine(new string('-', 20));
            }
        }
    }
}
