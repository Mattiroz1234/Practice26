using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Practice26
{
    internal class Program
    {
    }
    public class Post
    {
        public int userId;
        public int id;
        public string title;
        public string body;

        public static int GetID()
        {
            Console.WriteLine("enter number");
            int id = int.Parse(Console.ReadLine());
            if (id > 0 && id < 101)
            {
                return id;
            }
            else
            {
                return 0;
            }
        }

        public static async Task PrintPost()
        {
            //q1
            //string url = "https://jsonplaceholder.typicode.com/posts";
            //var client = new HttpClient();
            //var json = await client.GetStringAsync(url);
            //var posts = JsonConvert.DeserializeObject<List<Post>>(json);

            //for (int i = 0; i < 5; i++)
            //    Console.WriteLine($"{i + 1}. {posts[i].title}");

            //q2
            int num = GetID();
            if (num == 0)
            {
                Console.WriteLine("wrong number");
                return;
            }

            string url = $"https://jsonplaceholder.typicode.com/posts/{num}";
            var client = new HttpClient();
            var json = await client.GetStringAsync(url);
            var post = JsonConvert.DeserializeObject<Post>(json);

            Console.WriteLine(post.body);

            

        }
         
        static async Task Main()
         {
            await PrintPost();
        }

    }
}
