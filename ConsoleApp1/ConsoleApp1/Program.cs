using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {



            int i = 1;
            int n;
            int   Fat = 1;


            Console.WriteLine("Informe um numero:");
            n = int.Parse(Console.ReadLine());
            if (n > 0)
            {


                while (i <= n)
                {


                    Fat = Fat * i;
                    i++;
                }
                Console.WriteLine(Fat + "!");
            }
            else
            if( n == 0)
            {
                Console.WriteLine(Fat + "!");
            }
            else
                Console.WriteLine("fatorial não permitido");
        }
    }
}
            
