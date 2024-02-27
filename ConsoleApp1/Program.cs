using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            Console.WriteLine("Сколько раз написать репка?");
            string a = Console.ReadLine();
            int.TryParse(a, out b);
            for(int i=0;i<b;i++)
                Console.WriteLine("репка");
        }
    }
        
    
}