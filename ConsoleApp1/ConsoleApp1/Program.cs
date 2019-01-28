using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int t = 0; t < T; t++)
            {
                string line = Console.ReadLine();
                if(line == "Easy Problem")
                {
                    Console.WriteLine(20);
                }
                else if (line == "Medium Problem")
                {
                    Console.WriteLine(40);
                }
                else if (line == "Hard Problem")
                {
                    Console.WriteLine(68);
                }
            }
        }
    }
}
