using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duitku
{
    class User
    {
        private string _id_user;
        private string _userName; 
        private string _password;
        private string _email;

        public string ID_user
        {
            get { return _id_user; }
            set { _id_user = value; }
        }
        public string userName
        {
            get { return _userName;}
            set { _userName = value;}
        }

        public string Password
        {
            get { return _password;}
            set { _password = value;}
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public User(string _id_user, string _userName, string _email)
        {
            ID_user = _id_user;
            userName = _userName;
            Email = _email;
        }
        public Boolean Login(string username, string password)
        {
            return true; 
        }
    }
}
