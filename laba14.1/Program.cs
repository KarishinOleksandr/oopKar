using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba14._1
{
    public class FileManager : Form
    {
        private TreeView directoryTree;
        private ListBox fileList;
        private Button createDirectoryButton, deleteDirectoryButton;
        private Button createFileButton, deleteFileButton, editFileButton;
        private Button editAttributesButton, zipButton, unzipButton;
        private TextBox textEditor;

        public FileManager()
        {
            this.Text = "File Manager";

            // Створення дерева каталогів
            directoryTree = new TreeView();
            directoryTree.Dock = DockStyle.Left;
            directoryTree.AfterSelect += DirectoryTree_AfterSelect;
            Controls.Add(directoryTree);

            // Створення списку файлів
            fileList = new ListBox();
            fileList.Dock = DockStyle.Top;
            Controls.Add(fileList);

            // Створення кнопок
            createDirectoryButton = new Button { Text = "Create Directory" };
            createDirectoryButton.Click += CreateDirectoryButton_Click;
            Controls.Add(createDirectoryButton);

            deleteDirectoryButton = new Button { Text = "Delete Directory" };
            deleteDirectoryButton.Click += DeleteDirectoryButton_Click;
            Controls.Add(deleteDirectoryButton);

            createFileButton = new Button { Text = "Create File" };
            createFileButton.Click += CreateFileButton_Click;
            Controls.Add(createFileButton);

            deleteFileButton = new Button { Text = "Delete File" };
            deleteFileButton.Click += DeleteFileButton_Click;
            Controls.Add(deleteFileButton);

            editFileButton = new Button { Text = "Edit File" };
            editFileButton.Click += EditFileButton_Click;
            Controls.Add(editFileButton);

            editAttributesButton = new Button { Text = "Edit Attributes" };
            editAttributesButton.Click += EditAttributesButton_Click;
            Controls.Add(editAttributesButton);

            zipButton = new Button { Text = "Zip" };
            zipButton.Click += ZipButton_Click;
            Controls.Add(zipButton);

            unzipButton = new Button { Text = "Unzip" };
            unzipButton.Click += UnzipButton_Click;
            Controls.Add(unzipButton);

            // Створення текстового редактора
            textEditor = new TextBox();
            textEditor.Multiline = true;
            textEditor.Dock = DockStyle.Bottom;
            Controls.Add(textEditor);

            PopulateDirectoryTree();
        }

        private void PopulateDirectoryTree()
        {
            directoryTree.Nodes.Clear();
            AddDirectoryToTree(directoryTree.Nodes, Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }

        private void AddDirectoryToTree(TreeNodeCollection nodes, string path)
        {
            TreeNode node = nodes.Add(Path.GetFileName(path));
            node.Tag = path;

            try
            {
                foreach (string dir in Directory.GetDirectories(path))
                {
                    AddDirectoryToTree(node.Nodes, dir);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void DirectoryTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedPath = (string)e.Node.Tag;
            DisplayFilesInDirectory(selectedPath);
        }

        private void DisplayFilesInDirectory(string path)
        {
            fileList.Items.Clear();

            try
            {
                foreach (string file in Directory.GetFiles(path))
                {
                    fileList.Items.Add(Path.GetFileName(file));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CreateDirectoryButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create Directory button clicked.");
            Console.WriteLine("Create Directory button clicked.");
        }

        private void DeleteDirectoryButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete Directory button clicked.");
            Console.WriteLine("Delete Directory button clicked.");
        }

        private void CreateFileButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create File button clicked.");
            Console.WriteLine("Create File button clicked.");
        }

        private void DeleteFileButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete File button clicked.");
            Console.WriteLine("Delete File button clicked.");
        }

        private void EditFileButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit File button clicked.");
            Console.WriteLine("Edit File button clicked.");
        }

        private void EditAttributesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit Attributes button clicked.");
            Console.WriteLine("Edit Attributes button clicked.");
        }

        private void ZipButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zip button clicked.");
            Console.WriteLine("Zip button clicked.");
        }

        private void UnzipButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unzip button clicked.");
            Console.WriteLine("Unzip button clicked.");
        }

        static void Main()
        {
            Application.Run(new FileManager());
        }
    }
}
