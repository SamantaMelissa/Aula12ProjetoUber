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



             Motorista motorista = new Motorista();
             motorista.Nome = "Carla";
             motorista.Carro = "Volkswagen";
             motorista.Placa = "AHIF9844";

            Console.WriteLine("Sua Motorista: "+motorista.Nome);
            
            Console.WriteLine("Carro: " +motorista.Carro);
           
            Console.WriteLine("A placa do carro: "+motorista.Placa);
            

            


        }

    




    }
}
