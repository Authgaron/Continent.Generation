using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Interfaces;

namespace Service.DTOs
{
    abstract class DtoList<BaseDto, BaseDo> : IDtoList<BaseDto, BaseDo>
        where BaseDto : IDto<BaseDo>, new()
    {
        private List<BaseDto> dtoList;

        public void GenerateFromList(List<BaseDo> inputList)
        {
            dtoList = new List<BaseDto>();
            foreach (BaseDo domainObject in inputList)
            {
                BaseDto dto = new BaseDto();
                dto.FromDomainObject(domainObject);
                dtoList.Add(dto);
            }
        }
    }
}
