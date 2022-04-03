using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frutas = new() { 
                "Maça", "Banana", "Abacaxi", "Melância", "Pêra", "Uva", "Figo", "Pêssego", "Laranja",
                "Kiwi", "Manga", "Melão", "Morango"
            };

            Console.WriteLine("Pressione ENTER para iniciar");
            Console.ReadLine();

            Console.WriteLine("Exibindo a lista usando laço foreach \n");
            foreach (var fruta in frutas)
            {
                Console.WriteLine($"Fruta : {fruta}, Thread Id = {Thread.CurrentThread.ManagedThreadId} \t");
            }

            Console.WriteLine("\n\nExibindo a lista usando Parallel.ForEach");
            Parallel.ForEach(frutas, fruta => {
                Console.WriteLine($"Fruta : {fruta}, Thread Id = {Thread.CurrentThread.ManagedThreadId} \t");
            });

            Console.WriteLine("\nO método Main foi encerrado. Tecle Enter");
            Console.ReadLine();
        }
    }
}
