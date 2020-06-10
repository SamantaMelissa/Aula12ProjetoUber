using System;

namespace Aula12ProjetoUber
{
    class Program
    {
        static void Main(string[] args)
        {
            Passageiro Samanta = new Passageiro();

            Console.WriteLine("Digite seu login:");
            string login = Console.ReadLine();

            Console.WriteLine("Digite sua senha:");
            string senha = Console.ReadLine();

            Samanta.Login(login, senha);

             if( Samanta.TokenLogin != "" && Samanta.TokenLogin != null){
                 Console.WriteLine("Login autorizado!");
                 Console.WriteLine(Samanta.TokenLogin);
             }else{
                 Console.WriteLine("Não é possível utilizar o app");
             }



            Cartao visa = new Cartao();
            
               
             
            Console.WriteLine("Insira o núemro do cartão:");
            Console.ReadLine();
            
            
            Console.WriteLine("Insira o titular do cartão:");
            Console.ReadLine();

            Console.WriteLine("Insira a bandeira do cartão:");
            Console.ReadLine();

            Console.WriteLine("Insira o cvv do cartão:");
            Console.ReadLine();



            Samanta.LocalizacaoAtual = "Osasco, SP";
            Console.WriteLine("Insira o seu destino:");
            Console.ReadLine();




            Motorista motorista = new Motorista();
            motorista.Nome = "Carla";
            motorista.Carro = "Volkswagen";
            motorista.Placa = "AHIF9844";

            Console.WriteLine("Sua Motorista: "+motorista.Nome);
            
            Console.WriteLine("Carro: " +motorista.Carro);
           
            Console.WriteLine("A placa do carro: "+motorista.Placa);
            

            Corrida corrida = new Corrida();
            System.Console.WriteLine("Em aproximadamente 5 minutos o carro chegará ao destino"); 

                       


            


        }

    




    }
}
