using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    interface IDtoList<BaseDto, BaseDo> where BaseDto : IDto<BaseDo>, new()
    {
        void GenerateFromList(List<BaseDo> inputList); 
    }
}
