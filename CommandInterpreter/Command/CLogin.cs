using CommandInterpreter.CommandUitls;
using CommandInterpreter.Core;
using CommandInterpreter.UserCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.Command {
    [Permission(PermissionType.User)]
    [Description("login [User]", "Login to selected user")]
    internal class CLogin : ICommand {
        Interpreter interpreter;
        public CLogin(Interpreter interpreter) {
            this.interpreter = interpreter;
        }

        public void Execute(string[] args) {
            if (args.Length != 1) {
                Console.WriteLine("You need to select which user you want to log in.");
                return;
            }

            User? user = UsersData.Instance.Users.FirstOrDefault(e => e.LoginData.Login == args[0]);

            if (user == null) {
                Console.WriteLine("Cannot find user with this login.");
                return;
            }

            interpreter.User = Login.Start(args[0]);
        }
    }
}
