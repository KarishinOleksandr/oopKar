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

namespace laba13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDrives();
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox2.SelectedIndexChanged += listBoxContent_SelectedIndexChanged;
            btn1.Click += btn1_Click;
            InitializeDirectoryFilterComboBox();
        }

        private void LoadDrives()
        {
            listBox1.Items.Clear();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                listBox1.Items.Add(drive.Name);
            }
        }

        private void InitializeDirectoryFilterComboBox()
        {
            comboBoxDirectoryFilter.Items.Clear();
            comboBoxDirectoryFilter.Items.Add("Всі каталоги (*.*)");
            comboBoxDirectoryFilter.Items.Add("*.txt");
            comboBoxDirectoryFilter.Items.Add("*.exe");
            comboBoxDirectoryFilter.Items.Add("*.doc");
            comboBoxDirectoryFilter.SelectedIndex = 0; 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedDrive = listBox1.SelectedItem.ToString();
                textBoxPath.Text = selectedDrive;
                LoadDirectoryContent(selectedDrive);
                ShowDriveProperties(selectedDrive);
            }
        }

        private void listBoxContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                string selectedPath = Path.Combine(textBoxPath.Text, listBox2.SelectedItem.ToString());
                if (Directory.Exists(selectedPath))
                {
                    textBoxPath.Text = selectedPath;
                    LoadDirectoryContent(selectedPath);
                    ShowDirectoryProperties(selectedPath);
                }
                else if (File.Exists(selectedPath))
                {
                    textBoxPath.Text = selectedPath;
                    string fileExtension = Path.GetExtension(selectedPath).ToLower();

                    if (IsImageFile(fileExtension))
                    {
                        pictureBoxImage.ImageLocation = selectedPath;
                    }
                    else if (IsTextFile(fileExtension))
                    {
                        ShowTextFile(selectedPath);
                    }
                    else
                    {
                        ShowFileProperties(selectedPath);
                    }
                }
            }
        }

        private bool IsImageFile(string fileExtension)
        {
            return fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" || fileExtension == ".gif";
        }

        private bool IsTextFile(string fileExtension)
        {
            return fileExtension == ".txt" || fileExtension == ".doc" || fileExtension == ".docx";
        }

        private void ShowTextFile(string filePath)
        {
            try
            {
                richTextBoxContent.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                ShowFileProperties(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка відображення текстового файлу: " + ex.Message);
            }
        }

        private void LoadDirectoryContent(string path)
        {
            listBox2.Items.Clear();
            try
            {
                string[] directories = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);

                string directoryFilter = GetDirectoryFilterFromComboBox();
                string fileFilter = textBoxFileFilter.Text;

                foreach (string directory in directories)
                {
                    if (string.IsNullOrEmpty(directoryFilter) || directory.EndsWith(directoryFilter))
                    {
                        listBox2.Items.Add(Path.GetFileName(directory));
                    }
                }

                foreach (string file in files)
                {
                    if (string.IsNullOrEmpty(fileFilter) || Path.GetFileName(file).Contains(fileFilter))
                    {
                        listBox2.Items.Add(Path.GetFileName(file));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження вмісту каталогу: " + ex.Message);
            }
        }

        private void ShowDriveProperties(string driveName)
        {
            DriveInfo drive = new DriveInfo(driveName);
            label1.Text = $"Диск {drive.Name}\n" +
                                   $"Тип: {drive.DriveType}\n" +
                                   $"Формат: {drive.DriveFormat}\n" +
                                   $"Загальний розмір: {drive.TotalSize}\n" +
                                   $"Доступний простір: {drive.AvailableFreeSpace}";
        }

        private void ShowDirectoryProperties(string path)
        {
            try
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                label1.Text = $"Каталог {directory.Name}\n" +
                                       $"Повна назва: {directory.FullName}\n" +
                                       $"Створений: {directory.CreationTime}\n" +
                                       $"Останній доступ: {directory.LastAccessTime}\n" +
                                       $"Останні зміни: {directory.LastWriteTime}\n" +
                                       $"Корінь: {directory.Root}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка відображення властивостей каталогу: " + ex.Message);
            }
        }

        private void ShowFileProperties(string path)
        {
            try
            {
                FileInfo file = new FileInfo(path);
                string fileContent = File.ReadAllText(path);

                richTextBoxContent.Clear();
                richTextBoxContent.AppendText(fileContent);

                label1.Text = $"Файл {file.Name}\n" +
                                       $"Повна назва: {file.FullName}\n" +
                                       $"Розмір: {file.Length}\n" +
                                       $"Створений: {file.CreationTime}\n" +
                                       $"Останній доступ: {file.LastAccessTime}\n" +
                                       $"Останні зміни: {file.LastWriteTime}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка відображення властивостей файлу: " + ex.Message);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            LoadDirectoryContent(textBoxPath.Text);

            string fileNameFilter = textBoxFileFilter.Text;
            if (!string.IsNullOrEmpty(fileNameFilter))
            {
                FilterFilesByName(fileNameFilter);
            }
        }


        private string GetDirectoryFilterFromComboBox()
        {
            switch (comboBoxDirectoryFilter.SelectedIndex)
            {
                case 0:
                    return null;
                default:
                    return comboBoxDirectoryFilter.SelectedItem.ToString();
            }
        }
        private void FilterFilesByName(string fileNameFilter)
        {
            for (int i = listBox2.Items.Count - 1; i >= 0; i--)
            {
                string listItem = listBox2.Items[i].ToString();
                if (!listItem.Contains(fileNameFilter))
                {
                    listBox2.Items.RemoveAt(i);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "Списки";
            label4.Text = "Каталоги";
            label1.Text = "Шлях";
            label2.Text = "";
            btn1.Text = "Пошук";
        }
    }
}
