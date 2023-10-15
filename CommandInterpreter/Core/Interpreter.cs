using CommandInterpreter.Command;
using CommandInterpreter.CommandUitls;
using CommandInterpreter.UserCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.Core {
    internal class Interpreter {
        private CommandCollection CommandCollection { get; set; }
        private CommandTrimmer CommandTrimmer { get; set; }

        public User User { get; set; }

        public static string logicPath = "\\core";
        public static string osPath = $"{FileManager.GetCurrentDirectoryName()}";

        public Interpreter(User user) {
            User = user;

            CommandCollection = new CommandCollection(User);
            CommandTrimmer = new CommandTrimmer();

            InitializeCommands();
        }

        public void Start() {
            do {
                WritePrompt();

                string input = InputHandler.GetInput();

                CommandModel commandModel = CommandTrimmer.TrimInput(input);

                Interpret(commandModel.Name, commandModel.Args);
            } while(true);
        }

        private void InitializeCommands() {
            CommandCollection.AddCommand("clear", new CClear());
            CommandCollection.AddCommand("help", new CHelp(CommandCollection.Commands));
            CommandCollection.AddCommand("passwd", new CPasswd());
            CommandCollection.AddCommand("login", new CLogin(this));
            CommandCollection.AddCommand("ls", new CLs());
        }

        private void Interpret(string commandName, string[] args) {
            CommandCollection.ExecuteCommand(commandName, args);
        }

        private void WritePrompt() {
            Console.Write($"[");
            ConsoleWriter.Write(User.LoginData.Login, Colors.PermissionColors[User.PermissionType]);
            Console.Write("] >> ");
        }
    }
}
