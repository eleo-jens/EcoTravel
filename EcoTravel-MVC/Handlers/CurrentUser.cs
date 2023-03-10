using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel_MVC.Handlers
{
    public class CurrentUser
    {
        public int idUser { get; set; }
        public string email { get; set; }
        public DateTime lastConnexion { get; set; }
        public string role { get; set; }
    }
}
