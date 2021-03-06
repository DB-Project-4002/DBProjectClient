using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProjectClient.Util {
    public class Config {
        private static Config config = new Config();

        [JsonProperty]
        private string server = "";
        [JsonProperty]
        private string token = "";
        [JsonProperty]
        private int accountId;

        public static void Save() {
            File.Write("config.json", JsonConvert.SerializeObject(config, Formatting.Indented));
        }
        public static void Load() {
            config = JsonConvert.DeserializeObject<Config>(File.Read("config.json")) ?? new Config();
            Save();
        }

        public static string Server => config.server;
        public static string Token {
            get => config.token;
            set {
                config.token = value;
                Save();
            }
        }
        public static int AccountId {
            get => config.accountId;
            set {
                config.accountId = value;
                Save();
            }
        }
    }
}
