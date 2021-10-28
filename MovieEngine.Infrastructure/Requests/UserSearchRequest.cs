﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEngine.Infrastructure.Requests
{
   public class UserSearchRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? UserID { get; set; }

    }
}
