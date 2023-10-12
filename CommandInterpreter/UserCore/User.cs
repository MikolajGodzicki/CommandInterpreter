using CommandInterpreter.CommandUitls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.UserCore {
    internal class User {
        public string Name { get; private set; }
        public PermissionType PermissionType { get; private set; }
        public LoginData LoginData { get; private set; }

        public User() { }
        public User(string name, PermissionType permissionType, LoginData loginData) {
            Name = name;
            PermissionType = permissionType;
            LoginData = loginData;
        }
    }
}
