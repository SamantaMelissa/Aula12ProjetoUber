using System;

namespace Aula12ProjetoUber
{
    public class Corrida
    {
       
        public string localInicio { get; set; }
        public string localChegada { get; set; }
        public string StatusCorrida { get; set; }
        public string Motorista { get; set; }
        public string Passageiro{ get; set; }



        public bool cancelar(bool CancelarCorrida){
            if ( CancelarCorrida == true ){
                return  true;
        
            }
            return false;
        }
    }
}