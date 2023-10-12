using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.Command {
    internal interface ICommand {
        public void Execute(string[] args);
    }
}
