using System;

namespace CelularPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular android = new Celular();

            android.modelo = "S10";
            android.tamanho = 6.4f;
            android.cor = "Preto";
            android.ligado = false;

            if (android.ligado){
            
            Console.WriteLine( android.EnviarMensagem() );
            Console.WriteLine( android.Fazerligacao() );
            }
            else{
            Console.WriteLine("O celular está desligado.");

            }
        }
    }
}
