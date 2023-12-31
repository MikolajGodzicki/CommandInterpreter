﻿using CommandInterpreter.CommandUitls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.Command {
    [Permission(PermissionType.User)]
    [Description("clear", "Clears prompt")]
    internal class CClear : ICommand {
        public void Execute(string[] args) {
            if (args.Length != 0) {
                Console.WriteLine("Command doesn't use any arguments.");
                return;
            }

            Console.Clear();
        }
    }
}
