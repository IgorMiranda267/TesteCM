using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema
{
    abstract class Figura
    {
        /**
         * Uma classe Abstrata deve conter: 
         * Pelo menos 1 método abastrado
         * Não pode ser instanciada
         */
        public double Area { get; set; }

        public abstract void CalcularArea();
    }
}
