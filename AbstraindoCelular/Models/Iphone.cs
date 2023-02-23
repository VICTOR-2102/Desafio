using System;
using System.Collections.Generic;
using System.Text;

namespace AbstraindoCelular.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        { }
        public override void InstalarAplicativo(string nomeDoApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeDoApp} no Iphone.");
        }
    }
}
