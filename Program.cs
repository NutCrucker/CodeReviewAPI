using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using xNet;

namespace APIi
{
    class Program
    {
        static void Main(string[] args)
        {
            string token = "182063335.b5eb30d.ddb513f277fc430d9f939b6a9ff0bd64";
            string Continue = "Y";
            while (Continue == "Y"){
                GetRequest(token);
                Console.WriteLine("Would you like to continue? [Y/N]");
                Continue = Console.ReadLine();
            } 
        }
       
        public static void GetRequest(string Token)
        {
                string url = "https://api.instagram.com/v1/users/self/?access_token="+Token;
                var request = new HttpRequest();
                request.UserAgent = Http.ChromeUserAgent();
                HttpResponse response = request.Get(string.Format(url));
                string incomingJson = response.ToString().Remove(0, 9);
                incomingJson = incomingJson.Remove(incomingJson.Length - 24, 24);
                incomingJson = "[" + incomingJson + "]";
                File.WriteAllText("C:\\Users\\Tomer\\Desktop\\User.txt", incomingJson);
                StreamReader r = new StreamReader("C:\\Users\\Tomer\\Desktop\\User.txt");
                string json = r.ReadToEnd();
                List<User> items = JsonConvert.DeserializeObject<List<User>>(json);
                Console.WriteLine("What information would you like to get about {0}?[Fullname/Bio/Website/Media/Following/Followers]", items[0].Username);
                string Info = Console.ReadLine();
                getInfo(items[0], Info);
                r.Close();
        }
        public static void getInfo(User user, string info)
        {
            info = ReturnValidOption(user, info);
            switch (info)
            {
                case "Fullname":
                    Console.WriteLine(user.Fullname);
                    break;
                case "Bio":
                    Console.WriteLine(user.Bio);
                    break;
                case "Website":
                    Console.WriteLine(user.Website);
                    break;
                case "Media":
                    Console.WriteLine(user.Counts.Media);
                    break;
                case "Following":
                    Console.WriteLine(user.Counts.Follows);
                    break;
                case "Followers":
                    Console.WriteLine(user.Counts.FollowedBy);
                    break;
            }
        }
        public static string ReturnValidOption(User user, string info)
        {
            String[] Options = { "Fullname", "Bio", "Website", "Media", "Following", "Followers" };
            while (!Options.Contains(info))
            {
                Console.WriteLine("Invalid option! What information would you like to get about {0}?[Fullname/Bio/Website/Media/Following/Followers]", user.Username);
                info = Console.ReadLine();
            }
            return info;
        }
    }
}
