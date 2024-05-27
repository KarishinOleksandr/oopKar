using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace NotepadCSharp
{
    public partial class frmname : Form
    {
        public frmname()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmname
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmname";
            this.ResumeLayout(false);

        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            // Your implementation for mnuNew_Click
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            // Your implementation for mnuOpen_Click
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            // Your implementation for mnuSave_Click
        }

        // Add other event handlers and methods as needed
    }
}
