using System.IO;
using System.Text;
using ICSharpCode.TextEditor.Document;
using WeifenLuo.WinFormsUI.Docking;

namespace SqlQuerier
{
    public partial class ClassesForm : DockContent
    {
        public ClassesForm()
        {
            InitializeComponent();
            ClassInput.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("C#");
            ClassInput.Encoding = Encoding.Default;
        }

        public void NewClassText(string text)
        {
            ClassInput.Text = text;
            ClassInput.Refresh();
        }

        public void SaveAs(string fileName)
        {
            using (var sw = new StreamWriter(fileName, false, Encoding.Default))
            {
                sw.Write(ClassInput.Text);
            }
        }
    }
}
