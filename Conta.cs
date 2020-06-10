using System;

namespace Aula12ProjetoUber
{
    public class Conta
    {
        private string agencia;

        private string conta;


        public string Cadastrar { get; set; }

        public void Excluir(string ExcluirConta){
             Console.WriteLine("Excluir conta");
        }
    }
}