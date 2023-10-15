using CommandInterpreter.Core;
using CommandInterpreter.UserCore;

namespace CommandInterpreter {
    internal class Program {
        static void Main(string[] args) {

            Initializer initializer = new Initializer();
            initializer.Initialize();

            User user = Login.Start();

            Interpreter interpreter = new Interpreter(user);
            interpreter.Start();
        }
    }
}