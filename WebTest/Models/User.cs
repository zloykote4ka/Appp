using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string E_mail { get; set; }
        public string VK_link { get; set; }
        protected string login;
        protected string password;

        public bool SignOut()
        {
            return true;
        }
        

    }
}