namespace Aula_POO_celular
{
    public class celulares
    {
        public string cor;

        public string modelo;

        public float tamanho;

        public bool ligado;

        public int ligado2(int desligar, int ligar, int fazerLigacao, int enviarMensagem){
            return desligar + ligar + fazerLigacao + enviarMensagem;
        }

     public bool TraduzConsole(string condicao){
         if(condicao == "ligado"){
             ligado=true;
         }else{
             ligado=false;
         }
         return ligado;
     }

       }

 }

    
