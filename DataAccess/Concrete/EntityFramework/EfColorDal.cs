﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace DataAccess.Concrete.Entityframework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, CarDataContext>, IColorDal
    {
    }
}
