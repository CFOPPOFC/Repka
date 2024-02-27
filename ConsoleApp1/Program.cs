using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            int B;
            Console.WriteLine("Выбери режим\n1.выборочный\n2.бесконечный");
            string A = Console.ReadLine();
            int.TryParse(A, out B);
            if(B==1)
            {
                Console.WriteLine("Сколько раз написать репка?");
                string a = Console.ReadLine();
                int.TryParse(a, out b);
                for (int i = 0; i < b; i++)
                    Console.WriteLine("репка");
            }
            if(B==2)
            {
                while(true)
                {
                    Console.WriteLine("Репка");
                }
            }
            
        }
    }
        
    
}