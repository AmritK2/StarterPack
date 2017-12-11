using System;
using Newtonsoft.Json.Linq;

namespace StarterPack
{
    public class Program
    {
        private string json;

        public Program(string json)
        {
            JObject jObject = JObject.Parse(json);
            JToken jUser = jObject["username"];
            Name = (string)jUser["name"];
            Honor = (string)jUser["Honor"];
            Clan = (string)jUser["Clan"];
            LeaderboardPosition = (string)jUser["LeaderboardPosition"];
        }
        
        public string Name { get; set; }
        public string Honor { get; set; }
        public string Clan { get; set; }
        public string LeaderboardPosition { get; set; }

        private void GetInfo()
        {
            string json= "https://www.codewars.com/api/v1/users/Amrit2";
            Program user = new Program(json);

            Console.WriteLine("Name: " + user.Name);
            Console.WriteLine("Honor: " + user.Honor);
            Console.WriteLine("Clan: " + user.Clan);
            Console.WriteLine("Leader Board Position: " + user.LeaderboardPosition);
        }
        static void Main(string[] args)
        {
        }
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

        WebRequest request = WebRequest.Create("https://www.codewars.com/api/v1/users/Amrit2");
        WebResponse response = request.GetResponse(); 
        Console.WriteLine (((HttpWebResponse)response).StatusDescription);    
        Stream dataStream = response.GetResponseStream ();    
        StreamReader reader = new StreamReader (dataStream);  
        string responseFromServer = reader.ReadToEnd ();  
        Console.WriteLine(responseFromServer);  
        reader.Close();  
        response.Close();  
*/      