using DBProjectClient.Types;
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

        private static Dictionary<string, dynamic> Post(string path, Dictionary<string, dynamic>? data = null) {
            if (client.DefaultRequestHeaders.Contains("Authorization")) {
                client.DefaultRequestHeaders.Remove("Authorization");
            }
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Config.Token}");
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(path, content).Result;
            string responseText = response.Content.ReadAsStringAsync().Result;
            var responseData = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(responseText) ?? new Dictionary<string, dynamic>();
            responseData["status"] = response.StatusCode;
            return responseData;
        }
        private static Dictionary<string, dynamic> Patch(string path, Dictionary<string, dynamic>? data = null) {
            if (client.DefaultRequestHeaders.Contains("Authorization")) {
                client.DefaultRequestHeaders.Remove("Authorization");
            }
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Config.Token}");
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PatchAsync(path, content).Result;
            string responseText = response.Content.ReadAsStringAsync().Result;
            var responseData = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(responseText) ?? new Dictionary<string, dynamic>();
            responseData["status"] = response.StatusCode;
            return responseData;
        }
        private static Dictionary<string, dynamic> Delete(string path) {
            if (client.DefaultRequestHeaders.Contains("Authorization")) {
                client.DefaultRequestHeaders.Remove("Authorization");
            }
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Config.Token}");
            HttpResponseMessage response = client.DeleteAsync(path).Result;
            string responseText = response.Content.ReadAsStringAsync().Result;
            var responseData = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(responseText) ?? new Dictionary<string, dynamic>();
            responseData["status"] = response.StatusCode;
            return responseData;
        }
        private static Dictionary<string, dynamic> Get(string path) {
            if (client.DefaultRequestHeaders.Contains("Authorization")) {
                client.DefaultRequestHeaders.Remove("Authorization");
            }
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Config.Token}");
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
                Config.AccountId = response["data"].account_id;
            }
            else {
                throw new Exception((string)response["error"].message);
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
                Config.AccountId = response["data"].account_id;
            }
            else {
                throw new Exception((string)response["error"].message);
            }
        }

        public static dynamic GetAccount(int accountId) {
            var response = Get($"account/{accountId}");
            if (response["status"] == HttpStatusCode.OK) {
                return response["data"][0];
            }
            else {
                throw new Exception((string)response["error"].message);
            }
        }
        
        public static dynamic GetGameAccount(int accountId) {
            var response = Get($"account/{accountId}/game");
            if (response["status"] == HttpStatusCode.OK) {
                return response["data"][0];
            }
            else {
                throw new Exception((string)response["error"].message);
            }
        }

        public static List<MatchParticipation> GetMatchHistory(int accountId) {
            var response = Get($"account/{accountId}/game/matches");
            if (response["status"] == HttpStatusCode.OK) {
                var matches = new List<MatchParticipation>();
                foreach (var match in response["data"]) {
                    matches.Add(new MatchParticipation {
                        AccountId = (int)match.account_id,
                        AccountUsername = $"{match.name}#{match.tag}",
                        Team = match.team,
                        Time = DateTimeOffset.FromUnixTimeSeconds((long)match.time).LocalDateTime,
                        ChampionName = match.champion_name,
                        Grade = match.grade,
                        Kills = (int)match.kills,
                        Deaths = (int)match.deaths,
                        Assists = (int)match.assists,
                        CS = (int)match.cs,
                        DS = (int)match.ds,
                        Dragons = (int)match.dragons,
                        Rifts = (int)match.rifts,
                        Item1 = (int)(match.item_1.Value ?? 0),
                        Item2 = (int)(match.item_2.Value ?? 0),
                        Item3 = (int)(match.item_3.Value ?? 0),
                        Item4 = (int)(match.item_4.Value ?? 0),
                        Item5 = (int)(match.item_5.Value ?? 0),
                        Item6 = (int)(match.item_6.Value ?? 0)
                    });
                }
                return matches;
            }
            else {
                throw new Exception((string)response["error"].message);
            }
        }

        public static List<MatchParticipation> GetMatch(int accountId, DateTime time) {
            var response = Get($"account/{accountId}/game/matches/{new DateTimeOffset(time).ToUnixTimeSeconds()}");
            if (response["status"] == HttpStatusCode.OK) {
                var matches = new List<MatchParticipation>();
                foreach (var match in response["data"]) {
                    matches.Add(new MatchParticipation {
                        AccountId = (int)match.account_id,
                        AccountUsername = $"{match.name}#{match.tag}",
                        Team = match.team,
                        Time = DateTimeOffset.FromUnixTimeSeconds((long)match.time).LocalDateTime,
                        ChampionName = match.champion_name,
                        Grade = match.grade,
                        Kills = (int)match.kills,
                        Deaths = (int)match.deaths,
                        Assists = (int)match.assists,
                        CS = (int)match.cs,
                        DS = (int)match.ds,
                        Dragons = (int)match.dragons,
                        Rifts = (int)match.rifts,
                        Item1 = (int)(match.item_1.Value ?? 0),
                        Item2 = (int)(match.item_2.Value ?? 0),
                        Item3 = (int)(match.item_3.Value ?? 0),
                        Item4 = (int)(match.item_4.Value ?? 0),
                        Item5 = (int)(match.item_5.Value ?? 0),
                        Item6 = (int)(match.item_6.Value ?? 0)
                    });
                }
                return matches;
            }
            else {
                throw new Exception((string)response["error"].message);
            }
        }

        public static List<Champion> GetAllChampions() {
            var response = Get($"/game/champions");
            if (response["status"] == HttpStatusCode.OK) {
                var champions = new List<Champion>();
                foreach (var champion in response["data"]) {
                    champions.Add(new Champion {
                        Name = champion.name,
                        BlueEssencePrice = champion.blue_essence_price,
                        GameCreditPrice = champion.game_credit_price
                    });
                }
                return champions;
            }
            else {
                throw new Exception((string)response["error"].message);
            }
        }
        public static List<Champion> GetChampions(int accountId) {
            var response = Get($"account/{accountId}/game/champions");
            if (response["status"] == HttpStatusCode.OK) {
                var champions = new List<Champion>();
                foreach (var champion in response["data"]) {
                    champions.Add(new Champion {
                        Name = champion.champion_name,
                        Owned = true
                    });
                }
                return champions;
            }
            else {
                throw new Exception((string)response["error"].message);
            }
        }
        public static bool BuyChampion(int accountId, string championName) {
            var response = Post($"account/{accountId}/game/champions/{championName}");
            if (response["status"] == HttpStatusCode.OK) {
                return true;
            }
            else {
                throw new Exception((string)response["error"].message);
            }
        }

        public static List<ChampionSkin> GetAllChampionSkins(string championName) {
            var response = Get($"/game/champions/{championName}/skins");
            if (response["status"] == HttpStatusCode.OK) {
                var skins = new List<ChampionSkin>();
                foreach (var skin in response["data"]) {
                    skins.Add(new ChampionSkin {
                        Name = skin.name,
                        ChampionName = skin.champion_name,
                        OrangeEssencePrice = skin.orange_essence_price,
                        GameCreditPrice = skin.game_credit_price
                    });
                }
                return skins;
            }
            else {
                throw new Exception((string)response["error"].message);
            }
        }
        public static List<ChampionSkin> GetChampionSkins(int accountId, string championName) {
            var response = Get($"account/{accountId}/game/champions/{championName}/skins");
            if (response["status"] == HttpStatusCode.OK) {
                var skins = new List<ChampionSkin>();
                foreach (var skin in response["data"]) {
                    skins.Add(new ChampionSkin {
                        Name = skin.name,
                        ChampionName = skin.champion_name,
                        Owned = true
                    });
                }
                return skins;
            }
            else {
                throw new Exception((string)response["error"].message);
            }
        }
        public static bool BuyChampionSkin(int accountId, string championName, string skinName) {
            var response = Post($"account/{accountId}/game/champions/{championName}/skins/{skinName}");
            if (response["status"] == HttpStatusCode.OK) {
                return true;
            }
            else {
                throw new Exception((string)response["error"].message);
            }
        }

        public static List<Loot> GetAllLoots() {
            var response = Get($"game/loots");
            if (response["status"] == HttpStatusCode.OK) {
                var loots = new List<Loot>();
                foreach (var loot in response["data"]) {
                    loots.Add(new Loot {
                        Name = loot.name,
                        MythicEssencePrice = loot.mythic_essence_price,
                        GameCreditPrice = loot.game_credit_price,
                        Type = loot.type
                    });
                }
                return loots;
            }
            else {
                throw new Exception((string)response["error"].message);
            }
        }
        public static List<Loot> GetLoots(int accountId) {
            var response = Get($"account/{accountId}/game/loots");
            if (response["status"] == HttpStatusCode.OK) {
                var loots = new List<Loot>();
                foreach (var loot in response["data"]) {
                    loots.Add(new Loot {
                        Name = loot.loot_name,
                        Count = loot.count
                    });
                }
                return loots;
            }
            else {
                throw new Exception((string)response["error"].message);
            }
        }
        public static bool BuyLoot(int accountId, string lootName) {
            var data = new Dictionary<string, dynamic> {
                {"loot_name", lootName}
            };
            var response = Post($"account/{accountId}/game/loots", data);
            if (response["status"] == HttpStatusCode.OK) {
                return true;
            }
            else {
                throw new Exception((string)response["error"].message);
            }
        }

        public static List<Sticker> GetAllStickers() {
            var response = Get($"game/stickers");
            if (response["status"] == HttpStatusCode.OK) {
                var stickers = new List<Sticker>();
                foreach (var sticker in response["data"]) {
                    stickers.Add(new Sticker {
                        Name = sticker.name,
                        GameCreditPrice = sticker.game_credit_price
                    });
                }
                return stickers;
            }
            else {
                throw new Exception((string)response["error"].message);
            }
        }
        public static List<Sticker> GetStickers(int accountId) {
            var response = Get($"account/{accountId}/game/stickers");
            if (response["status"] == HttpStatusCode.OK) {
                var stickers = new List<Sticker>();
                foreach (var sticker in response["data"]) {
                    stickers.Add(new Sticker {
                        Name = sticker.sticker_name,
                        Owned = true
                    });
                }
                return stickers;
            }
            else {
                throw new Exception((string)response["error"].message);
            }
        }
        public static bool BuySticker(int accountId, string stickerName) {
            var data = new Dictionary<string, dynamic> {
                {"sticker_name", stickerName}
            };
            var response = Post($"account/{accountId}/game/stickers", data);
            if (response["status"] == HttpStatusCode.OK) {
                return true;
            }
            else {
                throw new Exception((string)response["error"].message);
            }
        }
        
        public static List<Account> GetFriends(int accountId) {
            var response = Get($"account/{accountId}/friends");
            if (response["status"] == HttpStatusCode.OK) {
                var friends = new List<Account>();
                foreach (var friend in response["data"]) {
                    friends.Add(new Account {
                        Id = friend.id,
                        Name = friend.name,
                        Tag = friend.tag,
                        Email = friend.email,
                        IsBlocked = friend.is_blocked
                    });
                }
                return friends;
            }
            else {
                throw new Exception((string)response["error"].message);
            }
        }
        public static bool AddFriend(string username) {
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic> {
                {"target_username", username},
            };
            var response = Post($"account/{Config.AccountId}/friends", data);
            if (response["status"] == HttpStatusCode.OK) {
                return true;
            }
            else {
                throw new Exception((string)response["error"].message);
            }
        }
        public static bool BlockFriend(int accountId) {
            var response = Patch($"account/{Config.AccountId}/friends/{accountId}");
            if (response["status"] == HttpStatusCode.OK) {
                return true;
            }
            else {
                throw new Exception((string)response["error"].message);
            }
        }
        public static bool DeleteFriend(int accountId) {
            var response = Delete($"account/{Config.AccountId}/friends/{accountId}");
            if (response["status"] == HttpStatusCode.OK) {
                return true;
            }
            else {
                throw new Exception((string)response["error"].message);
            }
        }
    }
}
