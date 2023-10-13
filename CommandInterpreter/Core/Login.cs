using CommandInterpreter.UserCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.Core {
    internal class Login {
        public User Start() {
            User? user;
            do {
                Console.Write("Login: ");
                string loginInput = InputHandler.GetInput();
                Console.Write("Password: ");
                string passwordInput = InputHandler.GetInput();

                LoginData loginData = new LoginData(loginInput, passwordInput);

                user = UsersData.Instance.Users.FirstOrDefault(e => e.LoginData.Equals(loginData));
            } while (user == null);


            return user;
        }
    }
}
