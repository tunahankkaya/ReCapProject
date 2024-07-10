﻿using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = Entities.Concrete.Color;

namespace DataAccess.Abstract
{
    public interface IColorDal:IEntityRepository<Color>
    {

    }
}
