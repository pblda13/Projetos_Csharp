﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Gestor_De_Estoque
{[System.Serializable]
    class ProdutoFisico : Produto,IEstoque
    {
        public float frete;
        private int  estoque;

        public ProdutoFisico (string nome,float preco,float frete) 
        {
            this.nome = nome;
            this.preco = preco;
            this.frete = frete;
           
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine($"Adicionar entrada no estoque de produto {nome}");
            Console.WriteLine($"Digite a Qts. que você quer dar entrada: ");
            int entrada = int.Parse(Console.ReadLine());
            estoque = estoque + entrada;
            Console.WriteLine("Entrada Registrada");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar saida no estoque de produto {nome}");
            Console.WriteLine($"Digite a Qts. que você quer dar baixa: ");
            int saida = int.Parse(Console.ReadLine());
            estoque = estoque - saida;
            Console.WriteLine("Saida Registrada");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Frete: {frete}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Estoque: {estoque}");
            Console.WriteLine("================================");
        }
    }
    
}
