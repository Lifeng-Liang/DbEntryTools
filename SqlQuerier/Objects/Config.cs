using Leafing.Data.Definition;
using Leafing.Core.Text;

namespace SqlQuerier.Objects
{
    public class Config : IDbObject
    {
        [DbKey(IsDbGenerate = false), Length(1, 255)]
        public string Name = "";

        public string Content;

        public T GetContentObj<T>()
        {
            return XmlSerializer<T>.Xml.Deserialize(Content);
        }

        public void SetContentObj<T>(T obj)
        {
            Content = XmlSerializer<T>.Xml.Serialize(obj);
        }
    }
}
