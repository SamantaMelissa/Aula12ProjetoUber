using System;

namespace Aula12ProjetoUber
{
    public class Usuario
    {
        //Propriedades:

        public string Nome { get; set; } //forma reduzida 

        //forma complexa:
        private int idade;
        public int Idade
        {
            get { return idade; }
            //set { idade = value; }
            set {
                if(idade > 0 ){
                    idade = value;
                }
            }
        }

        public string  Foto { get; set; }

        private string login = "samanta.melissa02";
        private string senha = "123456";

        public string LocalizacaoAtual { get; set; }
        public string TokenLogin { get; set; }

        public string TipoAcesso { get; set; }

        public bool Login(string login, string senha){

            //chamar um atributo fora do método

            if( this.login == login && this.senha == senha){
                TokenLogin = "5569-54*526";
                return true;
            }
            return false;


        }
        
        public void Logout(){
            TokenLogin = "";
        }
        
        
        public virtual void Excluir(){
           Console.WriteLine("Excluindo dados");
        }
    }
}