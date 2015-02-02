using System.Collections.Generic;
using Leafing.Core;
using Leafing.Data.Driver;

namespace SqlQuerier.AppCode
{
    class MockDbDriverFactory : DbDriverFactory
    {
        public static void Clear()
        {
            var jar = (Dictionary<string, DbDriver>)ClassHelper.GetValue(DbDriverFactory.Instance, "Jar");
            jar.Clear();
        }
    }
}
