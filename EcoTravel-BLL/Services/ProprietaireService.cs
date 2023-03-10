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
    public class ProprietaireService : IProprietaireRepository<Proprietaire, int>
    {
        private readonly IProprietaireRepository<DO.Proprietaire, int> _repository;
        private readonly ILogementRepository<DO.Logement, int> _logement_repository;

        public ProprietaireService(IProprietaireRepository<DO.Proprietaire, int> repository, ILogementRepository<DO.Logement, int> logement_repository)
        {
            _repository = repository;
            _logement_repository = logement_repository;
        }

        public Proprietaire Get(int id)
        {
            Proprietaire entity = _repository.Get(id).ToBLL();
            entity.logements = _logement_repository.GetByProprietaire(id).Select(e => e.ToBLL());
            return entity;
        }

        public int Insert(Proprietaire entity)
        {
            return _repository.Insert(entity.ToDAL());
        }

        public int? CheckPassword(string email, string password)
        {
            return _repository.CheckPassword(email, password);
        }
    }
}
