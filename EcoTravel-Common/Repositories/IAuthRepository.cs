﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_Common.Repositories
{
    public interface IAuthRepository
    {
        int? CheckPassword(string email, string password);
    }
}
