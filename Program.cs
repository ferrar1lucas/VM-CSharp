using System.Xml.XPath;

namespace Calculadora;

public class Program
{
    public static void Main()
    {
        bool varcontinue = true;

        while (varcontinue)
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("Digite o primeiro numero: ");
            double num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            double num2 = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            Console.WriteLine("Operações");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");

            Console.WriteLine("Digite a operação desejada:");
            int operation = Convert.ToInt32(Console.ReadLine());

            if(operation == 1)
            {
                result = num1 + num2;
            }
            else if(operation == 2)
            {
                result = num1 - num2;
            }
            else if( operation == 3)
            {
                result = num1 * num2;
            }
            else if(operation == 4)
            {
                if(num2 == 0)
                {
                    Console.WriteLine("Erro");
                }
                else
                {
                    result = num1 / num2;
                }
            }
            else
            {
                Console.WriteLine("Operação inválida");
            }

            Console.WriteLine("Resultado: " + result);

            Console.WriteLine("Deseja continuar? (s/n)");
            string response = Console.ReadLine();

            if (response != "s")
            {
                varcontinue = false;
            }
        }
        Console.WriteLine("Obrigado");
    }
}