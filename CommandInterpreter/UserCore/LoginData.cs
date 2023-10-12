using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.UserCore {
    [Serializable]
    internal class LoginData {
        public string Login { get; set; }
        public string Password { get; set; }

        public LoginData(string login, string password) { 
            Login = login;
            Password = password;
        }
    }
}
