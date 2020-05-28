namespace CelularPOO
{
    public class Celular
    {
        // Atributos
        public string cor;

        public string modelo;

        public float tamanho;

        public bool ligado;


        //Métodos


        public string Ligar(){
            ligado = true;
            return "Ligando celular";
        }

        public string Desligar(){
            ligado = false;
            return "Desligando celular";
        }

        public string Fazerligacao(){
            return "Fazendo ligação";
        }

        public string EnviarMensagem(){
            return "Enviando mensagem";
        }

    }
}