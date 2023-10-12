using CommandInterpreter.CommandUitls;
using CommandInterpreter.UserCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.Command {
    internal class CommandCollection {
        public Dictionary<string, ICommand> Commands { get; private set; }

        private User User { get; set; }

        public CommandCollection(User user) { 
            Commands = new Dictionary<string, ICommand>();
            User = user;
        }

        public void AddCommand(string commandName, ICommand command) => Commands.Add(commandName, command);

        public void ExecuteCommand(string commandName, string[] args) {
            if (commandName == string.Empty) {
                return;
            }

            if (!Commands.ContainsKey(commandName)) {
                Console.WriteLine($"Cannot find command: [{commandName}].");
                return;
            }

            ICommand command = Commands[commandName];

            object[] attr = command.GetType().GetCustomAttributes(false);
            foreach( object obj in attr ) {
                if (obj is PermissionAttribute)
                {
                    PermissionType permission = ((PermissionAttribute)obj).PermissionType;
                    if (permission > User.PermissionType) {
                        Console.WriteLine($"You have not enough permissions to use [{commandName}]");
                        return;
                    }
                }
            }

            command.Execute(args);
        }
    }
}
