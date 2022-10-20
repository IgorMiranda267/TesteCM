using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema
{
    class Circulo : Figura
    {
        const double Pi = 3.14;
        public double Raio { get; private set; }// Uso do Encapsulamento

        public Circulo()
        {
        }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        //Polimorfismo na sobrescrita de metodo
        public override void CalcularArea()
        {
            this.Area = (Pi * (Raio * Raio));
        }
    }
}
