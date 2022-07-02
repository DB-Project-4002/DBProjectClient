using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DBProjectClient.Util {
    public static class Server {
        private static HttpClient client = new HttpClient();
        public static void Initialize() {
            client.BaseAddress = new Uri($"http://{Config.Server}:8080/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private static Dictionary<string, dynamic> Post(string path, Dictionary<string, dynamic> data) {
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(path, content).Result;
            string responseText = response.Content.ReadAsStringAsync().Result;
            var responseData = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(responseText) ?? new Dictionary<string, dynamic>();
            responseData["status"] = response.StatusCode;
            return responseData;
        }
        private static Dictionary<string, dynamic> Get(string path) {
            HttpResponseMessage response = client.GetAsync(path).Result;
            string responseText = response.Content.ReadAsStringAsync().Result;
            var responseData = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(responseText) ?? new Dictionary<string, dynamic>();
            responseData["status"] = response.StatusCode;
            return responseData;
        }

        public static void Login(string username, string password) {
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic> {
                {"username", username},
                {"password", password},
            };
            var response = Post($"account/login", data);
            if (response["status"] == HttpStatusCode.Created) {
                Config.Token = response["data"].token;
                //Config.AccountId = response["data"].account_id;
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Config.Token}");
            }
            else {
                throw new Exception(response["error"].message);
            }
        }
        public static void Register(string email, string username, string password) {
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic> {
                {"email", email},
                {"name", username.Split("#")[0]},
                {"tag", username.Split("#")[1]},
                {"password", password},
            };
            var response = Post($"account", data);
            if (response["status"] == HttpStatusCode.Created) {
                Config.Token = response["data"].token;
                //Config.AccountId = response["data"].account_id;
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Config.Token}");
            }
            else {
                throw new Exception(response["error"].message);
            }
        }
        public static dynamic GetGameAccount(int accountId) {
            var response = Get($"account/{accountId}/game");
            if (response["status"] == HttpStatusCode.OK) {
                return response["data"][0];
            }
            else {
                throw new Exception(response["error"].message);
            }
        }
        public static dynamic GetFriends(int accountId) {
            var response = Get($"account/{accountId}/friends");
            if (response["status"] == HttpStatusCode.OK) {
                return response["data"];
            }
            else {
                throw new Exception(response["error"].message);
            }
        }
    }
}
