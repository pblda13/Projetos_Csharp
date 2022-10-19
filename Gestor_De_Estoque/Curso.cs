using System;
using System.Collections.Generic;
using System.Text;

namespace Gestor_De_Estoque
{
    [System.Serializable]
    class Curso:Produto,IEstoque
    {
        public string autor;
        private int vagas;

        public Curso(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

        public void AdicionarEntrada()
        {

            Console.WriteLine($"Adicionar vagas no curso {nome}");
            Console.WriteLine($"Digite a Qts. de vagas que você quer dar entrada: ");
            int entrada = int.Parse(Console.ReadLine());
           vagas = vagas + entrada;
            Console.WriteLine("Entrada Registrada");
            Console.ReadLine();

        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Consumir vagas no curso {nome}");
            Console.WriteLine($"Digite a Qts. de vagas que você quer consumir: ");
            int saida = int.Parse(Console.ReadLine());
            vagas = vagas - saida;
            Console.WriteLine("Saida Registrada");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Vagas restantes: {vagas}");
            Console.WriteLine("================================");
        }
    }
}
