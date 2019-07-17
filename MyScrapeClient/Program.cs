using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCodeLibary;

//Chris White
namespace MyScrapeClient
{
    public class Program
    {
       static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();
            string value =myScrape.ScrapeWebpage("http://msdn.microsoft.com");
            Console.WriteLine(value);
            Console.ReadLine();
        }

    }

}

