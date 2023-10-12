using CommandInterpreter.Core;
using CommandInterpreter.UserCore;

namespace CommandInterpreter {
    internal class Program {
        static void Main(string[] args) {
            Login login = new Login();
            User user = login.Start();

            Interpreter interpreter = new Interpreter(user);
            interpreter.Start();
        }
    }
}