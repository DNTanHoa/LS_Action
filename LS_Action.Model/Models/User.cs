using System;
using System.Collections.Generic;
using System.Text;

namespace LS_Action.Model
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string hashkey { get; set; }
        public string phone { get; set; }
        public string fullname { get; set; }
        public string email { get; set; }
        public string avatar { get; set; }
        public bool isActive { get; set; }
    }
}
