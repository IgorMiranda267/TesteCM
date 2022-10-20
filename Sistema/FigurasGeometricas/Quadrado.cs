using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema
{
    class Quadrado : Figura
    {
        public double Lado { get; private set; }// Uso do Encapsulamento

        
        public Quadrado()
        {
        }
        public Quadrado(double lado)
        {
            Lado = lado;
        }

        //Polimorfismo na sobrescrita de metodo
        public override void CalcularArea()
        {
            this.Area = Lado * Lado;
        }
    }
}
