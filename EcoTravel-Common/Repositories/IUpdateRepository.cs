using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_Common.Repositories
{
    public interface IUpdateRepository<TEntity, TId>
    {
        bool Update(TEntity entity, TId id);
    }
}
