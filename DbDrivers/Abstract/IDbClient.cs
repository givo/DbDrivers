using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbDrivers.Abstract
{
    public interface IDbClient
    {
        bool Connect(string connectionString);

        IDatabase GetDatabase(string name);
    }
}
