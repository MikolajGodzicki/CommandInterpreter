using CommandInterpreter.CommandUitls;
using CommandInterpreter.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.Command {

    [Permission(PermissionType.User)]
    [Description("ls", "Shows all files in current path")]
    internal class CLs : ICommand {
        public void Execute(string[] args) {
            if (args.Length != 0) {
                Console.WriteLine("Command doesn't use any arguments.");
                return;
            }

            foreach (string item in FileManager.GetFiles()) {
                Console.WriteLine($". {item}");
            }

            foreach (string item in FileManager.GetDirectories()) {
                Console.WriteLine($"d {item}");
            }
        }
    }
}
