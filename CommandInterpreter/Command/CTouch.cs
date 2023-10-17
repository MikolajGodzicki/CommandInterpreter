using CommandInterpreter.CommandUitls;
using CommandInterpreter.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.Command {
    [Permission(PermissionType.User)]
    [Description("touch [name]", "Creates file with setted name")]
    internal class CTouch : ICommand {
        public void Execute(string[] args) {
            if (args.Length != 1) {
                Console.WriteLine("You need to write down name for the file.");
                return;
            }

            string fileName = args[0];
            if (FileManager.GetFiles().Contains(fileName)) {
                Console.WriteLine("There exist file with this name.");
                return;
            }

            File.Create($"{Interpreter.osPath}\\{fileName}");
        }
    }
}
