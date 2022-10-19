using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {

            //Sem construtores
            Filme filme = new Filme();
            filme.Nome = "Sei lá";
            filme.Executar();

            Filme filme2 = new Filme();
            filme2.Nome = "Está dando onda";
            filme2.Executar();

            // Com construtores
            Filme filme3 = new Filme("It", "jjjjjjjjjjj", 1995, "Sony");
            filme3.Executar();

            Console.WriteLine("=======================================");
            // Exemplo Herança

            Aluno aluno1 = new Aluno();
            aluno1.Nome = "Julio";
            aluno1.Email = "hdgjhfdghdhgj";
            aluno1.Senha = "123";
            aluno1.Turno = "Vespertino";
            aluno1.Exibir();
            aluno1.Logar();

            Console.WriteLine("=======================================");

            //Exemplo interfaces         
            IDrawable shape = new Quad(); // podemos usar a propria interface ,pois só ira aparecer quem implementa a interface 
            shape.Draw();

            //Exemplo Abstract
            Drawable shape2 = new Line();
            shape2.Draw();


        }
    }
}
