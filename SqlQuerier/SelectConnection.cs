using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using Leafing.Core;
using SqlQuerier.DataAccess;
using SqlQuerier.Objects;

namespace SqlQuerier
{
    public partial class SelectConnection : Form
    {
        internal string ResultXmlString;

        public SelectConnection()
        {
            InitializeComponent();
        }

        private void DataBaseText_TextChanged(object sender, EventArgs e)
        {
            OnTextChanged();
        }

        private void DbProviderFactoryText_TextChanged(object sender, EventArgs e)
        {
            OnTextChanged();
        }

        private void DbDriverText_TextChanged(object sender, EventArgs e)
        {
            OnTextChanged();
        }

        private void OnTextChanged()
        {
            var xd = new XmlDocument();
            XmlElement pn = xd.CreateElement("Leafing.Settings");
            xd.AppendChild(pn);

            AppendFromTextBox(xd, DataBaseText);
            AppendFromTextBox(xd, DbProviderFactoryText);
            AppendFromTextBox(xd, DbDriverText);

            if (pn.ChildNodes.Count == 0)
            {
                PreviewText.Text = "";
            }
            else
            {
                var ms = new MemoryStream();
                xd.Save(ms);
                ms.Position = 0;
                using (var sr = new StreamReader(ms))
                {
                    PreviewText.Text = sr.ReadToEnd();
                }
            }
            ButtonOK.Enabled = (PreviewText.Text == "" ? false : true);
        }

        private void AppendFromTextBox(XmlDocument xd, TextBox tb)
        {
            string name = tb.Name.Substring(0, tb.Name.Length - "Text".Length);
            if (tb.Enabled && tb.Text != "")
            {
                AppendNode(xd, name, tb.Text);
            }
        }

        private void AppendNode(XmlDocument xd, string key, string value)
        {
            XmlNode xn = xd.CreateElement("add");
            XmlAttribute xk = xd.CreateAttribute("key");
            xk.Value = key;
            xn.Attributes.Append(xk);
            XmlAttribute xv = xd.CreateAttribute("value");
            xv.Value = value;
            xn.Attributes.Append(xv);
            xd.ChildNodes[0].AppendChild(xn);
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            var p = new DbProperty
                        {
                            Name = SavedName.Text,
                            DataBase = DataBaseText.Text,
                            DbDriver = DbDriverText.Text,
                            DbProviderFactory = DbProviderFactoryText.Text
                        };
            DbAccess.Instance.SaveDbProperty(p);

            ResultXmlString = PreviewText.Text;
            BuildCodegenConfig(ResultXmlString);
            Close();
        }

        private static void BuildCodegenConfig(string c)
        {
            const string configTemplate =
@"<?xml version=""1.0"" encoding=""utf-8"" ?>
<configuration>
  <configSections>
    <section name=""Leafing.Settings"" type=""Leafing.Core.Setting.NameValueSectionHandler, Leafing.Core"" />
  </configSections>

{0}
  <startup useLegacyV2RuntimeActivationPolicy=""true"">
    <supportedRuntime version=""v4.0"" sku="".NETFramework,Version=v4.0""/>
  </startup>
</configuration>";

            string config = string.Format(configTemplate, c);
            string path = Path.Combine(Path.Combine(SystemHelper.BaseDirectory, "Bin"), "Leafing.CodeGen.exe.config");
            using (var fout = new StreamWriter(path))
            {
                fout.WriteLine(config);
            }
        }

        private void SelectConnection_Load(object sender, EventArgs e)
        {
            List<DbProperty> ps = DbAccess.Instance.GetAllDbProperty();
            foreach (DbProperty p in ps)
            {
                SavedName.Items.Add(p.Name);
            }
            if (SavedName.Items.Count > 0)
            {
                SavedName.SelectedIndex = 0;
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DbAccess.Instance.DeleteDbProperty(SavedName.Text);
                SavedName.Items.Clear();
                SelectConnection_Load(sender, e);
            }
        }

        private void SavedName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbProperty p = DbAccess.Instance.GetDbProperty(SavedName.Text);
            if (p != null)
            {
                DataBaseText.Text = p.DataBase;
                DbDriverText.Text = p.DbDriver;
                DbProviderFactoryText.Text = p.DbProviderFactory;
            }
            OnTextChanged();
        }
    }
}