﻿using Core.DataAccess;
using DataAccess.Apstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFremawork
{
    public class EfColorDal : EfEntityRepositoryBase<Color, Context>,IColorDal
    {
      
    }
}
