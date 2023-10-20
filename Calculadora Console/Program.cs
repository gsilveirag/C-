using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Calculadora Simples");
            Console.WriteLine("Selecione uma operação:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 0)
            {
                break;
            }

            double num1, num2, result;

            Console.Write("Digite o primeiro número: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"Resultado: {num1} + {num2} = {result}");
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine($"Resultado: {num1} - {num2} = {result}");
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"Resultado: {num1} * {num2} = {result}");
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Erro: Divisão por zero.");
                    }
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Resultado: {num1} / {num2} = {result}");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}