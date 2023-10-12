using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.Command {
    internal class CommandCollection {
        private Dictionary<string, ICommand> Commands { get; set; }

        public CommandCollection() { 
            Commands = new Dictionary<string, ICommand>();
        }

        public void AddCommand(string commandName, ICommand command) => Commands.Add(commandName, command);

        public void ExecuteCommand(string commandName, string[] args) {
            if (!Commands.ContainsKey(commandName)) {
                Console.WriteLine($"Cannot find command: [{commandName}].");
                return;
            }

            Commands[commandName].Execute(args);
        }
    }
}
