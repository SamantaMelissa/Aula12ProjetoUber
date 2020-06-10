using System;

namespace Aula12ProjetoUber
{
    public class Cartao 
    {
        private string numero  { get; set; }
        private string titular  { get; set; }
        private string bandeira  { get; set; }
        private string cvv  { get; set; }

        

        public string Cadastrar(int numero){
    
           return("7774 34838 9 ");

        }
        
        public string Cadastrar(string Titular, string Bandeira){
    
           return($"O titular: {Titular} e a bandeira: {Bandeira}");

        }
        public string Cadastrar(short cvv){
    
           return("Insira o cvv:");

        }
        

        public void Excluir (string ExcluirDados){

        Console.WriteLine("Excluindo dados do cartão");

        
        }
    }
}