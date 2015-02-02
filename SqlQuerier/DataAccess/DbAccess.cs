using System;
using System.Collections.Generic;
using Leafing.Data;
using SqlQuerier.Objects;

namespace SqlQuerier.DataAccess
{
    public class DbAccess
    {
        public static readonly DbAccess Instance = new DbAccess();

        public Config GetConfig(string name)
        {
            return DbEntry.GetObject<Config>(name);
        }

        public void SaveConfig(Config c)
        {
            if(!c.Name.IsNullOrEmpty())
            {
                if(GetConfig(c.Name) != null)
                {
                    DbEntry.Update(c);
                }
                else
                {
                    DbEntry.Insert(c);
                }
            }
        }

        public void DeleteConfig(string name)
        {
            var c = new Config {Name = name};
            DbEntry.Delete(c);
        }

        public DbProperty GetDbProperty(string name)
        {
            return DbEntry.GetObject<DbProperty>(name);
        }

        public void SaveDbProperty(DbProperty p)
        {
            if (!p.Name.IsNullOrEmpty())
            {
                p.SavedDateTime = DateTime.Now;
                if (GetDbProperty(p.Name) != null)
                {
                    DbEntry.Update(p);
                }
                else
                {
                    DbEntry.Insert(p);
                }
            }
        }

        public void DeleteDbProperty(string name)
        {
            var p = new DbProperty {Name = name};
            DbEntry.Delete(p);
        }

        public List<DbProperty> GetAllDbProperty()
        {
            return DbEntry
                .From<DbProperty>()
                .Where(Condition.Empty)
                .OrderBy((DESC)"SavedDateTime")
                .Select();
        }
    }
}
