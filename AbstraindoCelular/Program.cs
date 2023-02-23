using AbstraindoCelular.Models;
using System;

namespace AbstraindoCelular
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Nokia:");
            Smartphone nokia = new Nokia("(11)99931-7924", "1º Modelo", "45564", 128);
            nokia.Ligar();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("\n");

            Console.WriteLine("Iphone:");
            Smartphone iphone = new Iphone("(11)99986-3658", "Iphone 13", "54845", 64);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}
