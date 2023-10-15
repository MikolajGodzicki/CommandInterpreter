using CommandInterpreter.UserCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.Core {
    internal class Login {
        public static User Start() {
            User? user;
            do {
                string loginInput = InputHandler.GetInput("Login: ");
                string passwordInput = InputHandler.GetInput("Password: ");

                LoginData loginData = new LoginData(loginInput, passwordInput);

                user = UsersData.Instance.Users.FirstOrDefault(e => e.LoginData.Equals(loginData));
                if (user == null) {
                    ConsoleWriter.WriteLine("Incorrect login data.", ConsoleColor.Red);
                }
            } while (user == null);


            return user;
        }

        public static User Start(string login) {
            User? user;
            do {
                string loginInput = login;
                string passwordInput = InputHandler.GetInput("Password: ");

                LoginData loginData = new LoginData(loginInput, passwordInput);

                user = UsersData.Instance.Users.FirstOrDefault(e => e.LoginData.Equals(loginData));
                if (user == null) {
                    ConsoleWriter.WriteLine("Incorrect login data.", ConsoleColor.Red);
                }
            } while (user == null);


            return user;
        }
    }
}
