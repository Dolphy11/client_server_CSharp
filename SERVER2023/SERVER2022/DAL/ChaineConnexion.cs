﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVER2023.DAL
{
    class ChaineConnexion
    {
        public static string ConnectionString
        {

            get { return "Server=localhost;database=bd_svb; User Id=root; Password="; }
        }
    }
}
