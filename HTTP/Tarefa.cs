using System;
using System.Collections.Generic;
using System.Text;

namespace HTTP
{
    class Tarefa
    {
        public int userId;
        public int id;
        public string title;
        public bool completed;

        public void Exibir()
        {
            Console.WriteLine("");
            Console.WriteLine($"User id: {userId}");
            Console.WriteLine($"Id: {userId}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Completed: {completed}");
            Console.WriteLine("");
            Console.WriteLine("============================");
        }

    }
}
