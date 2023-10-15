using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.Core {
    internal class InputHandler {
        public static string GetInput(string message) {
            Console.Write(message);
            string? _input = Console.ReadLine();
            string input = _input == null ? string.Empty : _input;
            return input;
        }

        public static string GetInput() {
            string? _input = Console.ReadLine();
            string input = _input == null ? string.Empty : _input;
            return input;
        }
    }
}
