using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Chris White
namespace UnderstandArrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

            string[] names = new string[] { "Eddie", "Alex", "Micheal", "David Lee" };
            /*
            for (int i = 0; i < names.length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
            */
            /*
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */
            string zig = "You can get waht you want out of life" +
                "if you help enough other people get waht they want.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();
          
        }
            
    }
}
