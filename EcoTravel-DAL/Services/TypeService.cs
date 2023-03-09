using EcoTravel_Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_DAL.Services
{
    public class TypeService : ITypeRepository<Type, int>
    {
        public IEnumerable<Type> Get()
        {
            throw new NotImplementedException();
        }

        public Type Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
