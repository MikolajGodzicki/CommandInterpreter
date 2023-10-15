using CommandInterpreter.CommandUitls;
using CommandInterpreter.Core;
using CommandInterpreter.UserCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.Command {
    [Permission(PermissionType.Sudoer)]
    [Description("passwd [User]", "Change password for selected user")]
    internal class CPasswd : ICommand {
        public void Execute(string[] args) {
            if (args.Length != 1) {
                Console.WriteLine("You need to select which user password you want to change.");
                return;
            }

            User? user = UsersData.Instance.Users.FirstOrDefault(e => e.LoginData.Login == args[0]);

            if (user == null) {
                Console.WriteLine("Cannot find user with this login.");
                return;
            }

            string newPassword = InputHandler.GetInput("Insert new password: ");

            user.LoginData.Password = newPassword;

            ConsoleWriter.WriteLine("Password succesfully changed!", ConsoleColor.Green);
        }
    }
}
