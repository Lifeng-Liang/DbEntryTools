using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ICSharpCode.TextEditor.Document;
using Leafing.Core;

namespace TemplateBuilder
{
    public partial class MainForm : Form
    {
        private readonly string _codegenPath;
        private string _mode;

        public MainForm()
        {
            InitializeComponent();
            _codegenPath = Path.Combine(Path.Combine(SystemHelper.BaseDirectory, "Bin"), "Leafing.CodeGen.exe");
            ModeSelector.SelectedIndex = 0;
        }

        private string RunCodegen(string arg)
        {
            var startInfo = new ProcessStartInfo(_codegenPath)
                                {
                                    Arguments = arg,
                                    WindowStyle = ProcessWindowStyle.Hidden,
                                    UseShellExecute = false,
                                    CreateNoWindow = true,
                                    RedirectStandardOutput = true
                                };
            var process = new Process {StartInfo = startInfo};
            process.Start();
            string r = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return r;
        }

        private void LoadAssembly_Click(object sender, EventArgs e)
        {
            if (openDllDialog.ShowDialog() == DialogResult.OK)
            {
                TypeSelector.Items.Clear();
                AssemblyFileName.Text = openDllDialog.FileName;
                string result = RunCodegen(_mode + AssemblyFileName.Text + "\"");
                foreach (var s in result.Split(new[]{"\r\n"}, StringSplitOptions.RemoveEmptyEntries))
                {
                    TypeSelector.Items.Add(s);
                }
            }
        }

        private void CopyToClipboard_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ResultText.Text))
            {
                SetErrorMsg("It's Empty!!!");
            }
            else
            {
                Clipboard.SetText(ResultText.Text);
                SetNoticeMsg("Copy to clipboard done!");
            }
        }

        private void SetErrorMsg(string text)
        {
            msg.ForeColor = Color.Red;
            msg.Text = text;
            MessageBox.Show(text);
        }

        private void SetNoticeMsg(string text)
        {
            msg.ForeColor = Color.DarkGreen;
            msg.Text = text;
        }

        private void TypeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string action = "";
                if(ActionSelector.Visible)
                {
                    action = " " + ActionSelector.Text;
                }
                if(MasterName.Visible && !string.IsNullOrEmpty(MasterName.Text))
                {
                    action += " " + MasterName.Text;
                }
                string result = RunCodegen(_mode + AssemblyFileName.Text + "\" \"" + TypeSelector.Text + "\"" + action);
                ResultText.Text = result;
                ResultText.Refresh();
            }
            catch (NotImplementedException ex)
            {
                SetErrorMsg(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ResultText.Document.ReadOnly = true;
        }

        private void ModeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ModeSelector.SelectedIndex)
            {
                case 0:
                    _mode = "a \"";
                    ActionSelector.Visible = false;
                    MasterName.Visible = false;
                    ResultText.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("HTML");
                    break;
                case 1:
                    _mode = "ra \"";
                    ActionSelector.Visible = true;
                    MasterName.Visible = false;
                    ActionSelector.Items.Clear();
                    ActionSelector.Items.AddRange(new object[] { "All", "New", "Create", "List", "Show", "Edit", "Update", "Destroy" });
                    ActionSelector.SelectedIndex = 0;
                    ResultText.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("C#");
                    break;
                case 2:
                    _mode = "rv \"";
                    ActionSelector.Visible = true;
                    MasterName.Visible = true;
                    ActionSelector.Items.Clear();
                    ActionSelector.Items.AddRange(new object[] { "New", "List", "Show", "Edit" });
                    ActionSelector.SelectedIndex = 0;
                    ResultText.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("HTML");
                    break;
                case 3:
                    ActionSelector.Visible = false;
                    MasterName.Visible = false;
                    _mode = "m \"";
                    ResultText.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("HTML");
                    break;
                default:
                    break;
            }
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            if(TypeSelector.Visible)
            {
                TypeSelector_SelectedIndexChanged(sender, e);
            }
        }
    }
}
