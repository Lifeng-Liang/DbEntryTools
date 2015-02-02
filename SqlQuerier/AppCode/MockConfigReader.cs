using System.Collections.Generic;
using System.Collections.Specialized;
using Leafing.Core.Setting;
using System.Xml;

namespace SqlQuerier.AppCode
{
    public class MockConfigReader : ConfigReaderProxy
    {
        private readonly Dictionary<string, NameValueCollection> _dict;

        public MockConfigReader(string xmlConfig)
        {
            _dict = new Dictionary<string, NameValueCollection>();
            var xd = new XmlDocument();
            xd.LoadXml(xmlConfig);
            var nh = new NameValueSectionHandler();
            var nvc = (NameValueCollection)nh.Create(null, null, xd.FirstChild);
            _dict.Add(xd.FirstChild.Name, nvc);
            SetInstance(this);
        }

        public override NameValueCollection GetSection(string sectionName)
        {
            if (_dict.ContainsKey(sectionName))
            {
                return _dict[sectionName];
            }
            return new NameValueCollection();
        }
    }
}
