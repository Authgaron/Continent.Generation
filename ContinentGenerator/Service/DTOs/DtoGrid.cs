using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Interfaces;

namespace Service.DTOs
{
    abstract class DtoGrid<BaseDto, BaseDo> : IDtoGrid<BaseDto, BaseDo>
        where BaseDto : IDto<BaseDo>, new()
    {
        private List<List<BaseDto>> dtoGrid;

        public void GenerateFromGrid(List<List<BaseDo>> inputList)
        {
            dtoGrid = new List<List<BaseDto>>();
            foreach (List<BaseDo> domainObjectList in inputList)
            {
                dtoGrid.Add(new List<BaseDto>());
                List<BaseDto> currentRow = dtoGrid[dtoGrid.Count - 1];
                foreach (BaseDo domainObject in domainObjectList)
                {
                    BaseDto dto = new BaseDto();
                    dto.FromDomainObject(domainObject);
                    currentRow.Add(dto);
                }
            }
        }
    }
}
