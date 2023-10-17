using CommandInterpreter.CommandUitls;
using CommandInterpreter.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.Command {
    [Permission(PermissionType.User)]
    [Description("mv [source] [destination]", "Move file from source path to destination path")]
    internal class CMv : ICommand {
        public void Execute(string[] args) {
            if (args.Length != 2) {
                Console.WriteLine("You need to write down name for the file.");
                return;
            }

            string source = args[0];
            string destination = args[1];

            if (destination.StartsWith('\\')) {
                destination = destination.Substring(1);
                destination = $"{Interpreter.corePath}\\{destination}";
            } else {
                destination = $"{Interpreter.osPath}\\{destination}";
            }

            source = $"{Interpreter.osPath}\\{source}";

            if (File.Exists(destination)) {
                Console.WriteLine("This file exist.");
                return;
            }

            File.Move(source, destination);
        }
    }
}
