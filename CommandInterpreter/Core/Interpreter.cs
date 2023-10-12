using CommandInterpreter.Command;
using CommandInterpreter.CommandUitls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.Core {
    internal class Interpreter {
        private CommandCollection CommandCollection { get; set; }
        private CommandTrimmer CommandTrimmer { get; set; }

        public Interpreter() { 
            CommandCollection = new CommandCollection();
            CommandTrimmer = new CommandTrimmer();
            InitializeCommands();
        }

        public void Start() {
            do {
                Console.Write(">> ");
                string? _input = Console.ReadLine();
                string input = _input == null ? string.Empty : _input;

                CommandModel commandModel = CommandTrimmer.TrimInput(input);

                Interpret(commandModel.Name, commandModel.Args);
            } while(true);
        }

        private void InitializeCommands() {
            CommandCollection.AddCommand("help", new CHelp());
            CommandCollection.AddCommand("clear", new CClear());
        }

        private void Interpret(string commandName, string[] args) {
            CommandCollection.ExecuteCommand(commandName, args);
        }
    }
}
