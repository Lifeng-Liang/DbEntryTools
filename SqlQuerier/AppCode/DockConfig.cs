using System.IO;
using System.Text;
using Leafing.Core.Text;
using SqlQuerier.DataAccess;
using SqlQuerier.Objects;
using WeifenLuo.WinFormsUI.Docking;

namespace SqlQuerier.AppCode
{
    public static class DockConfig
    {
        private const string DockConfigName = "DockConfig";

        public static void SaveDockConfig(DockPanel dp)
        {
            using ( Stream s = new MemoryStream())
            {
                dp.SaveAsXml(s, Encoding.Default, true);
                var c = new Config {Name = DockConfigName, Content = StringHelper.ReadToEnd(s, 0)};
                DbAccess.Instance.SaveConfig(c);
            }
        }

        public static bool LoadDockConfig(DockPanel dp, DeserializeDockContent deDockContent)
        {
            Config c = DbAccess.Instance.GetConfig(DockConfigName);
            if (c != null)
            {
                using (Stream s = new MemoryStream())
                {
                    using (var sw = new StreamWriter(s))
                    {
                        sw.Write(c.Content);
                        sw.Flush();
                        s.Position = 0;
                        dp.LoadFromXml(s, deDockContent);
                    }
                }
                return true;
            }
            return false;
        }
    }
}
