using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.CommandUitls {
    internal class CommandTrimmer {
         public CommandModel TrimInput(string input) {
            input = input.Trim();
            string name = input.Split(' ').First();
            string[] args = input.Split(" ").Skip(1).ToArray();
            
            CommandModel commandModel = new CommandModel(name, args);
            return commandModel;
        }
    }
}
