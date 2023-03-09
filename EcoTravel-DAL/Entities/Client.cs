using EcoTravel_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_DAL.Entities
{
    public class Client : IClient
    {
        //int
        public int idClient { get; set; }

        //nvarchar(50)
        public string nom { get; set; }

        //nvarchar(50)
        public string prenom { get; set; }

        //char(2)
        public string pays { get; set; }

        //nvarchar(255)
        public string email { get; set; }

        //nvarchar(20)
        public string telephone { get; set; }

        //varbinary(32)
        public string password { get; set; }
    }
}
