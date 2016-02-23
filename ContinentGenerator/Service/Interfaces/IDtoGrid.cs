using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    interface IDtoGrid<BaseDto, BaseDo> where BaseDto : IDto<BaseDo>, new()
    {
        void GenerateFromGrid(List<List<BaseDo>> inputList);
    }
}
