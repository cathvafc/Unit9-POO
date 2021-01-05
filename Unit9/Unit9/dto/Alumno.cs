using System;
using System.Collections.Generic;
using System.Text;

namespace Unit9
{
    class Alumno
    {

        private string nombre = "";
      
        private int edad = 0; 

        public Alumno(string nombre, int edad)
        {
            this.edad = edad;
            this.nombre = nombre;

        }

        public  void MayorDeEdad()
        {
            if (edad >= 18)
            {
                Console.WriteLine(" Es mayor de edad");
            }
            else
            {
                Console.WriteLine(" No es mayor de edad");
            }
        }

        public int getEdad()
        {
            return edad;
        }
        public void setEdad(int edad)
        {
            this.edad = edad; 
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(int edad)
        {
            this.edad = edad;
        }

    }
}
