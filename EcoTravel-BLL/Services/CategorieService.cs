using EcoTravel_BLL.Entities;
using DO = EcoTravel_DAL.Entities;
using EcoTravel_Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoTravel_BLL.Mapper;

namespace EcoTravel_BLL.Services
{
    public class CategorieService : ICategorieRepository<Categorie, int>
    {
        private readonly ICategorieRepository<DO.Categorie, int> _repository;
        public CategorieService(ICategorieRepository<DO.Categorie, int> repository)
        {
            _repository = repository; 
        }

        public IEnumerable<Categorie> Get()
        {
            return _repository.Get().Select(e => e.ToBLL());
        }

        public Categorie Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }
    }
}
