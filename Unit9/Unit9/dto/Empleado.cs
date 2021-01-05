using System;
using System.Collections.Generic;
using System.Text;

namespace Unit9
{
    class Empleado
    {
        private int sueldo = 0;
        private string nombre = "";
        public Empleado(string nombre, int sueldo)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
        }

        public void PagarImpuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("Tiene que pagar impuestos");
            }
            else
            {
                Console.WriteLine("No tiene que pagar impuestos");
            }
        }

        public int getSueldo()
        {
            return sueldo;
        }
        public void setSueldo(int sueldo)
        {
            this.sueldo = sueldo;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
