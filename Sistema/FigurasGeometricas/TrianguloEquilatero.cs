using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema
{
    class TrianguloEquilatero : Figura
    {
        public double Base { get; private set; }// Uso do Encapsulamento
        public double Altura { get; private set; }// Uso do Encapsulamento

        public TrianguloEquilatero()
        {
        }

        public TrianguloEquilatero(double Base, double altura)
        {
            this.Base = Base;
            Altura = altura;
        }

        //Polimorfismo na sobrescrita de metodo
        public override void CalcularArea()
        {
            this.Area = ((Base * Altura) / 2.0);
        }
    }
}
