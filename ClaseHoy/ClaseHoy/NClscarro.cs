using ClaseHoy.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseHoy.Negocio
{
    class NClscarro
    {
        public String Encender(Clscarro carro)
        {

            return " El carro de color" + carro.Color + " Con capacidad de" + carro.Capacidad + "esta encendido";


        }
    }
}
