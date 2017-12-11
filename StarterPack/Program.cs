using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.IO;
using Newtonsoft.json.Linq.Jobject;

namespace StarterPack
{
    public class Program
    {
        public void User(string json)
        {
            JObject jObject = JObject.Parse(json);
            Jtoken jUser = jObject["username"];
            name = (string) jUser["name"];
            honor = (string) jUser["honor"];
            clan = (string) jUser["clan"];
            leaderboardPosition = (string) jUser["leaderboardPosition"];
        }

        public string name { get; set; }
        public string honor { get; set; }
        public string clan { get; set; }
        public string leaderboardPosition { get; set; }

        private void GetInfo()
        {
            string json= "https://www.codewars.com/api/v1/users/Amrit2";
            Program user = new Program(json);

            Console.WriteLine("Name: " + user.name);
            Console.WriteLine("Honor: " + user.honor);
            Console.WriteLine("Clan: " + user.clan);
            Console.WriteLine("Leader Board Position: " + user.leaderboardPosition);
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