using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.CommandUitls {
    internal class DescriptionAttribute : Attribute {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public DescriptionAttribute(string name, string description) {
            Name = name;
            Description = description;
        }

    }
}
