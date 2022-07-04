using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Djalma_Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cidade;
            Console.WriteLine("Informe o codigo da cidade:\r\n 1 – Atibaia\r\n 2 - " +
                "Bragança Paulista \r\n 3 – Mairiporã\r\n 4 – Nazaré\r\n 5 – Terra Preta\r\n 6 – Extrema\r\n 7 – Vargem");

            cidade = Convert.ToInt32(Console.ReadLine());
            switch (cidade)
            {
                case 1:
                    Console.WriteLine("Insira a data ddmmaaaa: ");
                    break;
                case 2:
                    Console.WriteLine("Bragança Paulista");
                    break;
                case 3:
                    Console.WriteLine("Mairiporã");
                    break;
                case 4:
                    Console.WriteLine("Nazaré");
                    break;
                case 5:
                    Console.WriteLine("Terra Preta");
                    break;
                case 6:
                    Console.WriteLine("Extrema");
                    break;
                case 7:
                    Console.WriteLine("Vargem");
                    break;
            }
            Console.ReadKey();
        }
    }
}
