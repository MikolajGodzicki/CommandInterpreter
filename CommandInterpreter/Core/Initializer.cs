using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.Core {
    internal class Initializer {
        public void Initialize() {
            FileManager.CreateFilesIfNotExist();
        }
    }
}
