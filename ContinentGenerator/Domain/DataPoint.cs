using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    abstract class DataPoint<TDataContainer> : IDataPoint<TDataContainer> where TDataContainer : IDataContainer
    {
        int x;
        int y;
        int scale;
        private TDataContainer data { get; set; }
    }
}
