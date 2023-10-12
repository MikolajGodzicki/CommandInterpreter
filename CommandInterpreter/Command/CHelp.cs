using CommandInterpreter.CommandUitls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.Command {
    [Permission(PermissionType.All)]
    internal class CHelp : ICommand {
        public void Execute(string[] args) {
        }
    }
}
