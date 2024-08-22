using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lista_2
{
    internal class Retangulo
    {
        private double altura;
        private double lado;

        public Retangulo()
        {

        }

        public double CalcularArea()
        {
            return (altura * lado);
        }

        public double CalcularPerimetro()
        {
            return (lado * 4);

        }

        public string Lado
        {
            get { return Lado; }
            set { Lado = value; }
        }
        public string Altura
        {
            get { return Altura; }
            set { Altura = value; }
        }

    }
}
