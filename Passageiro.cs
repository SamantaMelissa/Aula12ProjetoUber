using System;

namespace Aula12ProjetoUber
{
    public class Passageiro : Usuario
    {
        public string SolcitarMotorista(){
            return "Procurando morotista...";
        }

        public bool Pagar(string statusCorrida){
            if(statusCorrida == "Finalizada"){
                return true;
            }
            return false;
        }
    }
}