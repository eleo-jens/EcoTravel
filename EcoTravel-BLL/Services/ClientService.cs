using BO = EcoTravel_BLL.Entities;
using DO = EcoTravel_DAL.Entities;
using EcoTravel_Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoTravel_BLL.Entities;
using EcoTravel_BLL.Mapper;

namespace EcoTravel_BLL.Services
{
    public class ClientService : IClientRepository<Client, int>
    {
        private readonly IClientRepository<DO.Client, int> _repository;
        public ClientService(IClientRepository<DO.Client, int> repository)
        {
            _repository = repository;
        }

        public Client Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public int Insert(Client entity)
        {
            return _repository.Insert(entity.ToDAL());
        }

        public int? CheckPassword(string email, string password)
        {
            return _repository.CheckPassword(email, password);
        }
    }
}
