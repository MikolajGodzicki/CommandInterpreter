using CommandInterpreter.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter.UserCore {
    internal class UsersData {
        private static UsersData instance;
        public static UsersData Instance { 
            get {
                if (instance == null) {
                    instance = new UsersData();
                }
                return instance; 
            } 
        }

        public List<User> Users { get; set; } = new List<User>();

        public UsersData() {
            Check();
        }

        private void Check() {
            string[] data = FileManager.GetUsersFile().ToArray();
            foreach (string user in data) {
                Users.Add(new User(user));
            }
        }
    }
}
