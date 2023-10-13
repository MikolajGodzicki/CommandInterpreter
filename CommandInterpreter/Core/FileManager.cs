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
            CreateUsersFile("Root:root:123:1");
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
                                       //name:login:password:permission
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
                return String.Empty;
            }

            return path;
        }
    }
}
