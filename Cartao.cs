using System;

namespace Aula12ProjetoUber
{
    public class Cartao 
    {
        private string numero;
        private string titular;
        private string bandeira;
        private string cvv;

        

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