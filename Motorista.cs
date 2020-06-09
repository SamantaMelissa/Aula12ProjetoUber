using System;

namespace Aula12ProjetoUber
{
    public class Motorista : Usuario
    {
        public string Carro { get; set; }

        public string Placa { get; set; }

        public string aceitarPassageiro(string nome){
            return $"Aceitar passageiro {nome}";
        }

        public bool receberPagamento(string modo){
            if (modo == "Depósito"){
                return true;
            }
            return false;
        }
 








    }
      
 

    
}