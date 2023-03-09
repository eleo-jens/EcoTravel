using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_Common.Repositories
{
    public interface IRepository<TEntity, TId>: IGetRepository<TEntity, TId>, IInsertRepository<TEntity, TId>, IDeleteRepository<TEntity, TId>, IUpdateRepository<TEntity, TId>
    {
    }
}
