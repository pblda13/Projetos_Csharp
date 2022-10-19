using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace HTTP
{
    class Program
    {
        static void Main(string[] args)
        {
            ReqList();
            ReqUnica();
        }

        static void ReqUnica()
        {

            var requisicao = WebRequest.Create("https://jsonplaceholder.typicode.com/todos/5");
            requisicao.Method = "Get";
            var resposta = requisicao.GetResponse();

            using (resposta)
            {
                var stream = resposta.GetResponseStream();
                StreamReader leitor = new StreamReader(stream);
                object dados = leitor.ReadToEnd();

                Tarefa tarefa = JsonConvert.DeserializeObject<Tarefa>(dados.ToString());

                tarefa.Exibir();

                stream.Close();
                resposta.Close();
            }
        }
        static void ReqList()
        {
            var requisicao = WebRequest.Create("https://jsonplaceholder.typicode.com/todos/");
            requisicao.Method = "Get";
            var resposta = requisicao.GetResponse();

            using (resposta)
            {
                var stream = resposta.GetResponseStream();
                StreamReader leitor = new StreamReader(stream);
                object dados = leitor.ReadToEnd();

                List<Tarefa> tarefas = JsonConvert.DeserializeObject<List<Tarefa>>(dados.ToString());
                foreach (Tarefa tarefa in tarefas)
                {
                    tarefa.Exibir();

                }

                stream.Close();
                resposta.Close();
            }
        }
    }
}
