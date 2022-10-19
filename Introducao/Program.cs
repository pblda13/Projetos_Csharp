using System;
using System.Collections.Generic;
using System.Linq;

namespace Introducao
{
    class Program
    {
        static void Main(string[] args)
        {
            Variaveis();
            EntradaESaidaDeDados();
            OperadorAritmético();
            OperadorDeReferencia();
            OperadoresLogicos();
            OperadoresRelacionais();
            Condicional();
            Repeticao();
            Listas();
            Array();

        }

        static void Variaveis()
        {
            Console.WriteLine("=============== Variaveis ===================");
            Console.WriteLine();

            float fl = 1.20f;
            bool boo = false;
            double dou = 1.20;
            int num = 1;
            string nome = "Nome";
            string idade = "19";

            //Conversoes

            string a = num.ToString(); // Está convertendo um inteiro para string
            int m = Convert.ToInt32(idade); //Está convertendo uma string para inteiro

            Console.WriteLine(a);
            Console.WriteLine(m);
        }


        static void EntradaESaidaDeDados()
        {
            Console.WriteLine("=============== Entrada E Saida De Dados ===================");
            Console.WriteLine();

            Console.WriteLine("Digite seu Nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Seu nome é: " + nome);

        }
        static void OperadorAritmético()
        {
            Console.WriteLine("=============== Operador Aritmético ===================");
            Console.WriteLine();
            /*
            +	Adição
            -	Subtração
            * Multiplicação
            /	Divisão
            %	Módulo (resto da divisão)
           */

            int a = 5, b = 10, c = 15, d = 20; // declaramos quatro variáveis do tipo int
            Console.WriteLine(a + d); // operação de soma
            Console.WriteLine(c - a); // operação de subtração
            Console.WriteLine(b * c); // operação de multiplicação
            Console.WriteLine(d / b); // operação de divisão
            Console.WriteLine(c % b); // operação de módulo (resto de divisão)
            Console.WriteLine(c % b); // operação de módulo (resto de divisão)
            Console.WriteLine(c % b); // operação de módulo (resto de divisão)
        }


        static void OperadorDeReferencia()
        {
            Console.WriteLine("=============== Operador De Referencia ===================");
            Console.WriteLine();

            /* 
            + =	mais igual
            - =	menos igual
            * =	vezes igual
            / =	dividido igual
            % =	módulo igual
            */
            int x = 5;
            x += 5; // é a mesma coisa que x = x + 5
            Console.WriteLine("Valor do x = " + x);
        }

        static void OperadoresRelacionais()
        {
            Console.WriteLine("=============== Operadores Relacionais ===================");
            Console.WriteLine();

            /*
           == Igual a
           != Diferente de
           > Maior que
           < Menor que
           >= Maior do que ou igual a
           <= Menor do que ou igual a
           */
            int a = 10, b = 25, c = 50, d = 100; // declaramos quatro variáveis de tipo int

            Console.WriteLine(a == d); // avaliamos a igualdade entre a e d
            Console.WriteLine(b != c);  // avaliamos a desigualdade entre b e c
            Console.WriteLine(a > b); // avaliamos se a é maior que b
            Console.WriteLine(c < d);  // avaliamos se c é menor que d
            Console.WriteLine(c >= a); // avaliamos se c é maior ou igual que a
            Console.WriteLine(d <= b); // avaliamos se d é menor ou igual que b
        }

        static void OperadoresLogicos()
        {
            Console.WriteLine("=============== Operadores Logicos ===================");
            Console.WriteLine();

            /*     
            && AND = E
            || OR = Ou
             !   NOT = Não
            */

            int a = 5, b = 10, c = 15, d = 20; // declaramos quatro variáveis do tipo int

            Console.WriteLine(a == 5 && d == 10); // avaliamos se a é igual a 5 e se d é igual a 10
            Console.WriteLine(c < b || d == 20); // avaliamos se c é menor que b ou se d é igual a 20
            Console.WriteLine(!(b > a)); // negamos que b é maior que a
        }

        static void Condicional()
        {
            Console.WriteLine("=============== Estrutura Condicional ===================");
            Console.WriteLine();

            // Estrutura if/else

            int idade = 18;
            if (idade >= 18)
            {
                // Se a váriavel idade for maior ou igual à 18 esse trecho de código será executado
                Console.WriteLine("Você é maior de idade!");
            }
            else
            {
                // Se a váriavel idade não for maior ou igual à 18 esse trecho de código será executado
                Console.WriteLine("Você é menor de idade!");
            }


            // Estrutura switch/case

            int mes = 2;
            switch (mes)
            {
                case 1:
                    Console.WriteLine("O mês é Janeiro!");
                    break;
                case 2:
                    Console.WriteLine("O mês é Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("O mês é Março");
                    break;
                case 4:
                    Console.WriteLine("O mês é Abril");
                    break;
                case 5:
                    Console.WriteLine("O mês é Maio");
                    break;
                case 6:
                    Console.WriteLine("O mês é Junho");
                    break;
                case 7:
                    Console.WriteLine("O mês é Julho");
                    break;
                case 8:
                    Console.WriteLine("O mês é Agosto");
                    break;
                case 9:
                    Console.WriteLine("O mês é Setembro");
                    break;
                case 10:
                    Console.WriteLine("O mês é Outubro");
                    break;
                case 11:
                    Console.WriteLine("O mês é Novembro");
                    break;
                case 12:
                    Console.WriteLine("O mês é Dezembro");
                    break;
                default:
                    Console.WriteLine("Mês inválido");
                    break;
            }

            // Ternário 

            double media = 8;
            string resultado = "Olá aluno, você foi ";
            resultado += media >= 7 ? "aprovado." : "reprovado.";
            Console.WriteLine(resultado);
        }

        static void Repeticao()
        {
            Console.WriteLine("=============== Estrutura de Repetição ===================");
            Console.WriteLine();

            //Estrutura while

            int numero = -1;
            while (numero != 10)
            {
                Console.Write("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero < 10)
                {
                    Console.WriteLine("Você errou, tente um número maior.");
                }
                else if (numero > 10)
                {
                    Console.WriteLine("Você errou, tente um número menor.");
                }
                else
                {
                    Console.WriteLine("Parabéns, você acertou!");
                }
            }

            //  Estrutura do/while

            int contador = 15;
            do
            {
                Console.WriteLine("O contador vale: " + contador);
                contador++;
            } while (contador <= 10);

            // Estrutura for

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("A variável i agora vale " + i);
            }
            //Estrutura foreach


            string[] alunos = new string[4] { "Cleyson", "Anna", "Autobele", "Hayssa" };
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(alunos[i]);
            }

        }

        static void Listas()
        {
            Console.WriteLine("=============== Listas ===================");
            Console.WriteLine();

            List<double> lista = new List<double> { 1, 2, 3, 4 };
            double maiorValor = lista.Max();

            Console.WriteLine(maiorValor);
        }

        static void Array()
        {
            Console.WriteLine("=============== Array/Vetor ===================");
            Console.WriteLine();

            string[] b = new string[3];
            b[0] = "Pamela";
            b[1] = "Borges";
            b[2] = "Lira";


            foreach (string nome in b)
            {
                Console.WriteLine(nome);
            }
        }

    }
}
    
