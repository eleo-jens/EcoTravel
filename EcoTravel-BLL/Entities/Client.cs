using System;
using EcoTravel_Common.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_BLL.Entities
{
    public class Client : IClient
    {
        public int idClient { get; set; }

        public string nom { get; set; }

        public string prenom { get; set; }

        public string pays { get; set; }

        public string email { get; set; }

        public string telephone { get; set; }

        public string password { get; set; }
    }
}
