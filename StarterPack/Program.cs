using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace StarterPack
{
    public class Program
    {
        static void Main(string[] args)
        {
            GetRequest("https://www.codewars.com/api/v1/users/Amrit2");
        }

        static async void GetRequest(string url)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            HttpContent content = response.Content;
            string info = await content.ReadAsStringAsync();
            Console.WriteLine(info);
        }
        /*
        public static async Task<string> GetUserInfo(string url)
        {
            var client = new HttpClient();
            string info =  await client.GetStringAsync(url);
            return info;
        }

        static void Main(string[] args)
        {
            var response = GetUserInfo("https://www.codewars.com/api/v1/users/Amrit2");
            Console.WriteLine(response);
        }
        */
    }
}





/*
        string url = "https://www.codewars.com/api/v1/users/Amrit2";
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse response = (HttpWebRequest)request.GetResponse();
        private Stream reStream = response.GetResponseStream();

        static HttpClient client = new HttpClient();
        static async Task<HttpResponseMessage> GetAsync(string path)
        {
           
            HttpResponseMessage response = await client.GetAsync("https://www.codewars.com/api/v1/users/Amrit2");
            if (response.IsSuccessStatusCode)
            {
                
            }
            
        }
        public Program(string json)
        {
            JObject jObject = JObject.Parse(json);
            JToken jUser = jObject["username"];
            Name = (string)jUser["name"];
            Honor = (string)jUser["honor"];
            Clan = (string)jUser["clan"];
            LeaderboardPosition = (string)jUser["leaderboardPosition"];
        }

    private void GetInfo()
        {
            const string url = "https://www.codewars.com/api/v1/users/Amrit2";
            var user = new Program(url);

            Console.WriteLine("Name: " + user.Name);
            Console.WriteLine("Honor: " + user.Honor);
            Console.WriteLine("Clan: " + user.Clan);
            Console.WriteLine("Leader Board Position: " + user.LeaderboardPosition);
        }

    public string Name { get; set; }
        public string Honor { get; set; }
        public string Clan { get; set; }
        public string LeaderboardPosition { get; set; }

        
*/
