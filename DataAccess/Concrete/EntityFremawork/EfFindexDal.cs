﻿using Core.DataAccess;
using DataAccess.Apstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFremawork
{
    public class EfFindexDal:EfEntityRepositoryBase<Findex,Context>,IFindexDal
    {
    }
}
