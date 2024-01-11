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
            // Solicitando ao usuário que insira o primeiro valor
            Console.Write("Insira o primeiro valor: ");
            // Lendo a entrada do usuário e armazenando-a na variável valor1
            string valor1 = Console.ReadLine();

            // Solicitando ao usuário que insira o segundo valor
            Console.Write("Insira o segundo valor: ");
            // Lendo a entrada do usuário e armazenando-a na variável valor2
            string valor2 = Console.ReadLine();

            // Solicitando ao usuário que insira um operador
            Console.Write("Insira um operador (+, -, *, /): ");
            // Lendo a entrada do usuário e armazenando-a na variável operador
            string operador = Console.ReadLine();

            // Inicializando a variável resultado como 0
            decimal resultado = 0;

            // Verificando qual operador foi inserido e realizando a operação correspondente
            if (operador == "+")
            {
                // Se o operador for +, somamos os valores
                resultado = Convert.ToInt16(valor1) + Convert.ToInt16(valor2);
            }
            else if (operador == "-")
            {
                // Se o operador for -, subtraímos os valores
                resultado = Convert.ToInt16(valor1) - Convert.ToInt16(valor2);
            }
            else if (operador == "*")
            {
                // Se o operador for *, multiplicamos os valores
                resultado = Convert.ToInt16(valor1) * Convert.ToInt16(valor2);
            }
            else if (operador == "/")
            {
                // Se o operador for /, dividimos os valores
                // Mas primeiro verificamos se o divisor é 0 para evitar uma exceção de divisão por zero
                if (Convert.ToInt16(valor2) == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Operação invalida!");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    resultado = Convert.ToDecimal(valor1) / Convert.ToDecimal(valor2);
                }
            }
            else
            {
                // Se o operador não for nenhum dos acima, informamos ao usuário que a operação é inválida
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Operador inválido!");
                Console.ReadKey();
                return;
                
            }

            // Imprimindo o resultado no console
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Resultado é: " + resultado);

            // Aguardando uma tecla ser pressionada para encerrar o programa
            Console.ReadKey();
        }
    }
}
