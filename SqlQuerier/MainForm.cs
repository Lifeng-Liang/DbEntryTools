using System;
using System.Windows.Forms;
using Leafing.Data.Common;
using Leafing.Data.SqlEntry;
using SqlQuerier.AppCode;
using WeifenLuo.WinFormsUI.Docking;

namespace SqlQuerier
{
    public partial class MainForm : Form
    {
        private int _childFormNumber;
        private DataProvider _currentProvider;
        private readonly DbStruct _dbStructForm = new DbStruct();
        private DeserializeDockContent _deDockContent;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _deDockContent = new DeserializeDockContent(GetContentFromPersistString);
            if (!DockConfig.LoadDockConfig(dockPanel1, _deDockContent))
            {
                _dbStructForm.Show(dockPanel1);
                _dbStructForm.Show();
            }
            ShowNewForm(sender, e);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            selectconnectionCToolStripMenuItem_Click(sender, e);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DockConfig.SaveDockConfig(dockPanel1);
        }

        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(DbStruct).ToString())
            {
                return _dbStructForm;
            }
            return null;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            CreateNewForm("");
        }

        private void CreateNewForm(string fileName)
        {
            var f = new SqlForm();
            f.Show(dockPanel1);
            f.NewOpenFile(fileName, _childFormNumber++);
        }

        public void NewClassForm(string text, string name)
        {
            var f = new ClassesForm {Text = name, TabText = name};
            f.Show(dockPanel1);
            f.NewClassText(text);
        }

        private void OpenFile(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
                                     {
                                         InitialDirectory =
                                             Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                                         Filter = "SQL文件(*.sql)|*.sql|所有文件(*.*)|*.*"
                                     };
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                CreateNewForm(openFileDialog.FileName);
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                var saveFileDialog = new SaveFileDialog
                                         {
                                             InitialDirectory =
                                                 Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                                             Filter = "SQL文件(*.sql)|*.sql|所有文件(*.*)|*.*"
                                         };
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    ((SqlForm)ActiveMdiChild).SaveAs(saveFileDialog.FileName);
                }
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new MyAbout();
            a.ShowDialog(this);
        }

        private void selectconnectionCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sc = new SelectConnection();
            sc.ShowDialog(this);
            if (sc.ResultXmlString != null)
            {
                new MockConfigReader(sc.ResultXmlString);
                MockDbDriverFactory.Clear();
                _currentProvider = new DataProvider("");
                if (ActiveMdiChild != null)
                {
                    var f = (SqlForm)ActiveMdiChild;
                }
                _dbStructForm.RefreshNewConnection(_currentProvider);
            }
        }

        private void runRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ((SqlForm)ActiveMdiChild).RunScript(_currentProvider);
            }
        }

        private void dbStructDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dbStructDToolStripMenuItem.Checked)
            {
                _dbStructForm.Show(dockPanel1);
            }
            else
            {
                _dbStructForm.Hide();
            }
        }

        private void toolStripRun_Click(object sender, EventArgs e)
        {
            runRToolStripMenuItem_Click(sender, e);
        }

        private void toolStripSelectConnection_Click(object sender, EventArgs e)
        {
            selectconnectionCToolStripMenuItem_Click(sender, e);
        }

    }
}
