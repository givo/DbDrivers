using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbDrivers.Abstract
{
    public interface IDatabase
    {
        string Name { get; set; }

        IDbCollection<T> GetCollection<T>(string name);
    }
}
