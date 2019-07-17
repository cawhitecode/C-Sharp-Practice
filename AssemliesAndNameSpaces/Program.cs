using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Chris White
namespace AssemliesAndNameSpaces
{
    public class Program
    {
        private static void connect()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }
        static void Main(string[] args)
        {
            string episodeIV = @"
            It is a period of civil war.
            Rebel spaceships, striking
            from a hidden base, have won
            their first victory against
            the evil Galactic Empire.

            During the battle, Rebel
            spies managed to steal secret
            plans to the Empire's
            ultimate weapon, the DEATH
            STAR, an armored space
            station with enough power to
            destroy an entire planet.

            Pursued by the Empire's
            sinister agents, Princess
            Leia races home aboard her
            starship, custodian of the
            stolen plans that can save
            her people and restore
            freedom to the galaxy.....";

            File.WriteAllText(@"C:\Users\Chris\Documents\Visual Studio 2015\Projects\BobTabor - 10\episodeIV.txt", episodeIV);

            WebClient client = new WebClient();
            connect();
            string scrap = client.DownloadString("https://starwars.fandom.com/wiki/Opening_crawl");

            File.WriteAllText(@"C:\Users\Chris\Documents\Visual Studio 2015\Projects\BobTabor - 10\WebScrap.txt", scrap);

            Console.WriteLine(episodeIV);
            Console.ReadLine();

        }

    }

}

