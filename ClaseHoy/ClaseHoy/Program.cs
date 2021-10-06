using ClaseHoy.Entidades;
using ClaseHoy.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseHoy
{
    class Program
    {
        static void Main(string[] args)
        {
            Clscarro clscarro = new Clscarro();
            NClscarro nclscarro = new NClscarro();

            clscarro.Color = "Azul";
            clscarro.Capacidad = 5;

            Console.WriteLine(nclscarro.Encender(clscarro));
            Console.ReadLine();
        }
    }
}
