using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Gestor_De_Estoque
{
    enum Menu { Listar = 1, Adicionar = 2, Remover = 3, Entrada = 4, Saida = 5, Sair = 6 }
    class Program
    {
        static List<IEstoque> produtos = new List<IEstoque>();
        static void Main(string[] args)
        {
            Carregar();
            bool escolherSair = false;
            while (escolherSair == false)
            {
                Console.WriteLine("Sistema de Estoque");
                Console.WriteLine("1-Listar\n2-Adicionar\n3-Remover\n4-Registrar Entrada\n5-Registrar Saida\n6-Sair");
                int intOp = int.Parse(Console.ReadLine());

                if (intOp > 0 && intOp < 7)
                {
                    Menu opcao = (Menu)intOp;
                    switch (opcao)
                    {
                        case Menu.Listar:
                            Listagem();
                            break;
                        case Menu.Adicionar:
                            Cadastro();
                            break;
                        case Menu.Remover:
                            Remover();
                            break;
                        case Menu.Entrada:
                            Entrada();
                            break;
                        case Menu.Saida:
                            Saida();
                            break;
                        case Menu.Sair:
                            escolherSair = true;
                            break;                     
                    }
                }
                else
                {
                    escolherSair = true;
                }
                Console.Clear();
            }

            static void Listagem()
            {
                Console.WriteLine("Listar Produtos");
                int i = 0;

                foreach (IEstoque produto in produtos)
                {
                    Console.WriteLine("ID:"+i);
                    produto.Exibir();
                    i++;
                }
                Console.ReadLine();
            }
            static void Entrada()
            {
                Listagem();
                Console.WriteLine("Digite o ID do elemento que você quer dar entrada: ");
                int id = int.Parse(Console.ReadLine());
                if (id >= 0 && id < produtos.Count)
                {
                    produtos[id].AdicionarEntrada();
                    Salvar();
                }
            }
            static void Saida()
            {
                Listagem();
                Console.WriteLine("Digite o ID do elemento que você quer dar baixa: ");
                int id = int.Parse(Console.ReadLine());
                if (id >= 0 && id < produtos.Count)
                {
                    produtos[id].AdicionarEntrada();
                    Salvar();
                }

            }
            static void Remover()
            {
                Listagem();
                Console.WriteLine("Digite o ID do elemento que você quer remover: ");
                int id = int.Parse(Console.ReadLine());
                if (id >= 0 && id < produtos.Count)
                {
                    produtos.RemoveAt(id);
                    Salvar();
                }

            }

            static void Cadastro()
            {
                Console.WriteLine("Cadastro de Produtos");
                Console.WriteLine("1-Produto Fisico\n2-Ebook\n3-Curso");
                int opStr = int.Parse(Console.ReadLine());

                switch (opStr)
                {
                    case 1:
                        CadastrarPFisico();
                        break;
                    case 2:
                        CadastrarEbook();
                        break;
                    case 3:
                        CadastrarCurso();
                        break;                  
                }


            }

            static void CadastrarPFisico()
            {
                Console.WriteLine("Cadastrando produto fisico: ");
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Preço: ");
                float preco = float.Parse(Console.ReadLine());
                Console.WriteLine("Frete: ");
                float frete = float.Parse(Console.ReadLine());
                ProdutoFisico pf = new ProdutoFisico(nome, preco, frete);
                produtos.Add(pf);
                Salvar();
            }

            static void CadastrarEbook()
            {
                Console.WriteLine("Cadastrando Ebook: ");
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Preço: ");
                float preco = float.Parse(Console.ReadLine());
                Console.WriteLine("Autor: ");
                string autor = Console.ReadLine();
                Ebook eb = new Ebook(nome, preco, autor);
                produtos.Add(eb);
                Salvar();
            }

            static void CadastrarCurso()
            {
                Console.WriteLine("Cadastrando Curso: ");
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Preço: ");
                float preco = float.Parse(Console.ReadLine());
                Console.WriteLine("Autor: ");
                string autor = Console.ReadLine();
                Curso cs = new Curso(nome, preco, autor);
                produtos.Add(cs);
                Salvar();
            }

            static void Salvar()
            {
                FileStream stream = new FileStream("produtos.dat", FileMode.OpenOrCreate);
                BinaryFormatter encoder = new BinaryFormatter();

                encoder.Serialize(stream, produtos);
                stream.Close(); 
            }
            static void Carregar()
            {
                FileStream stream = new FileStream("produtos.dat", FileMode.OpenOrCreate);
                BinaryFormatter encoder = new BinaryFormatter();
                try
                {
                    produtos = (List<IEstoque>)encoder.Deserialize(stream);

                    if(produtos == null)
                    {
                        produtos = new List<IEstoque>();
                    }
                }
                catch (Exception e)
                {

                    produtos = new List<IEstoque>();
                }
                              
                stream.Close();
            }
        }
    }
}
