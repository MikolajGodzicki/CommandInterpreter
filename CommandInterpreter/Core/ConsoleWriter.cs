using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.Core {
    internal class ConsoleWriter {
        public static void WriteLine(string message, ConsoleColor FColor = ConsoleColor.Gray, ConsoleColor BColor = ConsoleColor.Black) {
            Console.ForegroundColor = FColor;
            Console.BackgroundColor = BColor;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void Write(string message, ConsoleColor FColor = ConsoleColor.Gray, ConsoleColor BColor = ConsoleColor.Black) {
            Console.ForegroundColor = FColor;
            Console.BackgroundColor = BColor;
            Console.Write(message);
            Console.ResetColor();
        }
    }
}
