﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Mapping
{
    // Entity : Model Class 
    // Table 
    internal class User
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }    
        public string phone { get; set; }
        public string CardNumber { get; set; }
        public DateOnly Expiredate { get; set; }

    }
}
