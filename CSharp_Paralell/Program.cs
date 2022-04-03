using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_Paralell
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione ENTER para iniciar");
            Console.ReadLine();

            Parallel.Invoke(
                () => ExibirDias(),
                () => ExibirMeses());

            Console.WriteLine("\nO método Main foi encerrado. Tecle Enter");
            Console.ReadLine();
        }

        static void ExibirDias()
        {
            string[] diasArray = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado"};

            foreach (var dia in diasArray)
            {
                Console.WriteLine($"Dia: {dia}");
                Thread.Sleep(1500);
            }
        }

        static void ExibirMeses()
        {
            string[] mesesArray = { "Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out",
            "Nov","Dez"};

            foreach (var mes in mesesArray)
            {
                Console.WriteLine($"Mês: {mes}");
                Thread.Sleep(1200);
            }
        }
    }
}
