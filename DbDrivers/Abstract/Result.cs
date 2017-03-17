using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbDrivers.Abstract
{
    public class Result
    {
        public bool IsAcknowledged { get; set; }

        public int DocsCount { get; set; }
    }
}
