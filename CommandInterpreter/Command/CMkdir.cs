using CommandInterpreter.CommandUitls;
using CommandInterpreter.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.Command {
    internal class CMkdir : ICommand {
        [Permission(PermissionType.User)]
        [Description("mkdir [name]", "Creates directory with setted name")]
        public void Execute(string[] args) {
            if (args.Length != 1) {
                Console.WriteLine("You need to write down name for the directory.");
                return;
            }

            string dirName = args[0];
            if (FileManager.GetDirectories().Contains(dirName)) {
                Console.WriteLine("There exist directory with this name.");
                return;
            }

            Directory.CreateDirectory($"{Interpreter.osPath}\\{dirName}");
        }
    }
}
