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

        public User(string data) {
            string[] _data = data.Split(':');
            Name = _data[0];
            LoginData = new LoginData(_data[1], _data[2]);
            PermissionType = (PermissionType) int.Parse(_data[3]);
        }

        public override string ToString() {
            return $"{Name}:{LoginData.Login}:{LoginData.Password}:{PermissionType}";
        }
    }
}
