using System;

namespace Calculadora
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao = 2, Divisao = 3, Multiplicacao = 4, Potencia = 5, Raiz = 6, Sair = 7 }
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Seja bem vindo ao CALC,selecione uma das opções");
                Console.WriteLine();
                Console.WriteLine("1-Soma\n2-Subrtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                    default:
                        break;
                }

               

                
            }
            Console.Clear();
        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte entre para voltar ao MENU");
        }
        static void Subtracao()
        {
            Console.WriteLine("Subtração de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte entre para voltar ao MENU");
        } 
        static void Divisao()
        {
            Console.WriteLine("Divisão de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = Convert.ToInt32(Console.ReadLine());
            double resultado = a / b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte entre para voltar ao MENU");
        }
        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = Convert.ToInt32(Console.ReadLine());
            double resultado = a * b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte entre para voltar ao MENU");
        }
        static void Potencia()
        {
            Console.WriteLine("Potencia de um numero: ");
            Console.WriteLine("Digite a base: ");
            int baseNun = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expo = Convert.ToInt32(Console.ReadLine());
            double resultado = Math.Pow(baseNun, expo);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte entre para voltar ao MENU");
        }
        static void Raiz()
        {
            Console.WriteLine("Raiz de um numero: ");
            Console.WriteLine("Digite o  numero: ");
            int a = Convert.ToInt32(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte entre para voltar ao MENU");
        }
    }
}
