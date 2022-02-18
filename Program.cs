using System;

namespace AppDivisivel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = 2520;
            int menor = 2520;

            for (int i = 1; i <= 20; i++)
            {
                if (num % i == 0 && menor > i)
                    menor = i;                                
            }

            Console.WriteLine("O menor numero: " + menor);
            Console.WriteLine("Pressione ENTER para sair...");
            Console.Read();
        }
    }
}
