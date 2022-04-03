using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione ENTER para iniciar");
            Console.ReadLine();

            ProcessarLaco();
            Console.WriteLine("\n\n");

            Parallel.For(0, 11, i => Console.WriteLine($"{i} \t"));

            Console.WriteLine("\nO método Main foi encerrado. Tecle Enter");
            Console.ReadLine();
        }

        static void ProcessarLaco()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{i} Thread : = {Thread.CurrentThread.ManagedThreadId} \t");

                Thread.Sleep(500);
            }
        }
    }
}
