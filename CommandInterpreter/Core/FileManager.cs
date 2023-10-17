using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.Core {
    internal class FileManager {
        public static void CreateFilesIfNotExist() {
            //directories
            CreateDirectory($"{GetCurrentDirectoryName()}\\core");
            CreateDirectory($"{GetCurrentDirectoryName()}\\core\\usr");
            CreateDirectory($"{GetCurrentDirectoryName()}\\core\\usr\\bin");
            CreateDirectory($"{GetCurrentDirectoryName()}\\core\\etc");

            //files
            CreateUsersFile("root:123:1");
        }

        private static void CreateDirectory(string path) {
            if (!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }
        }

        private static void CreateFile(string path) {
            if (!File.Exists(path)) {
                File.Create(path);
            }
        }

        private static void CreateUsersFile(string data) {
            string path = $"{GetCurrentDirectoryName()}\\core\\etc\\users.bin";
            if (!File.Exists(path)) {
                                       //login:password:permission
                File.WriteAllText(path, data);
            }
        }

        public static IEnumerable<string> GetUsersFile() {
            string path = $"{GetCurrentDirectoryName()}\\core\\etc\\users.bin";
            if (File.Exists(path)) {
                return File.ReadAllLines(path);
            }

            return new string[0];
        }

        public static string GetCurrentDirectoryName() {
            string? path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (path == null) {
                return string.Empty;
            }

            return path;
        }

        public static IEnumerable<string> GetFiles() {
            return Directory.EnumerateFiles(Interpreter.osPath).Select(e => e.Split("\\").Last());
        }

        public static IEnumerable<string> GetDirectories() {
            return Directory.EnumerateDirectories(Interpreter.osPath).Select(e => e.Split("\\").Last());
        }
    }
}
