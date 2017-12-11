using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace StarterPack
{
    class Program
    {
        static HttpClient client = new HttpClient();

        
        WebRequest request = WebRequest.Create("https://www.codewars.com/api/v1/users/:id_or_username");
        WebResponse response = request.GetResponse(); 
        Console.WriteLine (((HttpWebResponse)response).StatusDescription);  
        
        static void Main(string[] args)
        {
        }
    }
}
