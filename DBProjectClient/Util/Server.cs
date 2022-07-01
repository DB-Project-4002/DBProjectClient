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
            client.BaseAddress = new Uri($"http://{Config.Server}:80/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private static Dictionary<string, dynamic> Request(string path, Dictionary<string, dynamic> data) {
            var content = new StringContent(JsonConvert.SerializeObject(data));
            HttpResponseMessage response = client.PostAsync(path, content).Result;
            //response.EnsureSuccessStatusCode();
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
            var response = Request($"account/login", data);
            if (response["status"] == HttpStatusCode.OK) {
                Config.Token = response["data"].token;
            }
            else {
                throw new Exception(response["error"].message);
            }
        }
        public static void Register(string email, string username, string password) {
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic> {
                {"email", email},
                {"username", username},
                {"password", password},
            };
            var response = Request($"account", data);
            if (response["status"] == HttpStatusCode.OK) {
                Config.Token = response["data"].token;
            }
            else {
                throw new Exception(response["error"].message);
            }
        }
    }
}
