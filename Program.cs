using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meu_primeiro_progama_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o primeiro valor: ");
            string valor1 = Console.ReadLine();

            Console.Write("Insira o segundo valor: ");
            string valor2 = Console.ReadLine();

            Console.Write("Insira um operador (+, -, *, /): ");
            string operador = Console.ReadLine();

            decimal resultado = 0;
            if (operador == "+")
            {
                resultado = Convert.ToInt16(valor1) + Convert.ToInt16(valor2);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Resultado é: " + resultado);
            }
            else if (operador == "-")
            {
                resultado = Convert.ToInt16(valor1) - Convert.ToInt16(valor2);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Resultado é: " + resultado);
            }
            else if (operador == "*")
            {
                resultado = Convert.ToInt16(valor1) * Convert.ToInt16(valor2);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Resultado é: " + resultado);
            }
            else if (operador == "/")
            {
                if (Convert.ToInt16(valor2) == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Operação invalida!");
                }
                else
                {
                    resultado = Convert.ToDecimal(valor1) / Convert.ToDecimal(valor2);

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Resultado é: " + resultado);
                }
            }
               
            Console.ReadKey();
        }
    }
}
