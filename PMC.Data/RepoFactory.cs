using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.Data
{
    public class RepoFactory
    {
        //production repo factory
        public DataContext DB { get; set; }
        public Guid SessionId { get; set; }
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public bool HasSession { get { return (SessionId != new Guid()) ? true : false; } }

        private Dictionary<Type, object> cache = new Dictionary<Type, object>();

        public T Get<T>()
        {
            if (DB == null)
                DB = new DataContext();
            Type type = typeof(T);
            if (cache.ContainsKey(type))
                return (T)cache[type];

            var newObject = (T)Activator.CreateInstance(type, new object[] { UserID, DB });
            cache.Add(type, newObject);
            return newObject;
        }

       
    }
}
