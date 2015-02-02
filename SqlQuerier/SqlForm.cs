using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ICSharpCode.TextEditor.Document;
using Leafing.Data.SqlEntry;
using Leafing.Core.Text;
using SqlQuerier.AppCode;
using WeifenLuo.WinFormsUI.Docking;

namespace SqlQuerier
{
    public partial class SqlForm : DockContent
    {
        private readonly List<DataGridView> _viewSet = new List<DataGridView>();
        //private FormPercentSplitHelper _formHelper;

        public SqlForm()
        {
            InitializeComponent();
            new FormPercentSplitHelper(this, BottomPanel, BottomSplitter);
            SqlInput.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("SQL");
            SqlInput.Encoding = Encoding.Default;
            TabText = null;
        }

        public void NewOpenFile(string fileName, int index)
        {
            if (fileName != "")
            {
                Text = string.Format("{0} - Window({1})", fileName, index);
                SqlInput.Text = StringHelper.ReadToEnd(new StreamReader(fileName, Encoding.Default));
            }
            else
            {
                Text = string.Format("(New) - Window({0})", index);
            }
        }

        public void SaveAs(string fileName)
        {
            using (var sw = new StreamWriter(fileName, false, Encoding.Default))
            {
                sw.Write(SqlInput.Text);
            }
        }

        private void DisposeDataViews()
        {
            ViewPanel.Controls.Clear();
            foreach (DataGridView dv in _viewSet)
            {
                dv.Dispose();
            }
            _viewSet.Clear();
        }

        public void RunScript(DataProvider currentProvider)
        {
            try
            {
                ResultText.Text = "";
                if (SqlInput.Enabled)
                {
                    DisposeDataViews();
                    string sqlString = SqlInput.Text;
                    var sql = new SqlStatement(sqlString);
                    DataSet ds = currentProvider.ExecuteDataset(sql);
                    for (int i = ds.Tables.Count - 1; i >= 0; i--)
                    {
                        DataTable dt = ds.Tables[i];
                        var dv = new DataGridView();
                        ViewPanel.Controls.Add(dv);
                        dv.Dock = DockStyle.Top;
                        dv.DataSource = dt;
                        dv.Visible = true;
                    }
                    ResultText.Text = string.Format("Execute Sql :\r\n{0}\r\nDone!", sqlString);
                    ResultTab.SelectedTab = ds.Tables.Count == 0 ? Messages : Result;
                }
            }
            catch (Exception ex)
            {
                ResultText.Text = ex.ToString();
                ResultTab.SelectedTab = Messages;
            }
        }
    }
}
