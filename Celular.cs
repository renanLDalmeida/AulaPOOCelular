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

        /// <summary>
        /// Ligar o celular
        /// </summary>
        /// <returns>Mensagem de ligando celular</returns>
        public string Ligar(){
            ligado = true;
            return "Ligando celular";
        }

        /// <summary>
        /// Desligar o celular
        /// </summary>
        /// <returns>Mensagem de desligando celular</returns>
        public string Desligar(){
            ligado = false;
            return "Desligando celular";
        }

        /// <summary>
        /// Fazer ligação
        /// </summary>
        /// <returns>Mensagem de fazendo ligação</returns>
        public string Fazerligacao(){
            return "Fazendo ligação";
        }
        
        /// <summary>
        /// Enviar mensagem
        /// </summary>
        /// <returns>Mensagem de enviando mensagem</returns>
        public string EnviarMensagem(){
            return "Enviando mensagem";
        }

    }
}