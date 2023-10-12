using CommandInterpreter.Core;

namespace CommandInterpreter {
    internal class Program {
        static void Main(string[] args) {
            Interpreter interpreter = new Interpreter();
            interpreter.Start();
        }
    }
}