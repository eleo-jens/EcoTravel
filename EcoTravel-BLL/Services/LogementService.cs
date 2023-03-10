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
    public class LogementService : ILogementRepository<Logement, int>
    {
        private readonly ILogementRepository<DO.Logement, int> _repository;

        public LogementService(ILogementRepository<DO.Logement, int> repository)
        {
            _repository = repository;
        }
        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<Logement> Get()
        {
            return _repository.Get().Select(e => e.ToBLL());
        }

        public Logement Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public int Insert(Logement entity)
        {
            return _repository.Insert(entity.ToDAL());
        }

        public bool Update(Logement entity, int id)
        {
            return _repository.Update(entity.ToDAL(), id);
        }

        public IEnumerable<Logement> GetByProprietaire(int idProprietaire)
        {
            return _repository.GetByProprietaire(idProprietaire).Select(e => e.ToBLL());    
        }

        public IEnumerable<Logement> GetByCategorie(int idCategorie)
        {
            return _repository.GetByCategorie(idCategorie).Select(e => e.ToBLL());
        }
    }
}
