using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public class Usuario
    {
       

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Usuario()
        {
        }

        public Usuario(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }
        // Exemplo de polimorfismo de sobreposição
        public virtual void Exibir()
        {
            Console.WriteLine($"Nome {Nome}");
            Console.WriteLine($"Email {Email}");
            Console.WriteLine($"Nome {Nome}");
        }

        public void Logar()
        {
            Console.WriteLine("Logando........");
        }
    }

    public class Aluno : Usuario
    {
        public List<string> Turmas = new List<string>();
        public string Turno = "Matutino";

        public Aluno()
        {
        }

        public Aluno(string nome, string email, string senha, List<string> turmas, string turno) : base(nome, email, senha)
        {
            Turmas = turmas;
            Turno = turno;
        }

        // Polimorfirmo de sobreposicão da classe PAI
        public override void Exibir()
        {
            base.Exibir();
            Console.WriteLine($"TURNO: {Turno}");
        }
    }

    
}
