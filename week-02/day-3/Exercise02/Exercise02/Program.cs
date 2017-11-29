using System;

namespace UrlFixer
{
    public class UrlFixer
    {
        public static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";
            {

                string method1 = url.Replace("bots", "odds").Replace("s/", "s:/");
                Console.WriteLine(method1);
            }

            {
                string method2 = url.Replace("bots", "odds").Insert(5, ":");
                Console.WriteLine(method2);
            }

            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crutial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!



            Console.ReadLine();
        }
    }
}