﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    interface IDto<BaseDo>
    {
        void FromDomainObject(BaseDo domoainObject);
    }
}
