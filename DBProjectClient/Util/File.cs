using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProjectClient.Util {
    class File {
        public static string Read(string path) {
            string data = "";
            try {
                data = System.IO.File.ReadAllText(path);
            }
            catch { }
            return data;
        }
        public static void Write(string path, string data) {
            try {
                System.IO.File.WriteAllText(path, data);
            }
            catch { }
        }
    }
}
