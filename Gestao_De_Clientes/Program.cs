using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Gestao_De_Clientes
{
    class Program
    {
        [System.Serializable]
        struct Cliente
        {
            public string nome;
            public string email;
            public string cpf;
        }
        static List<Cliente> clientes = new List<Cliente>();
        enum Menu { Listagem = 1, Adicionar = 2, remover = 3, sair = 4 }
        static void Main(string[] args)
        {
            Carregar();
            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Sistemas de clientes - Bem vindo");
                Console.WriteLine("1- Listagem\n2-Adicionar\n3-Remover\n4-Sair");
                int intOp = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)intOp;

                switch (opcao)
                {
                    case Menu.Listagem:
                        Listagem();
                        break;
                    case Menu.Adicionar:
                        Adicionar();
                        break;
                    case Menu.remover:
                        Remover();
                        break;
                    case Menu.sair:
                        escolheuSair = true;
                        break;
                    default:
                        break;
                }
                //Console.Clear();
            }
        }

        static void Adicionar()
        {
            Cliente cliente = new Cliente();
            Console.WriteLine("Cadastro de cliente");
            Console.WriteLine("Nome do cliente");
            cliente.nome = Console.ReadLine();
            Console.WriteLine("Email do cliente");
            cliente.email = Console.ReadLine();
            Console.WriteLine("CPF do cliente");
            cliente.cpf = Console.ReadLine();
            clientes.Add(cliente);
            Salvar();
            Console.WriteLine("Cadastro concluido,aperte ENTER para SAIR.");
            Console.ReadLine();

        }
        static void Listagem()
        {
            var i = 0;
            if (clientes.Count > 0)
            {
                Console.WriteLine("Lista de clientes");
                foreach (var item in clientes)

                {
                    Console.WriteLine($"ID: {i+1}");
                    Console.WriteLine($"Nome: {item.nome}");
                    Console.WriteLine($"E-mail: {item.email}");
                    Console.WriteLine($"CPF: {item.cpf}");
                    Console.WriteLine("==========================");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Não tem cliente cadastrado");
            }

        }
        static void Remover()
        {
            Listagem();
            Console.WriteLine("Digite o ID que será removido");
            int id = int.Parse(Console.ReadLine());
            clientes.RemoveAt(id);
            Salvar();

        }
        static void Salvar()
        {
            FileStream stream = new FileStream("clients.dat", FileMode.OpenOrCreate);
            BinaryFormatter enconder = new BinaryFormatter();
            enconder.Serialize(stream, clientes);
            stream.Close();
        }

        static void Carregar()
        {
            FileStream stream = new FileStream("clients.dat", FileMode.OpenOrCreate);
            try
            {
               
                BinaryFormatter enconder = new BinaryFormatter();
                clientes = (List<Cliente>)enconder.Deserialize(stream);
                if (clientes == null)
                {
                    clientes = new List<Cliente>();
                }
               
            }
            catch (Exception)
            {

                clientes = new List<Cliente>();
            }

            stream.Close();
        }
    }
}
