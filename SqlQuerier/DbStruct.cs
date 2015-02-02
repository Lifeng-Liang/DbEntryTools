using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Leafing.Data;
using Leafing.Data.Common;
using Leafing.Data.SqlEntry;
using Leafing.Core;
using WeifenLuo.WinFormsUI.Docking;

namespace SqlQuerier
{
    public partial class DbStruct : DockContent
    {
        private readonly string _codegenPath;
        private DataProvider _currentProvider;
        private DbStructInterface _si;

        public DbStruct()
        {
            InitializeComponent();
            TabText = null;
            _codegenPath = Path.Combine(Path.Combine(SystemHelper.BaseDirectory, "Bin"), "Leafing.CodeGen.exe");
        }

        public void RefreshNewConnection(DataProvider currentProvider)
        {
            _currentProvider = currentProvider;
            if (currentProvider != null)
            {
                _si = currentProvider.Dialect.GetDbStructInterface();
                InitStructTree();
            }
        }

        private void InitStructTree()
        {
            try
            {
                StructTree.Nodes.Clear();
                CreateSubTree(_si.TablesTypeName);
                //CreateSubTree(_si.ViewsTypeName, _si.ViewsParams);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, this driver is not support enum table function.");
            }
        }

        private void CreateSubTree(string name)
        {
            TreeNode tn = StructTree.Nodes.Add(name);
            DbEntry.UsingConnection(delegate
            {
                foreach (string s in _currentProvider.Driver.GetTableNames())
                {
                    var t = new TreeNode(s, 0, 0);
                    tn.Nodes.Add(t);
                    CreateColumnsLeaf(t);
                }
            });
            tn.Expand();
        }

        private void CreateColumnsLeaf(TreeNode tn)
        {
            Util.IfCatchException(true, delegate
            {
                List<DbColumnInfo> dis = _currentProvider.GetDbColumnInfoList(tn.Text);
                foreach (DbColumnInfo di in dis)
                {
                    string cn = string.Format("{0}({1}-{2}({3}),{4})",
                        di.ColumnName, di.DataType, di.ProviderType, di.ColumnSize,
                        di.AllowDBNull ? "NULL" : "NOT NULL");
                    int i = di.IsKey ? 3 : 1;
                    var t = new TreeNode(cn, i, i);
                    tn.Nodes.Add(t);
                }
            });
        }

        private void refreshRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshNewConnection(_currentProvider);
        }

        private void generateClassesGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = "*";
            if(StructTree.SelectedNode.Parent != null)
            {
                if (StructTree.SelectedNode.Parent.Parent == null)
                {
                    s = StructTree.SelectedNode.Text;
                }
                else
                {
                    MessageBox.Show("Please select the table!");
                    return;
                }
            }
            string text = RunCodegen("m " + s);

            Program.Form.NewClassForm(text, "Class - " + s);
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
            var process = new Process { StartInfo = startInfo };
            process.Start();
            string r = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return r;
        }
    }
}