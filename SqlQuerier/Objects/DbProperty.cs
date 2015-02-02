using System;
using Leafing.Data.Definition;

namespace SqlQuerier.Objects
{
    public class DbProperty : IDbObject
    {
        [DbKey(IsDbGenerate = false), Length(1, 255)]
        public string Name = "";
        public string DataBase = "";
        public string DbProviderFactory = "";
        public string DbDriver = "";
        public DateTime SavedDateTime = DateTime.MinValue;
    }
}
