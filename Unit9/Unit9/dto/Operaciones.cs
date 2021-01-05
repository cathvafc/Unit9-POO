using System;
using System.Collections.Generic;
using System.Text;

namespace Unit9
{
    class Operaciones
    {
        private int num1 = 0;
        private int num2 = 0;
        public Operaciones(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int Suma ()
        {
            return num1 + num2;
        }

        public int Resta()
        {
            return num1 - num2;
        }

        public int Multiplicación()
        {
            return num1 * num2;
        }

        public int Division()
        {
            return num1 / num2;
        }
    }
}
