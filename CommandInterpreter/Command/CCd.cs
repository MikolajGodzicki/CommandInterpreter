using CommandInterpreter.CommandUitls;
using CommandInterpreter.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.Command {
    [Permission(PermissionType.User)]
    [Description("cd [path]", "Change path to selected directory")]
    internal class CCd : ICommand {

        public void Execute(string[] args) {
            if (args.Length != 1) {
                Console.WriteLine("You need to select which directory you want to change.");
                return;
            }

            string pathToChange = args[0];

            if (pathToChange == "..") {
                string path = Interpreter.logicPath;
                List<string> list = path.Split('\\').ToList();

                list.RemoveAt(list.Count - 1);
                Interpreter.logicPath = string.Join('\\', list);

                return;
            }

            if (pathToChange == "/") {
                Interpreter.logicPath = "\\";
                return;
            }

            List<string> directories = FileManager.GetDirectories().ToList();

            if (directories.Contains(pathToChange)) {
                Interpreter.logicPath += "\\" + pathToChange;
                return;
            }
        }
    }
}
