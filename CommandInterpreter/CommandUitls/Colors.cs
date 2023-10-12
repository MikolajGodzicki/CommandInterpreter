using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.CommandUitls {
    internal class Colors {
        public static Dictionary<PermissionType, ConsoleColor> PermissionColors = new Dictionary<PermissionType, ConsoleColor>() {
            { PermissionType.User, ConsoleColor.White },
            { PermissionType.Sudoer, ConsoleColor.Magenta },
        };
    }
}
