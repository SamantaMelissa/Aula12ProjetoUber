using System;

namespace Aula12ProjetoUber
{
    public class Conta
    {
        private string agencia  { get; set; }

        private string conta  { get; set; }


        public string Cadastrar { get; set; }

        public void Excluir(string ExcluirConta){
             Console.WriteLine("Excluir conta");
        }
    }
}