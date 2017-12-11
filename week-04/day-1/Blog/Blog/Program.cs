using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            var LoremIpsum = new BlogPost();

            LoremIpsum.AuthorName = "John Doe";
            LoremIpsum.Title = "Lorem Ipsum";
            LoremIpsum.Text = "Lorem ipsum dolor sit amet.";
            LoremIpsum.PublicationDate = "2000.05.04";

        }
    }
}
