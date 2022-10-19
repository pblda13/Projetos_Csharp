using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    class Filme
    {
        public string Nome;
        public string Desc;
        public int Ano;
        public string Studio;
        public List<string> Atores = new List<string>();

        public Filme()
        {
        }

        public Filme(string nome, string desc, int ano, string studio)
        {
            Nome = nome;
            Desc = desc;
            Ano = ano;
            Studio = studio;
        }

        public void Executar()
        {
            Console.WriteLine($"Rodando filme {Nome}");
        }

        public void Pausar()
        {
            Console.WriteLine($"Filme {Nome} pausado ");
        }
    }
}
