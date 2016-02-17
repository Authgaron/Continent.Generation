using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Interfaces;

namespace Service.DTOs
{
    public class DataPointDto : IDto
    {
        int x;
        int y;
        int scale;
        IDataContainer data;
    }
}
