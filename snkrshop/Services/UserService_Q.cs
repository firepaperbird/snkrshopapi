﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snkrshop.Services
{
    partial interface UserService
    {
        int LoginUser(string username, string password);
        string SetRole(string username, int role);
    }
}
