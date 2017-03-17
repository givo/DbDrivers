using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbDrivers.Abstract
{
    public interface IDbCollection<T>
    {
        void InsertOne(T doc);

        Result UpdateOne(IDictionary<string, object> filter, IDictionary<string, object> update);

        IEnumerable<T> Find(IDictionary<string, object> filter);

        Result DeleteOne(IDictionary<string, object> filter);
    }
}
