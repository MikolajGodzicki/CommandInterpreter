using CommandInterpreter.UserCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.Core {
    internal class Login {
        public User Start() {
            Console.Write("Login: ");
            string loginInput = InputHandler.GetInput();
            Console.Write("Password: ");
            string passwordInput = InputHandler.GetInput();



            return new User();
        }
    }
}
