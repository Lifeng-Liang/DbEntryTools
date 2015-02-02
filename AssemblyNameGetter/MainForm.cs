using System;
using System.Windows.Forms;
using System.Reflection;

namespace AssemblyNameGetter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            if (GetAssembly.ShowDialog() == DialogResult.OK)
            {
                AssemblyPath.Text = GetAssembly.FileName;
                GetAssemblyName();
            }
        }

        private void GetAssemblyName()
        {
            string s = AssemblyPath.Text;
            Assembly asm = Assembly.LoadFile(s);
            AssemblyName.Text = asm.FullName;
        }

        private void CopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(AssemblyName.Text);
            MessageBox.Show("Done!");
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            AssemblyPath.Text = path;
            GetAssemblyName();
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
