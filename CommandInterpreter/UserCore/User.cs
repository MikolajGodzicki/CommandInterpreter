using CommandInterpreter.CommandUitls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.UserCore {
    internal class User {
        public PermissionType PermissionType { get; private set; }
        public LoginData LoginData { get; private set; }

        public User() { }
        public User(PermissionType permissionType, LoginData loginData) {
            PermissionType = permissionType;
            LoginData = loginData;
        }

        public User(string data) {
            string[] _data = data.Split(':');
            LoginData = new LoginData(_data[0], _data[1]);
            PermissionType = (PermissionType) int.Parse(_data[2]);
        }

        public override string ToString() {
            return $"{LoginData.Login}:{LoginData.Password}:{PermissionType}";
        }
    }
}
