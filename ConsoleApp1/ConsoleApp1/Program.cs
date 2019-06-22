using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var list = new List<string>();
            while (list.Count < 5) {
                list.Add(Console.ReadLine());
            }

            var i = 0;
            while (i < list.Count) {
                Console.WriteLine(list[i]);
                i++;
            }
            Console.ReadLine();
            
        }
    }
}
