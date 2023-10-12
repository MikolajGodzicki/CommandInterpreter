using CommandInterpreter.CommandUitls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.Command {
    [Permission(PermissionType.User)]
    [Description("help", "Displays available commands")]
    internal class CHelp : ICommand {
        private Dictionary<string, ICommand> Commands { get; set; }
        public CHelp(Dictionary<string, ICommand> commands) {
            Commands = commands;
        }

        public void Execute(string[] args) {
            foreach (var command in Commands) {
                object[] descriptions = command.Value.GetType().GetCustomAttributes(false);
                foreach (object desc in descriptions) {
                    if (desc is DescriptionAttribute) {
                        DescriptionAttribute descriptionAttribute = (DescriptionAttribute) desc;
                        Console.WriteLine($"{descriptionAttribute.Name}: {descriptionAttribute.Description}");
                    }
                }
            }
        }
    }
}
