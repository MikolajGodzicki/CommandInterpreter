using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.CommandUitls {
    internal class CommandModel {
        public string Name { get; set; }
        public string[] Args { get; set; }

        public CommandModel(string name, string[] args) { 
            Name = name;
            Args = args;
        }
    }
}
