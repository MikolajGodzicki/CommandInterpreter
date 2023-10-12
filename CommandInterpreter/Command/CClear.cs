using CommandInterpreter.CommandUitls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.Command {

    [Description("clear", "Clears prompt")]
    internal class CClear : ICommand {
        public void Execute(string[] args) {
            Console.Clear();
        }
    }
}
