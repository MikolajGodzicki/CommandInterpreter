using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.CommandUitls {
    internal class PermissionAttribute : Attribute {
        public PermissionType PermissionType { get; private set; }
        public PermissionAttribute(PermissionType permissionType) {
            PermissionType = permissionType;
        }
    }
}
