using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;


namespace lab15
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string host = tbHost.Text;
            string username = tbUser.Text;
            string password = tbPass.Text;

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(host);
            request.Credentials = new NetworkCredential(username, password);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            try
            {
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                using (Stream responseStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(responseStream))
                {
                    treeView.Nodes.Clear();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        treeView.Nodes.Add(line);
                    }

                    MessageBox.Show(response.WelcomeMessage);
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("Помилка при підключенні до FTP сервера: " + ex.Message);
            }
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Всі файли|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                tbSize.Text = filePath;

                string host = tbHost.Text;
                string username = tbUser.Text;
                string password = tbPass.Text;

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(host + "/" + filePath);
                request.Credentials = new NetworkCredential(username, password);
                request.Method = WebRequestMethods.Ftp.GetFileSize;

                try
                {
                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                    {
                        long size = response.ContentLength;
                        MessageBox.Show("Розмір файлу: " + size + " байт");
                    }
                }
                catch (WebException ex)
                {
                    MessageBox.Show("Помилка при отриманні розміру файлу: " + ex.Message);
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string host = tbHost.Text;
            string username = tbUser.Text;
            string password = tbPass.Text;
            string directoryPath = tbNewDir.Text;

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(host + "/" + directoryPath);
            request.Credentials = new NetworkCredential(username, password);
            request.Method = WebRequestMethods.Ftp.MakeDirectory;

            try
            {
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    MessageBox.Show("Директорію " + directoryPath + " створено");
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("Помилка при створенні директорії: " + ex.Message);
            }
        }

        private void btnDelFolder_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Виберіть шлях для видалення директорії";
            openFileDialog.FileName = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string directoryPath = openFileDialog.FileName;
                tbDelFolder.Text = directoryPath;

                string host = tbHost.Text;
                string username = tbUser.Text;
                string password = tbPass.Text;

                string ftpDirectoryPath = host + directoryPath;

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpDirectoryPath);
                request.Credentials = new NetworkCredential(username, password);
                request.Method = WebRequestMethods.Ftp.RemoveDirectory;

                try
                {
                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                    {
                        MessageBox.Show("Директорію " + directoryPath + " видалено");
                    }
                }
                catch (WebException ex)
                {
                    MessageBox.Show("Помилка при видаленні директорії: " + ex.Message);
                }
            }
        }

        private void btnDelFile_Click(object sender, EventArgs e)
        {
            string host = tbHost.Text;
            string username = tbUser.Text;
            string password = tbPass.Text;
            string filePath = tbDelFile.Text;

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(host + "/" + filePath);
            request.Credentials = new NetworkCredential(username, password);
            request.Method = WebRequestMethods.Ftp.DeleteFile;

            try
            {
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    MessageBox.Show("Файл " + filePath + " видалено");
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("Помилка при видаленні файлу: " + ex.Message);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Всі файли|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                tbUpload.Text = filePath;

                string host = tbHost.Text;
                string username = tbUser.Text;
                string password = tbPass.Text;

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(host + "/" + Path.GetFileName(filePath));
                request.Credentials = new NetworkCredential(username, password);
                request.Method = WebRequestMethods.Ftp.UploadFile;

                try
                {
                    using (Stream fileStream = File.OpenRead(filePath))
                    using (Stream ftpStream = request.GetRequestStream())
                    {
                        fileStream.CopyTo(ftpStream);
                    }

                    MessageBox.Show("Файл " + Path.GetFileName(filePath) + " завантажено");
                }
                catch (WebException ex)
                {
                    MessageBox.Show("Помилка при завантаженні файлу: " + ex.Message);
                }
            }
        }
    }
}