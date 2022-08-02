using System;

namespace projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroChamada = 0;
            string nomeAluno = "Christian Perin";

            numeroChamada = 1;

            Console.WriteLine(numeroChamada);
            Console.WriteLine(nomeAluno);

            Console.WriteLine(args[0].ToString());
            Console.WriteLine(args[1].ToString());
            Console.WriteLine(args[2].ToString());
            Console.WriteLine(args[3].ToString());

            Console.WriteLine("Hello World!");
        }
    } 
}
