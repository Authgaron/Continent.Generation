using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Interfaces;

namespace Service.DTOs
{
    abstract class DataPointDto<TPointDo, TDataContainer> : IDto<TPointDo>
    {
        int x;
        int y;
        int scale;
        TDataContainer data;

        public void FromDomainObject(TPointDo domainObject)
        {
        }
    }
}
