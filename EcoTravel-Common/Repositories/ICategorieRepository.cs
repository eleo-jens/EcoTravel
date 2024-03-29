﻿using EcoTravel_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_Common.Repositories
{
    public interface ICategorieRepository<TEntity, TId> : IGetRepository<TEntity, TId> where TEntity: ICategorie
    {
    }
}
